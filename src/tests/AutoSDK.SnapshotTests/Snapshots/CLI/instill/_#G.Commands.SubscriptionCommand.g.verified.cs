//HintName: G.Commands.SubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubscriptionCommand : global::System.CommandLine.Command
    {
        public SubscriptionCommand(
            GetAuthenticatedUserSubscriptionCommand command0,
            GetOrganizationSubscriptionCommand command1,
            GetRemainingCreditCommand command2)
            : base(
                name: "subscription")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}