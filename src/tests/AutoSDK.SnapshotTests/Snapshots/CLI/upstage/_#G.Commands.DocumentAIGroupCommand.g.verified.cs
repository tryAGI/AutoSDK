//HintName: G.Commands.DocumentAIGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DocumentAIGroupCommand : global::System.CommandLine.Command
    {
        public DocumentAIGroupCommand(
            DocumentAIDocumentOcrCommand command0,
            DocumentAIDocumentParseCommand command1,
            DocumentAILayoutAnalysisCommand command2)
            : base(
                name: "documentai")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}