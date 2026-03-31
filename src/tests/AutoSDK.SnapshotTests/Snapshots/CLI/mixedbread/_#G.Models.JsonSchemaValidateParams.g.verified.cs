//HintName: G.Models.JsonSchemaValidateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for validating a JSON schema.
    /// </summary>
    public sealed partial class JsonSchemaValidateParams
    {
        /// <summary>
        /// The JSON schema to validate
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
        /// Initializes a new instance of the <see cref="JsonSchemaValidateParams" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// The JSON schema to validate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaValidateParams(
            object jsonSchema)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaValidateParams" /> class.
        /// </summary>
        public JsonSchemaValidateParams()
        {
        }
    }
}