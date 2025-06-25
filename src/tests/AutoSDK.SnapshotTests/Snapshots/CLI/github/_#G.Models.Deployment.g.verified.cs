﻿//HintName: G.Models.Deployment.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Unique identifier of the deployment<br/>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDEwOkRlcGxveW1lbnQx
        /// </summary>
        /// <example>MDEwOkRlcGxveW1lbnQx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: a84d88e7554fc1fa21bcbc4efae3c782a70d2b9d
        /// </summary>
        /// <example>a84d88e7554fc1fa21bcbc4efae3c782a70d2b9d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// The ref to deploy. This can be a branch, tag, or sha.<br/>
        /// Example: topic-branch
        /// </summary>
        /// <example>topic-branch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Parameter to specify a task to execute<br/>
        /// Example: deploy
        /// </summary>
        /// <example>deploy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<object, string> Payload { get; set; }

        /// <summary>
        /// Example: staging
        /// </summary>
        /// <example>staging</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_environment")]
        public string? OriginalEnvironment { get; set; }

        /// <summary>
        /// Name for the target deployment environment.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Example: Deploy request from hubot
        /// </summary>
        /// <example>Deploy request from hubot</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/deployments/1/statuses
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/deployments/1/statuses</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// Specifies if the given environment is will no longer exist at some point in the future. Default: false.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transient_environment")]
        public bool? TransientEnvironment { get; set; }

        /// <summary>
        /// Specifies if the given environment is one that end-users directly interact with. Default: false.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("production_environment")]
        public bool? ProductionEnvironment { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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