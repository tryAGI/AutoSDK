//HintName: G.Commands.ConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConnectorCommand : global::System.CommandLine.Command
    {
        public ConnectorCommand(
            ListConnectorsCommand command0,
            CreateConnectorCommand command1,
            DeleteConnectorCommand command2,
            GetConnectorCommand command3,
            UpdateConnectorCommand command4,
            OAuthAuthorizeConnectorCommand command5)
            : base(
                name: "connector")
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