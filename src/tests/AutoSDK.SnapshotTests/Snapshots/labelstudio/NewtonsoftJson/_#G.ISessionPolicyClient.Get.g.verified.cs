//HintName: G.ISessionPolicyClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionPolicyClient
    {
        /// <summary>
        /// Retrieve Session Policy<br/>
        /// Retrieve session timeout policy for the currently active organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionTimeoutPolicy> GetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}