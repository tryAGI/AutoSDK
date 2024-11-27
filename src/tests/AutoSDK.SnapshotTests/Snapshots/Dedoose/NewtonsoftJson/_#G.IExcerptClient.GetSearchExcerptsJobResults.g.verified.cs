//HintName: G.IExcerptClient.GetSearchExcerptsJobResults.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// GetSearchExcerptsJobResults<br/>
        /// GetSearchExcerptsJobResults
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> GetSearchExcerptsJobResultsAsync(
            global::G.GetSearchExcerptsJobResultsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSearchExcerptsJobResults<br/>
        /// GetSearchExcerptsJobResults
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Excerpt>> GetSearchExcerptsJobResultsAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}