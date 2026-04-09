//HintName: G.IDashboardClient.GetScoresOverTime.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString> GetScoresOverTimeAsync(

            global::G.DataOverTimeRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="userFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString> GetScoresOverTimeAsync(
            global::G.DataOverTimeRequestTimeFilter timeFilter,
            global::G.RequestClickhouseFilterNode userFilter,
            global::G.TimeIncrement dbIncrement,
            double timeZoneDifference,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}