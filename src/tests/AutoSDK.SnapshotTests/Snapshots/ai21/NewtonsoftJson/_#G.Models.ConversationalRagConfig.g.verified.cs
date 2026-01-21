//HintName: G.Models.ConversationalRagConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class ConversationalRagConfig
    {
        /// <summary>
        /// messages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Message> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Default Value: 15
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_segments")]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_strategy")]
        public global::G.ConversationalRagConfigRetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// Default Value: 0.8F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_similarity_threshold")]
        public double? RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_neighbors")]
        public int? MaxNeighbors { get; set; }

        /// <summary>
        /// Default Value: 0.98F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hybrid_search_alpha")]
        public double? HybridSearchAlpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagConfig" /> class.
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="fileIds"></param>
        /// <param name="maxSegments">
        /// Default Value: 15
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold">
        /// Default Value: 0.8F
        /// </param>
        /// <param name="maxNeighbors"></param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 0.98F
        /// </param>
        public ConversationalRagConfig(
            global::System.Collections.Generic.IList<global::G.Message> messages,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            global::System.Collections.Generic.IList<string>? fileIds,
            int? maxSegments,
            global::G.ConversationalRagConfigRetrievalStrategy? retrievalStrategy,
            double? retrievalSimilarityThreshold,
            int? maxNeighbors,
            double? hybridSearchAlpha)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Path = path;
            this.Labels = labels;
            this.FileIds = fileIds;
            this.MaxSegments = maxSegments;
            this.RetrievalStrategy = retrievalStrategy;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.MaxNeighbors = maxNeighbors;
            this.HybridSearchAlpha = hybridSearchAlpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalRagConfig" /> class.
        /// </summary>
        public ConversationalRagConfig()
        {
        }
    }
}