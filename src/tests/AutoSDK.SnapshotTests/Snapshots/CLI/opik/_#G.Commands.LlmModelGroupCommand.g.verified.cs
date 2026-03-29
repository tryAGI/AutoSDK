//HintName: G.Commands.LlmModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LlmModelGroupCommand : global::System.CommandLine.Command
    {
        public LlmModelGroupCommand(
            LlmModelsGetLlmModelsCommand command0)
            : base(
                name: "llmmodel")
        {
            Subcommands.Add(command0);
        }
    }
}