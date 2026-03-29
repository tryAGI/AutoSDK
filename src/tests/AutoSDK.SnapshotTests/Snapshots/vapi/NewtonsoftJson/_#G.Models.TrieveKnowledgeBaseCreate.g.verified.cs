//HintName: G.Models.TrieveKnowledgeBaseCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrieveKnowledgeBaseCreate
    {
        /// <summary>
        /// This is to create a new dataset on Trieve.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TrieveKnowledgeBaseCreateType Type { get; set; }

        /// <summary>
        /// These are the chunk plans used to create the dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkPlans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TrieveKnowledgeBaseChunkPlan> ChunkPlans { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseCreate" /> class.
        /// </summary>
        /// <param name="chunkPlans">
        /// These are the chunk plans used to create the dataset.
        /// </param>
        /// <param name="type">
        /// This is to create a new dataset on Trieve.
        /// </param>
        public TrieveKnowledgeBaseCreate(
            global::System.Collections.Generic.IList<global::G.TrieveKnowledgeBaseChunkPlan> chunkPlans,
            global::G.TrieveKnowledgeBaseCreateType type)
        {
            this.Type = type;
            this.ChunkPlans = chunkPlans ?? throw new global::System.ArgumentNullException(nameof(chunkPlans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseCreate" /> class.
        /// </summary>
        public TrieveKnowledgeBaseCreate()
        {
        }
    }
}