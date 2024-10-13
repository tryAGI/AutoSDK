//HintName: G.Models.JsonResponseFormatV2JsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [BETA] A JSON schema object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](/docs/structured-outputs-json#schema-constraints) for more information.<br/>
    /// Example (required name and age object):<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "type": "object",<br/>
    ///   "properties": {<br/>
    ///     "name": {"type": "string"},<br/>
    ///     "age": {"type": "integer"}<br/>
    ///   },<br/>
    ///   "required": ["name", "age"]<br/>
    /// }<br/>
    /// ```<br/>
    /// **Note**: This field must not be specified when the `type` is set to `"text"`.
    /// </summary>
    public sealed partial class JsonResponseFormatV2JsonSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.JsonResponseFormatV2JsonSchema? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.JsonResponseFormatV2JsonSchema>(
                json,
                jsonSerializerOptions);
        }

    }
}