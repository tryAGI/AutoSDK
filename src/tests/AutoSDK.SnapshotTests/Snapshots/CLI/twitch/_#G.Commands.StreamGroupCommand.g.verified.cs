//HintName: G.Commands.StreamGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamGroupCommand : global::System.CommandLine.Command
    {
        public StreamGroupCommand(
            StreamsCreateStreamMarkerCommand command0,
            StreamsGetFollowedStreamsCommand command1,
            StreamsGetStreamKeyCommand command2,
            StreamsGetStreamMarkersCommand command3,
            StreamsGetStreamsCommand command4)
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