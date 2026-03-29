//HintName: G.IApi.ReadinessReadinessGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Readiness<br/>
        /// Readiness endpoint for Kubernetes readiness probe.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadinessReadinessGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}