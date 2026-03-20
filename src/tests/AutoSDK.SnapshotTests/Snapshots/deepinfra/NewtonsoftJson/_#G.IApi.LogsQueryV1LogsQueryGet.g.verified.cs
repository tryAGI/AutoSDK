//HintName: G.IApi.LogsQueryV1LogsQueryGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Logs Query<br/>
        /// Query inference logs.<br/>
        /// * Without timestamps (from/to) returns last `limit` messages (in last month).<br/>
        /// * With `from` only, returns first `limit` messages after `from` (inclusive).<br/>
        /// * With `to` only, returns last `limit` messages before `to` (inclusive).<br/>
        /// * With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.<br/>
        /// * `from` and `to` should be no more than a month apart.
        /// </summary>
        /// <param name="deployId">
        /// the deploy id to get the logs from
        /// </param>
        /// <param name="from">
        /// start of period, in fractional seconds since unix epoch (inclusive)
        /// </param>
        /// <param name="to">
        /// end of period, in fractional seconds since unix epoch (exclusive)
        /// </param>
        /// <param name="limit">
        /// how many items to return at most (default 100, in [1, 1000])<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LogQueryOut> LogsQueryV1LogsQueryGetAsync(
            string deployId,
            string? from = default,
            string? to = default,
            int? limit = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}