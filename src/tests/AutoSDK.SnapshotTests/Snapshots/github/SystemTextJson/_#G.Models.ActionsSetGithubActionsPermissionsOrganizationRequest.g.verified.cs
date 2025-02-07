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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllowedActionsJsonConverter))]
        public global::G.AllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsOrganizationRequest" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetGithubActionsPermissionsOrganizationRequest(
            global::G.EnabledRepositories enabledRepositories,
            global::G.AllowedActions? allowedActions)
        {
            this.EnabledRepositories = enabledRepositories;
            this.AllowedActions = allowedActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsOrganizationRequest" /> class.
        /// </summary>
        public ActionsSetGithubActionsPermissionsOrganizationRequest()
        {
        }
    }
}