//HintName: G.IProvidersClient.GetProviders.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultProviderMetricArrayString> GetProvidersAsync(

            global::G.ProviderQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultProviderMetricArrayString> GetProvidersAsync(
            global::G.FilterNode filter,
            double offset,
            double limit,
            global::G.ProviderQueryParamsTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}