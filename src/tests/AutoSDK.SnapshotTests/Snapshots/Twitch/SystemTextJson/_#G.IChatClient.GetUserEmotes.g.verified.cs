//HintName: G.IChatClient.GetUserEmotes.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// NEW Retrieves emotes available to the user across all channels.<br/>
        /// NEW Retrieves emotes available to the user across all channels.<br/>
        /// __Authorization:__<br/>
        /// * Requires a user access token that includes the **user:read:emotes** scope.<br/>
        /// * Query parameter `user_id` must match the `user_id` in the user access token.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserEmotesResponse> GetUserEmotesAsync(
            string userId,
            string? broadcasterId = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}