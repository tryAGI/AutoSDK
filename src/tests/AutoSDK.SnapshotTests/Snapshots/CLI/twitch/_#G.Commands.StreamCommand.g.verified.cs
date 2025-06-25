//HintName: G.Commands.StreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamCommand : global::System.CommandLine.Command
    {
        public StreamCommand(
            GetStreamKeyCommand command0,
            GetStreamsCommand command1,
            GetFollowedStreamsCommand command2,
            CreateStreamMarkerCommand command3,
            GetStreamMarkersCommand command4)
            : base(
                name: "stream")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}