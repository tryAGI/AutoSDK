//HintName: G.Commands.AuthenticationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AuthenticationGroupCommand : global::System.CommandLine.Command
    {
        public AuthenticationGroupCommand(
            AuthenticationGetUserIdentityCommand command0)
            : base(
                name: "authentication")
        {
            Subcommands.Add(command0);
        }
    }
}