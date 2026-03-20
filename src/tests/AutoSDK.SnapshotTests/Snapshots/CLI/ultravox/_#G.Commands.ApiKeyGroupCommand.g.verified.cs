//HintName: G.Commands.ApiKeyGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeyGroupCommand : global::System.CommandLine.Command
    {
        public ApiKeyGroupCommand(
            ApiKeysApiKeysCreateCommand command0,
            ApiKeysApiKeysDestroyCommand command1,
            ApiKeysApiKeysListCommand command2,
            ApiKeysApiKeysPartialUpdateCommand command3,
            ApiKeysApiKeysRetrieveCommand command4,
            ApiKeysApiKeysUpdateCommand command5)
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