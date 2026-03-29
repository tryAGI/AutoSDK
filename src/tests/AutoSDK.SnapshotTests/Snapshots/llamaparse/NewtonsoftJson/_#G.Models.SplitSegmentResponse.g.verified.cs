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
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public string Category { get; set; } = default!;

        /// <summary>
        /// 1-indexed page numbers in this split.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Pages { get; set; } = default!;

        /// <summary>
        /// Categorical confidence level. Valid values are: high, medium, low.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence_category", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConfidenceCategory { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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