//HintName: G.Commands.GetGameAnalyticsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetGameAnalyticsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The game’s client ID. If specified, the response contains a report for the specified game. If not specified, the response includes a report for each of the authenticated user’s games.",
        };

        private global::System.CommandLine.Option<global::G.GetGameAnalyticsType?> Type { get; } = new(
            name: "type")
        {
            Description = @"The type of analytics report to get. Possible values are:  
* overview\_v2",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = @"The reporting window’s start date, in RFC3339 format. Set the time portion to zeroes (for example, 2021-10-22T00:00:00Z). If you specify a start date, you must specify an end date.  
The start date must be within one year of today’s date. If you specify an earlier date, the API ignores it and uses a date that’s one year prior to today’s date. If you don’t specify a start and end date, the report includes all available data for the last 365 days from today.  
The report contains one row of data for each day in the reporting window.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndedAt { get; } = new(
            name: "endedAt")
        {
            Description = @"The reporting window’s end date, in RFC3339 format. Set the time portion to zeroes (for example, 2021-10-22T00:00:00Z). The report is inclusive of the end date.  
Specify an end date only if you provide a start date. Because it can take up to two days for the data to be available, you must specify an end date that’s earlier than today minus one to two days. If not, the API ignores your end date and uses an end date that is today minus one to two days.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of report URLs to return per page in the response. The minimum page size is 1 URL per page and the maximum is 100 URLs per page. The default is 20.  
**NOTE**: While you may specify a maximum value of 100, the response will contain at most 20 URLs per page.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)  
This parameter is ignored if _game\_id_ parameter is set.",
        };
        public GetGameAnalyticsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets an analytics report for one or more games. The response contains the URLs used to download the reports (CSV files). [Learn more](https://dev.twitch.tv/docs/insights)

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **analytics:read:games** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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