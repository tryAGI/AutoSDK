//HintName: G.ISessionPolicyClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionPolicyClient
    {
        /// <summary>
        /// Update Session Policy<br/>
        /// Update session timeout policy for the currently active organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionTimeoutPolicy> UpdateAsync(

            global::G.PatchedSessionTimeoutPolicyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Session Policy<br/>
        /// Update session timeout policy for the currently active organization.
        /// </summary>
        /// <param name="maxSessionAge">
        /// Number of minutes that a session can be active before needing to re-login
        /// </param>
        /// <param name="maxTimeBetweenActivity">
        /// Number of minutes that a session stays active without any activity
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionTimeoutPolicy> UpdateAsync(
            int? maxSessionAge = default,
            int? maxTimeBetweenActivity = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}