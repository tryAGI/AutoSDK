//HintName: G.Commands.StartGeneratingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartGeneratingGroupCommand : global::System.CommandLine.Command
    {
        public StartGeneratingGroupCommand(
            StartGeneratingCreateCharacterPerformanceCommand command0,
            StartGeneratingCreateImageToVideoCommand command1,
            StartGeneratingCreateSoundEffectCommand command2,
            StartGeneratingCreateSpeechToSpeechCommand command3,
            StartGeneratingCreateTextToImageCommand command4,
            StartGeneratingCreateTextToSpeechCommand command5,
            StartGeneratingCreateTextToVideoCommand command6,
            StartGeneratingCreateVideoToVideoCommand command7,
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