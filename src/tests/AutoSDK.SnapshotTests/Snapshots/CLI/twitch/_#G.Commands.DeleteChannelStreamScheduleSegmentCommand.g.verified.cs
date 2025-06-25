//HintName: G.Commands.DeleteChannelStreamScheduleSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteChannelStreamScheduleSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that owns the streaming schedule. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the broadcast segment to remove.",
        };

        public DeleteChannelStreamScheduleSegmentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Removes a broadcast segment from the broadcaster’s streaming schedule.

**NOTE**: For recurring segments, removing a segment removes all segments in the recurring schedule.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Schedule.DeleteChannelStreamScheduleSegmentAsync(
                broadcasterId: broadcasterId,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}