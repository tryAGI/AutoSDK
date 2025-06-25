//HintName: G.Commands.AudioIsolationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioIsolationCommand : global::System.CommandLine.Command
    {
        public AudioIsolationCommand(
            CreateAudioIsolationCommand command0,
            CreateAudioIsolationStreamCommand command1)
            : base(
                name: "audioisolation")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}