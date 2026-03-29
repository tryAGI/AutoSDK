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
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PdfConversionFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PdfConversionFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePdfRequest" /> class.
        /// </summary>
        /// <param name="format">
        /// The format into which the PDF content should be converted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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