//HintName: G.ISourcesClient.RetrieveSource.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Retrieve Source<br/>
        /// Get all sources
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Source2> RetrieveSourceAsync(
            string sourceId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}