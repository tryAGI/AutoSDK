//HintName: G.Commands.UpdateChannelStreamScheduleSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChannelStreamScheduleSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string id,
            global::System.DateTime? startTime,
            string? duration,
            string? categoryId,
            string? title,
            bool? isCanceled,
            string? timezone,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateChannelStreamScheduleSegmentResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster who owns the broadcast segment to update. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the broadcast segment to update.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartTime { get; } = new(
            name: "startTime")
        {
            Description = @"The date and time that the broadcast segment starts. Specify the date and time in RFC3339 format (for example, 2022-08-02T06:00:00Z).  
**NOTE**: Only partners and affiliates may update a broadcast’s start time and only for non-recurring segments.",
        };

        private global::System.CommandLine.Option<string?> Duration { get; } = new(
            name: "duration")
        {
            Description = @"The length of time, in minutes, that the broadcast is scheduled to run. The duration must be in the range 30 through 1380 (23 hours).",
        };

        private global::System.CommandLine.Option<string?> CategoryId { get; } = new(
            name: "categoryId")
        {
            Description = @"The ID of the category that best represents the broadcast’s content. To get the category ID, use the [Search Categories](https://dev.twitch.tv/docs/api/reference#search-categories) endpoint.",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"The broadcast’s title. The title may contain a maximum of 140 characters.",
        };

        private global::System.CommandLine.Option<bool?> IsCanceled { get; } = new(
            name: "isCanceled")
        {
            Description = @"A Boolean value that indicates whether the broadcast is canceled. Set to **true** to cancel the segment.  
**NOTE**: For recurring segments, the API cancels the first segment after the current UTC date and time and not the specified segment (unless the specified segment is the next segment after the current UTC date and time).",
        };

        private global::System.CommandLine.Option<string?> Timezone { get; } = new(
            name: "timezone")
        {
            Description = @"The time zone where the broadcast takes place. Specify the time zone using [IANA time zone database](https://www.iana.org/time-zones) format (for example, America/New\_York).",
        };
        public UpdateChannelStreamScheduleSegmentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates a scheduled broadcast segment.

For recurring segments, updating a segment’s title, category, duration, and timezone, changes all segments in the recurring schedule, not just the specified segment.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Id);
            Options.Add(StartTime);
            Options.Add(Duration);
            Options.Add(CategoryId);
            Options.Add(Title);
            Options.Add(IsCanceled);
            Options.Add(Timezone);

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
            var duration = parseResult.GetRequiredValue(Duration);
            var categoryId = parseResult.GetRequiredValue(CategoryId);
            var title = parseResult.GetRequiredValue(Title);
            var isCanceled = parseResult.GetRequiredValue(IsCanceled);
            var timezone = parseResult.GetRequiredValue(Timezone);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                startTime: startTime,
                duration: duration,
                categoryId: categoryId,
                title: title,
                isCanceled: isCanceled,
                timezone: timezone,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schedule.UpdateChannelStreamScheduleSegmentAsync(
                broadcasterId: broadcasterId,
                id: id,
                startTime: startTime,
                duration: duration,
                categoryId: categoryId,
                title: title,
                isCanceled: isCanceled,
                timezone: timezone,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}