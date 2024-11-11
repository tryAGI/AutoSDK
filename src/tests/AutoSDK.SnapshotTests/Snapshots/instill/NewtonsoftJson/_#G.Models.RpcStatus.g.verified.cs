//HintName: G.Models.RpcStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for<br/>
    /// different programming environments, including REST APIs and RPC APIs. It is<br/>
    /// used by [gRPC](https://github.com/grpc). Each `Status` message contains<br/>
    /// three pieces of data: error code, error message, and error details.<br/>
    /// You can find out more about this error model and how to work with it in the<br/>
    /// [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public sealed partial class RpcStatus
    {
        /// <summary>
        /// The status code, which should be an enum value of<br/>
        /// [google.rpc.Code][google.rpc.Code].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any<br/>
        /// user-facing error message should be localized and sent in the<br/>
        /// [google.rpc.Status.details][google.rpc.Status.details] field, or localized<br/>
        /// by the client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// A list of messages that carry the error details.  There is a common set of<br/>
        /// message types for APIs to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::System.Collections.Generic.IList<global::G.Any>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcStatus" /> class.
        /// </summary>
        /// <param name="code">
        /// The status code, which should be an enum value of<br/>
        /// [google.rpc.Code][google.rpc.Code].
        /// </param>
        /// <param name="message">
        /// A developer-facing error message, which should be in English. Any<br/>
        /// user-facing error message should be localized and sent in the<br/>
        /// [google.rpc.Status.details][google.rpc.Status.details] field, or localized<br/>
        /// by the client.
        /// </param>
        /// <param name="details">
        /// A list of messages that carry the error details.  There is a common set of<br/>
        /// message types for APIs to use.
        /// </param>
        public RpcStatus(
            int? code,
            string? message,
            global::System.Collections.Generic.IList<global::G.Any>? details)
        {
            this.Code = code;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcStatus" /> class.
        /// </summary>
        public RpcStatus()
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
        public static global::G.RpcStatus? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RpcStatus>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RpcStatus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RpcStatus?>(serializer.Deserialize<global::G.RpcStatus>(jsonReader));
        }

    }
}