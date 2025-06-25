//HintName: G.Commands.GetChannelStreamScheduleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetChannelStreamScheduleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id,
            global::System.DateTime? startTime,
            string? utcOffset,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetChannelStreamScheduleResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that owns the streaming schedule you want to get.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the scheduled segment to return. To specify more than one segment, include the ID of each segment you want to get. For example, `id=1234&id=5678`. You may specify a maximum of 100 IDs.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartTime { get; } = new(
            name: "startTime")
        {
            Description = @"The UTC date and time that identifies when in the broadcaster’s schedule to start returning segments. If not specified, the request returns segments starting after the current UTC date and time. Specify the date and time in RFC3339 format (for example, `2022-09-01T00:00:00Z`).",
        };

        private global::System.CommandLine.Option<string?> UtcOffset { get; } = new(
            name: "utcOffset")
        {
            Description = @"Not supported.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 25 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetChannelStreamScheduleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets the broadcaster’s streaming schedule. You can get the entire schedule or specific segments of the schedule. [Learn More](https://help.twitch.tv/s/article/channel-page-setup#Schedule)

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Options.Add(Id);
            Options.Add(StartTime);
            Options.Add(UtcOffset);
            Options.Add(First);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var utcOffset = parseResult.GetRequiredValue(UtcOffset);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                startTime: startTime,
                utcOffset: utcOffset,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schedule.GetChannelStreamScheduleAsync(
                broadcasterId: broadcasterId,
                id: id,
                startTime: startTime,
                utcOffset: utcOffset,
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