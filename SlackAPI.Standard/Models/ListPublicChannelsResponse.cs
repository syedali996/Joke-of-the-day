// <copyright file="ListPublicChannelsResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SlackAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SlackAPI.Standard;
    using SlackAPI.Standard.Utilities;

    /// <summary>
    /// ListPublicChannelsResponse.
    /// </summary>
    public class ListPublicChannelsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPublicChannelsResponse"/> class.
        /// </summary>
        public ListPublicChannelsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPublicChannelsResponse"/> class.
        /// </summary>
        /// <param name="ok">ok.</param>
        /// <param name="channels">channels.</param>
        /// <param name="responseMetadata">response_metadata.</param>
        public ListPublicChannelsResponse(
            bool ok,
            List<Models.Channel> channels,
            Models.ResponseMetadata responseMetadata)
        {
            this.Ok = ok;
            this.Channels = channels;
            this.ResponseMetadata = responseMetadata;
        }

        /// <summary>
        /// Gets or sets Ok.
        /// </summary>
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or sets Channels.
        /// </summary>
        [JsonProperty("channels")]
        public List<Models.Channel> Channels { get; set; }

        /// <summary>
        /// Gets or sets ResponseMetadata.
        /// </summary>
        [JsonProperty("response_metadata")]
        public Models.ResponseMetadata ResponseMetadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListPublicChannelsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is ListPublicChannelsResponse other &&
                this.Ok.Equals(other.Ok) &&
                ((this.Channels == null && other.Channels == null) || (this.Channels?.Equals(other.Channels) == true)) &&
                ((this.ResponseMetadata == null && other.ResponseMetadata == null) || (this.ResponseMetadata?.Equals(other.ResponseMetadata) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ok = {this.Ok}");
            toStringOutput.Add($"this.Channels = {(this.Channels == null ? "null" : $"[{string.Join(", ", this.Channels)} ]")}");
            toStringOutput.Add($"this.ResponseMetadata = {(this.ResponseMetadata == null ? "null" : this.ResponseMetadata.ToString())}");
        }
    }
}