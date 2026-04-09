//HintName: G.IDataExplorerClient.ApiDatasetsColumnsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDataExplorerClient
    {
        /// <summary>
        /// Get data explorer columns<br/>
        /// Retrieve the data explorer columns available for a specific Dataset.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsColumnsRetrieveAsync(
            int? dataset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}