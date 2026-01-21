//HintName: G.Models.JSONResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONResponseFormat
    {
        /// <summary>
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseFormatType Type { get; set; } = default!;

        /// <summary>
        /// A JSON schema object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](https://docs.cohere.com/docs/structured-outputs-json#schema-constraints) for more information.<br/>
        /// Example (required name and age object):<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }<br/>
        /// ```<br/>
        /// **Note**: This field must not be specified when the `type` is set to `"text"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </param>
        /// <param name="schema">
        /// A JSON schema object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](https://docs.cohere.com/docs/structured-outputs-json#schema-constraints) for more information.<br/>
        /// Example (required name and age object):<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {"type": "string"},<br/>
        ///     "age": {"type": "integer"}<br/>
        ///   },<br/>
        ///   "required": ["name", "age"]<br/>
        /// }<br/>
        /// ```<br/>
        /// **Note**: This field must not be specified when the `type` is set to `"text"`.
        /// </param>
        public JSONResponseFormat(
            global::G.ResponseFormatType type,
            object? schema)
        {
            this.Type = type;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONResponseFormat" /> class.
        /// </summary>
        public JSONResponseFormat()
        {
        }
    }
}