//HintName: G.Commands.Connectors2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Connectors2GroupCommand : global::System.CommandLine.Command
    {
        public Connectors2GroupCommand(
            Connectors2ListCommand command0,
            Connectors2CreateCommand command1,
            Connectors2GetCommand command2,
            Connectors2UpdateCommand command3,
            Connectors2DeleteCommand command4,
            Connectors2OAuthAuthorizeCommand command5)
            : base(
                name: "connectors2")
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