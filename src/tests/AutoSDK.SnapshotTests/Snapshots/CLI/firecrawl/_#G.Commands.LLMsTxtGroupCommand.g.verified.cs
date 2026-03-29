//HintName: G.Commands.LLMsTxtGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LLMsTxtGroupCommand : global::System.CommandLine.Command
    {
        public LLMsTxtGroupCommand(
            LLMsTxtGenerateLLMsTxtCommand command0,
            LLMsTxtGetLLMsTxtStatusCommand command1)
            : base(
                name: "llmstxt")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}