//HintName: G.IAdminClient.ReingestAllStores.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Reingest all stores<br/>
        /// Reingest all stores across all organizations (admin only).<br/>
        /// This endpoint creates StoreFileReingestionJob for each store.<br/>
        /// Returns:<br/>
        ///     dict: Confirmation message with count of jobs created.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="storeIdentifier"></param>
        /// <param name="statuses">
        /// Statuses of files to reingest
        /// </param>
        /// <param name="billable">
        /// Whether the reingestion is billable to the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReingestAllStoresAsync(
            global::System.Guid organizationId,
            string storeIdentifier,
            global::System.Collections.Generic.IList<global::G.VectorStoreFileStatus>? statuses = default,
            bool? billable = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}