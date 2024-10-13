//HintName: G.Models.PurgeLemurRequestDataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PurgeLemurRequestDataResponse
    {
        /// <summary>
        /// The ID of the deletion request of the LeMUR request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestId { get; set; } = default!;

        /// <summary>
        /// The ID of the LeMUR request to purge the data for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id_to_purge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestIdToPurge { get; set; } = default!;

        /// <summary>
        /// Whether the request data was deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

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
        public static global::G.PurgeLemurRequestDataResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PurgeLemurRequestDataResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}