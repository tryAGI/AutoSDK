//HintName: G.Commands.GetVideosCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVideosCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"A list of IDs that identify the videos you want to get. To get more than one video, include this parameter for each video you want to get. For example, `id=1234&id=5678`. You may specify a maximum of 100 IDs. The endpoint ignores duplicate IDs and IDs that weren't found (if there's at least one valid ID).  
The _id_, _user\_id_, and _game\_id_ parameters are mutually exclusive.",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID of the user whose list of videos you want to get.  
The _id_, _user\_id_, and _game\_id_ parameters are mutually exclusive.",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"A category or game ID. The response contains a maximum of 500 videos that show this content. To get category/game IDs, use the [Search Categories](https://dev.twitch.tv/docs/api/reference#search-categories) endpoint.  
The _id_, _user\_id_, and _game\_id_ parameters are mutually exclusive.",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = @"A filter used to filter the list of videos by the language that the video owner broadcasts in. For example, to get videos that were broadcast in German, set this parameter to the ISO 639-1 two-letter code for German (i.e., DE). For a list of supported languages, see [Supported Stream Language](https://help.twitch.tv/s/article/languages-on-twitch#streamlang). If the language is not supported, use “other.”  
Specify this parameter only if you specify the _game\_id_ query parameter.",
        };

        private global::System.CommandLine.Option<global::G.GetVideosPeriod?> Period { get; } = new(
            name: "period")
        {
            Description = @"A filter used to filter the list of videos by when they were published. For example, videos published in the last week. Possible values are:  
* all
* day
* month
* week
The default is ""all,"" which returns videos published in all periods.  
Specify this parameter only if you specify the _game\_id_ or _user\_id_ query parameter.",
        };

        private global::System.CommandLine.Option<global::G.GetVideosSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = @"The order to sort the returned videos in. Possible values are:  
* time — Sort the results in descending order by when they were created (i.e., latest video first).
* trending — Sort the results in descending order by biggest gains in viewership (i.e., highest trending video first).
* views — Sort the results in descending order by most views (i.e., highest number of views first).
The default is ""time.""  
Specify this parameter only if you specify the _game\_id_ or _user\_id_ query parameter.",
        };

        private global::System.CommandLine.Option<global::G.GetVideosType?> Type { get; } = new(
            name: "type")
        {
            Description = @"A filter used to filter the list of videos by the video's type. Possible case-sensitive values are:  
* all
* archive — On-demand videos (VODs) of past streams.
* highlight — Highlight reels of past streams.
* upload — External videos that the broadcaster uploaded using the Video Producer.
The default is ""all,"" which returns all video types.  
Specify this parameter only if you specify the _game\_id_ or _user\_id_ query parameter.",
        };

        private global::System.CommandLine.Option<string?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100\. The default is 20.  
Specify this parameter only if you specify the _game\_id_ or _user\_id_ query parameter.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)  
Specify this parameter only if you specify the _user\_id_ query parameter.",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"The cursor used to get the previous page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)  
Specify this parameter only if you specify the _user\_id_ query parameter.",
        };
        public GetVideosCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets information about one or more published videos. You may get videos by ID, by user, or by game/category.

You may apply several filters to get a subset of the videos. The filters are applied as an AND operation to each video. For example, if _language_ is set to ‘de’ and _game\_id_ is set to 21779, the response includes only videos that show playing League of Legends by users that stream in German. The filters apply only if you get videos by user ID or game ID.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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