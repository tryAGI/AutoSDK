//HintName: G.Commands.UserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserCommand : global::System.CommandLine.Command
    {
        public UserCommand(
            GetUserSubscriptionCommand command0,
            GetUserCommand command1)
            : base(
                name: "user")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}