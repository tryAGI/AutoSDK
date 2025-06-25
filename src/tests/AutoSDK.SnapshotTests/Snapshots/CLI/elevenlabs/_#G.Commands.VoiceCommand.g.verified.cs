//HintName: G.Commands.VoiceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceCommand : global::System.CommandLine.Command
    {
        public VoiceCommand(
            GetVoicesCommand command0,
            GetV2VoicesCommand command1,
            GetVoicesSettingsDefaultCommand command2,
            GetVoicesByVoiceIdSettingsCommand command3,
            GetVoicesByVoiceIdCommand command4,
            DeleteVoicesByVoiceIdCommand command5,
            CreateVoicesByVoiceIdSettingsEditCommand command6,
            CreateVoicesAddCommand command7,
            CreateVoicesByVoiceIdEditCommand command8,
            CreateVoicesAddByPublicUserIdByVoiceIdCommand command9,
            GetSharedVoicesCommand command10,
            CreateSimilarVoicesCommand command11)
            : base(
                name: "voice")
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
            Subcommands.Add(command10);
            Subcommands.Add(command11);
        }
    }
}