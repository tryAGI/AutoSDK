//HintName: G.IUsageLimitsClient.ListUsageLimits.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// List Usage Limits<br/>
        /// List out the configured usage limits for a given tenant.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UsageLimit>> ListUsageLimitsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}