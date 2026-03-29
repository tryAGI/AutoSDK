//HintName: G.Commands.DashboardGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DashboardGroupCommand : global::System.CommandLine.Command
    {
        public DashboardGroupCommand(
            DashboardsCreateDashboardCommand command0,
            DashboardsDeleteDashboardCommand command1,
            DashboardsDeleteDashboardsBatchCommand command2,
            DashboardsFindDashboardsCommand command3,
            DashboardsGetDashboardByIdCommand command4,
            DashboardsUpdateDashboardCommand command5)
            : base(
                name: "dashboard")
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