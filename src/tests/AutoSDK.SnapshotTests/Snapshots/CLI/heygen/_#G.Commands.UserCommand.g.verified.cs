//HintName: G.Commands.UserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserCommand : global::System.CommandLine.Command
    {
        public UserCommand(
            V2UserRemainingQuotaCommand command0)
            : base(
                name: "user")
        {
            Subcommands.Add(command0);
        }
    }
}