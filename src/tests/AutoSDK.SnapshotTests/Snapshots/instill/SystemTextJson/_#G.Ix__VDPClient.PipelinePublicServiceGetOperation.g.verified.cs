//HintName: G.Ix__VDPClient.PipelinePublicServiceGetOperation.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Get the details of a long-running operation<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations such as asynchronous pipeline triggers.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOperationResponse> PipelinePublicServiceGetOperationAsync(
            string operationId,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}