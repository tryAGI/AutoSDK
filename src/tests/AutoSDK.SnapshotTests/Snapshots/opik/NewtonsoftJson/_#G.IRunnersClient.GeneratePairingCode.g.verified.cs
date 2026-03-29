//HintName: G.IRunnersClient.GeneratePairingCode.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Generate a pairing code<br/>
        /// Generate a pairing code for a local runner in the current workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerPairResponse> GeneratePairingCodeAsync(

            global::G.LocalRunnerPairRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a pairing code<br/>
        /// Generate a pairing code for a local runner in the current workspace
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerPairResponse> GeneratePairingCodeAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}