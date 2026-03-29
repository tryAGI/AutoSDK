//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AdminApiGroupCommand command0,
            ManageGlossaryGroupCommand command1,
            ManageMultilingualGlossaryGroupCommand command2,
            MetaInformationGroupCommand command3,
            RephraseTextGroupCommand command4,
            StyleRuleGroupCommand command5,
            TranslateDocumentGroupCommand command6,
            TranslateTextGroupCommand command7,
            VoiceAPIGroupCommand command8)
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