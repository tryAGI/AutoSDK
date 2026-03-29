//HintName: G.Models.ResponseFormatJsonObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON object response format. An older method of generating JSON responses.<br/>
    /// Using `json_schema` is recommended for models that support it. Note that the<br/>
    /// model will not generate JSON without a system or user message instructing it<br/>
    /// to do so.
    /// </summary>
    public sealed partial class ResponseFormatJsonObject
    {
        /// <summary>
        /// The type of response format being defined. Always `json_object`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFormatJsonObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined. Always `json_object`.
        /// </param>
        public ResponseFormatJsonObject(
            global::G.ResponseFormatJsonObjectType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonObject" /> class.
        /// </summary>
        public ResponseFormatJsonObject()
        {
        }
    }
}