//HintName: G.Commands.TranslateDocumentGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateDocumentGroupCommand : global::System.CommandLine.Command
    {
        public TranslateDocumentGroupCommand(
            TranslateDocumentsDownloadDocumentCommand command0,
            TranslateDocumentsGetDocumentStatusCommand command1,
            TranslateDocumentsTranslateDocumentCommand command2)
            : base(
                name: "translatedocument")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}