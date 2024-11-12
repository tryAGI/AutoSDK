//HintName: G.IChannelPointsClient.DeleteCustomReward.g.cs
#nullable enable

namespace G
{
    public partial interface IChannelPointsClient
    {
        /// <summary>
        /// Deletes a custom reward that the broadcaster created.<br/>
        /// Deletes a custom reward that the broadcaster created.<br/>
        /// The app used to create the reward is the only app that may delete it. If the reward’s redemption status is UNFULFILLED at the time the reward is deleted, its redemption status is marked as FULFILLED.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteCustomRewardAsync(
            string broadcasterId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}