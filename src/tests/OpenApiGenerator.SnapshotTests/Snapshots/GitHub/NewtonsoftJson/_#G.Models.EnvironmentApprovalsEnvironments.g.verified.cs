//HintName: G.Models.EnvironmentApprovalsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentApprovalsEnvironments
    {
        /// <summary>
        /// The id of the environment.
        /// <br/>Example: 56780428
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// <br/>Example: MDExOkVudmlyb25tZW50NTY3ODA0Mjg=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The name of the environment.
        /// <br/>Example: staging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/github/hello-world/environments/staging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/github/hello-world/deployments/activity_log?environments_filter=staging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The time that the environment was created, in ISO 8601 format.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the environment was last updated, in ISO 8601 format.
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}