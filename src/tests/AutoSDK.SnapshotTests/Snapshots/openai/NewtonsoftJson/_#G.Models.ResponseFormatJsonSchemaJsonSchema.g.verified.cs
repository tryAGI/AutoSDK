//HintName: G.Models.ResponseFormatJsonSchemaJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured Outputs configuration options, including a JSON Schema.
    /// </summary>
    public sealed partial class ResponseFormatJsonSchemaJsonSchema
    {
        /// <summary>
        /// A description of what the response format is for, used by the model to<br/>
        /// determine how to respond in the format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the response format. Must be a-z, A-Z, 0-9, or contain<br/>
        /// underscores and dashes, with a maximum length of 64.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The schema for the response format, described as a JSON Schema object.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Whether to enable strict schema adherence when generating the output.<br/>
        /// If set to true, the model will always follow the exact schema defined<br/>
        /// in the `schema` field. Only a subset of JSON Schema is supported when<br/>
        /// `strict` is `true`. To learn more, read the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchemaJsonSchema" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of what the response format is for, used by the model to<br/>
        /// determine how to respond in the format.
        /// </param>
        /// <param name="name">
        /// The name of the response format. Must be a-z, A-Z, 0-9, or contain<br/>
        /// underscores and dashes, with a maximum length of 64.
        /// </param>
        /// <param name="schema">
        /// The schema for the response format, described as a JSON Schema object.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </param>
        /// <param name="strict">
        /// Whether to enable strict schema adherence when generating the output.<br/>
        /// If set to true, the model will always follow the exact schema defined<br/>
        /// in the `schema` field. Only a subset of JSON Schema is supported when<br/>
        /// `strict` is `true`. To learn more, read the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Default Value: false
        /// </param>
        public ResponseFormatJsonSchemaJsonSchema(
            string name,
            string? description,
            object? schema,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchemaJsonSchema" /> class.
        /// </summary>
        public ResponseFormatJsonSchemaJsonSchema()
        {
        }
    }
}