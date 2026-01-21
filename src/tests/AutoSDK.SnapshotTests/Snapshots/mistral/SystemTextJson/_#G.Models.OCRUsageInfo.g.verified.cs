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
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PagesProcessed { get; set; }

        /// <summary>
        /// Document size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_size_bytes")]
        public int? DocSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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