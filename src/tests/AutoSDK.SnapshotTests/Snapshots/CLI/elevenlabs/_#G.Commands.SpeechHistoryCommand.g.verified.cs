//HintName: G.Commands.SpeechHistoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpeechHistoryCommand : global::System.CommandLine.Command
    {
        public SpeechHistoryCommand(
            GetHistoryCommand command0,
            GetHistoryByHistoryItemIdCommand command1,
            DeleteHistoryByHistoryItemIdCommand command2,
            GetHistoryByHistoryItemIdAudioCommand command3,
            CreateHistoryDownloadCommand command4)
            : base(
                name: "speechhistory")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}