//HintName: G.IConnectorsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// Delete a Connector<br/>
        /// Delete a connector by ID. See ['Connectors'](https://docs.cohere.com/docs/connectors) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteConnectorResponse> DeleteAsync(
            string id,
            string? xClientName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}