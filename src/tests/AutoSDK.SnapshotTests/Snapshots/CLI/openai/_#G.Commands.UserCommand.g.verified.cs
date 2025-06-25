//HintName: G.Commands.UserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserCommand : global::System.CommandLine.Command
    {
        public UserCommand(
            ListUsersCommand command0,
            RetrieveUserCommand command1,
            ModifyUserCommand command2,
            DeleteUserCommand command3)
            : base(
                name: "user")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}