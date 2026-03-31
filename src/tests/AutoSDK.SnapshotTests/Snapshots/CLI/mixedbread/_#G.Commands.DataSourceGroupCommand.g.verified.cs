//HintName: G.Commands.DataSourceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourceGroupCommand : global::System.CommandLine.Command
    {
        public DataSourceGroupCommand(
            DataSourcesAuthorizeDataSourceCommand command0,
            DataSourcesCreateConnectorCommand command1,
            DataSourcesCreateDataSourceCommand command2,
            DataSourcesDeleteConnectorCommand command3,
            DataSourcesDeleteDataSourceCommand command4,
            DataSourcesGetConnectorCommand command5,
            DataSourcesGetDataSourceCommand command6,
            DataSourcesListConnectorsCommand command7,
            DataSourcesListDataSourcesCommand command8,
            DataSourcesOauth2CallbackCommand command9,
            DataSourcesUpdateConnectorCommand command10,
            DataSourcesUpdateDataSourceCommand command11)
            : base(
                name: "datasource")
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
        }
    }
}