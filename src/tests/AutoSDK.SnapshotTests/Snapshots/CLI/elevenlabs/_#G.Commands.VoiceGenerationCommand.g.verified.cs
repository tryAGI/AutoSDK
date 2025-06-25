//HintName: G.Commands.VoiceGenerationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceGenerationCommand : global::System.CommandLine.Command
    {
        public VoiceGenerationCommand(
            GetVoiceGenerationGenerateVoiceParametersCommand command0,
            CreateVoiceGenerationGenerateVoiceCommand command1,
            CreateVoiceGenerationCreateVoiceCommand command2)
            : base(
                name: "voicegeneration")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}