//HintName: G.IGoalsClient.GetCreatorGoals.g.cs
#nullable enable

namespace G
{
    public partial interface IGoalsClient
    {
        /// <summary>
        /// Gets the broadcaster’s list of active goals.<br/>
        /// Gets the broadcaster’s list of active goals. Use this endpoint to get the current progress of each goal.<br/>
        /// Instead of polling for the progress of a goal, consider [subscribing](https://dev.twitch.tv/docs/eventsub/manage-subscriptions) to receive notifications when a goal makes progress using the [channel.goal.progress](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelgoalprogress) subscription type. [Read More](https://dev.twitch.tv/docs/api/goals#requesting-event-notifications)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:goals** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCreatorGoalsResponse> GetCreatorGoalsAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}