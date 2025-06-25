//HintName: G.Commands.GetChannelFollowersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetChannelFollowersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? userId,
            string broadcasterId,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetChannelFollowersResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The broadcaster’s ID. Returns the list of users that follow this broadcaster.",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"A user’s ID. Use this parameter to see whether the user follows this broadcaster. If specified, the response contains this user if they follow the broadcaster. If not specified, the response contains all users that follow the broadcaster.  
Using this parameter requires both a user access token with the **moderator:read:followers** scope and the user ID in the access token match the broadcaster\_id or be the user ID for a moderator of the specified broadcaster.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100\. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read more](https://dev.twitch.tv/docs/api/guide#pagination).",
        };
        public GetChannelFollowersCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of users that follow the specified broadcaster. You can also use this endpoint to see whether a specific user follows the broadcaster.

__Authorization:__

* Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:followers** scope.
* The ID in the broadcaster\_id query parameter must match the user ID in the access token or the user ID in the access token must be a moderator for the specified broadcaster.

This endpoint will return specific follower information only if both of the above are true. If a scope is not provided or the user isn’t the broadcaster or a moderator for the specified channel, only the total follower count will be included in the response.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Options.Add(UserId);
            Options.Add(First);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                userId: userId,
                broadcasterId: broadcasterId,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Channels.GetChannelFollowersAsync(
                userId: userId,
                broadcasterId: broadcasterId,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}