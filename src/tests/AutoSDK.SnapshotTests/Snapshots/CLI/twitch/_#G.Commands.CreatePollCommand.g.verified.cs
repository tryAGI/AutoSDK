//HintName: G.Commands.CreatePollCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePollCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CreatePollBodyChoice>> Choices { get; } = new(
            name: "choices")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> Duration { get; } = new(
            name: "duration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ChannelPointsVotingEnabled { get; } = new(
            name: "channelPointsVotingEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> ChannelPointsPerVote { get; } = new(
            name: "channelPointsPerVote")
        {
            Description = @"",
        };
        public CreatePollCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a poll that viewers in the broadcaster’s channel can vote on.

The poll begins as soon as it’s created. You may run only one poll at a time.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.")
        {
            _client = client;

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