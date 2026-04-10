//HintName: G.ISessionClient.GetNames.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultSessionNameResultArrayString> GetNamesAsync(

            global::G.SessionNameQueryParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameContains"></param>
        /// <param name="timezoneDifference"></param>
        /// <param name="pSize"></param>
        /// <param name="useInterquartile"></param>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultSessionNameResultArrayString> GetNamesAsync(
            string nameContains,
            double timezoneDifference,
            global::G.SessionNameQueryParamsPSize? pSize = default,
            bool? useInterquartile = default,
            global::G.TimeFilterMs? timeFilter = default,
            global::G.SessionFilterNode? filter = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}