//HintName: G.Commands.VoiceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceGroupCommand : global::System.CommandLine.Command
    {
        public VoiceGroupCommand(
            VoicesVoicesCloneCommand command0,
            VoicesVoicesDeleteCommand command1,
            VoicesVoicesGetCommand command2,
            VoicesVoicesListCommand command3,
            VoicesVoicesLocalizeCommand command4,
            VoicesVoicesUpdateCommand command5)
            : base(
                name: "voice")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}