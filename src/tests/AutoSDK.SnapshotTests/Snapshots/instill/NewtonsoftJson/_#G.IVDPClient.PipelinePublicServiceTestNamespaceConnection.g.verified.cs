//HintName: G.IVDPClient.PipelinePublicServiceTestNamespaceConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Test a connection<br/>
        /// Makes a request to the 3rd party app that the connection is configured to<br/>
        /// communicate with, and checks the result of the call. If the test fails,<br/>
        /// the response status and error message will provide more information about<br/>
        /// the failure.<br/>
        /// Note that this action might affect the quota or billing of the integrated<br/>
        /// account in the 3rd party app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="connectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceTestNamespaceConnectionAsync(
            string namespaceId,
            string connectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}