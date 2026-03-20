//HintName: G.Commands.RealtimeGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RealtimeGroupCommand : global::System.CommandLine.Command
    {
        public RealtimeGroupCommand(
            RealtimeCreateTemporaryTokenCommand command0)
            : base(
                name: "realtime")
        {
            Subcommands.Add(command0);
        }
    }
}