//HintName: G.Commands.AutomationRuleEvaluatorGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AutomationRuleEvaluatorGroupCommand : global::System.CommandLine.Command
    {
        public AutomationRuleEvaluatorGroupCommand(
            AutomationRuleEvaluatorsCreateAutomationRuleEvaluatorCommand command0,
            AutomationRuleEvaluatorsDeleteAutomationRuleEvaluatorBatchCommand command1,
            AutomationRuleEvaluatorsFindEvaluatorsCommand command2,
            AutomationRuleEvaluatorsGetEvaluatorByIdCommand command3,
            AutomationRuleEvaluatorsGetEvaluatorLogsByIdCommand command4,
            AutomationRuleEvaluatorsUpdateAutomationRuleEvaluatorCommand command5)
            : base(
                name: "automationruleevaluator")
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