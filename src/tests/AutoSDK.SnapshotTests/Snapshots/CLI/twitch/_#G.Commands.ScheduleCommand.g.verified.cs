//HintName: G.Commands.ScheduleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ScheduleCommand : global::System.CommandLine.Command
    {
        public ScheduleCommand(
            GetChannelStreamScheduleCommand command0,
            GetChannelIcalendarCommand command1,
            UpdateChannelStreamScheduleCommand command2,
            CreateChannelStreamScheduleSegmentCommand command3,
            UpdateChannelStreamScheduleSegmentCommand command4,
            DeleteChannelStreamScheduleSegmentCommand command5)
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