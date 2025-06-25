//HintName: G.Commands.DependabotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotCommand : global::System.CommandLine.Command
    {
        public DependabotCommand(
            DependabotListAlertsForEnterpriseCommand command0,
            DependabotListAlertsForOrgCommand command1,
            DependabotListOrgSecretsCommand command2,
            DependabotGetOrgPublicKeyCommand command3,
            DependabotGetOrgSecretCommand command4,
            DependabotCreateOrUpdateOrgSecretCommand command5,
            DependabotDeleteOrgSecretCommand command6,
            DependabotListSelectedReposForOrgSecretCommand command7,
            DependabotSetSelectedReposForOrgSecretCommand command8,
            DependabotAddSelectedRepoToOrgSecretCommand command9,
            DependabotRemoveSelectedRepoFromOrgSecretCommand command10,
            DependabotListAlertsForRepoCommand command11,
            DependabotGetAlertCommand command12,
            DependabotUpdateAlertCommand command13,
            DependabotListRepoSecretsCommand command14,
            DependabotGetRepoPublicKeyCommand command15,
            DependabotGetRepoSecretCommand command16,
            DependabotCreateOrUpdateRepoSecretCommand command17,
            DependabotDeleteRepoSecretCommand command18)
            : base(
                name: "dependabot")
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
            Subcommands.Add(command17);
            Subcommands.Add(command18);
        }
    }
}