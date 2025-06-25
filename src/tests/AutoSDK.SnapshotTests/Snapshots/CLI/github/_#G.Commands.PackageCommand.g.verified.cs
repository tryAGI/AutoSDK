//HintName: G.Commands.PackageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackageCommand : global::System.CommandLine.Command
    {
        public PackageCommand(
            PackagesListDockerMigrationConflictingPackagesForOrganizationCommand command0,
            PackagesListPackagesForOrganizationCommand command1,
            PackagesGetPackageForOrganizationCommand command2,
            PackagesDeletePackageForOrgCommand command3,
            PackagesRestorePackageForOrgCommand command4,
            PackagesGetAllPackageVersionsForPackageOwnedByOrgCommand command5,
            PackagesGetPackageVersionForOrganizationCommand command6,
            PackagesDeletePackageVersionForOrgCommand command7,
            PackagesRestorePackageVersionForOrgCommand command8,
            PackagesListDockerMigrationConflictingPackagesForAuthenticatedUserCommand command9,
            PackagesListPackagesForAuthenticatedUserCommand command10,
            PackagesGetPackageForAuthenticatedUserCommand command11,
            PackagesDeletePackageForAuthenticatedUserCommand command12,
            PackagesRestorePackageForAuthenticatedUserCommand command13,
            PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserCommand command14,
            PackagesGetPackageVersionForAuthenticatedUserCommand command15,
            PackagesDeletePackageVersionForAuthenticatedUserCommand command16,
            PackagesRestorePackageVersionForAuthenticatedUserCommand command17,
            PackagesListDockerMigrationConflictingPackagesForUserCommand command18,
            PackagesListPackagesForUserCommand command19,
            PackagesGetPackageForUserCommand command20,
            PackagesDeletePackageForUserCommand command21,
            PackagesRestorePackageForUserCommand command22,
            PackagesGetAllPackageVersionsForPackageOwnedByUserCommand command23,
            PackagesGetPackageVersionForUserCommand command24,
            PackagesDeletePackageVersionForUserCommand command25,
            PackagesRestorePackageVersionForUserCommand command26)
            : base(
                name: "package")
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
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
        }
    }
}