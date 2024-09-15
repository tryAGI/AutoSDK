//HintName: G.IModerationClient.GetUnbanRequests.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// NEW Gets a list of unban requests for a broadcaster’s channel.<br/>
        /// NEW Gets a list of unban requests for a broadcaster’s channel.<br/>
        /// __Authorization:__<br/>
        /// * Requires a user access token that includes the **moderator:read:unban\_requests** or **moderator:manage:unban\_requests** scope.<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="status"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUnbanRequestsResponse> GetUnbanRequestsAsync(
            string broadcasterId,
            string moderatorId,
            string status,
            string? userId = default,
            string? after = default,
            int first = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}