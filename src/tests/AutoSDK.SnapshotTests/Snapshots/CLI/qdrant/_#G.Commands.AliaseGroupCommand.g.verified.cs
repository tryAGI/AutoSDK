//HintName: G.Commands.AliaseGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AliaseGroupCommand : global::System.CommandLine.Command
    {
        public AliaseGroupCommand(
            AliasesGetCollectionAliasesCommand command0,
            AliasesGetCollectionsAliasesCommand command1,
            AliasesUpdateAliasesCommand command2)
            : base(
                name: "aliase")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}