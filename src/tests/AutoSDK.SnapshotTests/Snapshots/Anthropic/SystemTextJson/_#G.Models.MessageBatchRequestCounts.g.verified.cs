//HintName: G.Models.MessageBatchRequestCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tallies requests within the Message Batch, categorized by their status.
    /// </summary>
    public sealed partial class MessageBatchRequestCounts
    {
        /// <summary>
        /// Number of requests in the Message Batch that are processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Processing { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that have completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Succeeded { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that encountered an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errored { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that have been canceled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Canceled { get; set; }

        /// <summary>
        /// Number of requests in the Message Batch that have expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Expired { get; set; }

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
        public static global::G.MessageBatchRequestCounts? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MessageBatchRequestCounts),
                jsonSerializerContext) as global::G.MessageBatchRequestCounts;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MessageBatchRequestCounts? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageBatchRequestCounts>(
                json,
                jsonSerializerOptions);
        }

    }
}