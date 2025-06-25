//HintName: G.Commands.CodeScanningCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningCommand : global::System.CommandLine.Command
    {
        public CodeScanningCommand(
            CodeScanningListAlertsForOrgCommand command0,
            CodeScanningListAlertsForRepoCommand command1,
            CodeScanningGetAlertCommand command2,
            CodeScanningUpdateAlertCommand command3,
            CodeScanningListAlertInstancesCommand command4,
            CodeScanningListRecentAnalysesCommand command5,
            CodeScanningGetAnalysisCommand command6,
            CodeScanningDeleteAnalysisCommand command7,
            CodeScanningListCodeqlDatabasesCommand command8,
            CodeScanningGetCodeqlDatabaseCommand command9,
            CodeScanningCreateVariantAnalysisCommand command10,
            CodeScanningGetVariantAnalysisCommand command11,
            CodeScanningGetVariantAnalysisRepoTaskCommand command12,
            CodeScanningGetDefaultSetupCommand command13,
            CodeScanningUpdateDefaultSetupCommand command14,
            CodeScanningUploadSarifCommand command15,
            CodeScanningGetSarifCommand command16)
            : base(
                name: "codescanning")
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
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
        }
    }
}