//HintName: G.Commands.AlertGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AlertGroupCommand : global::System.CommandLine.Command
    {
        public AlertGroupCommand(
            AlertsCreateAlertCommand command0,
            AlertsDeleteAlertBatchCommand command1,
            AlertsFindAlertsCommand command2,
            AlertsGetAlertByIdCommand command3,
            AlertsGetWebhookExamplesCommand command4,
            AlertsTestWebhookCommand command5,
            AlertsUpdateAlertCommand command6)
            : base(
                name: "alert")
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