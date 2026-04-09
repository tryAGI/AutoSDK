//HintName: G.IDatasetStorageGcsClient.ApiDatasetStoragesGcsColumnsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageGcsClient
    {
        /// <summary>
        /// Get data column names from storage<br/>
        /// Retrieves column names from users JSON/blob data in bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesGcsColumnsRetrieveAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}