//HintName: G.Commands.GetClipsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetClipsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndedAt { get; } = new(
            name: "endedAt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsFeatured { get; } = new(
            name: "isFeatured")
        {
            Description = @"",
        };
        public GetClipsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets one or more video clips that were captured from streams. For information about clips, see [How to use clips](https://help.twitch.tv/s/article/how-to-use-clips).

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).

__Request Query Parameters:__

The _id_, _game\_id_, and _broadcaster\_id_ query parameters are mutually exclusive.")
        {
            _client = client;

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