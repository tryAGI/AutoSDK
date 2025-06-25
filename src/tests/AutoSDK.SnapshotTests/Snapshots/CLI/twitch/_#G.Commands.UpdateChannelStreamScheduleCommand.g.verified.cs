//HintName: G.Commands.UpdateChannelStreamScheduleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChannelStreamScheduleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            bool? isVacationEnabled,
            global::System.DateTime? vacationStartTime,
            global::System.DateTime? vacationEndTime,
            string? timezone,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsVacationEnabled { get; } = new(
            name: "isVacationEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> VacationStartTime { get; } = new(
            name: "vacationStartTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> VacationEndTime { get; } = new(
            name: "vacationEndTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Timezone { get; } = new(
            name: "timezone")
        {
            Description = @"",
        };
        public UpdateChannelStreamScheduleCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates the broadcaster’s schedule settings, such as scheduling a vacation.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Options.Add(IsVacationEnabled);
            Options.Add(VacationStartTime);
            Options.Add(VacationEndTime);
            Options.Add(Timezone);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var isVacationEnabled = parseResult.GetRequiredValue(IsVacationEnabled);
            var vacationStartTime = parseResult.GetRequiredValue(VacationStartTime);
            var vacationEndTime = parseResult.GetRequiredValue(VacationEndTime);
            var timezone = parseResult.GetRequiredValue(Timezone);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                isVacationEnabled: isVacationEnabled,
                vacationStartTime: vacationStartTime,
                vacationEndTime: vacationEndTime,
                timezone: timezone,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Schedule.UpdateChannelStreamScheduleAsync(
                broadcasterId: broadcasterId,
                isVacationEnabled: isVacationEnabled,
                vacationStartTime: vacationStartTime,
                vacationEndTime: vacationEndTime,
                timezone: timezone,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}