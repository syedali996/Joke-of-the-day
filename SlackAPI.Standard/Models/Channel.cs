// <copyright file="Channel.cs" company="APIMatic">
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
    /// Channel.
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel"/> class.
        /// </summary>
        public Channel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Channel"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="isChannel">is_channel.</param>
        /// <param name="isGroup">is_group.</param>
        /// <param name="isIm">is_im.</param>
        /// <param name="isMpim">is_mpim.</param>
        /// <param name="isPrivate">is_private.</param>
        /// <param name="created">created.</param>
        /// <param name="isArchived">is_archived.</param>
        /// <param name="isGeneral">is_general.</param>
        /// <param name="unlinked">unlinked.</param>
        /// <param name="nameNormalized">name_normalized.</param>
        /// <param name="isShared">is_shared.</param>
        /// <param name="isOrgShared">is_org_shared.</param>
        /// <param name="isPendingExtShared">is_pending_ext_shared.</param>
        /// <param name="pendingShared">pending_shared.</param>
        /// <param name="contextTeamId">context_team_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="isExtShared">is_ext_shared.</param>
        /// <param name="sharedTeamIds">shared_team_ids.</param>
        /// <param name="pendingConnectedTeamIds">pending_connected_team_ids.</param>
        /// <param name="isMember">is_member.</param>
        /// <param name="topic">topic.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="previousNames">previous_names.</param>
        /// <param name="numMembers">num_members.</param>
        /// <param name="parentConversation">parent_conversation.</param>
        /// <param name="frozenReason">frozen_reason.</param>
        public Channel(
            string id,
            string name,
            bool isChannel,
            bool isGroup,
            bool isIm,
            bool isMpim,
            bool isPrivate,
            int created,
            bool isArchived,
            bool isGeneral,
            int unlinked,
            string nameNormalized,
            bool isShared,
            bool isOrgShared,
            bool isPendingExtShared,
            List<string> pendingShared,
            string contextTeamId,
            string creator,
            bool isExtShared,
            List<string> sharedTeamIds,
            List<string> pendingConnectedTeamIds,
            bool isMember,
            Models.Topic1 topic,
            Models.Purpose purpose,
            List<string> previousNames,
            int numMembers,
            string parentConversation = null,
            string frozenReason = null)
        {
            this.Id = id;
            this.Name = name;
            this.IsChannel = isChannel;
            this.IsGroup = isGroup;
            this.IsIm = isIm;
            this.IsMpim = isMpim;
            this.IsPrivate = isPrivate;
            this.Created = created;
            this.IsArchived = isArchived;
            this.IsGeneral = isGeneral;
            this.Unlinked = unlinked;
            this.NameNormalized = nameNormalized;
            this.IsShared = isShared;
            this.IsOrgShared = isOrgShared;
            this.IsPendingExtShared = isPendingExtShared;
            this.PendingShared = pendingShared;
            this.ContextTeamId = contextTeamId;
            this.ParentConversation = parentConversation;
            this.Creator = creator;
            this.IsExtShared = isExtShared;
            this.SharedTeamIds = sharedTeamIds;
            this.PendingConnectedTeamIds = pendingConnectedTeamIds;
            this.IsMember = isMember;
            this.Topic = topic;
            this.Purpose = purpose;
            this.PreviousNames = previousNames;
            this.NumMembers = numMembers;
            this.FrozenReason = frozenReason;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets IsChannel.
        /// </summary>
        [JsonProperty("is_channel")]
        public bool IsChannel { get; set; }

        /// <summary>
        /// Gets or sets IsGroup.
        /// </summary>
        [JsonProperty("is_group")]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Gets or sets IsIm.
        /// </summary>
        [JsonProperty("is_im")]
        public bool IsIm { get; set; }

        /// <summary>
        /// Gets or sets IsMpim.
        /// </summary>
        [JsonProperty("is_mpim")]
        public bool IsMpim { get; set; }

        /// <summary>
        /// Gets or sets IsPrivate.
        /// </summary>
        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or sets Created.
        /// </summary>
        [JsonProperty("created")]
        public int Created { get; set; }

        /// <summary>
        /// Gets or sets IsArchived.
        /// </summary>
        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or sets IsGeneral.
        /// </summary>
        [JsonProperty("is_general")]
        public bool IsGeneral { get; set; }

        /// <summary>
        /// Gets or sets Unlinked.
        /// </summary>
        [JsonProperty("unlinked")]
        public int Unlinked { get; set; }

        /// <summary>
        /// Gets or sets NameNormalized.
        /// </summary>
        [JsonProperty("name_normalized")]
        public string NameNormalized { get; set; }

        /// <summary>
        /// Gets or sets IsShared.
        /// </summary>
        [JsonProperty("is_shared")]
        public bool IsShared { get; set; }

        /// <summary>
        /// Gets or sets IsOrgShared.
        /// </summary>
        [JsonProperty("is_org_shared")]
        public bool IsOrgShared { get; set; }

        /// <summary>
        /// Gets or sets IsPendingExtShared.
        /// </summary>
        [JsonProperty("is_pending_ext_shared")]
        public bool IsPendingExtShared { get; set; }

        /// <summary>
        /// Gets or sets PendingShared.
        /// </summary>
        [JsonProperty("pending_shared")]
        public List<string> PendingShared { get; set; }

        /// <summary>
        /// Gets or sets ContextTeamId.
        /// </summary>
        [JsonProperty("context_team_id")]
        public string ContextTeamId { get; set; }

        /// <summary>
        /// Gets or sets ParentConversation.
        /// </summary>
        [JsonProperty("parent_conversation", NullValueHandling = NullValueHandling.Include)]
        public string ParentConversation { get; set; }

        /// <summary>
        /// Gets or sets Creator.
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets IsExtShared.
        /// </summary>
        [JsonProperty("is_ext_shared")]
        public bool IsExtShared { get; set; }

        /// <summary>
        /// Gets or sets SharedTeamIds.
        /// </summary>
        [JsonProperty("shared_team_ids")]
        public List<string> SharedTeamIds { get; set; }

        /// <summary>
        /// Gets or sets PendingConnectedTeamIds.
        /// </summary>
        [JsonProperty("pending_connected_team_ids")]
        public List<string> PendingConnectedTeamIds { get; set; }

        /// <summary>
        /// Gets or sets IsMember.
        /// </summary>
        [JsonProperty("is_member")]
        public bool IsMember { get; set; }

        /// <summary>
        /// Gets or sets Topic.
        /// </summary>
        [JsonProperty("topic")]
        public Models.Topic1 Topic { get; set; }

        /// <summary>
        /// Gets or sets Purpose.
        /// </summary>
        [JsonProperty("purpose")]
        public Models.Purpose Purpose { get; set; }

        /// <summary>
        /// Gets or sets PreviousNames.
        /// </summary>
        [JsonProperty("previous_names")]
        public List<string> PreviousNames { get; set; }

        /// <summary>
        /// Gets or sets NumMembers.
        /// </summary>
        [JsonProperty("num_members")]
        public int NumMembers { get; set; }

        /// <summary>
        /// Gets or sets FrozenReason.
        /// </summary>
        [JsonProperty("frozen_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Channel : ({string.Join(", ", toStringOutput)})";
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

            return obj is Channel other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.IsChannel.Equals(other.IsChannel) &&
                this.IsGroup.Equals(other.IsGroup) &&
                this.IsIm.Equals(other.IsIm) &&
                this.IsMpim.Equals(other.IsMpim) &&
                this.IsPrivate.Equals(other.IsPrivate) &&
                this.Created.Equals(other.Created) &&
                this.IsArchived.Equals(other.IsArchived) &&
                this.IsGeneral.Equals(other.IsGeneral) &&
                this.Unlinked.Equals(other.Unlinked) &&
                ((this.NameNormalized == null && other.NameNormalized == null) || (this.NameNormalized?.Equals(other.NameNormalized) == true)) &&
                this.IsShared.Equals(other.IsShared) &&
                this.IsOrgShared.Equals(other.IsOrgShared) &&
                this.IsPendingExtShared.Equals(other.IsPendingExtShared) &&
                ((this.PendingShared == null && other.PendingShared == null) || (this.PendingShared?.Equals(other.PendingShared) == true)) &&
                ((this.ContextTeamId == null && other.ContextTeamId == null) || (this.ContextTeamId?.Equals(other.ContextTeamId) == true)) &&
                ((this.ParentConversation == null && other.ParentConversation == null) || (this.ParentConversation?.Equals(other.ParentConversation) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                this.IsExtShared.Equals(other.IsExtShared) &&
                ((this.SharedTeamIds == null && other.SharedTeamIds == null) || (this.SharedTeamIds?.Equals(other.SharedTeamIds) == true)) &&
                ((this.PendingConnectedTeamIds == null && other.PendingConnectedTeamIds == null) || (this.PendingConnectedTeamIds?.Equals(other.PendingConnectedTeamIds) == true)) &&
                this.IsMember.Equals(other.IsMember) &&
                ((this.Topic == null && other.Topic == null) || (this.Topic?.Equals(other.Topic) == true)) &&
                ((this.Purpose == null && other.Purpose == null) || (this.Purpose?.Equals(other.Purpose) == true)) &&
                ((this.PreviousNames == null && other.PreviousNames == null) || (this.PreviousNames?.Equals(other.PreviousNames) == true)) &&
                this.NumMembers.Equals(other.NumMembers) &&
                ((this.FrozenReason == null && other.FrozenReason == null) || (this.FrozenReason?.Equals(other.FrozenReason) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.IsChannel = {this.IsChannel}");
            toStringOutput.Add($"this.IsGroup = {this.IsGroup}");
            toStringOutput.Add($"this.IsIm = {this.IsIm}");
            toStringOutput.Add($"this.IsMpim = {this.IsMpim}");
            toStringOutput.Add($"this.IsPrivate = {this.IsPrivate}");
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.IsArchived = {this.IsArchived}");
            toStringOutput.Add($"this.IsGeneral = {this.IsGeneral}");
            toStringOutput.Add($"this.Unlinked = {this.Unlinked}");
            toStringOutput.Add($"this.NameNormalized = {(this.NameNormalized == null ? "null" : this.NameNormalized == string.Empty ? "" : this.NameNormalized)}");
            toStringOutput.Add($"this.IsShared = {this.IsShared}");
            toStringOutput.Add($"this.IsOrgShared = {this.IsOrgShared}");
            toStringOutput.Add($"this.IsPendingExtShared = {this.IsPendingExtShared}");
            toStringOutput.Add($"this.PendingShared = {(this.PendingShared == null ? "null" : $"[{string.Join(", ", this.PendingShared)} ]")}");
            toStringOutput.Add($"this.ContextTeamId = {(this.ContextTeamId == null ? "null" : this.ContextTeamId == string.Empty ? "" : this.ContextTeamId)}");
            toStringOutput.Add($"this.ParentConversation = {(this.ParentConversation == null ? "null" : this.ParentConversation == string.Empty ? "" : this.ParentConversation)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator == string.Empty ? "" : this.Creator)}");
            toStringOutput.Add($"this.IsExtShared = {this.IsExtShared}");
            toStringOutput.Add($"this.SharedTeamIds = {(this.SharedTeamIds == null ? "null" : $"[{string.Join(", ", this.SharedTeamIds)} ]")}");
            toStringOutput.Add($"this.PendingConnectedTeamIds = {(this.PendingConnectedTeamIds == null ? "null" : $"[{string.Join(", ", this.PendingConnectedTeamIds)} ]")}");
            toStringOutput.Add($"this.IsMember = {this.IsMember}");
            toStringOutput.Add($"this.Topic = {(this.Topic == null ? "null" : this.Topic.ToString())}");
            toStringOutput.Add($"this.Purpose = {(this.Purpose == null ? "null" : this.Purpose.ToString())}");
            toStringOutput.Add($"this.PreviousNames = {(this.PreviousNames == null ? "null" : $"[{string.Join(", ", this.PreviousNames)} ]")}");
            toStringOutput.Add($"this.NumMembers = {this.NumMembers}");
            toStringOutput.Add($"this.FrozenReason = {(this.FrozenReason == null ? "null" : this.FrozenReason == string.Empty ? "" : this.FrozenReason)}");
        }
    }
}