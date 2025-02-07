//HintName: G.Models.WebhookPingHook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The webhook that is being pinged
    /// </summary>
    public sealed partial class WebhookPingHook
    {
        /// <summary>
        /// Determines whether the hook is actually triggered for the events it subscribes to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Only included for GitHub Apps. When you register a new GitHub App, GitHub sends a ping event to the webhook URL you specified during registration. The GitHub App ID sent in this field is required for authenticating an app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPingHookConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// Determines what events the hook is triggered for. Default: ['push'].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        /// Unique identifier of the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_response")]
        public global::G.HookResponse? LastResponse { get; set; }

        /// <summary>
        /// The type of webhook. The only valid value is 'web'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPingHookNameJsonConverter))]
        public global::G.WebhookPingHookName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ping_url")]
        public string? PingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_url")]
        public string? TestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPingHook" /> class.
        /// </summary>
        /// <param name="active">
        /// Determines whether the hook is actually triggered for the events it subscribes to.
        /// </param>
        /// <param name="appId">
        /// Only included for GitHub Apps. When you register a new GitHub App, GitHub sends a ping event to the webhook URL you specified during registration. The GitHub App ID sent in this field is required for authenticating an app.
        /// </param>
        /// <param name="config"></param>
        /// <param name="createdAt"></param>
        /// <param name="deliveriesUrl"></param>
        /// <param name="events">
        /// Determines what events the hook is triggered for. Default: ['push'].
        /// </param>
        /// <param name="id">
        /// Unique identifier of the webhook.
        /// </param>
        /// <param name="lastResponse"></param>
        /// <param name="name">
        /// The type of webhook. The only valid value is 'web'.
        /// </param>
        /// <param name="pingUrl"></param>
        /// <param name="testUrl"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPingHook(
            bool active,
            global::G.WebhookPingHookConfig config,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<string> events,
            int id,
            string type,
            global::System.DateTime updatedAt,
            int? appId,
            string? deliveriesUrl,
            global::G.HookResponse? lastResponse,
            global::G.WebhookPingHookName name,
            string? pingUrl,
            string? testUrl,
            string? url)
        {
            this.Active = active;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Id = id;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedAt = updatedAt;
            this.AppId = appId;
            this.DeliveriesUrl = deliveriesUrl;
            this.LastResponse = lastResponse;
            this.Name = name;
            this.PingUrl = pingUrl;
            this.TestUrl = testUrl;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPingHook" /> class.
        /// </summary>
        public WebhookPingHook()
        {
        }
    }
}