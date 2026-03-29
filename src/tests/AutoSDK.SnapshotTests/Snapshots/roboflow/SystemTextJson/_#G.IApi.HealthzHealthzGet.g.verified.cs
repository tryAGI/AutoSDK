//HintName: G.IApi.HealthzHealthzGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Healthz<br/>
        /// Health endpoint for Kubernetes liveness probe.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzHealthzGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}