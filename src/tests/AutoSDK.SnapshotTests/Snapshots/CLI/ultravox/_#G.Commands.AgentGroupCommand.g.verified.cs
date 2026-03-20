//HintName: G.Commands.AgentGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentGroupCommand : global::System.CommandLine.Command
    {
        public AgentGroupCommand(
            AgentsAgentsListCommand command0,
            AgentsAgentsCreateCommand command1,
            AgentsAgentsRetrieveCommand command2,
            AgentsAgentsPartialUpdateCommand command3,
            AgentsAgentsDestroyCommand command4,
            AgentsAgentsCallsListCommand command5,
            AgentsAgentsCallsCreateCommand command6)
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
        }
    }
}