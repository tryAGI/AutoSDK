//HintName: G.Models.PrivacyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivacyResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Vpn { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Proxy { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tor { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hosting { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Relay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyResponse" /> class.
        /// </summary>
        /// <param name="vpn">
        /// Example: true
        /// </param>
        /// <param name="proxy">
        /// Example: false
        /// </param>
        /// <param name="tor">
        /// Example: false
        /// </param>
        /// <param name="hosting">
        /// Example: false
        /// </param>
        /// <param name="relay">
        /// Example: false
        /// </param>
        /// <param name="service"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PrivacyResponse(
            bool vpn,
            bool proxy,
            bool tor,
            bool hosting,
            bool relay,
            string service)
        {
            this.Vpn = vpn;
            this.Proxy = proxy;
            this.Tor = tor;
            this.Hosting = hosting;
            this.Relay = relay;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyResponse" /> class.
        /// </summary>
        public PrivacyResponse()
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
        public static global::G.PrivacyResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PrivacyResponse),
                jsonSerializerContext) as global::G.PrivacyResponse;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PrivacyResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PrivacyResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PrivacyResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PrivacyResponse),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PrivacyResponse;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PrivacyResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PrivacyResponse?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}