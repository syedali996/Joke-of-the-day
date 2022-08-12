// <copyright file="BotProfile.cs" company="APIMatic">
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
    /// BotProfile.
    /// </summary>
    public class BotProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotProfile"/> class.
        /// </summary>
        public BotProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotProfile"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="appId">app_id.</param>
        /// <param name="name">name.</param>
        /// <param name="icons">icons.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="updated">updated.</param>
        /// <param name="teamId">team_id.</param>
        public BotProfile(
            string id,
            string appId,
            string name,
            Models.Icons icons,
            bool deleted,
            int updated,
            string teamId)
        {
            this.Id = id;
            this.AppId = appId;
            this.Name = name;
            this.Icons = icons;
            this.Deleted = deleted;
            this.Updated = updated;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets AppId.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Icons.
        /// </summary>
        [JsonProperty("icons")]
        public Models.Icons Icons { get; set; }

        /// <summary>
        /// Gets or sets Deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets Updated.
        /// </summary>
        [JsonProperty("updated")]
        public int Updated { get; set; }

        /// <summary>
        /// Gets or sets TeamId.
        /// </summary>
        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BotProfile : ({string.Join(", ", toStringOutput)})";
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

            return obj is BotProfile other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AppId == null && other.AppId == null) || (this.AppId?.Equals(other.AppId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Icons == null && other.Icons == null) || (this.Icons?.Equals(other.Icons) == true)) &&
                this.Deleted.Equals(other.Deleted) &&
                this.Updated.Equals(other.Updated) &&
                ((this.TeamId == null && other.TeamId == null) || (this.TeamId?.Equals(other.TeamId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.AppId = {(this.AppId == null ? "null" : this.AppId == string.Empty ? "" : this.AppId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Icons = {(this.Icons == null ? "null" : this.Icons.ToString())}");
            toStringOutput.Add($"this.Deleted = {this.Deleted}");
            toStringOutput.Add($"this.Updated = {this.Updated}");
            toStringOutput.Add($"this.TeamId = {(this.TeamId == null ? "null" : this.TeamId == string.Empty ? "" : this.TeamId)}");
        }
    }
}