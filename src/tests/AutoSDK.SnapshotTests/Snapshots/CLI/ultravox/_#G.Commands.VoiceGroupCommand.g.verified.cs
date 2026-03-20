//HintName: G.Commands.VoiceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceGroupCommand : global::System.CommandLine.Command
    {
        public VoiceGroupCommand(
            VoicesVoicesCreateCommand command0,
            VoicesVoicesDestroyCommand command1,
            VoicesVoicesListCommand command2,
            VoicesVoicesRetrieveCommand command3)
            : base(
                name: "voice")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}