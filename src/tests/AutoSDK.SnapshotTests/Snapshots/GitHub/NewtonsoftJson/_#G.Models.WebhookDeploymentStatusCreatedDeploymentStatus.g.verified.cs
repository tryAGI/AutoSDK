//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [deployment status](https://docs.github.com/rest/deployments/statuses#list-deployment-statuses).
    /// </summary>
    public sealed partial class WebhookDeploymentStatusCreatedDeploymentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentStatusCreatedDeploymentStatusCreator? Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentUrl { get; set; } = default!;

        /// <summary>
        /// The optional human-readable description added to the status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_url")]
        public string? EnvironmentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_url")]
        public string? LogUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubApp? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// The new state. Can be `pending`, `success`, `failure`, or `error`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// The optional link added to the status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentStatusCreatedDeploymentStatus" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="deploymentUrl"></param>
        /// <param name="description">
        /// The optional human-readable description added to the status.
        /// </param>
        /// <param name="environment"></param>
        /// <param name="environmentUrl"></param>
        /// <param name="id"></param>
        /// <param name="logUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="repositoryUrl"></param>
        /// <param name="state">
        /// The new state. Can be `pending`, `success`, `failure`, or `error`.
        /// </param>
        /// <param name="targetUrl">
        /// The optional link added to the status.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhookDeploymentStatusCreatedDeploymentStatus(
            string createdAt,
            global::G.WebhookDeploymentStatusCreatedDeploymentStatusCreator? creator,
            string deploymentUrl,
            string description,
            string environment,
            int id,
            string nodeId,
            string repositoryUrl,
            string state,
            string targetUrl,
            string updatedAt,
            string url,
            string? environmentUrl,
            string? logUrl,
            global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubApp? performedViaGithubApp)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.DeploymentUrl = deploymentUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.TargetUrl = targetUrl ?? throw new global::System.ArgumentNullException(nameof(targetUrl));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EnvironmentUrl = environmentUrl;
            this.LogUrl = logUrl;
            this.PerformedViaGithubApp = performedViaGithubApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentStatusCreatedDeploymentStatus" /> class.
        /// </summary>
        public WebhookDeploymentStatusCreatedDeploymentStatus()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookDeploymentStatusCreatedDeploymentStatus? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookDeploymentStatusCreatedDeploymentStatus>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentStatusCreatedDeploymentStatus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentStatusCreatedDeploymentStatus?>(serializer.Deserialize<global::G.WebhookDeploymentStatusCreatedDeploymentStatus>(jsonReader));
        }

    }
}