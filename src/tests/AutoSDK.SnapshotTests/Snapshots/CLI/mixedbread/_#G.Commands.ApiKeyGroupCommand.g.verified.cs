//HintName: G.Commands.ApiKeyGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeyGroupCommand : global::System.CommandLine.Command
    {
        public ApiKeyGroupCommand(
            ApiKeysCreateApiKeyCommand command0,
            ApiKeysDeleteApiKeyCommand command1,
            ApiKeysListApiKeysCommand command2,
            ApiKeysRerollApiKeyCommand command3,
            ApiKeysRetrieveApiKeyCommand command4,
            ApiKeysRevokeApiKeyCommand command5,
            ApiKeysUpdateApiKeyCommand command6)
            : base(
                name: "apikey")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}