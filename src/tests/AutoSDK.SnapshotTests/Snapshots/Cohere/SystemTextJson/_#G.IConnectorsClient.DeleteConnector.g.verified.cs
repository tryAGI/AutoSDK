//HintName: G.IConnectorsClient.DeleteConnector.g.cs
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConnectorAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}