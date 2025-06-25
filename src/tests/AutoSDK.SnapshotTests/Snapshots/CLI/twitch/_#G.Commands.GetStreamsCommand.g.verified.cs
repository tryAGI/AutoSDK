//HintName: G.Commands.GetStreamsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetStreamsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? userId,
            global::System.Collections.Generic.IList<string>? userLogin,
            global::System.Collections.Generic.IList<string>? gameId,
            global::G.GetStreamsType? type,
            global::System.Collections.Generic.IList<string>? language,
            int? first,
            string? before,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetStreamsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"A user ID used to filter the list of streams. Returns only the streams of those users that are broadcasting. You may specify a maximum of 100 IDs. To specify multiple IDs, include the _user\_id_ parameter for each user. For example, `&user_id=1234&user_id=5678`.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserLogin { get; } = new(
            name: "userLogin")
        {
            Description = @"A user login name used to filter the list of streams. Returns only the streams of those users that are broadcasting. You may specify a maximum of 100 login names. To specify multiple names, include the _user\_login_ parameter for each user. For example, `&user_login=foo&user_login=bar`.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"A game (category) ID used to filter the list of streams. Returns only the streams that are broadcasting the game (category). You may specify a maximum of 100 IDs. To specify multiple IDs, include the _game\_id_ parameter for each game. For example, `&game_id=9876&game_id=5432`.",
        };

        private global::System.CommandLine.Option<global::G.GetStreamsType?> Type { get; } = new(
            name: "type")
        {
            Description = @"The type of stream to filter the list of streams by. Possible values are:  
* all
* live
The default is _all_.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Language { get; } = new(
            name: "language")
        {
            Description = @"A language code used to filter the list of streams. Returns only streams that broadcast in the specified language. Specify the language using an ISO 639-1 two-letter language code or _other_ if the broadcast uses a language not in the list of [supported stream languages](https://help.twitch.tv/s/article/languages-on-twitch#streamlang).  
You may specify a maximum of 100 language codes. To specify multiple languages, include the _language_ parameter for each language. For example, `&language=de&language=fr`.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100 items per page. The default is 20.",
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
        public GetStreamsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of all streams. The list is in descending order by the number of viewers watching the stream. Because viewers come and go during a stream, it’s possible to find duplicate or missing streams in the list as you page through the results.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(UserId);
            Options.Add(UserLogin);
            Options.Add(GameId);
            Options.Add(Type);
            Options.Add(Language);
            Options.Add(First);
            Options.Add(Before);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var userLogin = parseResult.GetRequiredValue(UserLogin);
            var gameId = parseResult.GetRequiredValue(GameId);
            var type = parseResult.GetRequiredValue(Type);
            var language = parseResult.GetRequiredValue(Language);
            var first = parseResult.GetRequiredValue(First);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                userId: userId,
                userLogin: userLogin,
                gameId: gameId,
                type: type,
                language: language,
                first: first,
                before: before,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Streams.GetStreamsAsync(
                userId: userId,
                userLogin: userLogin,
                gameId: gameId,
                type: type,
                language: language,
                first: first,
                before: before,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}