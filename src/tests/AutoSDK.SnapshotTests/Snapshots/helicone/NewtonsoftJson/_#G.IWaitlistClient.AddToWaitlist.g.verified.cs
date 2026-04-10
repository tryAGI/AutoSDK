//HintName: G.IWaitlistClient.AddToWaitlist.g.cs
#nullable enable

namespace G
{
    public partial interface IWaitlistClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString> AddToWaitlistAsync(

            global::G.AddToWaitlistRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString> AddToWaitlistAsync(
            string feature,
            string email,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}