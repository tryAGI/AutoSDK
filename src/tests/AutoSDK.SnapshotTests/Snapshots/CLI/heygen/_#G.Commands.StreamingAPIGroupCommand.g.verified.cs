//HintName: G.Commands.StreamingApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingApiGroupCommand : global::System.CommandLine.Command
    {
        public StreamingApiGroupCommand(
            StreamingApiStreamingNewCommand command0,
            StreamingApiStreamingStartCommand command1,
            StreamingApiStreamingListCommand command2,
            StreamingApiStreamingIceCommand command3,
            StreamingApiStreamingTaskCommand command4,
            StreamingApiStreamingStopCommand command5,
            StreamingApiStreamingInterruptCommand command6,
            StreamingApiStreamingCreateTokenCommand command7,
            StreamingApiStreamingAvatarListCommand command8)
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