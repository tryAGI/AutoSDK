//HintName: G.Models.LlamaParseMarkdownOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Markdown output formatting options.
    /// </summary>
    public sealed partial class LlamaParseMarkdownOptions
    {
        /// <summary>
        /// Add link annotations to markdown output in the format [text](url). When false, only the link text is included
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotate_links")]
        public bool? AnnotateLinks { get; set; }

        /// <summary>
        /// Table formatting options including markdown vs HTML format and merging behavior
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tables")]
        public global::G.LlamaParseTables? Tables { get; set; }

        /// <summary>
        /// Embed images directly in markdown as base64 data URIs instead of extracting them as separate files. Useful for self-contained markdown output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_images")]
        public bool? InlineImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseMarkdownOptions" /> class.
        /// </summary>
        /// <param name="annotateLinks">
        /// Add link annotations to markdown output in the format [text](url). When false, only the link text is included
        /// </param>
        /// <param name="tables">
        /// Table formatting options including markdown vs HTML format and merging behavior
        /// </param>
        /// <param name="inlineImages">
        /// Embed images directly in markdown as base64 data URIs instead of extracting them as separate files. Useful for self-contained markdown output
        /// </param>
        public LlamaParseMarkdownOptions(
            bool? annotateLinks,
            global::G.LlamaParseTables? tables,
            bool? inlineImages)
        {
            this.AnnotateLinks = annotateLinks;
            this.Tables = tables;
            this.InlineImages = inlineImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseMarkdownOptions" /> class.
        /// </summary>
        public LlamaParseMarkdownOptions()
        {
        }
    }
}