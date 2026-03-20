//HintName: G.Commands.MigrationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationGroupCommand : global::System.CommandLine.Command
    {
        public MigrationGroupCommand(
            MigrationsMigrationsListForOrgCommand command0,
            MigrationsMigrationsStartForOrgCommand command1,
            MigrationsMigrationsGetStatusForOrgCommand command2,
            MigrationsMigrationsDownloadArchiveForOrgCommand command3,
            MigrationsMigrationsDeleteArchiveForOrgCommand command4,
            MigrationsMigrationsUnlockRepoForOrgCommand command5,
            MigrationsMigrationsListReposForOrgCommand command6,
            MigrationsMigrationsGetImportStatusCommand command7,
            MigrationsMigrationsStartImportCommand command8,
            MigrationsMigrationsUpdateImportCommand command9,
            MigrationsMigrationsCancelImportCommand command10,
            MigrationsMigrationsGetCommitAuthorsCommand command11,
            MigrationsMigrationsMapCommitAuthorCommand command12,
            MigrationsMigrationsGetLargeFilesCommand command13,
            MigrationsMigrationsSetLfsPreferenceCommand command14,
            MigrationsMigrationsListForAuthenticatedUserCommand command15,
            MigrationsMigrationsStartForAuthenticatedUserCommand command16,
            MigrationsMigrationsGetStatusForAuthenticatedUserCommand command17,
            MigrationsMigrationsGetArchiveForAuthenticatedUserCommand command18,
            MigrationsMigrationsDeleteArchiveForAuthenticatedUserCommand command19,
            MigrationsMigrationsUnlockRepoForAuthenticatedUserCommand command20,
            MigrationsMigrationsListReposForAuthenticatedUserCommand command21)
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