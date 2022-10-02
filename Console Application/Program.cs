using SlackAPI.Standard;
using SlackAPI.Standard.Models;
using JokeOfTheDay.Standard;
using JokeOfTheDay.Standard.Models;
using System;
using System.Threading;
using System.Linq;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 3)
            {
                Console.WriteLine("Please provide the following arguments:");
                Console.WriteLine("1) Time interval in hours");
                Console.WriteLine("2) Slack API access token");
                Console.WriteLine("3) Slack channel ID");

                return;
            }

            Console.WriteLine("Welcome to the Joke Bot Slack Integration!");
            Console.WriteLine("The application uses \"Joke of the day API\" and \"Slack API\" to publish jokes on slack.");

            var intervalBetweenJokePublishing = int.Parse(args[0]) * 60 * 60 * 1000;
            var slackAPIAccessToken = args[1];
            var slackChannelId = args[2];
            var slackAPIClient = new SlackAPIClient.Builder().AccessToken(slackAPIAccessToken).Build();
            var jokesAPIClient = new JokeOfTheDayClient.Builder().Build();
            var values = Enum.GetValues(typeof(CategoryModelEnum));
            var interator = 0;
            var jokesCategory = CategoryModelEnum.Category1;


            while (true)
            {
                try
                {
                    if (interator == values.Length)
                    {
                        interator = 0;
                    }

                    jokesCategory = (CategoryModelEnum)values.GetValue(interator++);

                    var joke = GetJoke(jokesCategory, jokesAPIClient);
                    var postJoke = SendMessageToSlackChannel(slackChannelId, joke, slackAPIClient);

                    if (postJoke)
                    {
                        Console.WriteLine($"Joke posted successfully at {DateTime.Now}");
                    }
                    else
                    {
                        Console.WriteLine("Failed to post the joke!");
                    }

                    Thread.Sleep(intervalBetweenJokePublishing);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine("Application crashed! Needs to be restarted.");
                    break;
                }
            }

        }

        public static bool SendMessageToSlackChannel(string channelId, string text, SlackAPIClient slackAPIClient)
        {
            var message = new Message()
            {
                Channel = channelId,
                Text = text
            };

            var response = slackAPIClient.BasicEndpointsController.PublishMessage(message);

            return response.Ok;
        }

        public static string GetJoke(CategoryModelEnum categoryModelEnum, JokeOfTheDayClient jokeOfTheDayClient)
        {
            var response = jokeOfTheDayClient.APIController.RetrieveJoke(categoryModelEnum);

            return response.Contents.Jokes[0].JokeProp.Text;
        }
    }
}
