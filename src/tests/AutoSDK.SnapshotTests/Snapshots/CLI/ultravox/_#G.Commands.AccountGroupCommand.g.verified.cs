//HintName: G.Commands.AccountGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AccountGroupCommand : global::System.CommandLine.Command
    {
        public AccountGroupCommand(
            AccountsListCommand command0,
            AccountsMeRetrieveCommand command1,
            AccountsMeBillingSubscriptionRetrieveCommand command2,
            AccountsMeUsageCallsRetrieveCommand command3)
            : base(
                name: "account")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}