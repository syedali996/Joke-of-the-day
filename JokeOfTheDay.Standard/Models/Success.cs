// <copyright file="Success.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace JokeOfTheDay.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JokeOfTheDay.Standard;
    using JokeOfTheDay.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Success.
    /// </summary>
    public class Success
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Success"/> class.
        /// </summary>
        public Success()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Success"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        public Success(
            int total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Gets or sets Total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Success : ({string.Join(", ", toStringOutput)})";
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

            return obj is Success other &&
                this.Total.Equals(other.Total);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}