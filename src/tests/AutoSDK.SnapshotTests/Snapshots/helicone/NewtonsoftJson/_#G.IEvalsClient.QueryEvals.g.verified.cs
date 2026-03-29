//HintName: G.IEvalsClient.QueryEvals.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvalArrayString> QueryEvalsAsync(

            global::G.EvalQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvalArrayString> QueryEvalsAsync(
            global::G.EvalFilterNode filter,
            global::G.EvalQueryParamsTimeFilter timeFilter,
            double? offset = default,
            double? limit = default,
            double? timeZoneDifference = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}