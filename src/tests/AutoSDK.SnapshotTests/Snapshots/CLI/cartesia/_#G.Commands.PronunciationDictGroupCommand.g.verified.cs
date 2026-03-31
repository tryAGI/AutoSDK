//HintName: G.Commands.PronunciationDictGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PronunciationDictGroupCommand : global::System.CommandLine.Command
    {
        public PronunciationDictGroupCommand(
            PronunciationDictsPronunciationDictsCreateCommand command0,
            PronunciationDictsPronunciationDictsDeleteCommand command1,
            PronunciationDictsPronunciationDictsGetCommand command2,
            PronunciationDictsPronunciationDictsListCommand command3,
            PronunciationDictsPronunciationDictsUpdateCommand command4)
            : base(
                name: "pronunciationdict")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}