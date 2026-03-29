//HintName: G.IMlClient.ListModelVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Get model versions<br/>
        /// Get available versions of the model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiMlVersionsRetrieveResponse> ListModelVersionsAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}