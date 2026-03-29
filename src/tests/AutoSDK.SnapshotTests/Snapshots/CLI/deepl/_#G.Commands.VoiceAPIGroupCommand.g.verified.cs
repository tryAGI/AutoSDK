//HintName: G.Commands.VoiceAPIGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceAPIGroupCommand : global::System.CommandLine.Command
    {
        public VoiceAPIGroupCommand(
            VoiceAPIGetVoiceStreamingUrlCommand command0,
            VoiceAPIRequestReconnectionCommand command1)
            : base(
                name: "voiceapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}