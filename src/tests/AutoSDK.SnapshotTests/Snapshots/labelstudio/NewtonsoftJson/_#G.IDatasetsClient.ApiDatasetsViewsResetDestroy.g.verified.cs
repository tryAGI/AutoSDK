//HintName: G.IDatasetsClient.ApiDatasetsViewsResetDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Reset dataset views<br/>
        /// Reset all views for a specific dataset.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsViewsResetDestroyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}