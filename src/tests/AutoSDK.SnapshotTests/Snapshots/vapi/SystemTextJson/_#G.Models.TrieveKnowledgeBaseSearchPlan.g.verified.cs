//HintName: G.Models.TrieveKnowledgeBaseSearchPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrieveKnowledgeBaseSearchPlan
    {
        /// <summary>
        /// Specifies the number of top chunks to return. This corresponds to the `page_size` parameter in Trieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// If true, stop words (specified in server/src/stop-words.txt in the git repo) will be removed. This will preserve queries that are entirely stop words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeStopWords")]
        public bool? RemoveStopWords { get; set; }

        /// <summary>
        /// This is the score threshold to filter out chunks with a score below the threshold for cosine distance metric. For Manhattan Distance, Euclidean Distance, and Dot Product, it will filter out scores above the threshold distance. This threshold applies before weight and bias modifications. If not specified, this defaults to no threshold. A threshold of 0 will default to no threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreThreshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// This is the search method used when searching for relevant chunks from the vector store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrieveKnowledgeBaseSearchPlanSearchTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TrieveKnowledgeBaseSearchPlanSearchType SearchType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseSearchPlan" /> class.
        /// </summary>
        /// <param name="searchType">
        /// This is the search method used when searching for relevant chunks from the vector store.
        /// </param>
        /// <param name="topK">
        /// Specifies the number of top chunks to return. This corresponds to the `page_size` parameter in Trieve.
        /// </param>
        /// <param name="removeStopWords">
        /// If true, stop words (specified in server/src/stop-words.txt in the git repo) will be removed. This will preserve queries that are entirely stop words.
        /// </param>
        /// <param name="scoreThreshold">
        /// This is the score threshold to filter out chunks with a score below the threshold for cosine distance metric. For Manhattan Distance, Euclidean Distance, and Dot Product, it will filter out scores above the threshold distance. This threshold applies before weight and bias modifications. If not specified, this defaults to no threshold. A threshold of 0 will default to no threshold.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrieveKnowledgeBaseSearchPlan(
            global::G.TrieveKnowledgeBaseSearchPlanSearchType searchType,
            double? topK,
            bool? removeStopWords,
            double? scoreThreshold)
        {
            this.TopK = topK;
            this.RemoveStopWords = removeStopWords;
            this.ScoreThreshold = scoreThreshold;
            this.SearchType = searchType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseSearchPlan" /> class.
        /// </summary>
        public TrieveKnowledgeBaseSearchPlan()
        {
        }
    }
}