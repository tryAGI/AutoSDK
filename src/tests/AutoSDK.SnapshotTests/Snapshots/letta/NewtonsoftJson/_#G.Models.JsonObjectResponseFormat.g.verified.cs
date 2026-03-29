//HintName: G.Models.JsonObjectResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response format for JSON object responses.
    /// </summary>
    public sealed partial class JsonObjectResponseFormat
    {
        /// <summary>
        /// The type of the response format.<br/>
        /// Default Value: json_object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonObjectResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the response format.<br/>
        /// Default Value: json_object
        /// </param>
        public JsonObjectResponseFormat(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonObjectResponseFormat" /> class.
        /// </summary>
        public JsonObjectResponseFormat()
        {
        }
    }
}