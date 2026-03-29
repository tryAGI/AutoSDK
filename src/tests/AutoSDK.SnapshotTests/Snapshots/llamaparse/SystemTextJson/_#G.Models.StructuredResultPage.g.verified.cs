//HintName: G.Models.StructuredResultPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredResultPage
    {
        /// <summary>
        /// Page number of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// List of structured items on the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ItemsItem4> Items { get; set; }

        /// <summary>
        /// Width of the page in points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageWidth { get; set; }

        /// <summary>
        /// Height of the page in points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageHeight { get; set; }

        /// <summary>
        /// Success indicator
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResultPage" /> class.
        /// </summary>
        /// <param name="pageNumber">
        /// Page number of the document
        /// </param>
        /// <param name="items">
        /// List of structured items on the page
        /// </param>
        /// <param name="pageWidth">
        /// Width of the page in points
        /// </param>
        /// <param name="pageHeight">
        /// Height of the page in points
        /// </param>
        /// <param name="success">
        /// Success indicator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredResultPage(
            int pageNumber,
            global::System.Collections.Generic.IList<global::G.ItemsItem4> items,
            double pageWidth,
            double pageHeight,
            bool success = true)
        {
            this.PageNumber = pageNumber;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.PageWidth = pageWidth;
            this.PageHeight = pageHeight;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResultPage" /> class.
        /// </summary>
        public StructuredResultPage()
        {
        }
    }
}