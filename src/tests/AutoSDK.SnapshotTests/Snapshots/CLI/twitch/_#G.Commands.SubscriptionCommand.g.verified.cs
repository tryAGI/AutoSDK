//HintName: G.Commands.SubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubscriptionCommand : global::System.CommandLine.Command
    {
        public SubscriptionCommand(
            GetBroadcasterSubscriptionsCommand command0,
            CheckUserSubscriptionCommand command1)
            : base(
                name: "subscription")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}