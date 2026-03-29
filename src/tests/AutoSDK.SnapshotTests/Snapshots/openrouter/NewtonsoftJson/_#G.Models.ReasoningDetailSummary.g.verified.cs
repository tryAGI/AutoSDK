//HintName: G.Models.ReasoningDetailSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning detail summary schema
    /// </summary>
    public sealed partial class ReasoningDetailSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ReasoningDetailSummaryType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.OneOf<global::G.ReasoningDetailSummaryFormat?, object>? Format { get; set; }

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
        /// Initializes a new instance of the <see cref="ReasoningDetailSummary" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="index"></param>
        public ReasoningDetailSummary(
            string summary,
            global::G.ReasoningDetailSummaryType type,
            string? id,
            global::G.OneOf<global::G.ReasoningDetailSummaryFormat?, object>? format,
            double? index)
        {
            this.Type = type;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Id = id;
            this.Format = format;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailSummary" /> class.
        /// </summary>
        public ReasoningDetailSummary()
        {
        }
    }
}