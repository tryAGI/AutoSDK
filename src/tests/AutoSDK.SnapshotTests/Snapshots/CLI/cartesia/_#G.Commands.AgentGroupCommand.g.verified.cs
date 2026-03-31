//HintName: G.Commands.AgentGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentGroupCommand : global::System.CommandLine.Command
    {
        public AgentGroupCommand(
            AgentsAgentsAddMetricToAgentCommand command0,
            AgentsAgentsCreateMetricCommand command1,
            AgentsAgentsDeleteCommand command2,
            AgentsAgentsDownloadCallAudioCommand command3,
            AgentsAgentsExportMetricResultsCommand command4,
            AgentsAgentsGetCommand command5,
            AgentsAgentsGetCallCommand command6,
            AgentsAgentsGetDeploymentCommand command7,
            AgentsAgentsGetMetricCommand command8,
            AgentsAgentsListCommand command9,
            AgentsAgentsListCallsCommand command10,
            AgentsAgentsListDeploymentsCommand command11,
            AgentsAgentsListMetricResultsCommand command12,
            AgentsAgentsListMetricsCommand command13,
            AgentsAgentsPhoneNumbersCommand command14,
            AgentsAgentsRemoveMetricFromAgentCommand command15,
            AgentsAgentsTemplatesCommand command16,
            AgentsAgentsUpdateCommand command17)
            : base(
                name: "agent")
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
        }
    }
}