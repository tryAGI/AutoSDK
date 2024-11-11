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
        [global::Newtonsoft.Json.JsonProperty("processing", Required = global::Newtonsoft.Json.Required.Always)]
        public int Processing { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have completed successfully.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("succeeded", Required = global::Newtonsoft.Json.Required.Always)]
        public int Succeeded { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that encountered an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errored", Required = global::Newtonsoft.Json.Required.Always)]
        public int Errored { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have been canceled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canceled", Required = global::Newtonsoft.Json.Required.Always)]
        public int Canceled { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expired", Required = global::Newtonsoft.Json.Required.Always)]
        public int Expired { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchRequestCounts" /> class.
        /// </summary>
        /// <param name="processing">
        /// Number of requests in the Message Batch that are processing.
        /// </param>
        /// <param name="succeeded">
        /// Number of requests in the Message Batch that have completed successfully.
        /// </param>
        /// <param name="errored">
        /// Number of requests in the Message Batch that encountered an error.
        /// </param>
        /// <param name="canceled">
        /// Number of requests in the Message Batch that have been canceled.
        /// </param>
        /// <param name="expired">
        /// Number of requests in the Message Batch that have expired.
        /// </param>
        public MessageBatchRequestCounts(
            int processing,
            int succeeded,
            int errored,
            int canceled,
            int expired)
        {
            this.Processing = processing;
            this.Succeeded = succeeded;
            this.Errored = errored;
            this.Canceled = canceled;
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchRequestCounts" /> class.
        /// </summary>
        public MessageBatchRequestCounts()
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
        public static global::G.MessageBatchRequestCounts? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MessageBatchRequestCounts>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.MessageBatchRequestCounts?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MessageBatchRequestCounts?>(serializer.Deserialize<global::G.MessageBatchRequestCounts>(jsonReader));
        }

    }
}