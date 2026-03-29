//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AliaseGroupCommand command0,
            BetaGroupCommand command1,
            CollectionGroupCommand command2,
            DistributedGroupCommand command3,
            IndexeGroupCommand command4,
            PointGroupCommand command5,
            SearchGroupCommand command6,
            ServiceGroupCommand command7,
            SnapshotGroupCommand command8)
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
            Subcommands.Add(command7);
            Subcommands.Add(command8);
        }
    }
}