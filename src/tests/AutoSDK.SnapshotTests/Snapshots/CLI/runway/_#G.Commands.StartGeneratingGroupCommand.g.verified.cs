//HintName: G.Commands.StartGeneratingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartGeneratingGroupCommand : global::System.CommandLine.Command
    {
        public StartGeneratingGroupCommand(
            CreateImageToVideoCommand command0,
            CreateTextToVideoCommand command1,
            CreateVideoToVideoCommand command2,
            CreateTextToImageCommand command3,
            CreateCharacterPerformanceCommand command4,
            CreateSoundEffectCommand command5,
            CreateSpeechToSpeechCommand command6,
            CreateTextToSpeechCommand command7,
            CreateVoiceDubbingCommand command8,
            CreateVoiceIsolationCommand command9)
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