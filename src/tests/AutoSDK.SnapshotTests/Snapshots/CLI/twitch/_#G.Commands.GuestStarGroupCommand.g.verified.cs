//HintName: G.Commands.GuestStarGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuestStarGroupCommand : global::System.CommandLine.Command
    {
        public GuestStarGroupCommand(
            GuestStarGetChannelGuestStarSettingsCommand command0,
            GuestStarUpdateChannelGuestStarSettingsCommand command1,
            GuestStarGetGuestStarSessionCommand command2,
            GuestStarCreateGuestStarSessionCommand command3,
            GuestStarEndGuestStarSessionCommand command4,
            GuestStarGetGuestStarInvitesCommand command5,
            GuestStarSendGuestStarInviteCommand command6,
            GuestStarDeleteGuestStarInviteCommand command7,
            GuestStarAssignGuestStarSlotCommand command8,
            GuestStarUpdateGuestStarSlotCommand command9,
            GuestStarDeleteGuestStarSlotCommand command10,
            GuestStarUpdateGuestStarSlotSettingsCommand command11)
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