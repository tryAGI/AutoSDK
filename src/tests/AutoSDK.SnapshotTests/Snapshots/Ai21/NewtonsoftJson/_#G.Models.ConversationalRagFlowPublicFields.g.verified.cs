//HintName: G.Models.ConversationalRagFlowPublicFields.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class ConversationalRagFlowPublicFields
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
        public int MaxSegments { get; set; } = 15;

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_strategy")]
        public global::G.ConversationalRagFlowPublicFieldsRetrievalStrategy? RetrievalStrategy { get; set; } = global::G.ConversationalRagFlowPublicFieldsRetrievalStrategy.Default;

        /// <summary>
        /// Default Value: 0.8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_similarity_threshold")]
        public double RetrievalSimilarityThreshold { get; set; } = 0.8;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_neighbors")]
        public int MaxNeighbors { get; set; }

        /// <summary>
        /// Default Value: 0.98
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hybrid_search_alpha")]
        public double HybridSearchAlpha { get; set; } = 0.98;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}