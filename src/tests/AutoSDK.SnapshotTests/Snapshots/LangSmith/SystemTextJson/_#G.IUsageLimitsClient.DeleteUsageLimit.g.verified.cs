//HintName: G.IUsageLimitsClient.DeleteUsageLimit.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// Delete Usage Limit<br/>
        /// Delete a specific usage limit.
        /// </summary>
        /// <param name="usageLimitId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUsageLimitAsync(
            global::System.Guid usageLimitId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}