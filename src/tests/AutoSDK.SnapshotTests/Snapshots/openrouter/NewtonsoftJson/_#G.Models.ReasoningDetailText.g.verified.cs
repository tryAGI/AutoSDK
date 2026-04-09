//HintName: G.Models.ReasoningDetailText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning detail text schema
    /// </summary>
    public sealed partial class ReasoningDetailText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReasoningDetailTextTypeJsonConverter))]
        public global::G.ReasoningDetailTextType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.OneOf<global::G.ReasoningDetailTextFormat?, object>? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailText" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="signature"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="index"></param>
        public ReasoningDetailText(
            global::G.ReasoningDetailTextType type,
            string? text,
            string? signature,
            string? id,
            global::G.OneOf<global::G.ReasoningDetailTextFormat?, object>? format,
            double? index)
        {
            this.Type = type;
            this.Text = text;
            this.Signature = signature;
            this.Id = id;
            this.Format = format;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailText" /> class.
        /// </summary>
        public ReasoningDetailText()
        {
        }
    }
}