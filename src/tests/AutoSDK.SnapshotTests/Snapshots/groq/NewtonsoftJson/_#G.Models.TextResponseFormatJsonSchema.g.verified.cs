//HintName: G.Models.TextResponseFormatJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON Schema response format. Used to generate structured JSON responses.
    /// </summary>
    public sealed partial class TextResponseFormatJsonSchema
    {
        /// <summary>
        /// The type of response format being defined. Always `json_schema`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter))]
        public global::G.TextResponseFormatJsonSchemaType Type { get; set; }

        /// <summary>
        /// The name of the response format. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of what the response format is for, used by the model to determine how to respond in the format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The schema for the response format, described as a JSON Schema object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Whether to enable strict schema adherence when generating the output.<br/>
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
        /// Initializes a new instance of the <see cref="TextResponseFormatJsonSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the response format. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
        /// </param>
        /// <param name="schema">
        /// The schema for the response format, described as a JSON Schema object.
        /// </param>
        /// <param name="type">
        /// The type of response format being defined. Always `json_schema`.
        /// </param>
        /// <param name="description">
        /// A description of what the response format is for, used by the model to determine how to respond in the format.
        /// </param>
        /// <param name="strict">
        /// Whether to enable strict schema adherence when generating the output.<br/>
        /// Default Value: false
        /// </param>
        public TextResponseFormatJsonSchema(
            string name,
            object schema,
            global::G.TextResponseFormatJsonSchemaType type,
            string? description,
            bool? strict)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatJsonSchema" /> class.
        /// </summary>
        public TextResponseFormatJsonSchema()
        {
        }
    }
}