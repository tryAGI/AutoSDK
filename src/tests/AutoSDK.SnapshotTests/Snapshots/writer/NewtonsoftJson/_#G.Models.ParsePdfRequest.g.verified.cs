//HintName: G.Models.ParsePdfRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParsePdfRequest
    {
        /// <summary>
        /// The format into which the PDF content should be converted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PdfConversionFormat Format { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePdfRequest" /> class.
        /// </summary>
        /// <param name="format">
        /// The format into which the PDF content should be converted.
        /// </param>
        public ParsePdfRequest(
            global::G.PdfConversionFormat format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePdfRequest" /> class.
        /// </summary>
        public ParsePdfRequest()
        {
        }
    }
}