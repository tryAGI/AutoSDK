//HintName: G.Commands.AgentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentCommand : global::System.CommandLine.Command
    {
        public AgentCommand(
            AgentsListCommand command0,
            AgentsCreateCommand command1,
            AgentsRetrieveCommand command2,
            AgentsPartialUpdateCommand command3,
            AgentsDestroyCommand command4,
            AgentsCallsListCommand command5,
            AgentsCallsCreateCommand command6)
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