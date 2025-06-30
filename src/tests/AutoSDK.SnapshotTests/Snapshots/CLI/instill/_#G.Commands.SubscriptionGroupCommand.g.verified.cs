//HintName: G.Commands.SubscriptionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubscriptionGroupCommand : global::System.CommandLine.Command
    {
        public SubscriptionGroupCommand(
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