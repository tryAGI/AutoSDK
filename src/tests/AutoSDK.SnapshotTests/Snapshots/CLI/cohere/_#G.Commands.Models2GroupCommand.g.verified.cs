//HintName: G.Commands.Models2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Models2GroupCommand : global::System.CommandLine.Command
    {
        public Models2GroupCommand(
            Models2GetCommand command0,
            Models2ListCommand command1)
            : base(
                name: "models2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}