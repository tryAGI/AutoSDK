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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDE2OkRlcGxveW1lbnRTdGF0dXMx
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The state of the status.
        /// <br/>Example: success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public DeploymentStatusState State { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// A short description of the status.
        /// <br/>Default Value: 
        /// <br/>Example: Deployment finished successfully.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The environment of the deployment that the status is for.
        /// <br/>Default Value: 
        /// <br/>Example: production
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; } = "";

        /// <summary>
        /// Deprecated: the URL to associate with this status.
        /// <br/>Default Value: 
        /// <br/>Example: https://example.com/deployment/42/output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/example/deployments/42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/example
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// The URL for accessing your environment.
        /// <br/>Default Value: 
        /// <br/>Example: https://staging.example.com/
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_url")]
        public string? EnvironmentUrl { get; set; } = "";

        /// <summary>
        /// The URL to associate with this status.
        /// <br/>Default Value: 
        /// <br/>Example: https://example.com/deployment/42/output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_url")]
        public string? LogUrl { get; set; } = "";

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}