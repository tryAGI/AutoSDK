//HintName: G.Models.Hook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhooks for repositories.
    /// </summary>
    public sealed partial class Hook
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the webhook.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of a valid service, use 'web' for a webhook.<br/>
        /// Example: web
        /// </summary>
        /// <example>web</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Determines whether the hook is actually triggered on pushes.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// Determines what events the hook is triggered for. Default: ['push'].<br/>
        /// Example: [push, pull_request]
        /// </summary>
        /// <example>[push, pull_request]</example>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Events { get; set; } = default!;

        /// <summary>
        /// Configuration object of the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/test
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1/test</example>
        [global::Newtonsoft.Json.JsonProperty("test_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/pings
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1/pings</example>
        [global::Newtonsoft.Json.JsonProperty("ping_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PingUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/deliveries
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1/deliveries</example>
        [global::Newtonsoft.Json.JsonProperty("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HookResponse LastResponse { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hook" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// Unique identifier of the webhook.<br/>
        /// Example: 42
        /// </param>
        /// <param name="name">
        /// The name of a valid service, use 'web' for a webhook.<br/>
        /// Example: web
        /// </param>
        /// <param name="active">
        /// Determines whether the hook is actually triggered on pushes.<br/>
        /// Example: true
        /// </param>
        /// <param name="events">
        /// Determines what events the hook is triggered for. Default: ['push'].<br/>
        /// Example: [push, pull_request]
        /// </param>
        /// <param name="config">
        /// Configuration object of the webhook
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1
        /// </param>
        /// <param name="testUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/test
        /// </param>
        /// <param name="pingUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/pings
        /// </param>
        /// <param name="deliveriesUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/deliveries
        /// </param>
        /// <param name="lastResponse"></param>
        public Hook(
            string type,
            int id,
            string name,
            bool active,
            global::System.Collections.Generic.IList<string> events,
            global::G.WebhookConfig config,
            global::System.DateTime updatedAt,
            global::System.DateTime createdAt,
            string url,
            string testUrl,
            string pingUrl,
            global::G.HookResponse lastResponse,
            string? deliveriesUrl)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Active = active;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.TestUrl = testUrl ?? throw new global::System.ArgumentNullException(nameof(testUrl));
            this.PingUrl = pingUrl ?? throw new global::System.ArgumentNullException(nameof(pingUrl));
            this.LastResponse = lastResponse ?? throw new global::System.ArgumentNullException(nameof(lastResponse));
            this.DeliveriesUrl = deliveriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hook" /> class.
        /// </summary>
        public Hook()
        {
        }
    }
}