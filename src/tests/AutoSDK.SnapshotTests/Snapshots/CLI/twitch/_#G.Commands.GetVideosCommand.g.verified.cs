//HintName: G.Commands.GetVideosCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVideosCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? id,
            string? userId,
            string? gameId,
            string? language,
            global::G.GetVideosPeriod? period,
            global::G.GetVideosSort? sort,
            global::G.GetVideosType? type,
            string? first,
            string? after,
            string? before,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetVideosResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetVideosPeriod?> Period { get; } = new(
            name: "period")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetVideosSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetVideosType?> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> First { get; } = new(
            name: "first")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };
        public GetVideosCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets information about one or more published videos. You may get videos by ID, by user, or by game/category.

You may apply several filters to get a subset of the videos. The filters are applied as an AND operation to each video. For example, if _language_ is set to ‘de’ and _game\_id_ is set to 21779, the response includes only videos that show playing League of Legends by users that stream in German. The filters apply only if you get videos by user ID or game ID.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

            Options.Add(Id);
            Options.Add(UserId);
            Options.Add(GameId);
            Options.Add(Language);
            Options.Add(Period);
            Options.Add(Sort);
            Options.Add(Type);
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
            var id = parseResult.GetRequiredValue(Id);
            var userId = parseResult.GetRequiredValue(UserId);
            var gameId = parseResult.GetRequiredValue(GameId);
            var language = parseResult.GetRequiredValue(Language);
            var period = parseResult.GetRequiredValue(Period);
            var sort = parseResult.GetRequiredValue(Sort);
            var type = parseResult.GetRequiredValue(Type);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);

            Validate(
                parseResult: parseResult,
                id: id,
                userId: userId,
                gameId: gameId,
                language: language,
                period: period,
                sort: sort,
                type: type,
                first: first,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Videos.GetVideosAsync(
                id: id,
                userId: userId,
                gameId: gameId,
                language: language,
                period: period,
                sort: sort,
                type: type,
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