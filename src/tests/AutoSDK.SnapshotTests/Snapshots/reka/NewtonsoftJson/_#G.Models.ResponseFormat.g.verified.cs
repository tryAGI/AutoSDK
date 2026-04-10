//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured output configuration. Forces the model to return valid JSON matching a schema.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// The response format type. Currently only "json_schema" is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatTypeJsonConverter))]
        public global::G.ResponseFormatType Type { get; set; }

        /// <summary>
        /// JSON Schema configuration for structured output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema")]
        public global::G.JsonSchemaConfig? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The response format type. Currently only "json_schema" is supported.
        /// </param>
        /// <param name="jsonSchema">
        /// JSON Schema configuration for structured output.
        /// </param>
        public ResponseFormat(
            global::G.ResponseFormatType type,
            global::G.JsonSchemaConfig? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}