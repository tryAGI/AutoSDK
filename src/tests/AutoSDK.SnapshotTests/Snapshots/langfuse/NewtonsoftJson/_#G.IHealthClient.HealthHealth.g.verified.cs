//HintName: G.IHealthClient.HealthHealth.g.cs
#nullable enable

namespace G
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Check health of API and database
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HealthResponse> HealthHealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}