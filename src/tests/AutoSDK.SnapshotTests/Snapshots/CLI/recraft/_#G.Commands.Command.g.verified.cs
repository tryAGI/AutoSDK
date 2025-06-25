//HintName: G.Commands.Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Command : global::System.CommandLine.Command
    {
        public Command(
            GetPingCommand command0)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
        }
    }
}