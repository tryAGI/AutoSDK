//HintName: G.Commands.EndPollCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EndPollCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string id,
            global::G.EndPollBodyStatus status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EndPollResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.EndPollBodyStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        public EndPollCommand(G.IApi client) : base(
            name: "end",
            description: @"Ends an active poll. You have the option to end it or end it and archive it.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Id);
            Arguments.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Polls.EndPollAsync(
                broadcasterId: broadcasterId,
                id: id,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}