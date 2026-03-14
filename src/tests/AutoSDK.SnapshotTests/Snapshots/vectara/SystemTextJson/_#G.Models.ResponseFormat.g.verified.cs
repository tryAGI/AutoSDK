//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the format the model must output.<br/>
    /// - `text`: Plain text responses (default).<br/>
    /// - `json_object`: Ensures the response is valid JSON.<br/>
    /// - `json_schema`: Ensures the response conforms to the provided JSON schema.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// The format type. Use 'json_schema' for structured outputs, 'json_object' for basic JSON mode, or 'text' for plain text.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::G.ResponseFormatType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseFormatType Type { get; set; } = global::G.ResponseFormatType.Text;

        /// <summary>
        /// Specification wrapper for a named JSON schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::G.JsonSchemaSpec? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The format type. Use 'json_schema' for structured outputs, 'json_object' for basic JSON mode, or 'text' for plain text.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="jsonSchema">
        /// Specification wrapper for a named JSON schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormat(
            global::G.ResponseFormatType type,
            global::G.JsonSchemaSpec? jsonSchema)
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