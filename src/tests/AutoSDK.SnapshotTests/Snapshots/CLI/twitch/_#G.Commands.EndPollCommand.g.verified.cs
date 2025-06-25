//HintName: G.Commands.EndPollCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EndPollCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the poll to update.",
        };

        private global::System.CommandLine.Argument<global::G.EndPollBodyStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"The status to set the poll to. Possible case-sensitive values are:  
* TERMINATED — Ends the poll before the poll is scheduled to end. The poll remains publicly visible.
* ARCHIVED — Ends the poll before the poll is scheduled to end, and then archives it so it's no longer publicly visible.",
        };

        public EndPollCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "end",
            description: @"Ends an active poll. You have the option to end it or end it and archive it.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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