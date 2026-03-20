//HintName: G.Commands.AccountGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AccountGroupCommand : global::System.CommandLine.Command
    {
        public AccountGroupCommand(
            AccountsAccountsListCommand command0,
            AccountsAccountsMeBillingSubscriptionRetrieveCommand command1,
            AccountsAccountsMeRetrieveCommand command2,
            AccountsAccountsMeUsageCallsRetrieveCommand command3)
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