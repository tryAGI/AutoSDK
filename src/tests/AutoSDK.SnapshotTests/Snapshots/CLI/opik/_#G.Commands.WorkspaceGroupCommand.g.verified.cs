//HintName: G.Commands.WorkspaceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WorkspaceGroupCommand : global::System.CommandLine.Command
    {
        public WorkspaceGroupCommand(
            WorkspacesCostsSummaryCommand command0,
            WorkspacesDeleteWorkspaceConfigurationCommand command1,
            WorkspacesGetCostCommand command2,
            WorkspacesGetMetricCommand command3,
            WorkspacesGetWorkspaceConfigurationCommand command4,
            WorkspacesGetWorkspaceVersionCommand command5,
            WorkspacesMetricsSummaryCommand command6,
            WorkspacesUpsertWorkspaceConfigurationCommand command7)
            : base(
                name: "workspace")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
        }
    }
}