//HintName: G.IChannelPointsClient.UpdateCustomReward.g.cs
#nullable enable

namespace G
{
    public partial interface IChannelPointsClient
    {
        /// <summary>
        /// Updates a custom reward.<br/>
        /// Updates a custom reward. The app used to create the reward is the only app that may update the reward.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/api/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.<br/>
        /// __Request Body:__<br/>
        /// The body of the request should contain only the fields you’re updating.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCustomRewardResponse> UpdateCustomRewardAsync(
            string broadcasterId,
            string id,
            global::G.UpdateCustomRewardBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a custom reward.<br/>
        /// Updates a custom reward. The app used to create the reward is the only app that may update the reward.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/api/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.<br/>
        /// __Request Body:__<br/>
        /// The body of the request should contain only the fields you’re updating.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="title">
        /// The reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.
        /// </param>
        /// <param name="prompt">
        /// The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.
        /// </param>
        /// <param name="cost">
        /// The cost of the reward, in channel points. The minimum is 1 point.
        /// </param>
        /// <param name="backgroundColor">
        /// The background color to use for the reward. Specify the color using Hex format (for example, \\#00E5CB).
        /// </param>
        /// <param name="isEnabled">
        /// A Boolean value that indicates whether the reward is enabled. Set to **true** to enable the reward. Viewers see only enabled rewards.
        /// </param>
        /// <param name="isUserInputRequired">
        /// A Boolean value that determines whether users must enter information to redeem the reward. Set to **true** if user input is required. See the `prompt` field.
        /// </param>
        /// <param name="isMaxPerStreamEnabled">
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). Set to **true** to limit redemptions.
        /// </param>
        /// <param name="maxPerStream">
        /// The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.
        /// </param>
        /// <param name="isMaxPerUserPerStreamEnabled">
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see `max_per_user_per_stream`). The minimum value is 1\. Set to **true** to limit redemptions.
        /// </param>
        /// <param name="maxPerUserPerStream">
        /// The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**.
        /// </param>
        /// <param name="isGlobalCooldownEnabled">
        /// A Boolean value that determines whether to apply a cooldown period between redemptions. Set to **true** to apply a cooldown period. For the duration of the cooldown period, see `global_cooldown_seconds`.
        /// </param>
        /// <param name="globalCooldownSeconds">
        /// The cooldown period, in seconds. Applied only if `is_global_cooldown_enabled` is **true**. The minimum value is 1; however, for it to be shown in the Twitch UX, the minimum value is 60.
        /// </param>
        /// <param name="isPaused">
        /// A Boolean value that determines whether to pause the reward. Set to **true** to pause the reward. Viewers can’t redeem paused rewards..
        /// </param>
        /// <param name="shouldRedemptionsSkipRequestQueue">
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCustomRewardResponse> UpdateCustomRewardAsync(
            string broadcasterId,
            string id,
            string? title = default,
            string? prompt = default,
            long? cost = default,
            string? backgroundColor = default,
            bool? isEnabled = default,
            bool? isUserInputRequired = default,
            bool? isMaxPerStreamEnabled = default,
            long? maxPerStream = default,
            bool? isMaxPerUserPerStreamEnabled = default,
            long? maxPerUserPerStream = default,
            bool? isGlobalCooldownEnabled = default,
            long? globalCooldownSeconds = default,
            bool? isPaused = default,
            bool? shouldRedemptionsSkipRequestQueue = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}