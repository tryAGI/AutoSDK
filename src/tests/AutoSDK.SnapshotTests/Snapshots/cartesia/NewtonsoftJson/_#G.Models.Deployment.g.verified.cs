//HintName: G.Models.Deployment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Deployment
    {
        /// <summary>
        /// The unique identifier for the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the agent associated with this deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The current status of the deployment. It can be `queued`, `inactive`, `deploy_error`, `skipped`, `build_error`, `building`, or `deployed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Marks that this deployment is the active deployment for its associated `agent_id`. Only one deployment per agent can be pinned at a time. Deployments can be pinned even if they are not live or failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPinned { get; set; } = default!;

        /// <summary>
        /// True if this deployment is the live production deployment for its associated `agent_id`. Only one deployment per agent can be live at a time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_live", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLive { get; set; } = default!;

        /// <summary>
        /// The ID of the environment variable collection associated with this deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env_var_collection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnvVarCollectionId { get; set; } = default!;

        /// <summary>
        /// The ID of the source code file associated with this deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceCodeFileId { get; set; } = default!;

        /// <summary>
        /// The commit hash of the Git repository for this deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_commit_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitCommitHash { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the deployment was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the deployment was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the build was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("build_completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime BuildCompletedAt { get; set; } = default!;

        /// <summary>
        /// Any error that occurred during the build process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("build_error")]
        public string? BuildError { get; set; }

        /// <summary>
        /// Logs generated during the build process of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("build_logs", Required = global::Newtonsoft.Json.Required.Always)]
        public string BuildLogs { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the build process started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("build_started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime BuildStartedAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the deployment process started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime DeploymentStartedAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the deployment process was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime DeploymentCompletedAt { get; set; } = default!;

        /// <summary>
        /// Any error that occurred during the deployment process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_error")]
        public string? DeploymentError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the deployment.
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent associated with this deployment.
        /// </param>
        /// <param name="status">
        /// The current status of the deployment. It can be `queued`, `inactive`, `deploy_error`, `skipped`, `build_error`, `building`, or `deployed`.
        /// </param>
        /// <param name="isPinned">
        /// Marks that this deployment is the active deployment for its associated `agent_id`. Only one deployment per agent can be pinned at a time. Deployments can be pinned even if they are not live or failed.
        /// </param>
        /// <param name="isLive">
        /// True if this deployment is the live production deployment for its associated `agent_id`. Only one deployment per agent can be live at a time.
        /// </param>
        /// <param name="envVarCollectionId">
        /// The ID of the environment variable collection associated with this deployment.
        /// </param>
        /// <param name="sourceCodeFileId">
        /// The ID of the source code file associated with this deployment.
        /// </param>
        /// <param name="gitCommitHash">
        /// The commit hash of the Git repository for this deployment.
        /// </param>
        /// <param name="createdAt">
        /// The UTC timestamp when the deployment was created.
        /// </param>
        /// <param name="updatedAt">
        /// The UTC timestamp when the deployment was last updated.
        /// </param>
        /// <param name="buildCompletedAt">
        /// The UTC timestamp when the build was completed.
        /// </param>
        /// <param name="buildLogs">
        /// Logs generated during the build process of the deployment.
        /// </param>
        /// <param name="buildStartedAt">
        /// The UTC timestamp when the build process started.
        /// </param>
        /// <param name="deploymentStartedAt">
        /// The UTC timestamp when the deployment process started.
        /// </param>
        /// <param name="deploymentCompletedAt">
        /// The UTC timestamp when the deployment process was completed.
        /// </param>
        /// <param name="buildError">
        /// Any error that occurred during the build process.
        /// </param>
        /// <param name="deploymentError">
        /// Any error that occurred during the deployment process.
        /// </param>
        public Deployment(
            string id,
            string agentId,
            string status,
            bool isPinned,
            bool isLive,
            string envVarCollectionId,
            string sourceCodeFileId,
            string gitCommitHash,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime buildCompletedAt,
            string buildLogs,
            global::System.DateTime buildStartedAt,
            global::System.DateTime deploymentStartedAt,
            global::System.DateTime deploymentCompletedAt,
            string? buildError,
            string? deploymentError)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.IsPinned = isPinned;
            this.IsLive = isLive;
            this.EnvVarCollectionId = envVarCollectionId ?? throw new global::System.ArgumentNullException(nameof(envVarCollectionId));
            this.SourceCodeFileId = sourceCodeFileId ?? throw new global::System.ArgumentNullException(nameof(sourceCodeFileId));
            this.GitCommitHash = gitCommitHash ?? throw new global::System.ArgumentNullException(nameof(gitCommitHash));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BuildCompletedAt = buildCompletedAt;
            this.BuildError = buildError;
            this.BuildLogs = buildLogs ?? throw new global::System.ArgumentNullException(nameof(buildLogs));
            this.BuildStartedAt = buildStartedAt;
            this.DeploymentStartedAt = deploymentStartedAt;
            this.DeploymentCompletedAt = deploymentCompletedAt;
            this.DeploymentError = deploymentError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        public Deployment()
        {
        }
    }
}