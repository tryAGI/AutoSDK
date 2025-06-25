//HintName: G.Commands.UpdateShieldModeStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateShieldModeStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            bool isActive,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateShieldModeStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster whose Shield Mode you want to activate or deactivate.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of the broadcaster or a user that is one of the broadcaster’s moderators. This ID must match the user ID in the access token.",
        };

        private global::System.CommandLine.Argument<bool> IsActive { get; } = new(
            name: "isActive")
        {
            Description = @"A Boolean value that determines whether to activate Shield Mode. Set to **true** to activate Shield Mode; otherwise, **false** to deactivate Shield Mode.",
        };

        public UpdateShieldModeStatusCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Activates or deactivates the broadcaster’s Shield Mode.

Twitch’s Shield Mode feature is like a panic button that broadcasters can push to protect themselves from chat abuse coming from one or more accounts. When activated, Shield Mode applies the overrides that the broadcaster configured in the Twitch UX. If the broadcaster hasn’t configured Shield Mode, it applies default overrides.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:shield\_mode** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(IsActive);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var isActive = parseResult.GetRequiredValue(IsActive);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                isActive: isActive,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.UpdateShieldModeStatusAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                isActive: isActive,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}