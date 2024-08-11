//HintName: G.Models.Environment.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a deployment environment
    /// </summary>
    public sealed partial class Environment
    {
        /// <summary>
        /// The id of the environment.<br/>
        /// Example: 56780428
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDExOkVudmlyb25tZW50NTY3ODA0Mjg=
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the environment.<br/>
        /// Example: staging
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/environments/staging
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The time that the environment was created, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the environment was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Built-in deployment protection rules for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_rules")]
        public global::System.Collections.Generic.IList<global::System.AnyOf<global::G.EnvironmentProtectionRuleVariant1?, global::G.EnvironmentProtectionRuleVariant2?, global::G.EnvironmentProtectionRuleVariant3?>>? ProtectionRules { get; set; }

        /// <summary>
        /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_branch_policy")]
        public global::G.DeploymentBranchPolicySettings? DeploymentBranchPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}