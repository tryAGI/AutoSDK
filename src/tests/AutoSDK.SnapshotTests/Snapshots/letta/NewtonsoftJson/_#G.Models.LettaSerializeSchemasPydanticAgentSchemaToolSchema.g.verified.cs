//HintName: G.Models.LettaSerializeSchemasPydanticAgentSchemaToolSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSerializeSchemasPydanticAgentSchemaToolSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args_json_schema")]
        public object? ArgsJsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolJSONSchema3 JsonSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_char_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReturnCharLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSerializeSchemasPydanticAgentSchemaToolSchema" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="jsonSchema"></param>
        /// <param name="name"></param>
        /// <param name="returnCharLimit"></param>
        /// <param name="sourceType"></param>
        /// <param name="tags"></param>
        /// <param name="toolType"></param>
        /// <param name="updatedAt"></param>
        /// <param name="argsJsonSchema"></param>
        /// <param name="sourceCode"></param>
        /// <param name="metadata"></param>
        public LettaSerializeSchemasPydanticAgentSchemaToolSchema(
            string createdAt,
            string description,
            global::G.ToolJSONSchema3 jsonSchema,
            string name,
            int returnCharLimit,
            string sourceType,
            global::System.Collections.Generic.IList<string> tags,
            string toolType,
            string updatedAt,
            object? argsJsonSchema,
            string? sourceCode,
            object? metadata)
        {
            this.ArgsJsonSchema = argsJsonSchema;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ReturnCharLimit = returnCharLimit;
            this.SourceCode = sourceCode;
            this.SourceType = sourceType ?? throw new global::System.ArgumentNullException(nameof(sourceType));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ToolType = toolType ?? throw new global::System.ArgumentNullException(nameof(toolType));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSerializeSchemasPydanticAgentSchemaToolSchema" /> class.
        /// </summary>
        public LettaSerializeSchemasPydanticAgentSchemaToolSchema()
        {
        }
    }
}