//HintName: G.Models.QuestionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuestionRequest
    {
        /// <summary>
        /// The unique identifiers of the Knowledge Graphs to query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> GraphIds { get; set; }

        /// <summary>
        /// Specify whether to include subqueries.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subqueries")]
        public bool? Subqueries { get; set; }

        /// <summary>
        /// The question to answer using the Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// Determines whether the model's output should be streamed. If true, the output is generated and sent incrementally, which can be useful for real-time applications.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Configuration options for Knowledge Graph queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_config")]
        public global::G.GraphQueryConfig? QueryConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionRequest" /> class.
        /// </summary>
        /// <param name="graphIds">
        /// The unique identifiers of the Knowledge Graphs to query.
        /// </param>
        /// <param name="question">
        /// The question to answer using the Knowledge Graph.
        /// </param>
        /// <param name="subqueries">
        /// Specify whether to include subqueries.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Determines whether the model's output should be streamed. If true, the output is generated and sent incrementally, which can be useful for real-time applications.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queryConfig">
        /// Configuration options for Knowledge Graph queries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionRequest(
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            string question,
            bool? subqueries,
            bool? stream,
            global::G.GraphQueryConfig? queryConfig)
        {
            this.GraphIds = graphIds ?? throw new global::System.ArgumentNullException(nameof(graphIds));
            this.Subqueries = subqueries;
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Stream = stream;
            this.QueryConfig = queryConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionRequest" /> class.
        /// </summary>
        public QuestionRequest()
        {
        }
    }
}