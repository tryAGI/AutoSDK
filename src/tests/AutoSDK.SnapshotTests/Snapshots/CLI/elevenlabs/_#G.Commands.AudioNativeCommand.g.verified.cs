//HintName: G.Commands.AudioNativeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioNativeCommand : global::System.CommandLine.Command
    {
        public AudioNativeCommand(
            CreateAudioNativeCommand command0,
            GetAudioNativeByProjectIdSettingsCommand command1,
            CreateAudioNativeByProjectIdContentCommand command2)
            : base(
                name: "audionative")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}