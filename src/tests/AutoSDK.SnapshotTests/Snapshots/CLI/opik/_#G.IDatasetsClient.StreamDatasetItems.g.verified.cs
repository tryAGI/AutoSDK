//HintName: G.IDatasetsClient.StreamDatasetItems.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Stream dataset items<br/>
        /// Stream dataset items
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamDatasetItemsAsync(

            global::G.DatasetItemStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream dataset items<br/>
        /// Stream dataset items
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="steamLimit"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="projectName"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamDatasetItemsAsync(
            string datasetName,
            global::System.Guid? lastRetrievedId = default,
            int? steamLimit = default,
            string? datasetVersion = default,
            string? projectName = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}