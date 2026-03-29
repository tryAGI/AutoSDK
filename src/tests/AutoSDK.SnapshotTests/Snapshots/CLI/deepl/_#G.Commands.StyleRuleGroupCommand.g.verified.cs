//HintName: G.Commands.StyleRuleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRuleGroupCommand : global::System.CommandLine.Command
    {
        public StyleRuleGroupCommand(
            StyleRulesCreateCustomInstructionCommand command0,
            StyleRulesCreateStyleRuleListCommand command1,
            StyleRulesDeleteCustomInstructionCommand command2,
            StyleRulesDeleteStyleRuleListCommand command3,
            StyleRulesGetCustomInstructionCommand command4,
            StyleRulesGetStyleRuleListCommand command5,
            StyleRulesGetStyleRuleListsCommand command6,
            StyleRulesUpdateCustomInstructionCommand command7,
            StyleRulesUpdateStyleRuleConfiguredRulesCommand command8,
            StyleRulesUpdateStyleRuleListCommand command9)
            : base(
                name: "stylerule")
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
        }
    }
}