﻿//HintName: G.Commands.VoiceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceGroupCommand : global::System.CommandLine.Command
    {
        public VoiceGroupCommand(
            VoicesListCommand command0,
            VoicesCreateCommand command1,
            VoicesRetrieveCommand command2,
            VoicesDestroyCommand command3)
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