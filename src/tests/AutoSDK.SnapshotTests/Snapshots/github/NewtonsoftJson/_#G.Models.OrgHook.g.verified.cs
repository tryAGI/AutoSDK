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
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/hooks/1
        /// </summary>
        /// <example>https://api.github.com/orgs/octocat/hooks/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/hooks/1/pings
        /// </summary>
        /// <example>https://api.github.com/orgs/octocat/hooks/1/pings</example>
        [global::Newtonsoft.Json.JsonProperty("ping_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PingUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/hooks/1/deliveries
        /// </summary>
        /// <example>https://api.github.com/orgs/octocat/hooks/1/deliveries</example>
        [global::Newtonsoft.Json.JsonProperty("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// Example: web
        /// </summary>
        /// <example>web</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: [push, pull_request]
        /// </summary>
        /// <example>[push, pull_request]</example>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Events { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgHookConfig Config { get; set; } = default!;

        /// <summary>
        /// Example: 2011-09-06T20:39:23Z
        /// </summary>
        /// <example>2011-09-06T20:39:23Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2011-09-06T17:26:27Z
        /// </summary>
        /// <example>2011-09-06T17:26:27Z</example>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgHook" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/octocat/hooks/1
        /// </param>
        /// <param name="pingUrl">
        /// Example: https://api.github.com/orgs/octocat/hooks/1/pings
        /// </param>
        /// <param name="deliveriesUrl">
        /// Example: https://api.github.com/orgs/octocat/hooks/1/deliveries
        /// </param>
        /// <param name="name">
        /// Example: web
        /// </param>
        /// <param name="events">
        /// Example: [push, pull_request]
        /// </param>
        /// <param name="active">
        /// Example: true
        /// </param>
        /// <param name="config"></param>
        /// <param name="updatedAt">
        /// Example: 2011-09-06T20:39:23Z
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-09-06T17:26:27Z
        /// </param>
        /// <param name="type"></param>
        public OrgHook(
            int id,
            string url,
            string pingUrl,
            string name,
            global::System.Collections.Generic.IList<string> events,
            bool active,
            global::G.OrgHookConfig config,
            global::System.DateTime updatedAt,
            global::System.DateTime createdAt,
            string type,
            string? deliveriesUrl)
        {
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PingUrl = pingUrl ?? throw new global::System.ArgumentNullException(nameof(pingUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Active = active;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DeliveriesUrl = deliveriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgHook" /> class.
        /// </summary>
        public OrgHook()
        {
        }
    }
}