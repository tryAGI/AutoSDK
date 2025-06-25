//HintName: G.Commands.PronunciationDictionaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PronunciationDictionaryCommand : global::System.CommandLine.Command
    {
        public PronunciationDictionaryCommand(
            CreatePronunciationDictionariesAddFromFileCommand command0,
            CreatePronunciationDictionariesAddFromRulesCommand command1,
            CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesCommand command2,
            CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesCommand command3,
            GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadCommand command4,
            GetPronunciationDictionariesByPronunciationDictionaryIdCommand command5,
            GetPronunciationDictionariesCommand command6)
            : base(
                name: "pronunciationdictionary")
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