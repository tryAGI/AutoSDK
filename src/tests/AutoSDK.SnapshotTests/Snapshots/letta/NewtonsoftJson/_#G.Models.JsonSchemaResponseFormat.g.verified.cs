//HintName: G.Models.JsonSchemaResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response format for JSON schema-based responses.
    /// </summary>
    public sealed partial class JsonSchemaResponseFormat
    {
        /// <summary>
        /// The type of the response format.<br/>
        /// Default Value: json_schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The JSON schema of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaResponseFormat" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// The JSON schema of the response.
        /// </param>
        /// <param name="type">
        /// The type of the response format.<br/>
        /// Default Value: json_schema
        /// </param>
        public JsonSchemaResponseFormat(
            object jsonSchema,
            string? type)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaResponseFormat" /> class.
        /// </summary>
        public JsonSchemaResponseFormat()
        {
        }
    }
}