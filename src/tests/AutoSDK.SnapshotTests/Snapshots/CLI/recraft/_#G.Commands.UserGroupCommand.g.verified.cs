//HintName: G.Commands.UserGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserGroupCommand : global::System.CommandLine.Command
    {
        public UserGroupCommand(
            GetCurrentUserCommand command0)
            : base(
                name: "user")
        {
            Subcommands.Add(command0);
        }
    }
}