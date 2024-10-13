//HintName: G.Models.CreateChatCompletionStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a streamed chunk of a chat completion response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion. Each chunk has the same ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the<br/>
        /// last chunk if you set `stream_options: {"include_usage": true}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateChatCompletionStreamResponseChoice> Choices { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// The model to generate the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The service tier used for processing the request. This field is only included if the `service_tier` parameter is specified in the request.<br/>
        /// Example: scale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionStreamResponseServiceTierJsonConverter))]
        public global::G.CreateChatCompletionStreamResponseServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion.chunk`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter))]
        public global::G.CreateChatCompletionStreamResponseObject Object { get; set; }

        /// <summary>
        /// An optional field that will only be present when you set `stream_options: {"include_usage": true}` in your request.<br/>
        /// When present, it contains a null value except for the last chunk which contains the token usage statistics for the entire request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.CreateChatCompletionStreamResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.CreateChatCompletionStreamResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CreateChatCompletionStreamResponse),
                jsonSerializerContext) as global::G.CreateChatCompletionStreamResponse;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateChatCompletionStreamResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateChatCompletionStreamResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}