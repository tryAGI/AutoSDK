//HintName: G.Commands.ProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectCommand : global::System.CommandLine.Command
    {
        public ProjectCommand(
            ListProjectsCommand command0,
            CreateProjectCommand command1,
            RetrieveProjectCommand command2,
            ModifyProjectCommand command3,
            ListProjectApiKeysCommand command4,
            RetrieveProjectApiKeyCommand command5,
            DeleteProjectApiKeyCommand command6,
            ArchiveProjectCommand command7,
            ListProjectRateLimitsCommand command8,
            UpdateProjectRateLimitsCommand command9,
            ListProjectServiceAccountsCommand command10,
            CreateProjectServiceAccountCommand command11,
            RetrieveProjectServiceAccountCommand command12,
            DeleteProjectServiceAccountCommand command13,
            ListProjectUsersCommand command14,
            CreateProjectUserCommand command15,
            RetrieveProjectUserCommand command16,
            ModifyProjectUserCommand command17,
            DeleteProjectUserCommand command18)
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
        }
    }
}