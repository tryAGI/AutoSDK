//HintName: G.Commands.ConnectorGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConnectorGroupCommand : global::System.CommandLine.Command
    {
        public ConnectorGroupCommand(
            ListConnectorsCommand command0,
            CreateConnectorCommand command1,
            GetConnectorCommand command2,
            UpdateConnectorCommand command3,
            DeleteConnectorCommand command4,
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