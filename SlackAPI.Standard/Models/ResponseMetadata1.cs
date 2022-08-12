// <copyright file="ResponseMetadata1.cs" company="APIMatic">
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
    /// ResponseMetadata1.
    /// </summary>
    public class ResponseMetadata1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetadata1"/> class.
        /// </summary>
        public ResponseMetadata1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetadata1"/> class.
        /// </summary>
        /// <param name="warnings">warnings.</param>
        public ResponseMetadata1(
            List<string> warnings)
        {
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or sets Warnings.
        /// </summary>
        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseMetadata1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResponseMetadata1 other &&
                ((this.Warnings == null && other.Warnings == null) || (this.Warnings?.Equals(other.Warnings) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Warnings = {(this.Warnings == null ? "null" : $"[{string.Join(", ", this.Warnings)} ]")}");
        }
    }
}