//HintName: G.Models.PromptResponseFormatJSONSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptResponseFormatJSONSchema
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"json_schema"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "json_schema";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptResponseFormatJSONSchemaDefinition JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResponseFormatJSONSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema"></param>
        /// <param name="type"></param>
        public PromptResponseFormatJSONSchema(
            global::G.PromptResponseFormatJSONSchemaDefinition jsonSchema,
            string type = "json_schema")
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResponseFormatJSONSchema" /> class.
        /// </summary>
        public PromptResponseFormatJSONSchema()
        {
        }
    }
}