//HintName: G.Commands.GuestStarGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuestStarGroupCommand : global::System.CommandLine.Command
    {
        public GuestStarGroupCommand(
            GuestStarAssignGuestStarSlotCommand command0,
            GuestStarCreateGuestStarSessionCommand command1,
            GuestStarDeleteGuestStarInviteCommand command2,
            GuestStarDeleteGuestStarSlotCommand command3,
            GuestStarEndGuestStarSessionCommand command4,
            GuestStarGetChannelGuestStarSettingsCommand command5,
            GuestStarGetGuestStarInvitesCommand command6,
            GuestStarGetGuestStarSessionCommand command7,
            GuestStarSendGuestStarInviteCommand command8,
            GuestStarUpdateChannelGuestStarSettingsCommand command9,
            GuestStarUpdateGuestStarSlotCommand command10,
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