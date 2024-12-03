//HintName: G.Models.SegmentSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentText", Required = global::Newtonsoft.Json.Required.Always)]
        public string SegmentText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentHtml")]
        public string? SegmentHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentType", Required = global::Newtonsoft.Json.Required.Always)]
        public string SegmentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasSummary", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasSummary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlights", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Highlight> Highlights { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentSummary" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="segmentText"></param>
        /// <param name="segmentHtml"></param>
        /// <param name="segmentType"></param>
        /// <param name="hasSummary"></param>
        /// <param name="highlights"></param>
        public SegmentSummary(
            string segmentText,
            string segmentType,
            bool hasSummary,
            global::System.Collections.Generic.IList<global::G.Highlight> highlights,
            string? summary,
            string? segmentHtml)
        {
            this.SegmentText = segmentText ?? throw new global::System.ArgumentNullException(nameof(segmentText));
            this.SegmentType = segmentType ?? throw new global::System.ArgumentNullException(nameof(segmentType));
            this.HasSummary = hasSummary;
            this.Highlights = highlights ?? throw new global::System.ArgumentNullException(nameof(highlights));
            this.Summary = summary;
            this.SegmentHtml = segmentHtml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentSummary" /> class.
        /// </summary>
        public SegmentSummary()
        {
        }
    }
}