//HintName: G.IUsersClient.GetUserPublicProfile.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get User Public Profile<br/>
        /// Retrieve a user's public profile
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserPublicGet> GetUserPublicProfileAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}