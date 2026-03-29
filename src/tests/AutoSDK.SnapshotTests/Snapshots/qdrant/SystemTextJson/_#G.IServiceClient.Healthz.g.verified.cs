//HintName: G.IServiceClient.Healthz.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Kubernetes healthz endpoint<br/>
        /// An endpoint for health checking used in Kubernetes.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}