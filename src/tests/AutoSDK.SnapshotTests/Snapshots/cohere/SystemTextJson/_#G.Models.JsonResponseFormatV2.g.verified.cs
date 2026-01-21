//HintName: G.Models.JsonResponseFormatV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonResponseFormatV2
    {
        /// <summary>
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatTypeV2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseFormatTypeV2 Type { get; set; }

        /// <summary>
        /// A [JSON schema](https://json-schema.org/overview/what-is-jsonschema) object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](https://docs.cohere.com/docs/structured-outputs-json#schema-constraints) for more information.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public object? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonResponseFormatV2" /> class.
        /// </summary>
        /// <param name="type">
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </param>
        /// <param name="jsonSchema">
        /// A [JSON schema](https://json-schema.org/overview/what-is-jsonschema) object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](https://docs.cohere.com/docs/structured-outputs-json#schema-constraints) for more information.<br/>
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
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonResponseFormatV2(
            global::G.ResponseFormatTypeV2 type,
            object? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonResponseFormatV2" /> class.
        /// </summary>
        public JsonResponseFormatV2()
        {
        }
    }
}