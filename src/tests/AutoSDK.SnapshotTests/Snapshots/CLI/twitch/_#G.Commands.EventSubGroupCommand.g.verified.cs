//HintName: G.Commands.EventSubGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EventSubGroupCommand : global::System.CommandLine.Command
    {
        public EventSubGroupCommand(
            EventSubCreateEventsubSubscriptionCommand command0,
            EventSubDeleteEventsubSubscriptionCommand command1,
            EventSubGetEventsubSubscriptionsCommand command2)
            : base(
                name: "eventsub")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}