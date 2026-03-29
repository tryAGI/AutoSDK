//HintName: G.Models.KnowledgeBaseAddSourcesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseAddSourcesRequest
    {
        /// <summary>
        /// Texts to add to the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_texts")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? KnowledgeBaseTexts { get; set; }

        /// <summary>
        /// Files to add to the knowledge base. Limit to 25 files, where each file is limited to 50MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_files")]
        public global::System.Collections.Generic.IList<byte[]>? KnowledgeBaseFiles { get; set; }

        /// <summary>
        /// URLs to be scraped and added to the knowledge base. Must be valid urls.<br/>
        /// Example: [https://www.example.com, https://www.retellai.com]
        /// </summary>
        /// <example>[https://www.example.com, https://www.retellai.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_urls")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseAddSourcesRequest" /> class.
        /// </summary>
        /// <param name="knowledgeBaseTexts">
        /// Texts to add to the knowledge base.
        /// </param>
        /// <param name="knowledgeBaseFiles">
        /// Files to add to the knowledge base. Limit to 25 files, where each file is limited to 50MB.
        /// </param>
        /// <param name="knowledgeBaseUrls">
        /// URLs to be scraped and added to the knowledge base. Must be valid urls.<br/>
        /// Example: [https://www.example.com, https://www.retellai.com]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseAddSourcesRequest(
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? knowledgeBaseTexts,
            global::System.Collections.Generic.IList<byte[]>? knowledgeBaseFiles,
            global::System.Collections.Generic.IList<string>? knowledgeBaseUrls)
        {
            this.KnowledgeBaseTexts = knowledgeBaseTexts;
            this.KnowledgeBaseFiles = knowledgeBaseFiles;
            this.KnowledgeBaseUrls = knowledgeBaseUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseAddSourcesRequest" /> class.
        /// </summary>
        public KnowledgeBaseAddSourcesRequest()
        {
        }
    }
}