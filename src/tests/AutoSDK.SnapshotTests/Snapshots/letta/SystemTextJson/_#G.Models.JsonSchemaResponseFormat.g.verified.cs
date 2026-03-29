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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The JSON schema of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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