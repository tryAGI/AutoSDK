//HintName: G.IUsersClient.UpdateCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// ✨ Update current user<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update details for the currently authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseUserAPI> UpdateCurrentUserAsync(

            global::G.PatchedLseUserSerializerUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update current user<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update details for the currently authenticated user.
        /// </summary>
        /// <param name="activeOrganization"></param>
        /// <param name="allowNewsletters">
        /// Allow sending newsletters to user
        /// </param>
        /// <param name="customHotkeys">
        /// Custom keyboard shortcuts configuration for the user interface
        /// </param>
        /// <param name="dateJoined"></param>
        /// <param name="emailNotificationSettings">
        /// Included only in requests
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="isEmailVerified">
        /// Included only in requests
        /// </param>
        /// <param name="lastName"></param>
        /// <param name="onboardingState">
        /// Included only in requests
        /// </param>
        /// <param name="password">
        /// Included only in requests
        /// </param>
        /// <param name="phone"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseUserAPI> UpdateCurrentUserAsync(
            object emailNotificationSettings,
            bool? isEmailVerified,
            string? onboardingState,
            string password,
            int? activeOrganization = default,
            bool? allowNewsletters = default,
            object? customHotkeys = default,
            global::System.DateTime? dateJoined = default,
            string? firstName = default,
            string? lastName = default,
            string? phone = default,
            string? username = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}