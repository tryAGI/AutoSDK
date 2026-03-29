//HintName: G.IDatasetsClient.ApiDatasetsDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete dataset<br/>
        /// Delete a dataset by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsDestroyAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}