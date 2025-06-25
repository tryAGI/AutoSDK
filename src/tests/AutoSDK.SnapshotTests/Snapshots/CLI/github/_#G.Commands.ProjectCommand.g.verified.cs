//HintName: G.Commands.ProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectCommand : global::System.CommandLine.Command
    {
        public ProjectCommand(
            ProjectsListForOrgCommand command0,
            ProjectsCreateForOrgCommand command1,
            ProjectsGetCardCommand command2,
            ProjectsUpdateCardCommand command3,
            ProjectsDeleteCardCommand command4,
            ProjectsMoveCardCommand command5,
            ProjectsGetColumnCommand command6,
            ProjectsUpdateColumnCommand command7,
            ProjectsDeleteColumnCommand command8,
            ProjectsListCardsCommand command9,
            ProjectsCreateCardCommand command10,
            ProjectsMoveColumnCommand command11,
            ProjectsGetCommand command12,
            ProjectsUpdateCommand command13,
            ProjectsDeleteCommand command14,
            ProjectsListCollaboratorsCommand command15,
            ProjectsAddCollaboratorCommand command16,
            ProjectsRemoveCollaboratorCommand command17,
            ProjectsGetPermissionForUserCommand command18,
            ProjectsListColumnsCommand command19,
            ProjectsCreateColumnCommand command20,
            ProjectsListForRepoCommand command21,
            ProjectsCreateForRepoCommand command22,
            ProjectsCreateForAuthenticatedUserCommand command23,
            ProjectsListForUserCommand command24)
            : base(
                name: "project")
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
        }
    }
}