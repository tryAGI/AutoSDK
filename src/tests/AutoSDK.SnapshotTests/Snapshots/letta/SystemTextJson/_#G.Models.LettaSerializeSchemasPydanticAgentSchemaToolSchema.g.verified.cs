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
        [global::System.Text.Json.Serialization.JsonPropertyName("args_json_schema")]
        public object? ArgsJsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolJSONSchema3 JsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_char_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReturnCharLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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