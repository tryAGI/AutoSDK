//HintName: G.IApi.UsagePaymentUsageGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Usage
        /// </summary>
        /// <param name="from">
        /// start of period, YYYY.MM or current(-N) format
        /// </param>
        /// <param name="to">
        /// end of period (if missing a single month marked by from is return), same format as from
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageOut> UsagePaymentUsageGetAsync(
            string from,
            string? to = default,
            object? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}