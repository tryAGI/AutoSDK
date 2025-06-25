//HintName: G.Commands.GetClipsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetClipsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? broadcasterId,
            string? gameId,
            global::System.Collections.Generic.IList<string>? id,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? first,
            string? before,
            string? after,
            bool? isFeatured,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetClipsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"An ID that identifies the broadcaster whose video clips you want to get. Use this parameter to get clips that were captured from the broadcaster’s streams.",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"An ID that identifies the game whose clips you want to get. Use this parameter to get clips that were captured from streams that were playing this game.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"An ID that identifies the clip to get. To specify more than one ID, include this parameter for each clip you want to get. For example, `id=foo&id=bar`. You may specify a maximum of 100 IDs. The API ignores duplicate IDs and IDs that aren’t found.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = @"The start date used to filter clips. The API returns only clips within the start and end date window. Specify the date and time in RFC3339 format.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndedAt { get; } = new(
            name: "endedAt")
        {
            Description = @"The end date used to filter clips. If not specified, the time window is the start date plus one week. Specify the date and time in RFC3339 format.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of clips to return per page in the response. The minimum page size is 1 clip per page and the maximum is 100\. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"The cursor used to get the previous page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };

        private global::System.CommandLine.Option<bool?> IsFeatured { get; } = new(
            name: "isFeatured")
        {
            Description = @"A Boolean value that determines whether the response includes featured clips. If **true**, returns only clips that are featured. If **false**, returns only clips that aren’t featured. All clips are returned if this parameter is not present.",
        };
        public GetClipsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets one or more video clips that were captured from streams. For information about clips, see [How to use clips](https://help.twitch.tv/s/article/how-to-use-clips).

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).

__Request Query Parameters:__

The _id_, _game\_id_, and _broadcaster\_id_ query parameters are mutually exclusive.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(BroadcasterId);
            Options.Add(GameId);
            Options.Add(Id);
            Options.Add(StartedAt);
            Options.Add(EndedAt);
            Options.Add(First);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(IsFeatured);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var gameId = parseResult.GetRequiredValue(GameId);
            var id = parseResult.GetRequiredValue(Id);
            var startedAt = parseResult.GetRequiredValue(StartedAt);
            var endedAt = parseResult.GetRequiredValue(EndedAt);
            var first = parseResult.GetRequiredValue(First);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var isFeatured = parseResult.GetRequiredValue(IsFeatured);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                gameId: gameId,
                id: id,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                before: before,
                after: after,
                isFeatured: isFeatured,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Clips.GetClipsAsync(
                broadcasterId: broadcasterId,
                gameId: gameId,
                id: id,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                before: before,
                after: after,
                isFeatured: isFeatured,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}