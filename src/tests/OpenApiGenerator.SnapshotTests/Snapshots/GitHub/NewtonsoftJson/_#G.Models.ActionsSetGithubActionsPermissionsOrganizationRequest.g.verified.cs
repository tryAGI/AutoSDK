//HintName: G.Models.ActionsSetGithubActionsPermissionsOrganizationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetGithubActionsPermissionsOrganizationRequest
    {
        /// <summary>
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EnabledRepositories EnabledRepositories { get; set; } = default!;

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_actions")]
        public global::G.AllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}