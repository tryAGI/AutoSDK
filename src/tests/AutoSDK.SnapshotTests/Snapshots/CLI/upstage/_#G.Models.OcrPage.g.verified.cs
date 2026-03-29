//HintName: G.Models.OcrPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrPage
    {
        /// <summary>
        /// The page number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The extracted text from this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Width of the page in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the page in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Individual word-level OCR results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::G.OcrWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPage" /> class.
        /// </summary>
        /// <param name="id">
        /// The page number.
        /// </param>
        /// <param name="text">
        /// The extracted text from this page.
        /// </param>
        /// <param name="width">
        /// Width of the page in pixels.
        /// </param>
        /// <param name="height">
        /// Height of the page in pixels.
        /// </param>
        /// <param name="words">
        /// Individual word-level OCR results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrPage(
            int? id,
            string? text,
            int? width,
            int? height,
            global::System.Collections.Generic.IList<global::G.OcrWord>? words)
        {
            this.Id = id;
            this.Text = text;
            this.Width = width;
            this.Height = height;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPage" /> class.
        /// </summary>
        public OcrPage()
        {
        }
    }
}