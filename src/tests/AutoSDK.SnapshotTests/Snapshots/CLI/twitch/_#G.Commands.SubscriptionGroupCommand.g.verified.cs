//HintName: G.Commands.SubscriptionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubscriptionGroupCommand : global::System.CommandLine.Command
    {
        public SubscriptionGroupCommand(
            SubscriptionsCheckUserSubscriptionCommand command0,
            SubscriptionsGetBroadcasterSubscriptionsCommand command1)
            : base(
                name: "subscription")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}