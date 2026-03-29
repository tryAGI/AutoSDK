//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response format to use for the chat completion, available with `palmyra-x4` and `palmyra-x5`.<br/>
    /// `text` is the default response format. [JSON Schema](https://json-schema.org/) is supported for structured responses. If you specify `json_schema`, you must also provide a `json_schema` object.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// The type of response format to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseFormatType Type { get; set; } = default!;

        /// <summary>
        /// The JSON schema to use for the response format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema")]
        public object? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format to use.
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema to use for the response format.
        /// </param>
        public ResponseFormat(
            global::G.ResponseFormatType type,
            object? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}