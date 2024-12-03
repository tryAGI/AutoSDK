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
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentHtml")]
        public string? SegmentHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasSummary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Highlight> Highlights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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