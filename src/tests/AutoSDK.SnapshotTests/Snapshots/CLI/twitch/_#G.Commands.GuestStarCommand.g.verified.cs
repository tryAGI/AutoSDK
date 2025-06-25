//HintName: G.Commands.GuestStarCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuestStarCommand : global::System.CommandLine.Command
    {
        public GuestStarCommand(
            GetChannelGuestStarSettingsCommand command0,
            UpdateChannelGuestStarSettingsCommand command1,
            GetGuestStarSessionCommand command2,
            CreateGuestStarSessionCommand command3,
            EndGuestStarSessionCommand command4,
            GetGuestStarInvitesCommand command5,
            SendGuestStarInviteCommand command6,
            DeleteGuestStarInviteCommand command7,
            AssignGuestStarSlotCommand command8,
            UpdateGuestStarSlotCommand command9,
            DeleteGuestStarSlotCommand command10,
            UpdateGuestStarSlotSettingsCommand command11)
            : base(
                name: "gueststar")
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