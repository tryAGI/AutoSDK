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
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OCRPageObject> Pages { get; set; } = default!;

        /// <summary>
        /// The model used to generate the OCR.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Usage info for the OCR request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OCRUsageInfo UsageInfo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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