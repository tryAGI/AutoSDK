//HintName: G.Commands.MetricGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetricGroupCommand : global::System.CommandLine.Command
    {
        public MetricGroupCommand(
            MetricsListPipelineTriggerRecordsCommand command0,
            MetricsListPipelineTriggerChartRecordsCommand command1,
            MetricsListModelTriggerChartRecordsCommand command2,
            MetricsListCreditConsumptionChartRecordsCommand command3)
            : base(
                name: "metric")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}