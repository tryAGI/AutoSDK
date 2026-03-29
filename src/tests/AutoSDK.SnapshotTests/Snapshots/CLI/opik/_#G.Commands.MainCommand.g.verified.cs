//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AgentConfigGroupCommand command0,
            AlertGroupCommand command1,
            AnnotationQueueGroupCommand command2,
            AssistantSidebarGroupCommand command3,
            AttachmentGroupCommand command4,
            AutomationRuleEvaluatorGroupCommand command5,
            ChatCompletionGroupCommand command6,
            CheckGroupCommand command7,
            DashboardGroupCommand command8,
            DatasetGroupCommand command9,
            ExperimentGroupCommand command10,
            FeedbackDefinitionGroupCommand command11,
            GuardrailGroupCommand command12,
            InsightsViewGroupCommand command13,
            LlmModelGroupCommand command14,
            LlmProviderKeyGroupCommand command15,
            ManualEvaluationGroupCommand command16,
            OllamaGroupCommand command17,
            OllieStateGroupCommand command18,
            OpenTelemetryIngestionGroupCommand command19,
            OptimizationGroupCommand command20,
            ProjectGroupCommand command21,
            PromptGroupCommand command22,
            RedirectGroupCommand command23,
            RetentionRuleGroupCommand command24,
            RunnerGroupCommand command25,
            ServiceToggleGroupCommand command26,
            SpanGroupCommand command27,
            SystemUsageGroupCommand command28,
            TraceGroupCommand command29,
            WelcomeWizardGroupCommand command30,
            WorkspaceGroupCommand command31,
            WorkspacePermissionGroupCommand command32)
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
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
        }
    }
}