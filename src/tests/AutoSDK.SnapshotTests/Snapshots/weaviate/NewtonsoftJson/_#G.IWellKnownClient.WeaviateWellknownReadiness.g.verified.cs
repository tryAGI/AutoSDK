//HintName: G.IWellKnownClient.WeaviateWellknownReadiness.g.cs
#nullable enable

namespace G
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// Get application readiness.<br/>
        /// Determines whether the application is ready to receive traffic. Can be used for kubernetes readiness probe.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task WeaviateWellknownReadinessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}