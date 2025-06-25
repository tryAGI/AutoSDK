//HintName: G.Commands.CreatePollCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePollCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePollBodyChoice> choices,
            int duration,
            bool? channelPointsVotingEnabled,
            int? channelPointsPerVote,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreatePollResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = @"The question that viewers will vote on. For example, _What game should I play next?_ The question may contain a maximum of 60 characters.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CreatePollBodyChoice>> Choices { get; } = new(
            name: "choices")
        {
            Description = @"A list of choices that viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 5 choices.",
        };

        private global::System.CommandLine.Argument<int> Duration { get; } = new(
            name: "duration")
        {
            Description = @"The length of time (in seconds) that the poll will run for. The minimum is 15 seconds and the maximum is 1800 seconds (30 minutes).",
        };

        private global::System.CommandLine.Option<bool?> ChannelPointsVotingEnabled { get; } = new(
            name: "channelPointsVotingEnabled")
        {
            Description = @"A Boolean value that indicates whether viewers may cast additional votes using Channel Points. If **true**, the viewer may cast more than one vote but each additional vote costs the number of Channel Points specified in `channel_points_per_vote`. The default is **false** (viewers may cast only one vote). For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).",
        };

        private global::System.CommandLine.Option<int?> ChannelPointsPerVote { get; } = new(
            name: "channelPointsPerVote")
        {
            Description = @"The number of points that the viewer must spend to cast one additional vote. The minimum is 1 and the maximum is 1000000\. Set only if `ChannelPointsVotingEnabled` is **true**.",
        };
        public CreatePollCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a poll that viewers in the broadcaster’s channel can vote on.

The poll begins as soon as it’s created. You may run only one poll at a time.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Title);
            Arguments.Add(Choices);
            Arguments.Add(Duration);
            Options.Add(ChannelPointsVotingEnabled);
            Options.Add(ChannelPointsPerVote);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var title = parseResult.GetRequiredValue(Title);
            var choices = parseResult.GetRequiredValue(Choices);
            var duration = parseResult.GetRequiredValue(Duration);
            var channelPointsVotingEnabled = parseResult.GetRequiredValue(ChannelPointsVotingEnabled);
            var channelPointsPerVote = parseResult.GetRequiredValue(ChannelPointsPerVote);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                title: title,
                choices: choices,
                duration: duration,
                channelPointsVotingEnabled: channelPointsVotingEnabled,
                channelPointsPerVote: channelPointsPerVote,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Polls.CreatePollAsync(
                broadcasterId: broadcasterId,
                title: title,
                choices: choices,
                duration: duration,
                channelPointsVotingEnabled: channelPointsVotingEnabled,
                channelPointsPerVote: channelPointsPerVote,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}