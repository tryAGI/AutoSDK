//HintName: G.Commands.ManageMultilingualGlossaryGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossaryGroupCommand : global::System.CommandLine.Command
    {
        public ManageMultilingualGlossaryGroupCommand(
            ManageMultilingualGlossariesCreateMultilingualGlossaryCommand command0,
            ManageMultilingualGlossariesDeleteDictionaryCommand command1,
            ManageMultilingualGlossariesDeleteMultilingualGlossaryCommand command2,
            ManageMultilingualGlossariesGetMultilingualGlossaryCommand command3,
            ManageMultilingualGlossariesGetMultilingualGlossaryEntriesCommand command4,
            ManageMultilingualGlossariesListMultilingualGlossariesCommand command5,
            ManageMultilingualGlossariesPatchMultilingualGlossaryCommand command6,
            ManageMultilingualGlossariesReplaceDictionaryCommand command7)
            : base(
                name: "managemultilingualglossary")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
        }
    }
}