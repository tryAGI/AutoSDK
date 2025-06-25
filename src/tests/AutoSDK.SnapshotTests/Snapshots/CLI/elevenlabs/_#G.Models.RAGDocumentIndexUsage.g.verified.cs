//HintName: G.Models.RAGDocumentIndexUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGDocumentIndexUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexUsage" /> class.
        /// </summary>
        /// <param name="usedBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGDocumentIndexUsage(
            int usedBytes)
        {
            this.UsedBytes = usedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexUsage" /> class.
        /// </summary>
        public RAGDocumentIndexUsage()
        {
        }
    }
}