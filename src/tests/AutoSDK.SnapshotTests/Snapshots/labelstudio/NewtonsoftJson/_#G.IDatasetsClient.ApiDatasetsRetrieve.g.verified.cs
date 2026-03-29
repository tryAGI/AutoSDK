//HintName: G.IDatasetsClient.ApiDatasetsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset<br/>
        /// Retrieve a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> ApiDatasetsRetrieveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}