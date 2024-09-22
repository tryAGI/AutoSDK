//HintName: G.IUserClient.PatchAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Update the authenticated user<br/>
        /// Updates the information of the authenticated user.<br/>
        /// In REST requests, only the supplied user fields will be taken into account<br/>
        /// when updating the resource.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchAuthenticatedUserResponse> PatchAuthenticatedUserAsync(
            global::G.AuthenticatedUser request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the authenticated user<br/>
        /// Updates the information of the authenticated user.<br/>
        /// In REST requests, only the supplied user fields will be taken into account<br/>
        /// when updating the resource.
        /// </summary>
        /// <param name="uid">
        /// User UUID. This field is optionally set by users on creation (it will be<br/>
        /// server-generated if unspecified).
        /// </param>
        /// <param name="id">
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </param>
        /// <param name="email">
        /// Email.
        /// </param>
        /// <param name="role">
        /// Role.<br/>
        /// It must be one of the following allowed roles:<br/>
        /// - `manager`<br/>
        /// - `ai-researcher`<br/>
        /// - `ai-engineer`<br/>
        /// - `data-engineer`<br/>
        /// - `data-scientist`<br/>
        /// - `analytics-engineer`<br/>
        /// - `hobbyist`
        /// </param>
        /// <param name="newsletterSubscription">
        /// This defines whether the user is subscribed to Instill AI's newsletter.
        /// </param>
        /// <param name="cookieToken">
        /// Console cookie token.
        /// </param>
        /// <param name="onboardingStatus">
        /// Onboarding Status.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchAuthenticatedUserResponse> PatchAuthenticatedUserAsync(
            string id,
            string email,
            bool newsletterSubscription,
            string? uid = default,
            string? role = default,
            string? cookieToken = default,
            global::G.OnboardingStatus? onboardingStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}