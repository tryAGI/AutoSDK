//HintName: G.Commands.GetPollsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetPollsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id,
            string? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetPollsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that created the polls. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"A list of IDs that identify the polls to return. To specify more than one ID, include this parameter for each poll you want to get. For example, `id=1234&id=5678`. You may specify a maximum of 20 IDs.  
Specify this parameter only if you want to filter the list that the request returns. The endpoint ignores duplicate IDs and those not owned by this broadcaster.",
        };

        private global::System.CommandLine.Option<string?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 20 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetPollsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of polls that the broadcaster created.

Polls are available for 90 days after they’re created.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:polls** or **channel:manage:polls** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Options.Add(Id);
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
            var id = parseResult.GetRequiredValue(Id);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Polls.GetPollsAsync(
                broadcasterId: broadcasterId,
                id: id,
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