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
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// Only included for GitHub Apps. When you register a new GitHub App, GitHub sends a ping event to the webhook URL you specified during registration. The GitHub App ID sent in this field is required for authenticating an app.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPingHookConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// Determines what events the hook is triggered for. Default: ['push'].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Events { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_response")]
        public global::G.HookResponse? LastResponse { get; set; }

        /// <summary>
        /// The type of webhook. The only valid value is 'web'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.WebhookPingHookName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ping_url")]
        public string? PingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_url")]
        public string? TestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookPingHook? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPingHook>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPingHook?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookPingHook?>(serializer.Deserialize<global::G.WebhookPingHook>(jsonReader));
        }

    }
}