// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace JokeOfTheDay.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using JokeOfTheDay.Standard;
    using JokeOfTheDay.Standard.Authentication;
    using JokeOfTheDay.Standard.Http.Client;
    using JokeOfTheDay.Standard.Http.Request;
    using JokeOfTheDay.Standard.Http.Request.Configuration;
    using JokeOfTheDay.Standard.Http.Response;
    using JokeOfTheDay.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal APIController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Retrieve Joke EndPoint.
        /// </summary>
        /// <param name="category">Required parameter: defines the category for the joke of the day.</param>
        /// <returns>Returns the Models.ResponseModel response from the API call.</returns>
        public Models.ResponseModel RetrieveJoke(
                Models.CategoryModelEnum category)
        {
            Task<Models.ResponseModel> t = this.RetrieveJokeAsync(category);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve Joke EndPoint.
        /// </summary>
        /// <param name="category">Required parameter: defines the category for the joke of the day.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseModel response from the API call.</returns>
        public async Task<Models.ResponseModel> RetrieveJokeAsync(
                Models.CategoryModelEnum category,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/jod");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "category", ApiHelper.JsonSerialize(category).Trim('\"') },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseModel>(response.Body);
        }

        /// <summary>
        /// Categories for jokes of the day EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic CategoriesForJokesOfTheDay()
        {
            Task<dynamic> t = this.CategoriesForJokesOfTheDayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Categories for jokes of the day EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> CategoriesForJokesOfTheDayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/jod/categories");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }
    }
}