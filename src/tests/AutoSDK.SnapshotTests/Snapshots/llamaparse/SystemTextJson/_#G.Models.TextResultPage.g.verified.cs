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
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// Plain text content of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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