//HintName: G.Models.OrgHook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Org Hook
    /// </summary>
    public sealed partial class OrgHook
    {
        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/octocat/hooks/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/octocat/hooks/1/pings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ping_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PingUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/octocat/hooks/1/deliveries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// <br/>Example: web
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// <br/>Example: [push, pull_request]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Events { get; set; } = default!;

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public OrgHookConfig Config { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}