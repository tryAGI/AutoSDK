//HintName: G.IWellKnownClient.WeaviateWellknownLiveness.g.cs
#nullable enable

namespace G
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// Get application liveness.<br/>
        /// Determines whether the application is alive. Can be used for kubernetes liveness probe
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task WeaviateWellknownLivenessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}