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
        [global::Newtonsoft.Json.JsonProperty("page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNumber { get; set; } = default!;

        /// <summary>
        /// List of structured items on the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ItemsItem4> Items { get; set; } = default!;

        /// <summary>
        /// Width of the page in points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_width", Required = global::Newtonsoft.Json.Required.Always)]
        public double PageWidth { get; set; } = default!;

        /// <summary>
        /// Height of the page in points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_height", Required = global::Newtonsoft.Json.Required.Always)]
        public double PageHeight { get; set; } = default!;

        /// <summary>
        /// Success indicator
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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