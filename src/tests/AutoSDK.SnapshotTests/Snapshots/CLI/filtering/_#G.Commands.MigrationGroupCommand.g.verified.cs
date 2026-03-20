//HintName: G.Commands.MigrationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationGroupCommand : global::System.CommandLine.Command
    {
        public MigrationGroupCommand(
            MigrationsMigrationsCancelImportCommand command0,
            MigrationsMigrationsDeleteArchiveForAuthenticatedUserCommand command1,
            MigrationsMigrationsDeleteArchiveForOrgCommand command2,
            MigrationsMigrationsDownloadArchiveForOrgCommand command3,
            MigrationsMigrationsGetArchiveForAuthenticatedUserCommand command4,
            MigrationsMigrationsGetCommitAuthorsCommand command5,
            MigrationsMigrationsGetImportStatusCommand command6,
            MigrationsMigrationsGetLargeFilesCommand command7,
            MigrationsMigrationsGetStatusForAuthenticatedUserCommand command8,
            MigrationsMigrationsGetStatusForOrgCommand command9,
            MigrationsMigrationsListForAuthenticatedUserCommand command10,
            MigrationsMigrationsListForOrgCommand command11,
            MigrationsMigrationsListReposForAuthenticatedUserCommand command12,
            MigrationsMigrationsListReposForOrgCommand command13,
            MigrationsMigrationsMapCommitAuthorCommand command14,
            MigrationsMigrationsSetLfsPreferenceCommand command15,
            MigrationsMigrationsStartForAuthenticatedUserCommand command16,
            MigrationsMigrationsStartForOrgCommand command17,
            MigrationsMigrationsStartImportCommand command18,
            MigrationsMigrationsUnlockRepoForAuthenticatedUserCommand command19,
            MigrationsMigrationsUnlockRepoForOrgCommand command20,
            MigrationsMigrationsUpdateImportCommand command21)
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