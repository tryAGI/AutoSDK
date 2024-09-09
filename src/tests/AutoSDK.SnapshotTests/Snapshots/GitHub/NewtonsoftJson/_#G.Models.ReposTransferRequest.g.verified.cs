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
        [global::Newtonsoft.Json.JsonProperty("new_owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewOwner { get; set; } = default!;

        /// <summary>
        /// The new name to be given to the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_name")]
        public string? NewName { get; set; }

        /// <summary>
        /// ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_ids")]
        public global::System.Collections.Generic.IList<int>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}