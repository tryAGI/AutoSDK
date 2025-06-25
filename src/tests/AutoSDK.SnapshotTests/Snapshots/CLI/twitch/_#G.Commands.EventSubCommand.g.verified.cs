//HintName: G.Commands.EventSubCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EventSubCommand : global::System.CommandLine.Command
    {
        public EventSubCommand(
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