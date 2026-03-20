//HintName: G.IUsersClient.GetUserBlockList.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the list of users that the broadcaster has blocked.<br/>
        /// Gets the list of users that the broadcaster has blocked. [Read More](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat?language=en%5FUS#BlockWhispersandMessagesfromStrangers)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:blocked\_users** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserBlockListResponse> GetUserBlockListAsync(
            string broadcasterId,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}