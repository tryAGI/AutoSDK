//HintName: G.IPollsClient.CreatePoll.g.cs
#nullable enable

namespace G
{
    public partial interface IPollsClient
    {
        /// <summary>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// The poll begins as soon as it’s created. You may run only one poll at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePollResponse> CreatePollAsync(
            global::G.CreatePollBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// Creates a poll that viewers in the broadcaster’s channel can vote on.<br/>
        /// The poll begins as soon as it’s created. You may run only one poll at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="title">
        /// The question that viewers will vote on. For example, _What game should I play next?_ The question may contain a maximum of 60 characters.
        /// </param>
        /// <param name="choices">
        /// A list of choices that viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 5 choices.
        /// </param>
        /// <param name="duration">
        /// The length of time (in seconds) that the poll will run for. The minimum is 15 seconds and the maximum is 1800 seconds (30 minutes).
        /// </param>
        /// <param name="channelPointsVotingEnabled">
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. If **true**, the viewer may cast more than one vote but each additional vote costs the number of Channel Points specified in `channel_points_per_vote`. The default is **false** (viewers may cast only one vote). For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </param>
        /// <param name="channelPointsPerVote">
        /// The number of points that the viewer must spend to cast one additional vote. The minimum is 1 and the maximum is 1000000\. Set only if `ChannelPointsVotingEnabled` is **true**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePollResponse> CreatePollAsync(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePollBodyChoice> choices,
            int duration,
            bool channelPointsVotingEnabled = default,
            int channelPointsPerVote = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}