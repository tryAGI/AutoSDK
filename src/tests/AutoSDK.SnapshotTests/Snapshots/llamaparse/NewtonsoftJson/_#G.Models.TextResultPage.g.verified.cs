//HintName: G.Models.TextResultPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextResultPage
    {
        /// <summary>
        /// Page number of the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNumber { get; set; } = default!;

        /// <summary>
        /// Plain text content of the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResultPage" /> class.
        /// </summary>
        /// <param name="pageNumber">
        /// Page number of the document
        /// </param>
        /// <param name="text">
        /// Plain text content of the page
        /// </param>
        public TextResultPage(
            int pageNumber,
            string text)
        {
            this.PageNumber = pageNumber;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResultPage" /> class.
        /// </summary>
        public TextResultPage()
        {
        }
    }
}