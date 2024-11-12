//HintName: G.IUsageLimitsClient.ListOrgUsageLimits.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// List Org Usage Limits<br/>
        /// List out the configured usage limits for a given organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UsageLimit>> ListOrgUsageLimitsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}