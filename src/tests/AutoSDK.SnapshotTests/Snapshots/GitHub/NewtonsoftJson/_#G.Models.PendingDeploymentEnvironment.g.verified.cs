//HintName: G.Models.PendingDeploymentEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingDeploymentEnvironment
    {
        /// <summary>
        /// The id of the environment.<br/>
        /// Example: 56780428L
        /// </summary>
        /// <example>56780428L</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Example: MDExOkVudmlyb25tZW50NTY3ODA0Mjg=
        /// </summary>
        /// <example>MDExOkVudmlyb25tZW50NTY3ODA0Mjg=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The name of the environment.<br/>
        /// Example: staging
        /// </summary>
        /// <example>staging</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/environments/staging
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/environments/staging</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging
        /// </summary>
        /// <example>https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging</example>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeploymentEnvironment" /> class.
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
        public PendingDeploymentEnvironment(
            long? id,
            string? nodeId,
            string? name,
            string? url,
            string? htmlUrl)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Name = name;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeploymentEnvironment" /> class.
        /// </summary>
        public PendingDeploymentEnvironment()
        {
        }
    }
}