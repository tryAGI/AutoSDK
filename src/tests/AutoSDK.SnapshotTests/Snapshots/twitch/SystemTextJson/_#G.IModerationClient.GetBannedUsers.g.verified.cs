//HintName: G.IModerationClient.GetBannedUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Gets all users that the broadcaster banned or put in a timeout.<br/>
        /// Gets all users that the broadcaster banned or put in a timeout.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** or **moderator:manage:banned\_users** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetBannedUsersResponse> GetBannedUsersAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId = default,
            int? first = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}