//HintName: G.IStorageClient.ApiDatasetStoragesList.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all dataset storages from the project<br/>
        /// Retrieve a list of the dataset storages of all types with their IDs.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesListAsync(
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}