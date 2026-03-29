//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ConvertTextToSpeechCommand command0,
            CreateChatCompletionCommand command1,
            DetectLanguageCommand command2,
            TranscribeSpeechCommand command3,
            TranslateSpeechCommand command4,
            TranslateTextCommand command5,
            TransliterateTextCommand command6)
            : base(
                name: "")
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