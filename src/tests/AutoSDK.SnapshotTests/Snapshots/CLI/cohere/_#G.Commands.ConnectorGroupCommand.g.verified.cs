//HintName: G.Commands.ConnectorGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConnectorGroupCommand : global::System.CommandLine.Command
    {
        public ConnectorGroupCommand(
            ConnectorsCreateCommand command0,
            ConnectorsDeleteCommand command1,
            ConnectorsGetCommand command2,
            ConnectorsListCommand command3,
            ConnectorsOAuthAuthorizeCommand command4,
            ConnectorsUpdateCommand command5)
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