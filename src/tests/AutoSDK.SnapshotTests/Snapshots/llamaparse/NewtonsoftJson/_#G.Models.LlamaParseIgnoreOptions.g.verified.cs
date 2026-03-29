//HintName: G.Models.LlamaParseIgnoreOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for ignoring specific types of text during extraction.
    /// </summary>
    public sealed partial class LlamaParseIgnoreOptions
    {
        /// <summary>
        /// Skip text rotated at an angle (not horizontal/vertical). Useful for ignoring watermarks or decorative angled text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_diagonal_text")]
        public bool? IgnoreDiagonalText { get; set; }

        /// <summary>
        /// Skip OCR text extraction from embedded images. Use when images contain irrelevant text (watermarks, logos) that shouldn't be in the output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_text_in_image")]
        public bool? IgnoreTextInImage { get; set; }

        /// <summary>
        /// Skip text marked as hidden in the document structure. Some PDFs contain invisible text layers used for accessibility or search indexing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_hidden_text")]
        public bool? IgnoreHiddenText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseIgnoreOptions" /> class.
        /// </summary>
        /// <param name="ignoreDiagonalText">
        /// Skip text rotated at an angle (not horizontal/vertical). Useful for ignoring watermarks or decorative angled text
        /// </param>
        /// <param name="ignoreTextInImage">
        /// Skip OCR text extraction from embedded images. Use when images contain irrelevant text (watermarks, logos) that shouldn't be in the output
        /// </param>
        /// <param name="ignoreHiddenText">
        /// Skip text marked as hidden in the document structure. Some PDFs contain invisible text layers used for accessibility or search indexing
        /// </param>
        public LlamaParseIgnoreOptions(
            bool? ignoreDiagonalText,
            bool? ignoreTextInImage,
            bool? ignoreHiddenText)
        {
            this.IgnoreDiagonalText = ignoreDiagonalText;
            this.IgnoreTextInImage = ignoreTextInImage;
            this.IgnoreHiddenText = ignoreHiddenText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseIgnoreOptions" /> class.
        /// </summary>
        public LlamaParseIgnoreOptions()
        {
        }
    }
}