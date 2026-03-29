//HintName: G.Models.LlamaParseSpatialTextOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Spatial text output options for preserving document layout.<br/>
    /// Spatial text maintains the visual positioning of text elements, useful for<br/>
    /// documents where layout conveys meaning (forms, tables, multi-column layouts).
    /// </summary>
    public sealed partial class LlamaParseSpatialTextOptions
    {
        /// <summary>
        /// Maintain consistent text column alignment across page boundaries. Automatically enabled for document-level parsing modes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_layout_alignment_across_pages")]
        public bool? PreserveLayoutAlignmentAcrossPages { get; set; }

        /// <summary>
        /// Include text below the normal size threshold. Useful for footnotes, watermarks, or fine print that might otherwise be filtered out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_very_small_text")]
        public bool? PreserveVerySmallText { get; set; }

        /// <summary>
        /// Keep multi-column layouts intact instead of linearizing columns into sequential text. Automatically enabled for non-fast tiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_unroll_columns")]
        public bool? DoNotUnrollColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseSpatialTextOptions" /> class.
        /// </summary>
        /// <param name="preserveLayoutAlignmentAcrossPages">
        /// Maintain consistent text column alignment across page boundaries. Automatically enabled for document-level parsing modes
        /// </param>
        /// <param name="preserveVerySmallText">
        /// Include text below the normal size threshold. Useful for footnotes, watermarks, or fine print that might otherwise be filtered out
        /// </param>
        /// <param name="doNotUnrollColumns">
        /// Keep multi-column layouts intact instead of linearizing columns into sequential text. Automatically enabled for non-fast tiers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseSpatialTextOptions(
            bool? preserveLayoutAlignmentAcrossPages,
            bool? preserveVerySmallText,
            bool? doNotUnrollColumns)
        {
            this.PreserveLayoutAlignmentAcrossPages = preserveLayoutAlignmentAcrossPages;
            this.PreserveVerySmallText = preserveVerySmallText;
            this.DoNotUnrollColumns = doNotUnrollColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseSpatialTextOptions" /> class.
        /// </summary>
        public LlamaParseSpatialTextOptions()
        {
        }
    }
}