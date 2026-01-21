//HintName: G.Models.OCRUsageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRUsageInfo
    {
        /// <summary>
        /// Number of pages processed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages_processed", Required = global::Newtonsoft.Json.Required.Always)]
        public int PagesProcessed { get; set; } = default!;

        /// <summary>
        /// Document size in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("doc_size_bytes")]
        public int? DocSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRUsageInfo" /> class.
        /// </summary>
        /// <param name="pagesProcessed">
        /// Number of pages processed
        /// </param>
        /// <param name="docSizeBytes">
        /// Document size in bytes
        /// </param>
        public OCRUsageInfo(
            int pagesProcessed,
            int? docSizeBytes)
        {
            this.PagesProcessed = pagesProcessed;
            this.DocSizeBytes = docSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRUsageInfo" /> class.
        /// </summary>
        public OCRUsageInfo()
        {
        }
    }
}