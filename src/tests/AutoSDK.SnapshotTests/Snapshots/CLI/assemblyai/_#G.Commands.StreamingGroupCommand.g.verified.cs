//HintName: G.Commands.StreamingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingGroupCommand : global::System.CommandLine.Command
    {
        public StreamingGroupCommand(
            CreateTemporaryTokenCommand command0)
            : base(
                name: "streaming")
        {
            Subcommands.Add(command0);
        }
    }
}