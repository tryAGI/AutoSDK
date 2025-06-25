//HintName: G.Commands.GetBitsLeaderboardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetBitsLeaderboardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? count,
            global::G.GetBitsLeaderboardPeriod? period,
            global::System.DateTime? startedAt,
            string? userId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetBitsLeaderboardResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Count { get; } = new(
            name: "count")
        {
            Description = @"The number of results to return. The minimum count is 1 and the maximum is 100\. The default is 10.",
        };

        private global::System.CommandLine.Option<global::G.GetBitsLeaderboardPeriod?> Period { get; } = new(
            name: "period")
        {
            Description = @"The time period over which data is aggregated (uses the PST time zone). Possible values are:  
* day — A day spans from 00:00:00 on the day specified in _started\_at_ and runs through 00:00:00 of the next day.
* week — A week spans from 00:00:00 on the Monday of the week specified in _started\_at_ and runs through 00:00:00 of the next Monday.
* month — A month spans from 00:00:00 on the first day of the month specified in _started\_at_ and runs through 00:00:00 of the first day of the next month.
* year — A year spans from 00:00:00 on the first day of the year specified in _started\_at_ and runs through 00:00:00 of the first day of the next year.
* all — Default. The lifetime of the broadcaster's channel.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = @"The start date, in RFC3339 format, used for determining the aggregation period. Specify this parameter only if you specify the _period_ query parameter. The start date is ignored if _period_ is all.  
Note that the date is converted to PST before being used, so if you set the start time to `2022-01-01T00:00:00.0Z` and _period_ to month, the actual reporting period is December 2021, not January 2022\. If you want the reporting period to be January 2022, you must set the start time to `2022-01-01T08:00:00.0Z` or `2022-01-01T00:00:00.0-08:00`.  
If your start date uses the ‘+’ offset operator (for example, `2022-01-01T00:00:00.0+05:00`), you must URL encode the start date.",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"An ID that identifies a user that cheered bits in the channel. If _count_ is greater than 1, the response may include users ranked above and below the specified user. To get the leaderboard’s top leaders, don’t specify a user ID.",
        };
        public GetBitsLeaderboardCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets the Bits leaderboard for the authenticated broadcaster.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **bits:read** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Count);
            Options.Add(Period);
            Options.Add(StartedAt);
            Options.Add(UserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var count = parseResult.GetRequiredValue(Count);
            var period = parseResult.GetRequiredValue(Period);
            var startedAt = parseResult.GetRequiredValue(StartedAt);
            var userId = parseResult.GetRequiredValue(UserId);

            Validate(
                parseResult: parseResult,
                count: count,
                period: period,
                startedAt: startedAt,
                userId: userId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Bits.GetBitsLeaderboardAsync(
                count: count,
                period: period,
                startedAt: startedAt,
                userId: userId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}