//HintName: G.Commands.ApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeyCommand : global::System.CommandLine.Command
    {
        public ApiKeyCommand(
            ApiKeysListCommand command0,
            ApiKeysCreateCommand command1,
            ApiKeysRetrieveCommand command2,
            ApiKeysUpdateCommand command3,
            ApiKeysPartialUpdateCommand command4,
            ApiKeysDestroyCommand command5)
            : base(
                name: "apikey")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}