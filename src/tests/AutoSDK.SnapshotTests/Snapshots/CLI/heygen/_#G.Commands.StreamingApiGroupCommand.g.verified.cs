//HintName: G.Commands.StreamingApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingApiGroupCommand : global::System.CommandLine.Command
    {
        public StreamingApiGroupCommand(
            StreamingApiStreamingAvatarListCommand command0,
            StreamingApiStreamingCreateTokenCommand command1,
            StreamingApiStreamingIceCommand command2,
            StreamingApiStreamingInterruptCommand command3,
            StreamingApiStreamingListCommand command4,
            StreamingApiStreamingNewCommand command5,
            StreamingApiStreamingStartCommand command6,
            StreamingApiStreamingStopCommand command7,
            StreamingApiStreamingTaskCommand command8)
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