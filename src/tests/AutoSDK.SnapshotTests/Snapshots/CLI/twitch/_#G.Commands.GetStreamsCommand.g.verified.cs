//HintName: G.Commands.GetStreamsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetStreamsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserLogin { get; } = new(
            name: "userLogin")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> GameId { get; } = new(
            name: "gameId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetStreamsType?> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };
        public GetStreamsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets a list of all streams. The list is in descending order by the number of viewers watching the stream. Because viewers come and go during a stream, it’s possible to find duplicate or missing streams in the list as you page through the results.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

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