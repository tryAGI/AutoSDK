//HintName: G.Commands.Datasets2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Datasets2GroupCommand : global::System.CommandLine.Command
    {
        public Datasets2GroupCommand(
            Datasets2CreateCommand command0,
            Datasets2ListCommand command1,
            Datasets2GetUsageCommand command2,
            Datasets2GetCommand command3,
            Datasets2DeleteCommand command4)
            : base(
                name: "datasets2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}