//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFormatType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        public ResponseFormat(
            global::G.ResponseFormatType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}