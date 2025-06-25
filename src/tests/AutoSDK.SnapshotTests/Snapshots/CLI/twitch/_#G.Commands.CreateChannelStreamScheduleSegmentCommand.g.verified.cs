//HintName: G.Commands.CreateChannelStreamScheduleSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateChannelStreamScheduleSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.DateTime startTime,
            string timezone,
            string duration,
            bool? isRecurring,
            string? categoryId,
            string? title,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateChannelStreamScheduleSegmentResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.DateTime> StartTime { get; } = new(
            name: "startTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Timezone { get; } = new(
            name: "timezone")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Duration { get; } = new(
            name: "duration")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsRecurring { get; } = new(
            name: "isRecurring")
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
        public CreateChannelStreamScheduleSegmentCommand(G.IApi client) : base(
            name: "create",
            description: @"Adds a single or recurring broadcast to the broadcaster’s streaming schedule. For information about scheduling broadcasts, see [Stream Schedule](https://help.twitch.tv/s/article/channel-page-setup#Schedule).

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(StartTime);
            Arguments.Add(Timezone);
            Arguments.Add(Duration);
            Options.Add(IsRecurring);
            Options.Add(CategoryId);
            Options.Add(Title);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var timezone = parseResult.GetRequiredValue(Timezone);
            var duration = parseResult.GetRequiredValue(Duration);
            var isRecurring = parseResult.GetRequiredValue(IsRecurring);
            var categoryId = parseResult.GetRequiredValue(CategoryId);
            var title = parseResult.GetRequiredValue(Title);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                startTime: startTime,
                timezone: timezone,
                duration: duration,
                isRecurring: isRecurring,
                categoryId: categoryId,
                title: title,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schedule.CreateChannelStreamScheduleSegmentAsync(
                broadcasterId: broadcasterId,
                startTime: startTime,
                timezone: timezone,
                duration: duration,
                isRecurring: isRecurring,
                categoryId: categoryId,
                title: title,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}