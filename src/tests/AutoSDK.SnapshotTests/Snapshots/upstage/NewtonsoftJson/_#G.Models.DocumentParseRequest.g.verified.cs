//HintName: G.Models.DocumentParseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentParseRequest
    {
        /// <summary>
        /// The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Document { get; set; } = default!;

        /// <summary>
        /// The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Documentname { get; set; } = default!;

        /// <summary>
        /// The model to use for document parsing.<br/>
        /// Default: document-parse<br/>
        /// Default Value: document-parse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// OCR mode. Set to auto to enable OCR for scanned documents,<br/>
        /// or force to always apply OCR.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ocr")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DocumentParseRequestOcrJsonConverter))]
        public global::G.DocumentParseRequestOcr? Ocr { get; set; }

        /// <summary>
        /// Whether to return bounding box coordinates for elements.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coordinates")]
        public bool? Coordinates { get; set; }

        /// <summary>
        /// Comma-separated list of output formats to include.<br/>
        /// Options: html, markdown, text<br/>
        /// Default Value: html,text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_formats")]
        public string? OutputFormats { get; set; }

        /// <summary>
        /// Start page number (1-indexed). Use to process a page range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_start")]
        public int? PageStart { get; set; }

        /// <summary>
        /// End page number (1-indexed, inclusive). Use to process a page range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_end")]
        public int? PageEnd { get; set; }

        /// <summary>
        /// JSON string of additional model parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_params")]
        public string? ModelParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseRequest" /> class.
        /// </summary>
        /// <param name="document">
        /// The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="documentname">
        /// The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="model">
        /// The model to use for document parsing.<br/>
        /// Default: document-parse<br/>
        /// Default Value: document-parse
        /// </param>
        /// <param name="ocr">
        /// OCR mode. Set to auto to enable OCR for scanned documents,<br/>
        /// or force to always apply OCR.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="coordinates">
        /// Whether to return bounding box coordinates for elements.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormats">
        /// Comma-separated list of output formats to include.<br/>
        /// Options: html, markdown, text<br/>
        /// Default Value: html,text
        /// </param>
        /// <param name="pageStart">
        /// Start page number (1-indexed). Use to process a page range.
        /// </param>
        /// <param name="pageEnd">
        /// End page number (1-indexed, inclusive). Use to process a page range.
        /// </param>
        /// <param name="modelParams">
        /// JSON string of additional model parameters.
        /// </param>
        public DocumentParseRequest(
            byte[] document,
            string documentname,
            string? model,
            global::G.DocumentParseRequestOcr? ocr,
            bool? coordinates,
            string? outputFormats,
            int? pageStart,
            int? pageEnd,
            string? modelParams)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Documentname = documentname ?? throw new global::System.ArgumentNullException(nameof(documentname));
            this.Model = model;
            this.Ocr = ocr;
            this.Coordinates = coordinates;
            this.OutputFormats = outputFormats;
            this.PageStart = pageStart;
            this.PageEnd = pageEnd;
            this.ModelParams = modelParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseRequest" /> class.
        /// </summary>
        public DocumentParseRequest()
        {
        }
    }
}