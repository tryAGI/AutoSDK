//HintName: G.ICostsClient.CostPurgeCostPurgePost.g.cs
#nullable enable

namespace G
{
    public partial interface ICostsClient
    {
        /// <summary>
        /// Cost Purge
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CostPurgeRes> CostPurgeCostPurgePostAsync(

            global::G.CostPurgeReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cost Purge
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CostPurgeRes> CostPurgeCostPurgePostAsync(
            string projectId,
            global::G.Query query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}