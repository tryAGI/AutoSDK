//HintName: G.Models.LongrunningOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This resource represents a long-running operation that is the result of a<br/>
    /// network API call.
    /// </summary>
    public sealed partial class LongrunningOperation
    {
        /// <summary>
        /// The server-assigned name, which is only unique within the same service that<br/>
        /// originally returns it. If you use the default HTTP mapping, the<br/>
        /// `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation.  It typically<br/>
        /// contains progress information and common metadata such as create time.<br/>
        /// Some services might not provide such metadata.  Any method that returns a<br/>
        /// long-running operation should document the metadata type, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Any? Metadata { get; set; }

        /// <summary>
        /// If the value is `false`, it means the operation is still in progress.<br/>
        /// If `true`, the operation is completed, and either `error` or `response` is<br/>
        /// available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("done")]
        public bool? Done { get; set; }

        /// <summary>
        /// The error result of the operation in case of failure or cancellation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.RpcStatus? Error { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success.  If the original<br/>
        /// method returns no data on success, such as `Delete`, the response is<br/>
        /// `google.protobuf.Empty`.  If the original method is standard<br/>
        /// `Get`/`Create`/`Update`, the response should be the resource.  For other<br/>
        /// methods, the response should have the type `XxxResponse`, where `Xxx`<br/>
        /// is the original method name.  For example, if the original method name<br/>
        /// is `TakeSnapshot()`, the inferred response type is<br/>
        /// `TakeSnapshotResponse`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.Any? Response { get; set; }

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
        public static global::G.LongrunningOperation? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LongrunningOperation>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.LongrunningOperation?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LongrunningOperation?>(serializer.Deserialize<global::G.LongrunningOperation>(jsonReader));
        }

    }
}