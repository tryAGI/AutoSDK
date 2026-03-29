//HintName: G.IStatusClient.GetProviderStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IStatusClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="timeFrame"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultProviderMetricsString> GetProviderStatusAsync(
            string provider,
            global::G.TimeFrame timeFrame,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}