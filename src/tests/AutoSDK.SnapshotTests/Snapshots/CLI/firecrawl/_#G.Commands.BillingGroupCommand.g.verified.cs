//HintName: G.Commands.BillingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BillingGroupCommand : global::System.CommandLine.Command
    {
        public BillingGroupCommand(
            BillingGetCreditUsageCommand command0,
            BillingGetTokenUsageCommand command1)
            : base(
                name: "billing")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}