//HintName: G.Models.OCRResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRResponse
    {
        /// <summary>
        /// List of OCR info for pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OCRPageObject> Pages { get; set; }

        /// <summary>
        /// The model used to generate the OCR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Usage info for the OCR request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OCRUsageInfo UsageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRResponse" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of OCR info for pages.
        /// </param>
        /// <param name="model">
        /// The model used to generate the OCR.
        /// </param>
        /// <param name="usageInfo">
        /// Usage info for the OCR request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRResponse(
            global::System.Collections.Generic.IList<global::G.OCRPageObject> pages,
            string model,
            global::G.OCRUsageInfo usageInfo)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.UsageInfo = usageInfo ?? throw new global::System.ArgumentNullException(nameof(usageInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRResponse" /> class.
        /// </summary>
        public OCRResponse()
        {
        }
    }
}