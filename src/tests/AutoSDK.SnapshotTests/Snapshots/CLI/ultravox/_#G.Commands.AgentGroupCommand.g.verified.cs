//HintName: G.Commands.AgentGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentGroupCommand : global::System.CommandLine.Command
    {
        public AgentGroupCommand(
            AgentsAgentsCallsCreateCommand command0,
            AgentsAgentsCallsListCommand command1,
            AgentsAgentsCreateCommand command2,
            AgentsAgentsDestroyCommand command3,
            AgentsAgentsListCommand command4,
            AgentsAgentsPartialUpdateCommand command5,
            AgentsAgentsRetrieveCommand command6)
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