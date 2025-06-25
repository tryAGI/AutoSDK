//HintName: G.Commands.GetModeratorsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetModeratorsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId,
            string? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetModeratorsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster whose list of moderators you want to get. This ID must match the user ID in the access token.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"A list of user IDs used to filter the results. To specify more than one ID, include this parameter for each moderator you want to get. For example, `user_id=1234&user_id=5678`. You may specify a maximum of 100 IDs.  
The returned list includes only the users from the list who are moderators in the broadcaster’s channel. The list is returned in the same order as you specified the IDs.",
        };

        private global::System.CommandLine.Option<string?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetModeratorsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets all users allowed to moderate the broadcaster’s chat room.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** scope. If your app also adds and removes moderators, you can use the **channel:manage:moderators** scope instead.")
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
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var userId = parseResult.GetRequiredValue(UserId);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.GetModeratorsAsync(
                broadcasterId: broadcasterId,
                userId: userId,
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