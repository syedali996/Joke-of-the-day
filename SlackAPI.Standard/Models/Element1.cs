// <copyright file="Element1.cs" company="APIMatic">
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
    /// Element1.
    /// </summary>
    public class Element1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Element1"/> class.
        /// </summary>
        public Element1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element1"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="text">text.</param>
        /// <param name="name">name.</param>
        /// <param name="unicode">unicode.</param>
        public Element1(
            string type,
            string text = null,
            string name = null,
            string unicode = null)
        {
            this.Type = type;
            this.Text = text;
            this.Name = name;
            this.Unicode = unicode;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Unicode.
        /// </summary>
        [JsonProperty("unicode", NullValueHandling = NullValueHandling.Ignore)]
        public string Unicode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Element1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Element1 other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Unicode == null && other.Unicode == null) || (this.Unicode?.Equals(other.Unicode) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Unicode = {(this.Unicode == null ? "null" : this.Unicode == string.Empty ? "" : this.Unicode)}");
        }
    }
}