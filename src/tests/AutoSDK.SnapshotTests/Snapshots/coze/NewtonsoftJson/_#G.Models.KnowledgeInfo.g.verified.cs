//HintName: G.Models.KnowledgeInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeInfo
    {
        /// <summary>
        /// 知识库id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// 知识库id
        /// </param>
        /// <param name="name">
        /// 知识库名称
        /// </param>
        public KnowledgeInfo(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeInfo" /> class.
        /// </summary>
        public KnowledgeInfo()
        {
        }
    }
}