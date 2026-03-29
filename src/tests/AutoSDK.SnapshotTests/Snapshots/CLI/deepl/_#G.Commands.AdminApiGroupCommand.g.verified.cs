//HintName: G.Commands.AdminApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiGroupCommand : global::System.CommandLine.Command
    {
        public AdminApiGroupCommand(
            AdminApiAdminCreateDeveloperKeyCommand command0,
            AdminApiAdminDeactivateDeveloperKeyCommand command1,
            AdminApiAdminGetAnalyticsCommand command2,
            AdminApiAdminGetDeveloperKeysCommand command3,
            AdminApiAdminRenameDeveloperKeyCommand command4,
            AdminApiAdminSetDeveloperKeyUsageLimitsCommand command5)
            : base(
                name: "adminapi")
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