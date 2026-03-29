//HintName: G.Commands.TranslationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslationGroupCommand : global::System.CommandLine.Command
    {
        public TranslationGroupCommand(
            TranslationTranslateCommand command0)
            : base(
                name: "translation")
        {
            Subcommands.Add(command0);
        }
    }
}