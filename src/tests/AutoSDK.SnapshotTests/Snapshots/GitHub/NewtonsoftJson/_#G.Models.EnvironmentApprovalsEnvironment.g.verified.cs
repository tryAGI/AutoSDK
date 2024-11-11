//HintName: G.Models.EnvironmentApprovalsEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentApprovalsEnvironment
    {
        /// <summary>
        /// The id of the environment.<br/>
        /// Example: 56780428
        /// </summary>
        /// <example>56780428</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

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
        /// The time that the environment was created, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time that the environment was last updated, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentApprovalsEnvironment" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the environment.<br/>
        /// Example: 56780428
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
        public EnvironmentApprovalsEnvironment(
            int? id,
            string? nodeId,
            string? name,
            string? url,
            string? htmlUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Name = name;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentApprovalsEnvironment" /> class.
        /// </summary>
        public EnvironmentApprovalsEnvironment()
        {
        }
    }
}