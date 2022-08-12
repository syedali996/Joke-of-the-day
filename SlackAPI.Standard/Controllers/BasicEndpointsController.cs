// <copyright file="BasicEndpointsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SlackAPI.Standard.Controllers
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
    using Newtonsoft.Json.Converters;
    using SlackAPI.Standard;
    using SlackAPI.Standard.Authentication;
    using SlackAPI.Standard.Http.Client;
    using SlackAPI.Standard.Http.Request;
    using SlackAPI.Standard.Http.Request.Configuration;
    using SlackAPI.Standard.Http.Response;
    using SlackAPI.Standard.Utilities;

    /// <summary>
    /// BasicEndpointsController.
    /// </summary>
    public class BasicEndpointsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicEndpointsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal BasicEndpointsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// List Public Channels EndPoint.
        /// </summary>
        /// <param name="cursor">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListPublicChannelsResponse response from the API call.</returns>
        public Models.ListPublicChannelsResponse ListPublicChannels(
                string cursor = null)
        {
            Task<Models.ListPublicChannelsResponse> t = this.ListPublicChannelsAsync(cursor);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List Public Channels EndPoint.
        /// </summary>
        /// <param name="cursor">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListPublicChannelsResponse response from the API call.</returns>
        public async Task<Models.ListPublicChannelsResponse> ListPublicChannelsAsync(
                string cursor = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/conversations.list");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "cursor", cursor },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ListPublicChannelsResponse>(response.Body);
        }

        /// <summary>
        /// Publish Message EndPoint.
        /// </summary>
        /// <param name="message">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PublishMessageResponse response from the API call.</returns>
        public Models.PublishMessageResponse PublishMessage(
                Models.Message message)
        {
            Task<Models.PublishMessageResponse> t = this.PublishMessageAsync(message);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Publish Message EndPoint.
        /// </summary>
        /// <param name="message">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishMessageResponse response from the API call.</returns>
        public async Task<Models.PublishMessageResponse> PublishMessageAsync(
                Models.Message message,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/chat.postMessage");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(message);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.PublishMessageResponse>(response.Body);
        }
    }
}