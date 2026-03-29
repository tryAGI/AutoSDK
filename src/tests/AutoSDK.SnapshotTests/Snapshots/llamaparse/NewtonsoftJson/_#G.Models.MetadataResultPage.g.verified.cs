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
        [global::Newtonsoft.Json.JsonProperty("page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNumber { get; set; } = default!;

        /// <summary>
        /// Confidence score for the page parsing (0-1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Speaker notes from presentation slides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_notes")]
        public string? SpeakerNotes { get; set; }

        /// <summary>
        /// Section name from presentation slides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slide_section_name")]
        public string? SlideSectionName { get; set; }

        /// <summary>
        /// Printed page number as it appears in the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("printed_page_number")]
        public string? PrintedPageNumber { get; set; }

        /// <summary>
        /// Original orientation angle of the page in degrees
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_orientation_angle")]
        public int? OriginalOrientationAngle { get; set; }

        /// <summary>
        /// Whether cost-optimized parsing was used for the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_optimized")]
        public bool? CostOptimized { get; set; }

        /// <summary>
        /// Whether auto mode was triggered for the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggered_auto_mode")]
        public bool? TriggeredAutoMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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