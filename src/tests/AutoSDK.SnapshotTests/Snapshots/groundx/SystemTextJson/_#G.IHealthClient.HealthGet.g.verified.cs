//HintName: G.IHealthClient.HealthGet.g.cs
#nullable enable

namespace G
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// get<br/>
        /// Look up the current health status of a specific service. Statuses update every 5 minutes.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HealthResponse> HealthGetAsync(
            string service,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}