//HintName: G.Models.PDFParserOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for PDF parsing.
    /// </summary>
    public sealed partial class PDFParserOptions
    {
        /// <summary>
        /// The engine to use for parsing PDF files. "pdf-text" is deprecated and automatically redirected to "cloudflare-ai".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        public global::G.PDFParserEngine? Engine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFParserOptions" /> class.
        /// </summary>
        /// <param name="engine">
        /// The engine to use for parsing PDF files. "pdf-text" is deprecated and automatically redirected to "cloudflare-ai".
        /// </param>
        public PDFParserOptions(
            global::G.PDFParserEngine? engine)
        {
            this.Engine = engine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFParserOptions" /> class.
        /// </summary>
        public PDFParserOptions()
        {
        }
    }
}