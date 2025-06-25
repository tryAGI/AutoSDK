//HintName: G.Commands.SoundGenerationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SoundGenerationCommand : global::System.CommandLine.Command
    {
        public SoundGenerationCommand(
            CreateSoundGenerationCommand command0)
            : base(
                name: "soundgeneration")
        {
            Subcommands.Add(command0);
        }
    }
}