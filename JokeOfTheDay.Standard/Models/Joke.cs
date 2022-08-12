// <copyright file="Joke.cs" company="APIMatic">
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
    /// Joke.
    /// </summary>
    public class Joke
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Joke"/> class.
        /// </summary>
        public Joke()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Joke"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="language">language.</param>
        /// <param name="background">background.</param>
        /// <param name="category">category.</param>
        /// <param name="date">date.</param>
        /// <param name="jokeProp">joke.</param>
        public Joke(
            string description,
            string language,
            string background,
            string category,
            string date,
            Models.Joke1 jokeProp)
        {
            this.Description = description;
            this.Language = language;
            this.Background = background;
            this.Category = category;
            this.Date = date;
            this.JokeProp = jokeProp;
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets Background.
        /// </summary>
        [JsonProperty("background")]
        public string Background { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets JokeProp.
        /// </summary>
        [JsonProperty("joke")]
        public Models.Joke1 JokeProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Joke : ({string.Join(", ", toStringOutput)})";
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

            return obj is Joke other &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                ((this.Background == null && other.Background == null) || (this.Background?.Equals(other.Background) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.JokeProp == null && other.JokeProp == null) || (this.JokeProp?.Equals(other.JokeProp) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language == string.Empty ? "" : this.Language)}");
            toStringOutput.Add($"this.Background = {(this.Background == null ? "null" : this.Background == string.Empty ? "" : this.Background)}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category == string.Empty ? "" : this.Category)}");
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date == string.Empty ? "" : this.Date)}");
            toStringOutput.Add($"this.JokeProp = {(this.JokeProp == null ? "null" : this.JokeProp.ToString())}");
        }
    }
}