//HintName: G.IUsersClient.PostAdminUsersCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Invite a User<br/>
        /// This endpoint allows the client to trigger an invitation to the provided email address.<br/>
        ///         It requires a token from a user with `super_admin` privileges.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PostAdminUsersCreateAsync(

            global::G.UserInviteParam request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite a User<br/>
        /// This endpoint allows the client to trigger an invitation to the provided email address.<br/>
        ///         It requires a token from a user with `super_admin` privileges.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PostAdminUsersCreateAsync(
            string? email = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}