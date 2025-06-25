//HintName: G.Commands.StreamingAPICommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingAPICommand : global::System.CommandLine.Command
    {
        public StreamingAPICommand(
            StreamingNewCommand command0,
            StreamingStartCommand command1,
            StreamingListCommand command2,
            StreamingIceCommand command3,
            StreamingTaskCommand command4,
            StreamingStopCommand command5,
            StreamingInterruptCommand command6,
            StreamingCreateTokenCommand command7,
            StreamingAvatarListCommand command8)
            : base(
                name: "streamingapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
        }
    }
}