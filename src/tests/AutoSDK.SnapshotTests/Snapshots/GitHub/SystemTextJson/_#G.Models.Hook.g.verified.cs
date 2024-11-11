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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Unique identifier of the webhook.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of a valid service, use 'web' for a webhook.<br/>
        /// Example: web
        /// </summary>
        /// <example>web</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Determines whether the hook is actually triggered on pushes.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Determines what events the hook is triggered for. Default: ['push'].<br/>
        /// Example: [push, pull_request]
        /// </summary>
        /// <example>[push, pull_request]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        /// Configuration object of the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/test
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1/test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/pings
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1/pings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ping_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PingUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks/1/deliveries
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks/1/deliveries</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HookResponse LastResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Hook? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Hook),
                jsonSerializerContext) as global::G.Hook;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Hook? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Hook>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Hook?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Hook),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Hook;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Hook?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Hook?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}