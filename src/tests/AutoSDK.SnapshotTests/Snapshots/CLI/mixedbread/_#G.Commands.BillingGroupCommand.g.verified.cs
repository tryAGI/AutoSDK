//HintName: G.Commands.BillingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BillingGroupCommand : global::System.CommandLine.Command
    {
        public BillingGroupCommand(
            BillingGetBillingSummaryCommand command0,
            BillingGetParsingCostHistogramCommand command1,
            BillingGetStoreCostHistogramCommand command2,
            BillingListStoreCostInfoCommand command3)
            : base(
                name: "billing")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}