//HintName: G.Commands.ModerationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModerationGroupCommand : global::System.CommandLine.Command
    {
        public ModerationGroupCommand(
            ModerationCheckAutomodStatusCommand command0,
            ModerationManageHeldAutomodMessagesCommand command1,
            ModerationGetAutomodSettingsCommand command2,
            ModerationUpdateAutomodSettingsCommand command3,
            ModerationGetBannedUsersCommand command4,
            ModerationBanUserCommand command5,
            ModerationUnbanUserCommand command6,
            ModerationGetUnbanRequestsCommand command7,
            ModerationResolveUnbanRequestsCommand command8,
            ModerationGetBlockedTermsCommand command9,
            ModerationAddBlockedTermCommand command10,
            ModerationRemoveBlockedTermCommand command11,
            ModerationDeleteChatMessagesCommand command12,
            ModerationGetModeratedChannelsCommand command13,
            ModerationGetModeratorsCommand command14,
            ModerationAddChannelModeratorCommand command15,
            ModerationRemoveChannelModeratorCommand command16,
            ModerationGetVipsCommand command17,
            ModerationAddChannelVipCommand command18,
            ModerationRemoveChannelVipCommand command19,
            ModerationUpdateShieldModeStatusCommand command20,
            ModerationGetShieldModeStatusCommand command21)
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