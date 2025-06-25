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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

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
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsRepositoryRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether GitHub Actions is enabled on the repository.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetGithubActionsPermissionsRepositoryRequest(
            bool enabled,
            global::G.AllowedActions? allowedActions)
        {
            this.Enabled = enabled;
            this.AllowedActions = allowedActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsRepositoryRequest" /> class.
        /// </summary>
        public ActionsSetGithubActionsPermissionsRepositoryRequest()
        {
        }
    }
}