//HintName: G.Models.StartConvertPDF2SwfRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartConvertPDF2SwfRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdfURI")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PdfURI { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConvertPDF2SwfRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="pdfURI"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartConvertPDF2SwfRequest(
            global::System.Guid projectId,
            string pdfURI)
        {
            this.ProjectId = projectId;
            this.PdfURI = pdfURI ?? throw new global::System.ArgumentNullException(nameof(pdfURI));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConvertPDF2SwfRequest" /> class.
        /// </summary>
        public StartConvertPDF2SwfRequest()
        {
        }
    }
}