//HintName: G.Models.ReposCreateDeploymentStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDeploymentStatusRequest
    {
        /// <summary>
        /// The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposCreateDeploymentStatusRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposCreateDeploymentStatusRequestState State { get; set; }

        /// <summary>
        /// The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; It's recommended to use the `log_url` parameter, which replaces `target_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        public string? TargetUrl { get; set; }

        /// <summary>
        /// The full URL of the deployment's output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `""`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_url")]
        public string? LogUrl { get; set; }

        /// <summary>
        /// A short description of the status. The maximum description length is 140 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`. If not defined, the environment of the previous status on the deployment will be used, if it exists. Otherwise, the environment of the deployment will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Sets the URL for accessing your environment. Default: `""`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_url")]
        public string? EnvironmentUrl { get; set; }

        /// <summary>
        /// Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status's deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_inactive")]
        public bool? AutoInactive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeploymentStatusRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.
        /// </param>
        /// <param name="targetUrl">
        /// The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; It's recommended to use the `log_url` parameter, which replaces `target_url`.
        /// </param>
        /// <param name="logUrl">
        /// The full URL of the deployment's output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `""`
        /// </param>
        /// <param name="description">
        /// A short description of the status. The maximum description length is 140 characters.
        /// </param>
        /// <param name="environment">
        /// Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`. If not defined, the environment of the previous status on the deployment will be used, if it exists. Otherwise, the environment of the deployment will be used.
        /// </param>
        /// <param name="environmentUrl">
        /// Sets the URL for accessing your environment. Default: `""`
        /// </param>
        /// <param name="autoInactive">
        /// Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status's deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposCreateDeploymentStatusRequest(
            global::G.ReposCreateDeploymentStatusRequestState state,
            string? targetUrl,
            string? logUrl,
            string? description,
            string? environment,
            string? environmentUrl,
            bool? autoInactive)
        {
            this.State = state;
            this.TargetUrl = targetUrl;
            this.LogUrl = logUrl;
            this.Description = description;
            this.Environment = environment;
            this.EnvironmentUrl = environmentUrl;
            this.AutoInactive = autoInactive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeploymentStatusRequest" /> class.
        /// </summary>
        public ReposCreateDeploymentStatusRequest()
        {
        }
    }
}