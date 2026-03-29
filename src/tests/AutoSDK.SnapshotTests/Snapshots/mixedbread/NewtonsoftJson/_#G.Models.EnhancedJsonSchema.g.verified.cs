//HintName: G.Models.EnhancedJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of enhancing a JSON schema.
    /// </summary>
    public sealed partial class EnhancedJsonSchema
    {
        /// <summary>
        /// The enhanced JSON schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedJsonSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// The enhanced JSON schema
        /// </param>
        public EnhancedJsonSchema(
            object jsonSchema)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedJsonSchema" /> class.
        /// </summary>
        public EnhancedJsonSchema()
        {
        }
    }
}