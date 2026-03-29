//HintName: G.Models.CreatedJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of creating a JSON schema.
    /// </summary>
    public sealed partial class CreatedJsonSchema
    {
        /// <summary>
        /// The created JSON schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedJsonSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// The created JSON schema
        /// </param>
        public CreatedJsonSchema(
            object jsonSchema)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedJsonSchema" /> class.
        /// </summary>
        public CreatedJsonSchema()
        {
        }
    }
}