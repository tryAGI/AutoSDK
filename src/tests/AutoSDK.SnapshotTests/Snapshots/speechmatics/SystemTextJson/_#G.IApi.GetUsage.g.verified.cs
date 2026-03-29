//HintName: G.IApi.GetUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get usage statistics
        /// </summary>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageResponse> GetUsageAsync(
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}