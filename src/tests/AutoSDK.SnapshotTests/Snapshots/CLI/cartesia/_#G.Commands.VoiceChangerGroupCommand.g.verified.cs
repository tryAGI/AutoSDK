//HintName: G.Commands.VoiceChangerGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceChangerGroupCommand : global::System.CommandLine.Command
    {
        public VoiceChangerGroupCommand(
            VoiceChangerVoiceChangerBytesCommand command0,
            VoiceChangerVoiceChangerSseCommand command1)
            : base(
                name: "voicechanger")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}