//HintName: G.Commands.UpdateChannelStreamScheduleSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChannelStreamScheduleSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartTime { get; } = new(
            name: "startTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Duration { get; } = new(
            name: "duration")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CategoryId { get; } = new(
            name: "categoryId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsCanceled { get; } = new(
            name: "isCanceled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Timezone { get; } = new(
            name: "timezone")
        {
            Description = "",
        };
        public UpdateChannelStreamScheduleSegmentCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates a scheduled broadcast segment.

For recurring segments, updating a segment’s title, category, duration, and timezone, changes all segments in the recurring schedule, not just the specified segment.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.")
        {
            _client = client;

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