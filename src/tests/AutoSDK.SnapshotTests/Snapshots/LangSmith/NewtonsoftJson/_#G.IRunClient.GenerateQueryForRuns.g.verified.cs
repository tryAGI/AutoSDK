//HintName: G.IRunClient.GenerateQueryForRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Generate Query For Runs<br/>
        /// Get runs filter expression query for a given natural language query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResponseBodyForRunsGenerateQuery> GenerateQueryForRunsAsync(
            global::G.RequestBodyForRunsGenerateQuery request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Query For Runs<br/>
        /// Get runs filter expression query for a given natural language query.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResponseBodyForRunsGenerateQuery> GenerateQueryForRunsAsync(
            string query,
            global::System.Collections.Generic.IList<global::G.RunsGenerateQueryFeedbackKeys>? feedbackKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}