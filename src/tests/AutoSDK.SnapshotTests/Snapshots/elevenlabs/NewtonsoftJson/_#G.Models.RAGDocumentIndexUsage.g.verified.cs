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
        [global::Newtonsoft.Json.JsonProperty("used_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsedBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexUsage" /> class.
        /// </summary>
        /// <param name="usedBytes"></param>
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