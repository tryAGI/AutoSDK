//HintName: G.Commands.GetBroadcasterSubscriptionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetBroadcasterSubscriptionsCommand : global::System.CommandLine.Command
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
            string? before,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetBroadcasterSubscriptionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The broadcaster’s ID. This ID must match the user ID in the access token.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"Filters the list to include only the specified subscribers. To specify more than one subscriber, include this parameter for each subscriber. For example, `&user_id=1234&user_id=5678`. You may specify a maximum of 100 subscribers.",
        };

        private global::System.CommandLine.Option<string?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. Do not specify if you set the _user\_id_ query parameter. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"The cursor used to get the previous page of results. Do not specify if you set the _user\_id_ query parameter. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetBroadcasterSubscriptionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of users that subscribe to the specified broadcaster.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:subscriptions** scope.

A Twitch extensions may use an app access token if the broadcaster has granted the **channel:read:subscriptions** scope from within the Twitch Extensions manager.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Options.Add(UserId);
            Options.Add(First);
            Options.Add(After);
            Options.Add(Before);

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
            var before = parseResult.GetRequiredValue(Before);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Subscriptions.GetBroadcasterSubscriptionsAsync(
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}