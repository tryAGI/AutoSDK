//HintName: G.IApi.V1ConversationalRag.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Conversational Rag
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationalRagResult> V1ConversationalRagAsync(
            global::G.ConversationalRagFlowPublicFields request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Conversational Rag
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
        /// Default Value: 0.8
        /// </param>
        /// <param name="maxNeighbors"></param>
        /// <param name="hybridSearchAlpha">
        /// Default Value: 0.98
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationalRagResult> V1ConversationalRagAsync(
            global::System.Collections.Generic.IList<global::G.Message> messages,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            int maxSegments = 15,
            global::G.ConversationalRagFlowPublicFieldsRetrievalStrategy? retrievalStrategy = global::G.ConversationalRagFlowPublicFieldsRetrievalStrategy.Default,
            double retrievalSimilarityThreshold = 0.8,
            int maxNeighbors = default,
            double hybridSearchAlpha = 0.98,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}