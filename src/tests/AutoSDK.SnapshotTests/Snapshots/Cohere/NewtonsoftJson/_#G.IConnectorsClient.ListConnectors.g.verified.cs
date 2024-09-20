//HintName: G.IConnectorsClient.ListConnectors.g.cs
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListConnectorsResponse> ListConnectorsAsync(
            double? limit = 30,
            double? offset = 0,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}