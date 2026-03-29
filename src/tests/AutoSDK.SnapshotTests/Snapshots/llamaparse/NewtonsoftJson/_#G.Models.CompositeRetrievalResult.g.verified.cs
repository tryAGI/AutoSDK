//HintName: G.Models.CompositeRetrievalResult.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRetrievalResult
    {
        /// <summary>
        /// The retrieved nodes from the composite retrieval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes")]
        public global::System.Collections.Generic.IList<global::G.CompositeRetrievedTextNodeWithScore>? Nodes { get; set; }

        /// <summary>
        /// The image nodes retrieved by the pipeline for the given query. Deprecated - will soon be replaced with 'page_screenshot_nodes'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_nodes")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.PageScreenshotNodeWithScore>? ImageNodes { get; set; }

        /// <summary>
        /// The page figure nodes retrieved by the pipeline for the given query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_figure_nodes")]
        public global::System.Collections.Generic.IList<global::G.PageFigureNodeWithScore>? PageFigureNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievalResult" /> class.
        /// </summary>
        /// <param name="nodes">
        /// The retrieved nodes from the composite retrieval.
        /// </param>
        /// <param name="pageFigureNodes">
        /// The page figure nodes retrieved by the pipeline for the given query.
        /// </param>
        public CompositeRetrievalResult(
            global::System.Collections.Generic.IList<global::G.CompositeRetrievedTextNodeWithScore>? nodes,
            global::System.Collections.Generic.IList<global::G.PageFigureNodeWithScore>? pageFigureNodes)
        {
            this.Nodes = nodes;
            this.PageFigureNodes = pageFigureNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievalResult" /> class.
        /// </summary>
        public CompositeRetrievalResult()
        {
        }
    }
}