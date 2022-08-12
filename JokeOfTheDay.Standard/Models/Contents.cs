// <copyright file="Contents.cs" company="APIMatic">
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
    /// Contents.
    /// </summary>
    public class Contents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents"/> class.
        /// </summary>
        public Contents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents"/> class.
        /// </summary>
        /// <param name="jokes">jokes.</param>
        /// <param name="copyright">copyright.</param>
        public Contents(
            List<Models.Joke> jokes,
            string copyright)
        {
            this.Jokes = jokes;
            this.Copyright = copyright;
        }

        /// <summary>
        /// Gets or sets Jokes.
        /// </summary>
        [JsonProperty("jokes")]
        public List<Models.Joke> Jokes { get; set; }

        /// <summary>
        /// Gets or sets Copyright.
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents : ({string.Join(", ", toStringOutput)})";
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

            return obj is Contents other &&
                ((this.Jokes == null && other.Jokes == null) || (this.Jokes?.Equals(other.Jokes) == true)) &&
                ((this.Copyright == null && other.Copyright == null) || (this.Copyright?.Equals(other.Copyright) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Jokes = {(this.Jokes == null ? "null" : $"[{string.Join(", ", this.Jokes)} ]")}");
            toStringOutput.Add($"this.Copyright = {(this.Copyright == null ? "null" : this.Copyright == string.Empty ? "" : this.Copyright)}");
        }
    }
}