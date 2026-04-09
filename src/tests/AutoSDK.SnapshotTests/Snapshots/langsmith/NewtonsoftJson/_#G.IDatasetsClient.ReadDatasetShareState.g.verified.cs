//HintName: G.IDatasetsClient.ReadDatasetShareState.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Dataset Share State<br/>
        /// Get the state of sharing a dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetShareSchema> ReadDatasetShareStateAsync(
            global::System.Guid datasetId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}