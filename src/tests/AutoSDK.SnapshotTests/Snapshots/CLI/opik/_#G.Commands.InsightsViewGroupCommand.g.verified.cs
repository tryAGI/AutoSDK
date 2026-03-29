//HintName: G.Commands.InsightsViewGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InsightsViewGroupCommand : global::System.CommandLine.Command
    {
        public InsightsViewGroupCommand(
            InsightsViewsCreateInsightsViewCommand command0,
            InsightsViewsDeleteInsightsViewCommand command1,
            InsightsViewsDeleteInsightsViewsBatchCommand command2,
            InsightsViewsFindInsightsViewsCommand command3,
            InsightsViewsGetInsightsViewByIdCommand command4,
            InsightsViewsUpdateInsightsViewCommand command5)
            : base(
                name: "insightsview")
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