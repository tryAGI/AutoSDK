//HintName: G.Commands.CodespaceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespaceCommand : global::System.CommandLine.Command
    {
        public CodespaceCommand(
            CodespacesListInOrganizationCommand command0,
            CodespacesSetCodespacesAccessCommand command1,
            CodespacesSetCodespacesAccessUsersCommand command2,
            CodespacesDeleteCodespacesAccessUsersCommand command3,
            CodespacesListOrgSecretsCommand command4,
            CodespacesGetOrgPublicKeyCommand command5,
            CodespacesGetOrgSecretCommand command6,
            CodespacesCreateOrUpdateOrgSecretCommand command7,
            CodespacesDeleteOrgSecretCommand command8,
            CodespacesListSelectedReposForOrgSecretCommand command9,
            CodespacesSetSelectedReposForOrgSecretCommand command10,
            CodespacesAddSelectedRepoToOrgSecretCommand command11,
            CodespacesRemoveSelectedRepoFromOrgSecretCommand command12,
            CodespacesGetCodespacesForUserInOrgCommand command13,
            CodespacesDeleteFromOrganizationCommand command14,
            CodespacesStopInOrganizationCommand command15,
            CodespacesListInRepositoryForAuthenticatedUserCommand command16,
            CodespacesCreateWithRepoForAuthenticatedUserCommand command17,
            CodespacesListDevcontainersInRepositoryForAuthenticatedUserCommand command18,
            CodespacesRepoMachinesForAuthenticatedUserCommand command19,
            CodespacesPreFlightWithRepoForAuthenticatedUserCommand command20,
            CodespacesCheckPermissionsForDevcontainerCommand command21,
            CodespacesListRepoSecretsCommand command22,
            CodespacesGetRepoPublicKeyCommand command23,
            CodespacesGetRepoSecretCommand command24,
            CodespacesCreateOrUpdateRepoSecretCommand command25,
            CodespacesDeleteRepoSecretCommand command26,
            CodespacesCreateWithPrForAuthenticatedUserCommand command27,
            CodespacesListForAuthenticatedUserCommand command28,
            CodespacesCreateForAuthenticatedUserCommand command29,
            CodespacesListSecretsForAuthenticatedUserCommand command30,
            CodespacesGetPublicKeyForAuthenticatedUserCommand command31,
            CodespacesGetSecretForAuthenticatedUserCommand command32,
            CodespacesCreateOrUpdateSecretForAuthenticatedUserCommand command33,
            CodespacesDeleteSecretForAuthenticatedUserCommand command34,
            CodespacesListRepositoriesForSecretForAuthenticatedUserCommand command35,
            CodespacesSetRepositoriesForSecretForAuthenticatedUserCommand command36,
            CodespacesAddRepositoryForSecretForAuthenticatedUserCommand command37,
            CodespacesRemoveRepositoryForSecretForAuthenticatedUserCommand command38,
            CodespacesGetForAuthenticatedUserCommand command39,
            CodespacesUpdateForAuthenticatedUserCommand command40,
            CodespacesDeleteForAuthenticatedUserCommand command41,
            CodespacesExportForAuthenticatedUserCommand command42,
            CodespacesGetExportDetailsForAuthenticatedUserCommand command43,
            CodespacesCodespaceMachinesForAuthenticatedUserCommand command44,
            CodespacesPublishForAuthenticatedUserCommand command45,
            CodespacesStartForAuthenticatedUserCommand command46,
            CodespacesStopForAuthenticatedUserCommand command47)
            : base(
                name: "codespace")
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
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
            Subcommands.Add(command33);
            Subcommands.Add(command34);
            Subcommands.Add(command35);
            Subcommands.Add(command36);
            Subcommands.Add(command37);
            Subcommands.Add(command38);
            Subcommands.Add(command39);
            Subcommands.Add(command40);
            Subcommands.Add(command41);
            Subcommands.Add(command42);
            Subcommands.Add(command43);
            Subcommands.Add(command44);
            Subcommands.Add(command45);
            Subcommands.Add(command46);
            Subcommands.Add(command47);
        }
    }
}