//HintName: G.IPiClient.GetCostsOverTime.g.cs
#nullable enable

namespace G
{
    public partial interface IPiClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultCostNumberCreatedAtTruncStringArrayString> GetCostsOverTimeAsync(

            global::G.DataOverTimeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="userFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultCostNumberCreatedAtTruncStringArrayString> GetCostsOverTimeAsync(
            global::G.DataOverTimeRequestTimeFilter timeFilter,
            global::G.RequestClickhouseFilterNode userFilter,
            global::G.TimeIncrement dbIncrement,
            double timeZoneDifference,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}