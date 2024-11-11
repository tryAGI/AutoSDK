//HintName: G.Models.WebhookDeploymentCreatedDeployment.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The [deployment](https://docs.github.com/rest/deployments/deployments#list-deployments).
    /// </summary>
    public sealed partial class WebhookDeploymentCreatedDeployment
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
        public global::G.WebhookDeploymentCreatedDeploymentCreator? Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalEnvironment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<object, string> Payload { get; set; } = default!;

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubApp? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("production_environment")]
        public bool? ProductionEnvironment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public string Task { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transient_environment")]
        public bool? TransientEnvironment { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedDeployment" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="description"></param>
        /// <param name="environment"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="originalEnvironment"></param>
        /// <param name="payload"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="productionEnvironment"></param>
        /// <param name="ref"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="sha"></param>
        /// <param name="statusesUrl"></param>
        /// <param name="task"></param>
        /// <param name="transientEnvironment"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhookDeploymentCreatedDeployment(
            string createdAt,
            global::G.WebhookDeploymentCreatedDeploymentCreator? creator,
            string? description,
            string environment,
            int id,
            string nodeId,
            string originalEnvironment,
            global::G.OneOf<object, string> payload,
            string @ref,
            string repositoryUrl,
            string sha,
            string statusesUrl,
            string task,
            string updatedAt,
            string url,
            global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubApp? performedViaGithubApp,
            bool? productionEnvironment,
            bool? transientEnvironment)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.OriginalEnvironment = originalEnvironment ?? throw new global::System.ArgumentNullException(nameof(originalEnvironment));
            this.Payload = payload;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.ProductionEnvironment = productionEnvironment;
            this.TransientEnvironment = transientEnvironment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedDeployment" /> class.
        /// </summary>
        public WebhookDeploymentCreatedDeployment()
        {
        }
    }
}