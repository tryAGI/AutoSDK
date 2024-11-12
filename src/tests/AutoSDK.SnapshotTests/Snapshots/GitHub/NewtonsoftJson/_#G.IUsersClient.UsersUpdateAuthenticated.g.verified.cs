//HintName: G.IUsersClient.UsersUpdateAuthenticated.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update the authenticated user<br/>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PrivateUser> UsersUpdateAuthenticatedAsync(
            global::G.UsersUpdateAuthenticatedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the authenticated user<br/>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="name">
        /// The new name of the user.<br/>
        /// Example: Omar Jahandar
        /// </param>
        /// <param name="email">
        /// The publicly visible email address of the user.<br/>
        /// Example: omar@example.com
        /// </param>
        /// <param name="blog">
        /// The new blog URL of the user.<br/>
        /// Example: blog.example.com
        /// </param>
        /// <param name="twitterUsername">
        /// The new Twitter username of the user.<br/>
        /// Example: therealomarj
        /// </param>
        /// <param name="company">
        /// The new company of the user.<br/>
        /// Example: Acme corporation
        /// </param>
        /// <param name="location">
        /// The new location of the user.<br/>
        /// Example: Berlin, Germany
        /// </param>
        /// <param name="hireable">
        /// The new hiring availability of the user.
        /// </param>
        /// <param name="bio">
        /// The new short biography of the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PrivateUser> UsersUpdateAuthenticatedAsync(
            string? name = default,
            string? email = default,
            string? blog = default,
            string? twitterUsername = default,
            string? company = default,
            string? location = default,
            bool? hireable = default,
            string? bio = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}