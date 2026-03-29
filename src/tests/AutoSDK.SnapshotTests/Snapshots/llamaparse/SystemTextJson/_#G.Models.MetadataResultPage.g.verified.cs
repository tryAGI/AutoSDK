//HintName: G.Models.MetadataResultPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Page-level metadata including confidence scores and presentation-specific data.
    /// </summary>
    public sealed partial class MetadataResultPage
    {
        /// <summary>
        /// Page number of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// Confidence score for the page parsing (0-1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Speaker notes from presentation slides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_notes")]
        public string? SpeakerNotes { get; set; }

        /// <summary>
        /// Section name from presentation slides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slide_section_name")]
        public string? SlideSectionName { get; set; }

        /// <summary>
        /// Printed page number as it appears in the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("printed_page_number")]
        public string? PrintedPageNumber { get; set; }

        /// <summary>
        /// Original orientation angle of the page in degrees
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_orientation_angle")]
        public int? OriginalOrientationAngle { get; set; }

        /// <summary>
        /// Whether cost-optimized parsing was used for the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_optimized")]
        public bool? CostOptimized { get; set; }

        /// <summary>
        /// Whether auto mode was triggered for the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_auto_mode")]
        public bool? TriggeredAutoMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultPage" /> class.
        /// </summary>
        /// <param name="pageNumber">
        /// Page number of the document
        /// </param>
        /// <param name="confidence">
        /// Confidence score for the page parsing (0-1)
        /// </param>
        /// <param name="speakerNotes">
        /// Speaker notes from presentation slides
        /// </param>
        /// <param name="slideSectionName">
        /// Section name from presentation slides
        /// </param>
        /// <param name="printedPageNumber">
        /// Printed page number as it appears in the document
        /// </param>
        /// <param name="originalOrientationAngle">
        /// Original orientation angle of the page in degrees
        /// </param>
        /// <param name="costOptimized">
        /// Whether cost-optimized parsing was used for the page
        /// </param>
        /// <param name="triggeredAutoMode">
        /// Whether auto mode was triggered for the page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataResultPage(
            int pageNumber,
            double? confidence,
            string? speakerNotes,
            string? slideSectionName,
            string? printedPageNumber,
            int? originalOrientationAngle,
            bool? costOptimized,
            bool? triggeredAutoMode)
        {
            this.PageNumber = pageNumber;
            this.Confidence = confidence;
            this.SpeakerNotes = speakerNotes;
            this.SlideSectionName = slideSectionName;
            this.PrintedPageNumber = printedPageNumber;
            this.OriginalOrientationAngle = originalOrientationAngle;
            this.CostOptimized = costOptimized;
            this.TriggeredAutoMode = triggeredAutoMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultPage" /> class.
        /// </summary>
        public MetadataResultPage()
        {
        }
    }
}