// <copyright file="Icons.cs" company="APIMatic">
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
    /// Icons.
    /// </summary>
    public class Icons
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Icons"/> class.
        /// </summary>
        public Icons()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Icons"/> class.
        /// </summary>
        /// <param name="image36">image_36.</param>
        /// <param name="image48">image_48.</param>
        /// <param name="image72">image_72.</param>
        public Icons(
            string image36,
            string image48,
            string image72)
        {
            this.Image36 = image36;
            this.Image48 = image48;
            this.Image72 = image72;
        }

        /// <summary>
        /// Gets or sets Image36.
        /// </summary>
        [JsonProperty("image_36")]
        public string Image36 { get; set; }

        /// <summary>
        /// Gets or sets Image48.
        /// </summary>
        [JsonProperty("image_48")]
        public string Image48 { get; set; }

        /// <summary>
        /// Gets or sets Image72.
        /// </summary>
        [JsonProperty("image_72")]
        public string Image72 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Icons : ({string.Join(", ", toStringOutput)})";
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

            return obj is Icons other &&
                ((this.Image36 == null && other.Image36 == null) || (this.Image36?.Equals(other.Image36) == true)) &&
                ((this.Image48 == null && other.Image48 == null) || (this.Image48?.Equals(other.Image48) == true)) &&
                ((this.Image72 == null && other.Image72 == null) || (this.Image72?.Equals(other.Image72) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Image36 = {(this.Image36 == null ? "null" : this.Image36 == string.Empty ? "" : this.Image36)}");
            toStringOutput.Add($"this.Image48 = {(this.Image48 == null ? "null" : this.Image48 == string.Empty ? "" : this.Image48)}");
            toStringOutput.Add($"this.Image72 = {(this.Image72 == null ? "null" : this.Image72 == string.Empty ? "" : this.Image72)}");
        }
    }
}