//HintName: G.Models.AutoModeSpatialTextOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Spatial text options for auto mode parsing configuration.
    /// </summary>
    public sealed partial class AutoModeSpatialTextOptions
    {
        /// <summary>
        /// Preserve text alignment across page boundaries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_layout_alignment_across_pages")]
        public bool? PreserveLayoutAlignmentAcrossPages { get; set; }

        /// <summary>
        /// Include very small text in spatial output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_very_small_text")]
        public bool? PreserveVerySmallText { get; set; }

        /// <summary>
        /// Keep column structure intact without unrolling
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do_not_unroll_columns")]
        public bool? DoNotUnrollColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeSpatialTextOptions" /> class.
        /// </summary>
        /// <param name="preserveLayoutAlignmentAcrossPages">
        /// Preserve text alignment across page boundaries
        /// </param>
        /// <param name="preserveVerySmallText">
        /// Include very small text in spatial output
        /// </param>
        /// <param name="doNotUnrollColumns">
        /// Keep column structure intact without unrolling
        /// </param>
        public AutoModeSpatialTextOptions(
            bool? preserveLayoutAlignmentAcrossPages,
            bool? preserveVerySmallText,
            bool? doNotUnrollColumns)
        {
            this.PreserveLayoutAlignmentAcrossPages = preserveLayoutAlignmentAcrossPages;
            this.PreserveVerySmallText = preserveVerySmallText;
            this.DoNotUnrollColumns = doNotUnrollColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeSpatialTextOptions" /> class.
        /// </summary>
        public AutoModeSpatialTextOptions()
        {
        }
    }
}