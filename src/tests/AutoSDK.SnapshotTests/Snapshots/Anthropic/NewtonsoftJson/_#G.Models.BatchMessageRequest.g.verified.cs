//HintName: G.Models.BatchMessageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An individual message request within a batch.
    /// </summary>
    public sealed partial class BatchMessageRequest
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for<br/>
        /// matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomId { get; set; } = default!;

        /// <summary>
        /// The request parameters for creating a message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateMessageRequest Params { get; set; } = default!;

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
        public static global::G.BatchMessageRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BatchMessageRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}