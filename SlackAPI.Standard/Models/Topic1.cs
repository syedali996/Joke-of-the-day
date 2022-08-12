// <copyright file="Topic1.cs" company="APIMatic">
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
    /// Topic1.
    /// </summary>
    public class Topic1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Topic1"/> class.
        /// </summary>
        public Topic1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Topic1"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="creator">creator.</param>
        /// <param name="lastSet">last_set.</param>
        public Topic1(
            string mValue,
            string creator,
            int lastSet)
        {
            this.MValue = mValue;
            this.Creator = creator;
            this.LastSet = lastSet;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets Creator.
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets LastSet.
        /// </summary>
        [JsonProperty("last_set")]
        public int LastSet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Topic1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Topic1 other &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                this.LastSet.Equals(other.LastSet);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator == string.Empty ? "" : this.Creator)}");
            toStringOutput.Add($"this.LastSet = {this.LastSet}");
        }
    }
}