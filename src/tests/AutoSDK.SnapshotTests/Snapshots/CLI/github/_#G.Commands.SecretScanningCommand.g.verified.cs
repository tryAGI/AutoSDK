//HintName: G.Commands.SecretScanningCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecretScanningCommand : global::System.CommandLine.Command
    {
        public SecretScanningCommand(
            SecretScanningListAlertsForEnterpriseCommand command0,
            SecretScanningListAlertsForOrgCommand command1,
            SecretScanningListAlertsForRepoCommand command2,
            SecretScanningGetAlertCommand command3,
            SecretScanningUpdateAlertCommand command4,
            SecretScanningListLocationsForAlertCommand command5,
            SecretScanningCreatePushProtectionBypassCommand command6)
            : base(
                name: "secretscanning")
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