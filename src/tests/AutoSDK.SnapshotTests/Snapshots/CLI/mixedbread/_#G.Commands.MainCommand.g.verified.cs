//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AdminGroupCommand command0,
            ApiKeyGroupCommand command1,
            BillingGroupCommand command2,
            CompletionGroupCommand command3,
            DataSourceGroupCommand command4,
            DeprecatedVectorStoreGroupCommand command5,
            ExtractionGroupCommand command6,
            FileGroupCommand command7,
            ParsingGroupCommand command8,
            SchemaGroupCommand command9,
            StoreGroupCommand command10)
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