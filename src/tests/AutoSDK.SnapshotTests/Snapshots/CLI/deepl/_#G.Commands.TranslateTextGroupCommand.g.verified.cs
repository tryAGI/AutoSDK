//HintName: G.Commands.TranslateTextGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateTextGroupCommand : global::System.CommandLine.Command
    {
        public TranslateTextGroupCommand(
            TranslateTextTranslateTextCommand command0)
            : base(
                name: "translatetext")
        {
            Subcommands.Add(command0);
        }
    }
}