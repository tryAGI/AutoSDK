﻿//HintName: G.Models.ReposTransferRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposTransferRequest
    {
        /// <summary>
        /// The username or organization name the repository will be transferred to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewOwner { get; set; }

        /// <summary>
        /// The new name to be given to the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        public string? NewName { get; set; }

        /// <summary>
        /// ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<int>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposTransferRequest" /> class.
        /// </summary>
        /// <param name="newOwner">
        /// The username or organization name the repository will be transferred to.
        /// </param>
        /// <param name="newName">
        /// The new name to be given to the repository.
        /// </param>
        /// <param name="teamIds">
        /// ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposTransferRequest(
            string newOwner,
            string? newName,
            global::System.Collections.Generic.IList<int>? teamIds)
        {
            this.NewOwner = newOwner ?? throw new global::System.ArgumentNullException(nameof(newOwner));
            this.NewName = newName;
            this.TeamIds = teamIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposTransferRequest" /> class.
        /// </summary>
        public ReposTransferRequest()
        {
        }
    }
}