//HintName: G.Commands.SubscriptionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubscriptionGroupCommand : global::System.CommandLine.Command
    {
        public SubscriptionGroupCommand(
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