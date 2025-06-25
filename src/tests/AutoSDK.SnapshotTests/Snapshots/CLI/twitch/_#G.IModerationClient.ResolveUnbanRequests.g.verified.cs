//HintName: G.IModerationClient.ResolveUnbanRequests.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// NEW Resolves an unban request by approving or denying it.<br/>
        /// NEW Resolves an unban request by approving or denying it.<br/>
        /// __Authorization:__<br/>
        /// * Requires a user access token that includes the **moderator:manage:unban\\\_requests** scope.<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the[user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="unbanRequestId"></param>
        /// <param name="status"></param>
        /// <param name="resolutionText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResolveUnbanRequestsResponse> ResolveUnbanRequestsAsync(
            string broadcasterId,
            string moderatorId,
            string unbanRequestId,
            string status,
            string? resolutionText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}