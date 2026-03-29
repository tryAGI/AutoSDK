//HintName: G.Commands.ManageGlossaryGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageGlossaryGroupCommand : global::System.CommandLine.Command
    {
        public ManageGlossaryGroupCommand(
            ManageGlossariesCreateGlossaryCommand command0,
            ManageGlossariesDeleteGlossaryCommand command1,
            ManageGlossariesGetGlossaryCommand command2,
            ManageGlossariesGetGlossaryEntriesCommand command3,
            ManageGlossariesListGlossariesCommand command4,
            ManageGlossariesListGlossaryLanguagesCommand command5)
            : base(
                name: "manageglossary")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}