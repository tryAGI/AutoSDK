//HintName: G.IAdminClient.AdminGetActivityMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetActivityMetrics.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminGetActivityMetricsAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}