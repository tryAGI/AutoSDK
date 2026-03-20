//HintName: G.Commands.ModerationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModerationGroupCommand : global::System.CommandLine.Command
    {
        public ModerationGroupCommand(
            ModerationAddBlockedTermCommand command0,
            ModerationAddChannelModeratorCommand command1,
            ModerationAddChannelVipCommand command2,
            ModerationBanUserCommand command3,
            ModerationCheckAutomodStatusCommand command4,
            ModerationDeleteChatMessagesCommand command5,
            ModerationGetAutomodSettingsCommand command6,
            ModerationGetBannedUsersCommand command7,
            ModerationGetBlockedTermsCommand command8,
            ModerationGetModeratedChannelsCommand command9,
            ModerationGetModeratorsCommand command10,
            ModerationGetShieldModeStatusCommand command11,
            ModerationGetUnbanRequestsCommand command12,
            ModerationGetVipsCommand command13,
            ModerationManageHeldAutomodMessagesCommand command14,
            ModerationRemoveBlockedTermCommand command15,
            ModerationRemoveChannelModeratorCommand command16,
            ModerationRemoveChannelVipCommand command17,
            ModerationResolveUnbanRequestsCommand command18,
            ModerationUnbanUserCommand command19,
            ModerationUpdateAutomodSettingsCommand command20,
            ModerationUpdateShieldModeStatusCommand command21)
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