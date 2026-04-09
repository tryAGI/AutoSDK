//HintName: G.IConnectorsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// List Connectors<br/>
        /// Returns a list of connectors ordered by descending creation date (newer first). See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 30
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListConnectorsResponse> ListAsync(
            double? limit = default,
            double? offset = default,
            string? xClientName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}