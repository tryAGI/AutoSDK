//HintName: G.IAdminClient.GetActivityMetricsAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetActivityMetrics<br/>
        /// GetActivityMetrics
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetActivityMetricsAsAdminAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}