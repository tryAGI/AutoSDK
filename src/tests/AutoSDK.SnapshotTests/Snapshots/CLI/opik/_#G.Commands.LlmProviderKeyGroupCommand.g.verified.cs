//HintName: G.Commands.LlmProviderKeyGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LlmProviderKeyGroupCommand : global::System.CommandLine.Command
    {
        public LlmProviderKeyGroupCommand(
            LlmProviderKeyDeleteLlmProviderApiKeysBatchCommand command0,
            LlmProviderKeyFindLlmProviderKeysCommand command1,
            LlmProviderKeyGetLlmProviderApiKeyByIdCommand command2,
            LlmProviderKeyStoreLlmProviderApiKeyCommand command3,
            LlmProviderKeyUpdateLlmProviderApiKeyCommand command4)
            : base(
                name: "llmproviderkey")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}