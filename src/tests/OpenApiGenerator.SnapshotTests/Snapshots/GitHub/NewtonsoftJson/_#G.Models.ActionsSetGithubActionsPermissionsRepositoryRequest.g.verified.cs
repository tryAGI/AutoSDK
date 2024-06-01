//HintName: G.Models.ActionsSetGithubActionsPermissionsRepositoryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetGithubActionsPermissionsRepositoryRequest
    {
        /// <summary>
        /// Whether GitHub Actions is enabled on the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_actions")]
        public ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}