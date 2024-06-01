//HintName: G.Models.DeploymentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of a deployment.
    /// </summary>
    public sealed partial class DeploymentStatus
    {
        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/example/deployments/42/statuses/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// <br/>Example: MDE2OkRlcGxveW1lbnRTdGF0dXMx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The state of the status.
        /// <br/>Example: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DeploymentStatusStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required DeploymentStatusState State { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// A short description of the status.
        /// <br/>Default Value: 
        /// <br/>Example: Deployment finished successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The environment of the deployment that the status is for.
        /// <br/>Default Value: 
        /// <br/>Example: production
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; } = "";

        /// <summary>
        /// Deprecated: the URL to associate with this status.
        /// <br/>Default Value: 
        /// <br/>Example: https://example.com/deployment/42/output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUrl { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/example/deployments/42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// The URL for accessing your environment.
        /// <br/>Default Value: 
        /// <br/>Example: https://staging.example.com/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_url")]
        public string? EnvironmentUrl { get; set; } = "";

        /// <summary>
        /// The URL to associate with this status.
        /// <br/>Default Value: 
        /// <br/>Example: https://example.com/deployment/42/output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_url")]
        public string? LogUrl { get; set; } = "";

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}