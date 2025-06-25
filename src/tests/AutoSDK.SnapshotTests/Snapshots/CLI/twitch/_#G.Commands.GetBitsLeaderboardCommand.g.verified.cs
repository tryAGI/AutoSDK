//HintName: G.Commands.GetBitsLeaderboardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetBitsLeaderboardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GetBitsLeaderboardPeriod?> Period { get; } = new(
            name: "period")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"",
        };
        public GetBitsLeaderboardCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the Bits leaderboard for the authenticated broadcaster.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **bits:read** scope.")
        {
            _client = client;

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