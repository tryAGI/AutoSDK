//HintName: G.Models.LayoutAnalysisRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutAnalysisRequest
    {
        /// <summary>
        /// The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Document { get; set; } = default!;

        /// <summary>
        /// The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Documentname { get; set; } = default!;

        /// <summary>
        /// The model to use for layout analysis.<br/>
        /// Default: layout-analysis<br/>
        /// Default Value: layout-analysis
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutAnalysisRequest" /> class.
        /// </summary>
        /// <param name="document">
        /// The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="documentname">
        /// The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="model">
        /// The model to use for layout analysis.<br/>
        /// Default: layout-analysis<br/>
        /// Default Value: layout-analysis
        /// </param>
        public LayoutAnalysisRequest(
            byte[] document,
            string documentname,
            string? model)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Documentname = documentname ?? throw new global::System.ArgumentNullException(nameof(documentname));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutAnalysisRequest" /> class.
        /// </summary>
        public LayoutAnalysisRequest()
        {
        }
    }
}