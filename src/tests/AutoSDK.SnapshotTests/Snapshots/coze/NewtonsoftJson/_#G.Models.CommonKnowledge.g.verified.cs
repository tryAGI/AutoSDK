//HintName: G.Models.CommonKnowledge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommonKnowledge
    {
        /// <summary>
        /// 知识库信息
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_infos")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeInfo>? KnowledgeInfos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonKnowledge" /> class.
        /// </summary>
        /// <param name="knowledgeInfos">
        /// 知识库信息
        /// </param>
        public CommonKnowledge(
            global::System.Collections.Generic.IList<global::G.KnowledgeInfo>? knowledgeInfos)
        {
            this.KnowledgeInfos = knowledgeInfos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonKnowledge" /> class.
        /// </summary>
        public CommonKnowledge()
        {
        }
    }
}