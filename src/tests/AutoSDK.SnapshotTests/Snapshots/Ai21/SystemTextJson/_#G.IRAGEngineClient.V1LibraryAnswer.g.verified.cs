//HintName: G.IRAGEngineClient.V1LibraryAnswer.g.cs
#nullable enable

namespace G
{
    public partial interface IRAGEngineClient
    {
        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LibraryAnswerResponse> V1LibraryAnswerAsync(
            global::G.LibraryAnswerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="question"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="fileIds"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalStrategy">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LibraryAnswerResponse> V1LibraryAnswerAsync(
            string question,
            int? maxSegments = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::G.AnswerLength? answerLength = default,
            global::G.Mode? mode = default,
            global::G.RetrievalStrategy? retrievalStrategy = default,
            double? retrievalSimilarityThreshold = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}