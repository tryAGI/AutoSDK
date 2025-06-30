//HintName: G.Commands.ModerationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModerationGroupCommand : global::System.CommandLine.Command
    {
        public ModerationGroupCommand(
            CheckAutomodStatusCommand command0,
            ManageHeldAutomodMessagesCommand command1,
            GetAutomodSettingsCommand command2,
            UpdateAutomodSettingsCommand command3,
            GetBannedUsersCommand command4,
            BanUserCommand command5,
            UnbanUserCommand command6,
            GetUnbanRequestsCommand command7,
            ResolveUnbanRequestsCommand command8,
            GetBlockedTermsCommand command9,
            AddBlockedTermCommand command10,
            RemoveBlockedTermCommand command11,
            DeleteChatMessagesCommand command12,
            GetModeratedChannelsCommand command13,
            GetModeratorsCommand command14,
            AddChannelModeratorCommand command15,
            RemoveChannelModeratorCommand command16,
            GetVipsCommand command17,
            AddChannelVipCommand command18,
            RemoveChannelVipCommand command19,
            UpdateShieldModeStatusCommand command20,
            GetShieldModeStatusCommand command21)
            : base(
                name: "moderation")
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
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
        }
    }
}