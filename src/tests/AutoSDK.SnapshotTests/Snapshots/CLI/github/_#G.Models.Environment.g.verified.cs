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
        /// Example: 56780428L
        /// </summary>
        /// <example>56780428L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDExOkVudmlyb25tZW50NTY3ODA0Mjg=
        /// </summary>
        /// <example>MDExOkVudmlyb25tZW50NTY3ODA0Mjg=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the environment.<br/>
        /// Example: staging
        /// </summary>
        /// <example>staging</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/environments/staging
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/environments/staging</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging
        /// </summary>
        /// <example>https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging</example>
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
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.EnvironmentProtectionRuleVariant1, global::G.EnvironmentProtectionRuleVariant2, global::G.EnvironmentProtectionRuleVariant3>>? ProtectionRules { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the environment.<br/>
        /// Example: 56780428L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOkVudmlyb25tZW50NTY3ODA0Mjg=
        /// </param>
        /// <param name="name">
        /// The name of the environment.<br/>
        /// Example: staging
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/environments/staging
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging
        /// </param>
        /// <param name="createdAt">
        /// The time that the environment was created, in ISO 8601 format.
        /// </param>
        /// <param name="updatedAt">
        /// The time that the environment was last updated, in ISO 8601 format.
        /// </param>
        /// <param name="protectionRules">
        /// Built-in deployment protection rules for the environment.
        /// </param>
        /// <param name="deploymentBranchPolicy">
        /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Environment(
            long id,
            string nodeId,
            string name,
            string url,
            string htmlUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.EnvironmentProtectionRuleVariant1, global::G.EnvironmentProtectionRuleVariant2, global::G.EnvironmentProtectionRuleVariant3>>? protectionRules,
            global::G.DeploymentBranchPolicySettings? deploymentBranchPolicy)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProtectionRules = protectionRules;
            this.DeploymentBranchPolicy = deploymentBranchPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        public Environment()
        {
        }
    }
}