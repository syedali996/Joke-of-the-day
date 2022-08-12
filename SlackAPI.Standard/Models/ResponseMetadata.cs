// <copyright file="ResponseMetadata.cs" company="APIMatic">
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
    /// ResponseMetadata.
    /// </summary>
    public class ResponseMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetadata"/> class.
        /// </summary>
        public ResponseMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetadata"/> class.
        /// </summary>
        /// <param name="nextCursor">next_cursor.</param>
        public ResponseMetadata(
            string nextCursor)
        {
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Gets or sets NextCursor.
        /// </summary>
        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseMetadata : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResponseMetadata other &&
                ((this.NextCursor == null && other.NextCursor == null) || (this.NextCursor?.Equals(other.NextCursor) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NextCursor = {(this.NextCursor == null ? "null" : this.NextCursor == string.Empty ? "" : this.NextCursor)}");
        }
    }
}