//HintName: G.Commands.GetUnbanRequestsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUnbanRequestsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster whose channel is receiving unban requests.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of the broadcaster or a user that has permission to moderate the broadcaster’s unban requests. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Status { get; } = new(
            name: "status")
        {
            Description = @"Filter by a status.  
* pending
* approved
* denied
* acknowledged
* canceled",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID used to filter what unban requests are returned.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"Cursor used to get next page of results. Pagination object in response contains cursor value.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in response",
        };
        public GetUnbanRequestsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"NEW Gets a list of unban requests for a broadcaster’s channel.

__Authorization:__

* Requires a user access token that includes the **moderator:read:unban\_requests** or **moderator:manage:unban\_requests** scope.
* Query parameter `moderator_id` must match the `user_id` in the [user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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