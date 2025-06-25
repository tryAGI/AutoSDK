//HintName: G.Commands.UpdateGuestStarSlotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateGuestStarSlotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string sourceSlotId,
            string? destinationSlotId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> SourceSlotId { get; } = new(
            name: "sourceSlotId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> DestinationSlotId { get; } = new(
            name: "destinationSlotId")
        {
            Description = @"",
        };
        public UpdateGuestStarSlotCommand(G.IApi client) : base(
            name: "update",
            description: @"BETA Allows a user to update the assigned slot for a particular user within the active Guest Star session.

__Authorization:__

* Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(SessionId);
            Arguments.Add(SourceSlotId);
            Options.Add(DestinationSlotId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var sessionId = parseResult.GetRequiredValue(SessionId);
            var sourceSlotId = parseResult.GetRequiredValue(SourceSlotId);
            var destinationSlotId = parseResult.GetRequiredValue(DestinationSlotId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                sourceSlotId: sourceSlotId,
                destinationSlotId: destinationSlotId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.UpdateGuestStarSlotAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                sourceSlotId: sourceSlotId,
                destinationSlotId: destinationSlotId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}