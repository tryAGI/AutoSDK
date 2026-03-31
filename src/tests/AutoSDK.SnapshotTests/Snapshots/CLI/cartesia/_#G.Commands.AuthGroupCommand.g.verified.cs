//HintName: G.Commands.AuthGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AuthGroupCommand : global::System.CommandLine.Command
    {
        public AuthGroupCommand(
            AuthAuthAccessTokenCommand command0)
            : base(
                name: "auth")
        {
            Subcommands.Add(command0);
        }
    }
}