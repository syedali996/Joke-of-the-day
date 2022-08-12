// <copyright file="Message1.cs" company="APIMatic">
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
    /// Message1.
    /// </summary>
    public class Message1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message1"/> class.
        /// </summary>
        public Message1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message1"/> class.
        /// </summary>
        /// <param name="botId">bot_id.</param>
        /// <param name="type">type.</param>
        /// <param name="text">text.</param>
        /// <param name="user">user.</param>
        /// <param name="ts">ts.</param>
        /// <param name="appId">app_id.</param>
        /// <param name="team">team.</param>
        /// <param name="botProfile">bot_profile.</param>
        /// <param name="blocks">blocks.</param>
        public Message1(
            string botId,
            string type,
            string text,
            string user,
            string ts,
            string appId,
            string team,
            Models.BotProfile botProfile,
            List<Models.Block> blocks)
        {
            this.BotId = botId;
            this.Type = type;
            this.Text = text;
            this.User = user;
            this.Ts = ts;
            this.AppId = appId;
            this.Team = team;
            this.BotProfile = botProfile;
            this.Blocks = blocks;
        }

        /// <summary>
        /// Gets or sets BotId.
        /// </summary>
        [JsonProperty("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets User.
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets Ts.
        /// </summary>
        [JsonProperty("ts")]
        public string Ts { get; set; }

        /// <summary>
        /// Gets or sets AppId.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets Team.
        /// </summary>
        [JsonProperty("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or sets BotProfile.
        /// </summary>
        [JsonProperty("bot_profile")]
        public Models.BotProfile BotProfile { get; set; }

        /// <summary>
        /// Gets or sets Blocks.
        /// </summary>
        [JsonProperty("blocks")]
        public List<Models.Block> Blocks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Message1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Message1 other &&
                ((this.BotId == null && other.BotId == null) || (this.BotId?.Equals(other.BotId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true)) &&
                ((this.Ts == null && other.Ts == null) || (this.Ts?.Equals(other.Ts) == true)) &&
                ((this.AppId == null && other.AppId == null) || (this.AppId?.Equals(other.AppId) == true)) &&
                ((this.Team == null && other.Team == null) || (this.Team?.Equals(other.Team) == true)) &&
                ((this.BotProfile == null && other.BotProfile == null) || (this.BotProfile?.Equals(other.BotProfile) == true)) &&
                ((this.Blocks == null && other.Blocks == null) || (this.Blocks?.Equals(other.Blocks) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BotId = {(this.BotId == null ? "null" : this.BotId == string.Empty ? "" : this.BotId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User == string.Empty ? "" : this.User)}");
            toStringOutput.Add($"this.Ts = {(this.Ts == null ? "null" : this.Ts == string.Empty ? "" : this.Ts)}");
            toStringOutput.Add($"this.AppId = {(this.AppId == null ? "null" : this.AppId == string.Empty ? "" : this.AppId)}");
            toStringOutput.Add($"this.Team = {(this.Team == null ? "null" : this.Team == string.Empty ? "" : this.Team)}");
            toStringOutput.Add($"this.BotProfile = {(this.BotProfile == null ? "null" : this.BotProfile.ToString())}");
            toStringOutput.Add($"this.Blocks = {(this.Blocks == null ? "null" : $"[{string.Join(", ", this.Blocks)} ]")}");
        }
    }
}