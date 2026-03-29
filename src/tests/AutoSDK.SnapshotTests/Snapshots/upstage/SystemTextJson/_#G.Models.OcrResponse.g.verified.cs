//HintName: G.Models.OcrResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrResponse
    {
        /// <summary>
        /// The API name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        public string? Api { get; set; }

        /// <summary>
        /// The model used for OCR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The extracted text from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Page-level OCR results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<global::G.OcrPage>? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.OcrUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResponse" /> class.
        /// </summary>
        /// <param name="api">
        /// The API name.
        /// </param>
        /// <param name="model">
        /// The model used for OCR.
        /// </param>
        /// <param name="text">
        /// The extracted text from the document.
        /// </param>
        /// <param name="pages">
        /// Page-level OCR results.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrResponse(
            string? api,
            string? model,
            string? text,
            global::System.Collections.Generic.IList<global::G.OcrPage>? pages,
            global::G.OcrUsage? usage)
        {
            this.Api = api;
            this.Model = model;
            this.Text = text;
            this.Pages = pages;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResponse" /> class.
        /// </summary>
        public OcrResponse()
        {
        }
    }
}