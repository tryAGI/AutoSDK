//HintName: G.Commands.SampleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SampleCommand : global::System.CommandLine.Command
    {
        public SampleCommand(
            DeleteVoicesByVoiceIdSamplesBySampleIdCommand command0,
            GetVoicesByVoiceIdSamplesBySampleIdAudioCommand command1)
            : base(
                name: "sample")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}