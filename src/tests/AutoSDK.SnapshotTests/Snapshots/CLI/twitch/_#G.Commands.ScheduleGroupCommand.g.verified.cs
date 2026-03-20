//HintName: G.Commands.ScheduleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ScheduleGroupCommand : global::System.CommandLine.Command
    {
        public ScheduleGroupCommand(
            ScheduleGetChannelStreamScheduleCommand command0,
            ScheduleGetChannelIcalendarCommand command1,
            ScheduleUpdateChannelStreamScheduleCommand command2,
            ScheduleCreateChannelStreamScheduleSegmentCommand command3,
            ScheduleUpdateChannelStreamScheduleSegmentCommand command4,
            ScheduleDeleteChannelStreamScheduleSegmentCommand command5)
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