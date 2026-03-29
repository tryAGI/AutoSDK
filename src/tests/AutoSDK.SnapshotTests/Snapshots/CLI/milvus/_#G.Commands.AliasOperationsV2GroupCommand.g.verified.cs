//HintName: G.Commands.AliasOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AliasOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public AliasOperationsV2GroupCommand(
            AliasOperationsV2CreateVectordbAliasesAlterCommand command0,
            AliasOperationsV2CreateVectordbAliasesCreateCommand command1,
            AliasOperationsV2CreateVectordbAliasesDescribeCommand command2,
            AliasOperationsV2CreateVectordbAliasesDropCommand command3,
            AliasOperationsV2CreateVectordbAliasesListCommand command4)
            : base(
                name: "aliasoperationsv2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}