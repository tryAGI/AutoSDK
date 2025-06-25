//HintName: G.Commands.GetGameAnalyticsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetGameAnalyticsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? gameId,
            global::G.GetGameAnalyticsType? type,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetGameAnalyticsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GetGameAnalyticsType?> Type { get; } = new(
            name: "type")
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

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"",
        };
        public GetGameAnalyticsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets an analytics report for one or more games. The response contains the URLs used to download the reports (CSV files). [Learn more](https://dev.twitch.tv/docs/insights)

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **analytics:read:games** scope.")
        {
            _client = client;

            Options.Add(GameId);
            Options.Add(Type);
            Options.Add(StartedAt);
            Options.Add(EndedAt);
            Options.Add(First);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var gameId = parseResult.GetRequiredValue(GameId);
            var type = parseResult.GetRequiredValue(Type);
            var startedAt = parseResult.GetRequiredValue(StartedAt);
            var endedAt = parseResult.GetRequiredValue(EndedAt);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                gameId: gameId,
                type: type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Analytics.GetGameAnalyticsAsync(
                gameId: gameId,
                type: type,
                startedAt: startedAt,
                endedAt: endedAt,
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