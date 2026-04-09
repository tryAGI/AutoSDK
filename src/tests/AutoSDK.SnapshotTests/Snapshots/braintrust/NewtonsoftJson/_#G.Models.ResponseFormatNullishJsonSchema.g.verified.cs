//HintName: G.Models.ResponseFormatNullishJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseFormatNullishJsonSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatNullishJsonSchemaTypeJsonConverter))]
        public global::G.ResponseFormatNullishJsonSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseFormatJsonSchema JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatNullishJsonSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema"></param>
        /// <param name="type"></param>
        public ResponseFormatNullishJsonSchema(
            global::G.ResponseFormatJsonSchema jsonSchema,
            global::G.ResponseFormatNullishJsonSchemaType type)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatNullishJsonSchema" /> class.
        /// </summary>
        public ResponseFormatNullishJsonSchema()
        {
        }
    }
}