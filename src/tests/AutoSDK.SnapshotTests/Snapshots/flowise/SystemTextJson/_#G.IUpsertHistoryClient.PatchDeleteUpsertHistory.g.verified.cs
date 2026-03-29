//HintName: G.IUpsertHistoryClient.PatchDeleteUpsertHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IUpsertHistoryClient
    {
        /// <summary>
        /// Delete upsert history records<br/>
        /// Soft delete upsert history records by IDs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PatchDeleteUpsertHistoryAsync(
            string id,

            global::G.PatchDeleteUpsertHistoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete upsert history records<br/>
        /// Soft delete upsert history records by IDs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids">
        /// List of upsert history record IDs to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PatchDeleteUpsertHistoryAsync(
            string id,
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}