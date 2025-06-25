//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            RootCommand command0,
            SchemaCommand command1,
            ObjectCommand command2,
            BatchCommand command3,
            BackupCommand command4,
            MetaCommand command5,
            ClusterCommand command6,
            NodeCommand command7,
            WellKnownCommand command8,
            GraphqlCommand command9,
            ClassificationCommand command10)
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
            Subcommands.Add(command9);
            Subcommands.Add(command10);
        }
    }
}