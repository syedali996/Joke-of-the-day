// <copyright file="Joke1.cs" company="APIMatic">
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
    /// Joke1.
    /// </summary>
    public class Joke1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Joke1"/> class.
        /// </summary>
        public Joke1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Joke1"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="lang">lang.</param>
        /// <param name="length">length.</param>
        /// <param name="clean">clean.</param>
        /// <param name="racial">racial.</param>
        /// <param name="date">date.</param>
        /// <param name="id">id.</param>
        /// <param name="text">text.</param>
        public Joke1(
            string title,
            string lang,
            string length,
            string clean,
            string racial,
            string date,
            string id,
            string text)
        {
            this.Title = title;
            this.Lang = lang;
            this.Length = length;
            this.Clean = clean;
            this.Racial = racial;
            this.Date = date;
            this.Id = id;
            this.Text = text;
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Lang.
        /// </summary>
        [JsonProperty("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets Length.
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; }

        /// <summary>
        /// Gets or sets Clean.
        /// </summary>
        [JsonProperty("clean")]
        public string Clean { get; set; }

        /// <summary>
        /// Gets or sets Racial.
        /// </summary>
        [JsonProperty("racial")]
        public string Racial { get; set; }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Joke1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Joke1 other &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Lang == null && other.Lang == null) || (this.Lang?.Equals(other.Lang) == true)) &&
                ((this.Length == null && other.Length == null) || (this.Length?.Equals(other.Length) == true)) &&
                ((this.Clean == null && other.Clean == null) || (this.Clean?.Equals(other.Clean) == true)) &&
                ((this.Racial == null && other.Racial == null) || (this.Racial?.Equals(other.Racial) == true)) &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Lang = {(this.Lang == null ? "null" : this.Lang == string.Empty ? "" : this.Lang)}");
            toStringOutput.Add($"this.Length = {(this.Length == null ? "null" : this.Length == string.Empty ? "" : this.Length)}");
            toStringOutput.Add($"this.Clean = {(this.Clean == null ? "null" : this.Clean == string.Empty ? "" : this.Clean)}");
            toStringOutput.Add($"this.Racial = {(this.Racial == null ? "null" : this.Racial == string.Empty ? "" : this.Racial)}");
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date == string.Empty ? "" : this.Date)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
        }
    }
}