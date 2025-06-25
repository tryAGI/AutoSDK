//HintName: G.Commands.MigrationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationCommand : global::System.CommandLine.Command
    {
        public MigrationCommand(
            MigrationsListForOrgCommand command0,
            MigrationsStartForOrgCommand command1,
            MigrationsGetStatusForOrgCommand command2,
            MigrationsDownloadArchiveForOrgCommand command3,
            MigrationsDeleteArchiveForOrgCommand command4,
            MigrationsUnlockRepoForOrgCommand command5,
            MigrationsListReposForOrgCommand command6,
            MigrationsGetImportStatusCommand command7,
            MigrationsStartImportCommand command8,
            MigrationsUpdateImportCommand command9,
            MigrationsCancelImportCommand command10,
            MigrationsGetCommitAuthorsCommand command11,
            MigrationsMapCommitAuthorCommand command12,
            MigrationsGetLargeFilesCommand command13,
            MigrationsSetLfsPreferenceCommand command14,
            MigrationsListForAuthenticatedUserCommand command15,
            MigrationsStartForAuthenticatedUserCommand command16,
            MigrationsGetStatusForAuthenticatedUserCommand command17,
            MigrationsGetArchiveForAuthenticatedUserCommand command18,
            MigrationsDeleteArchiveForAuthenticatedUserCommand command19,
            MigrationsUnlockRepoForAuthenticatedUserCommand command20,
            MigrationsListReposForAuthenticatedUserCommand command21)
            : base(
                name: "migration")
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
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
        }
    }
}