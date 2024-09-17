//HintName: G.IChannelPointsClient.GetCustomReward.g.cs
#nullable enable

namespace G
{
    public partial interface IChannelPointsClient
    {
        /// <summary>
        /// Gets a list of custom rewards that the specified broadcaster created.<br/>
        /// Gets a list of custom rewards that the specified broadcaster created.<br/>
        /// **NOTE**: A channel may offer a maximum of 50 rewards, which includes both enabled and disabled rewards.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:redemptions** or **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="onlyManageableRewards"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCustomRewardResponse> GetCustomRewardAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id = default,
            bool? onlyManageableRewards = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}