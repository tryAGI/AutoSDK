//HintName: G.Commands.ProjectGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectGroupCommand : global::System.CommandLine.Command
    {
        public ProjectGroupCommand(
            ProjectsCreateProjectCommand command0,
            ProjectsDeleteProjectByIdCommand command1,
            ProjectsDeleteProjectsBatchCommand command2,
            ProjectsFindAlertsByProjectCommand command3,
            ProjectsFindDashboardsByProjectCommand command4,
            ProjectsFindDatasetsByProjectCommand command5,
            ProjectsFindExperimentsByProjectCommand command6,
            ProjectsFindFeedbackScoreNamesByProjectIdsCommand command7,
            ProjectsFindOptimizationsByProjectCommand command8,
            ProjectsFindProjectsCommand command9,
            ProjectsFindTokenUsageNamesCommand command10,
            ProjectsGetProjectByIdCommand command11,
            ProjectsGetProjectKpiCardsCommand command12,
            ProjectsGetProjectMetricsCommand command13,
            ProjectsGetProjectStatsCommand command14,
            ProjectsGetPromptsByProjectCommand command15,
            ProjectsRetrieveProjectCommand command16,
            ProjectsUpdateProjectCommand command17)
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
        }
    }
}