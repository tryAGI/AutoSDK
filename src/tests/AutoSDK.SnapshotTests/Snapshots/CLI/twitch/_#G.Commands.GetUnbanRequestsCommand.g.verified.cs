//HintName: G.Commands.GetUnbanRequestsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUnbanRequestsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string status,
            string? userId,
            string? after,
            int? first,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetUnbanRequestsResponse response,
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

        private global::System.CommandLine.Argument<string> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"",
        };
        public GetUnbanRequestsCommand(G.IApi client) : base(
            name: "get",
            description: @"NEW Gets a list of unban requests for a broadcaster’s channel.

__Authorization:__

* Requires a user access token that includes the **moderator:read:unban\_requests** or **moderator:manage:unban\_requests** scope.
* Query parameter `moderator_id` must match the `user_id` in the [user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(Status);
            Options.Add(UserId);
            Options.Add(After);
            Options.Add(First);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var status = parseResult.GetRequiredValue(Status);
            var userId = parseResult.GetRequiredValue(UserId);
            var after = parseResult.GetRequiredValue(After);
            var first = parseResult.GetRequiredValue(First);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                status: status,
                userId: userId,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.GetUnbanRequestsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                status: status,
                userId: userId,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}