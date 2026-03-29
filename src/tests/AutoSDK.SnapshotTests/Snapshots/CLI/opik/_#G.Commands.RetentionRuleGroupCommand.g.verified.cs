//HintName: G.Commands.RetentionRuleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetentionRuleGroupCommand : global::System.CommandLine.Command
    {
        public RetentionRuleGroupCommand(
            RetentionRulesCreateRetentionRuleCommand command0,
            RetentionRulesDeactivateRetentionRuleCommand command1,
            RetentionRulesFindRetentionRulesCommand command2,
            RetentionRulesGetRetentionRuleByIdCommand command3)
            : base(
                name: "retentionrule")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}