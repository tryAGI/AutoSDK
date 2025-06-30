//HintName: G.Commands.EventSubGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EventSubGroupCommand : global::System.CommandLine.Command
    {
        public EventSubGroupCommand(
            CreateEventsubSubscriptionCommand command0,
            DeleteEventsubSubscriptionCommand command1,
            GetEventsubSubscriptionsCommand command2)
            : base(
                name: "eventsub")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}