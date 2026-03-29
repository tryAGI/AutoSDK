//HintName: G.IUpsertHistoryClient.GetAllUpsertHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IUpsertHistoryClient
    {
        /// <summary>
        /// Get all upsert history records<br/>
        /// Retrieve all upsert history records with optional filters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order">
        /// Default Value: ASC
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UpsertHistoryResponse>> GetAllUpsertHistoryAsync(
            string id,
            global::G.GetAllUpsertHistoryOrder? order = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}