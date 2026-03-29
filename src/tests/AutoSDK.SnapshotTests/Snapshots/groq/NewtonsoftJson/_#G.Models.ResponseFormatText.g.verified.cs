//HintName: G.Models.ResponseFormatText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default response format. Used to generate text responses.
    /// </summary>
    public sealed partial class ResponseFormatText
    {
        /// <summary>
        /// The type of response format being defined. Always `text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFormatTextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatText" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format being defined. Always `text`.
        /// </param>
        public ResponseFormatText(
            global::G.ResponseFormatTextType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatText" /> class.
        /// </summary>
        public ResponseFormatText()
        {
        }
    }
}