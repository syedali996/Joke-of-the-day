// <copyright file="Block.cs" company="APIMatic">
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
    /// Block.
    /// </summary>
    public class Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Block"/> class.
        /// </summary>
        public Block()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Block"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="blockId">block_id.</param>
        /// <param name="elements">elements.</param>
        public Block(
            string type,
            string blockId,
            List<Models.Element> elements)
        {
            this.Type = type;
            this.BlockId = blockId;
            this.Elements = elements;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets BlockId.
        /// </summary>
        [JsonProperty("block_id")]
        public string BlockId { get; set; }

        /// <summary>
        /// Gets or sets Elements.
        /// </summary>
        [JsonProperty("elements")]
        public List<Models.Element> Elements { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Block : ({string.Join(", ", toStringOutput)})";
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

            return obj is Block other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.BlockId == null && other.BlockId == null) || (this.BlockId?.Equals(other.BlockId) == true)) &&
                ((this.Elements == null && other.Elements == null) || (this.Elements?.Equals(other.Elements) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.BlockId = {(this.BlockId == null ? "null" : this.BlockId == string.Empty ? "" : this.BlockId)}");
            toStringOutput.Add($"this.Elements = {(this.Elements == null ? "null" : $"[{string.Join(", ", this.Elements)} ]")}");
        }
    }
}