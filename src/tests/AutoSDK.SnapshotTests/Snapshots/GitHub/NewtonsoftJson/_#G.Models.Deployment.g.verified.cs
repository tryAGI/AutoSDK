//HintName: G.Models.Deployment.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A request for a specific ref(branch,sha,tag) to be deployed
    /// </summary>
    public sealed partial class Deployment
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/deployments/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/deployments/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the deployment<br/>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOkRlcGxveW1lbnQx
        /// </summary>
        /// <example>MDEwOkRlcGxveW1lbnQx</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: a84d88e7554fc1fa21bcbc4efae3c782a70d2b9d
        /// </summary>
        /// <example>a84d88e7554fc1fa21bcbc4efae3c782a70d2b9d</example>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// The ref to deploy. This can be a branch, tag, or sha.<br/>
        /// Example: topic-branch
        /// </summary>
        /// <example>topic-branch</example>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// Parameter to specify a task to execute<br/>
        /// Example: deploy
        /// </summary>
        /// <example>deploy</example>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public string Task { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<object, string> Payload { get; set; } = default!;

        /// <summary>
        /// Example: staging
        /// </summary>
        /// <example>staging</example>
        [global::Newtonsoft.Json.JsonProperty("original_environment")]
        public string? OriginalEnvironment { get; set; }

        /// <summary>
        /// Name for the target deployment environment.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// Example: Deploy request from hubot
        /// </summary>
        /// <example>Deploy request from hubot</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/deployments/1/statuses
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/deployments/1/statuses</example>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example</example>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// Specifies if the given environment is will no longer exist at some point in the future. Default: false.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("transient_environment")]
        public bool? TransientEnvironment { get; set; }

        /// <summary>
        /// Specifies if the given environment is one that end-users directly interact with. Default: false.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("production_environment")]
        public bool? ProductionEnvironment { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/example/deployments/1
        /// </param>
        /// <param name="id">
        /// Unique identifier of the deployment<br/>
        /// Example: 42L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOkRlcGxveW1lbnQx
        /// </param>
        /// <param name="sha">
        /// Example: a84d88e7554fc1fa21bcbc4efae3c782a70d2b9d
        /// </param>
        /// <param name="ref">
        /// The ref to deploy. This can be a branch, tag, or sha.<br/>
        /// Example: topic-branch
        /// </param>
        /// <param name="task">
        /// Parameter to specify a task to execute<br/>
        /// Example: deploy
        /// </param>
        /// <param name="payload"></param>
        /// <param name="originalEnvironment">
        /// Example: staging
        /// </param>
        /// <param name="environment">
        /// Name for the target deployment environment.<br/>
        /// Example: production
        /// </param>
        /// <param name="description">
        /// Example: Deploy request from hubot
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="statusesUrl">
        /// Example: https://api.github.com/repos/octocat/example/deployments/1/statuses
        /// </param>
        /// <param name="repositoryUrl">
        /// Example: https://api.github.com/repos/octocat/example
        /// </param>
        /// <param name="transientEnvironment">
        /// Specifies if the given environment is will no longer exist at some point in the future. Default: false.<br/>
        /// Example: true
        /// </param>
        /// <param name="productionEnvironment">
        /// Specifies if the given environment is one that end-users directly interact with. Default: false.<br/>
        /// Example: true
        /// </param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        public Deployment(
            string url,
            long id,
            string nodeId,
            string sha,
            string @ref,
            string task,
            global::G.OneOf<object, string> payload,
            string environment,
            string? description,
            global::G.NullableSimpleUser? creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string statusesUrl,
            string repositoryUrl,
            string? originalEnvironment,
            bool? transientEnvironment,
            bool? productionEnvironment,
            global::G.NullableIntegration? performedViaGithubApp)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.Payload = payload;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.OriginalEnvironment = originalEnvironment;
            this.TransientEnvironment = transientEnvironment;
            this.ProductionEnvironment = productionEnvironment;
            this.PerformedViaGithubApp = performedViaGithubApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        public Deployment()
        {
        }
    }
}