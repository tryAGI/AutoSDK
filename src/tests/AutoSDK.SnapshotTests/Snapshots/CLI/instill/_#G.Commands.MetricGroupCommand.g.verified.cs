//HintName: G.Commands.MetricGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetricGroupCommand : global::System.CommandLine.Command
    {
        public MetricGroupCommand(
            MetricsListCreditConsumptionChartRecordsCommand command0,
            MetricsListModelTriggerChartRecordsCommand command1,
            MetricsListPipelineTriggerChartRecordsCommand command2,
            MetricsListPipelineTriggerRecordsCommand command3)
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