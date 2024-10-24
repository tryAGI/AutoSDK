﻿//HintName: G.Models.MessageBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A batch of message requests.
    /// </summary>
    public sealed partial class MessageBatch
    {
        /// <summary>
        /// Unique object identifier for the message batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch will expire and end processing, which is 24 hours after creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Processing status of the Message Batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageBatchProcessingStatus ProcessingStatus { get; set; } = default!;

        /// <summary>
        /// Tallies requests within the Message Batch, categorized by their status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_counts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageBatchRequestCounts RequestCounts { get; set; } = default!;

        /// <summary>
        /// URL to a `.jsonl` file containing the results of the Message Batch requests. Specified only once processing ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results_url")]
        public string? ResultsUrl { get; set; }

        /// <summary>
        /// Object type. For Message Batches, this is always `"message_batch"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageBatchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.MessageBatch? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MessageBatch>(
                json,
                jsonSerializerOptions);
        }

    }
}