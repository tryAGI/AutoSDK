//HintName: G.ITasksClient.ApiTasksAgreementRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get task label distribution<br/>
        /// Get aggregated label distribution across all annotations for a task. Returns counts of each label value grouped by control tag. This is an efficient endpoint that avoids N+1 queries.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiTasksAgreementRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}