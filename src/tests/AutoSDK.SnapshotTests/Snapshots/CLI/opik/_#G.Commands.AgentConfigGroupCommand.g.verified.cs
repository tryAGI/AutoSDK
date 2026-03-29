//HintName: G.Commands.AgentConfigGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigGroupCommand : global::System.CommandLine.Command
    {
        public AgentConfigGroupCommand(
            AgentConfigsCreateAgentConfigCommand command0,
            AgentConfigsCreateOrUpdateEnvsCommand command1,
            AgentConfigsDeleteEnvCommand command2,
            AgentConfigsGetBlueprintByEnvCommand command3,
            AgentConfigsGetBlueprintByIdCommand command4,
            AgentConfigsGetBlueprintByNameCommand command5,
            AgentConfigsGetBlueprintHistoryCommand command6,
            AgentConfigsGetDeltaByIdCommand command7,
            AgentConfigsGetLatestBlueprintCommand command8,
            AgentConfigsSetEnvByBlueprintNameCommand command9,
            AgentConfigsUpdateAgentConfigCommand command10)
            : base(
                name: "agentconfig")
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
        }
    }
}