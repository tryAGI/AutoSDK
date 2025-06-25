//HintName: G.Commands.EndGuestStarSessionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EndGuestStarSessionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster you want to end a Guest Star session for. Provided `broadcaster_id` must match the `user_id` in the auth token.",
        };

        private global::System.CommandLine.Argument<string> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = @"ID for the session to end on behalf of the broadcaster.",
        };

        public EndGuestStarSessionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "end",
            description: @"BETA Programmatically ends a Guest Star session on behalf of the broadcaster. Performs the same action as if the host clicked the “End Call” button in the Guest Star UI.

__Authorization:__

* Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:manage:guest_star`")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(SessionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var sessionId = parseResult.GetRequiredValue(SessionId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GuestStar.EndGuestStarSessionAsync(
                broadcasterId: broadcasterId,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}