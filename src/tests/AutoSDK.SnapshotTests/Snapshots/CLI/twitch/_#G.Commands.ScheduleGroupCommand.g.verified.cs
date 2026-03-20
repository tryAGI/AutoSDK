//HintName: G.Commands.ScheduleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ScheduleGroupCommand : global::System.CommandLine.Command
    {
        public ScheduleGroupCommand(
            ScheduleCreateChannelStreamScheduleSegmentCommand command0,
            ScheduleDeleteChannelStreamScheduleSegmentCommand command1,
            ScheduleGetChannelIcalendarCommand command2,
            ScheduleGetChannelStreamScheduleCommand command3,
            ScheduleUpdateChannelStreamScheduleCommand command4,
            ScheduleUpdateChannelStreamScheduleSegmentCommand command5)
            : base(
                name: "schedule")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}