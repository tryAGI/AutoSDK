//HintName: G.Commands.StartGeneratingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartGeneratingGroupCommand : global::System.CommandLine.Command
    {
        public StartGeneratingGroupCommand(
            StartGeneratingCreateImageToVideoCommand command0,
            StartGeneratingCreateTextToVideoCommand command1,
            StartGeneratingCreateVideoToVideoCommand command2,
            StartGeneratingCreateTextToImageCommand command3,
            StartGeneratingCreateCharacterPerformanceCommand command4,
            StartGeneratingCreateSoundEffectCommand command5,
            StartGeneratingCreateSpeechToSpeechCommand command6,
            StartGeneratingCreateTextToSpeechCommand command7,
            StartGeneratingCreateVoiceDubbingCommand command8,
            StartGeneratingCreateVoiceIsolationCommand command9)
            : base(
                name: "startgenerating")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
        }
    }
}