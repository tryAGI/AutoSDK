//HintName: G.Commands.ApiKeyGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeyGroupCommand : global::System.CommandLine.Command
    {
        public ApiKeyGroupCommand(
            ApiKeysApiKeysListCommand command0,
            ApiKeysApiKeysCreateCommand command1,
            ApiKeysApiKeysRetrieveCommand command2,
            ApiKeysApiKeysUpdateCommand command3,
            ApiKeysApiKeysPartialUpdateCommand command4,
            ApiKeysApiKeysDestroyCommand command5)
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