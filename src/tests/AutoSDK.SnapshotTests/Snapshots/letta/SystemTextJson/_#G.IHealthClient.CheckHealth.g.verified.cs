//HintName: G.IHealthClient.CheckHealth.g.cs
#nullable enable

namespace G
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Check Health<br/>
        /// Async health check endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Health> CheckHealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}