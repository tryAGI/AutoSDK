//HintName: G.ICreditsClient.GetSpendBreakdown.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeRange"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultSpendBreakdownResponseString> GetSpendBreakdownAsync(
            global::G.GetSpendBreakdownTimeRange? timeRange = default,
            string? startDate = default,
            string? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}