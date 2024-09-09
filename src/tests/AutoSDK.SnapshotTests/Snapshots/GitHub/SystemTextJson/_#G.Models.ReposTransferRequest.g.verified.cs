//HintName: G.Models.ReposTransferRequest.g.cs

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
    }
}