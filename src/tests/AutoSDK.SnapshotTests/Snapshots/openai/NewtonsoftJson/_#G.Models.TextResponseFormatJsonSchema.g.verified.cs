//HintName: G.Models.TextResponseFormatJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON Schema response format. Used to generate structured JSON responses.<br/>
    /// Learn more about [Structured Outputs](/docs/guides/structured-outputs).
    /// </summary>
    public sealed partial class TextResponseFormatJsonSchema
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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The schema for the response format, described as a JSON Schema object.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

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
        /// The type of response format being defined. Always `json_schema`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TextResponseFormatJsonSchemaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatJsonSchema" /> class.
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
        /// <param name="type">
        /// The type of response format being defined. Always `json_schema`.
        /// </param>
        public TextResponseFormatJsonSchema(
            object schema,
            string? description,
            string? name,
            bool? strict,
            global::G.TextResponseFormatJsonSchemaType type)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Description = description;
            this.Name = name;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatJsonSchema" /> class.
        /// </summary>
        public TextResponseFormatJsonSchema()
        {
        }
    }
}