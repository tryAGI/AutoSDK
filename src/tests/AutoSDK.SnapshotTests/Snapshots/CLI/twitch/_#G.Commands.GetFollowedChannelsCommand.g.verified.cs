﻿//HintName: G.Commands.GetFollowedChannelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetFollowedChannelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string? broadcasterId,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetFollowedChannelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"A user’s ID. Returns the list of broadcasters that this user follows. This ID must match the user ID in the user OAuth token.",
        };

        private global::System.CommandLine.Option<string?> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"A broadcaster’s ID. Use this parameter to see whether the user follows this broadcaster. If specified, the response contains this broadcaster if the user follows them. If not specified, the response contains all broadcasters that the user follows.",
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
        public GetFollowedChannelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of broadcasters that the specified user follows. You can also use this endpoint to see whether a user follows a specific broadcaster.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:follows** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserId);
            Options.Add(BroadcasterId);
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
            var response = await _client.Channels.GetFollowedChannelsAsync(
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