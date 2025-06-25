//HintName: G.Commands.MetricCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetricCommand : global::System.CommandLine.Command
    {
        public MetricCommand(
            ListPipelineTriggerRecordsCommand command0,
            ListPipelineTriggerChartRecordsCommand command1,
            ListModelTriggerChartRecordsCommand command2,
            ListCreditConsumptionChartRecordsCommand command3)
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