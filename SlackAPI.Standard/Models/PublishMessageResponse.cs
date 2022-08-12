// <copyright file="PublishMessageResponse.cs" company="APIMatic">
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
    /// PublishMessageResponse.
    /// </summary>
    public class PublishMessageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMessageResponse"/> class.
        /// </summary>
        public PublishMessageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMessageResponse"/> class.
        /// </summary>
        /// <param name="ok">ok.</param>
        /// <param name="channel">channel.</param>
        /// <param name="ts">ts.</param>
        /// <param name="message">message.</param>
        /// <param name="warning">warning.</param>
        /// <param name="responseMetadata">response_metadata.</param>
        public PublishMessageResponse(
            bool ok,
            string channel,
            string ts,
            Models.Message1 message,
            string warning,
            Models.ResponseMetadata1 responseMetadata)
        {
            this.Ok = ok;
            this.Channel = channel;
            this.Ts = ts;
            this.Message = message;
            this.Warning = warning;
            this.ResponseMetadata = responseMetadata;
        }

        /// <summary>
        /// Gets or sets Ok.
        /// </summary>
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or sets Channel.
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets Ts.
        /// </summary>
        [JsonProperty("ts")]
        public string Ts { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public Models.Message1 Message { get; set; }

        /// <summary>
        /// Gets or sets Warning.
        /// </summary>
        [JsonProperty("warning")]
        public string Warning { get; set; }

        /// <summary>
        /// Gets or sets ResponseMetadata.
        /// </summary>
        [JsonProperty("response_metadata")]
        public Models.ResponseMetadata1 ResponseMetadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PublishMessageResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is PublishMessageResponse other &&
                this.Ok.Equals(other.Ok) &&
                ((this.Channel == null && other.Channel == null) || (this.Channel?.Equals(other.Channel) == true)) &&
                ((this.Ts == null && other.Ts == null) || (this.Ts?.Equals(other.Ts) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Warning == null && other.Warning == null) || (this.Warning?.Equals(other.Warning) == true)) &&
                ((this.ResponseMetadata == null && other.ResponseMetadata == null) || (this.ResponseMetadata?.Equals(other.ResponseMetadata) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ok = {this.Ok}");
            toStringOutput.Add($"this.Channel = {(this.Channel == null ? "null" : this.Channel == string.Empty ? "" : this.Channel)}");
            toStringOutput.Add($"this.Ts = {(this.Ts == null ? "null" : this.Ts == string.Empty ? "" : this.Ts)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message.ToString())}");
            toStringOutput.Add($"this.Warning = {(this.Warning == null ? "null" : this.Warning == string.Empty ? "" : this.Warning)}");
            toStringOutput.Add($"this.ResponseMetadata = {(this.ResponseMetadata == null ? "null" : this.ResponseMetadata.ToString())}");
        }
    }
}