//HintName: G.Commands.OllamaGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OllamaGroupCommand : global::System.CommandLine.Command
    {
        public OllamaGroupCommand(
            OllamaListModelsCommand command0,
            OllamaTestConnectionCommand command1)
            : base(
                name: "ollama")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}