// <copyright file="IAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SlackAPI.Standard.Authentication
{
    using System.Threading.Tasks;
    using SlackAPI.Standard.Http.Request;

    /// <summary>
    /// IAuthManager adds the authenticaion layer to the http calls.
    /// <summary>
    internal interface IAuthManager
    {
        /// <summary>
        /// Add authentication information to the HTTP Request.
        /// </summary>
        /// <param name="httpRequest">The http request object on which authentication will be applied.</param>
        /// <returns>HttpRequest.</returns>
        HttpRequest Apply(HttpRequest httpRequest);

        /// <summary>
        /// Asynchronously add authentication information to the HTTP Request.
        /// </summary>
        /// <param name="httpRequest">The http request object on which authentication will be applied.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task<HttpRequest> ApplyAsync(HttpRequest httpRequest);
    }
}
