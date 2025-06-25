//HintName: G.Commands.StreamingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingCommand : global::System.CommandLine.Command
    {
        public StreamingCommand(
            CreateTemporaryTokenCommand command0)
            : base(
                name: "streaming")
        {
            Subcommands.Add(command0);
        }
    }
}