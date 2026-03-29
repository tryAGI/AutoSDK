//HintName: G.IMetricsClient.GetTokensOverTime.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultTokensOverTimeArrayString> GetTokensOverTimeAsync(

            global::G.MetricsOverTimeBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultTokensOverTimeArrayString> GetTokensOverTimeAsync(
            global::G.MetricsOverTimeBodyTimeFilter timeFilter,
            global::G.FilterNode filter,
            double timeZoneDifference,
            global::G.TimeIncrement? dbIncrement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}