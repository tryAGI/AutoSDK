//HintName: G.IUsersClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user details<br/>
        ///         Update details for a specific user, such as their name or contact information, in Label Studio.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseUser> UpdateAsync(
            int id,

            global::G.ApiUsersPartialUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user details<br/>
        ///         Update details for a specific user, such as their name or contact information, in Label Studio.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowNewsletters">
        /// Whether the user allows newsletters
        /// </param>
        /// <param name="avatar">
        /// Avatar URL of the user
        /// </param>
        /// <param name="email">
        /// Email of the user
        /// </param>
        /// <param name="firstName">
        /// First name of the user
        /// </param>
        /// <param name="requestId">
        /// User ID
        /// </param>
        /// <param name="initials">
        /// Initials of the user
        /// </param>
        /// <param name="lastName">
        /// Last name of the user
        /// </param>
        /// <param name="phone">
        /// Phone number of the user
        /// </param>
        /// <param name="username">
        /// Username of the user
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseUser> UpdateAsync(
            int id,
            bool? allowNewsletters = default,
            string? avatar = default,
            string? email = default,
            string? firstName = default,
            int? requestId = default,
            string? initials = default,
            string? lastName = default,
            string? phone = default,
            string? username = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}