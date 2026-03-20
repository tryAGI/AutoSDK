//HintName: G.Commands.SubscriptionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubscriptionGroupCommand : global::System.CommandLine.Command
    {
        public SubscriptionGroupCommand(
            SubscriptionsGetBroadcasterSubscriptionsCommand command0,
            SubscriptionsCheckUserSubscriptionCommand command1)
            : base(
                name: "subscription")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}