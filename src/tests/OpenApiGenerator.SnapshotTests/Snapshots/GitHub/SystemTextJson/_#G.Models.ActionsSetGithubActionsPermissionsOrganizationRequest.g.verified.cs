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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActionsJsonConverter))]
        public ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}