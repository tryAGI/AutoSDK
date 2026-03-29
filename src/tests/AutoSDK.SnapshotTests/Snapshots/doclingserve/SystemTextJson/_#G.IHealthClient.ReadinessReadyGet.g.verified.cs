//HintName: G.IHealthClient.ReadinessReadyGet.g.cs
#nullable enable

namespace G
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Readiness
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReadinessResponse> ReadinessReadyGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}