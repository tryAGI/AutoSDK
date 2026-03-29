//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AliasOperationsV2GroupCommand command0,
            CollectionOperationsV2GroupCommand command1,
            IndexOperationsV2GroupCommand command2,
            PartitionOperationsV2GroupCommand command3,
            RoleOperationsV2GroupCommand command4,
            UserOperationsV2GroupCommand command5,
            VectorOperationsV2GroupCommand command6)
            : base(
                description: "CLI tool")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}