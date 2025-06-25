//HintName: G.Commands.UnbanUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UnbanUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster whose chat room the user is banned from chatting in.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of the broadcaster or a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID of the user to remove the ban or timeout from.",
        };

        public UnbanUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "unban",
            description: @"Removes the ban or timeout that was placed on the specified user.

To ban a user, see [Ban user](https://dev.twitch.tv/docs/api/reference#ban-user).

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:banned\_users** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(UserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var userId = parseResult.GetRequiredValue(UserId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                userId: userId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Moderation.UnbanUserAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                userId: userId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}