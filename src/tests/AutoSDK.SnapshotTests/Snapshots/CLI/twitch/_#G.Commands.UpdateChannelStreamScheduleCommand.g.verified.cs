//HintName: G.Commands.UpdateChannelStreamScheduleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChannelStreamScheduleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster whose schedule settings you want to update. The ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Option<bool?> IsVacationEnabled { get; } = new(
            name: "isVacationEnabled")
        {
            Description = @"A Boolean value that indicates whether the broadcaster has scheduled a vacation. Set to **true** to enable Vacation Mode and add vacation dates, or **false** to cancel a previously scheduled vacation.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> VacationStartTime { get; } = new(
            name: "vacationStartTime")
        {
            Description = @"The UTC date and time of when the broadcaster’s vacation starts. Specify the date and time in RFC3339 format (for example, 2021-05-16T00:00:00Z). Required if _is\_vacation\_enabled_ is **true**.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> VacationEndTime { get; } = new(
            name: "vacationEndTime")
        {
            Description = @"The UTC date and time of when the broadcaster’s vacation ends. Specify the date and time in RFC3339 format (for example, 2021-05-30T23:59:59Z). Required if _is\_vacation\_enabled_ is **true**.",
        };

        private global::System.CommandLine.Option<string?> Timezone { get; } = new(
            name: "timezone")
        {
            Description = @"The time zone that the broadcaster broadcasts from. Specify the time zone using [IANA time zone database](https://www.iana.org/time-zones) format (for example, America/New\_York). Required if _is\_vacation\_enabled_ is **true**.",
        };
        public UpdateChannelStreamScheduleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates the broadcaster’s schedule settings, such as scheduling a vacation.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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