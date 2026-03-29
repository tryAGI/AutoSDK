//HintName: G.Models.SplitSegmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A segment of the split document.
    /// </summary>
    public sealed partial class SplitSegmentResponse
    {
        /// <summary>
        /// Category name this split belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// 1-indexed page numbers in this split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Pages { get; set; }

        /// <summary>
        /// Categorical confidence level. Valid values are: high, medium, low.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfidenceCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitSegmentResponse" /> class.
        /// </summary>
        /// <param name="category">
        /// Category name this split belongs to.
        /// </param>
        /// <param name="pages">
        /// 1-indexed page numbers in this split.
        /// </param>
        /// <param name="confidenceCategory">
        /// Categorical confidence level. Valid values are: high, medium, low.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitSegmentResponse(
            string category,
            global::System.Collections.Generic.IList<int> pages,
            string confidenceCategory)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.ConfidenceCategory = confidenceCategory ?? throw new global::System.ArgumentNullException(nameof(confidenceCategory));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitSegmentResponse" /> class.
        /// </summary>
        public SplitSegmentResponse()
        {
        }
    }
}