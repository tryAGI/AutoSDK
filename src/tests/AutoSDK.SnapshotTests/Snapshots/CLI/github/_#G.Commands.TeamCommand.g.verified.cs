//HintName: G.Commands.TeamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamCommand : global::System.CommandLine.Command
    {
        public TeamCommand(
            TeamsListCommand command0,
            TeamsCreateCommand command1,
            TeamsGetByNameCommand command2,
            TeamsUpdateInOrgCommand command3,
            TeamsDeleteInOrgCommand command4,
            TeamsListDiscussionsInOrgCommand command5,
            TeamsCreateDiscussionInOrgCommand command6,
            TeamsGetDiscussionInOrgCommand command7,
            TeamsUpdateDiscussionInOrgCommand command8,
            TeamsDeleteDiscussionInOrgCommand command9,
            TeamsListDiscussionCommentsInOrgCommand command10,
            TeamsCreateDiscussionCommentInOrgCommand command11,
            TeamsGetDiscussionCommentInOrgCommand command12,
            TeamsUpdateDiscussionCommentInOrgCommand command13,
            TeamsDeleteDiscussionCommentInOrgCommand command14,
            TeamsListPendingInvitationsInOrgCommand command15,
            TeamsListMembersInOrgCommand command16,
            TeamsGetMembershipForUserInOrgCommand command17,
            TeamsAddOrUpdateMembershipForUserInOrgCommand command18,
            TeamsRemoveMembershipForUserInOrgCommand command19,
            TeamsListProjectsInOrgCommand command20,
            TeamsCheckPermissionsForProjectInOrgCommand command21,
            TeamsAddOrUpdateProjectPermissionsInOrgCommand command22,
            TeamsRemoveProjectInOrgCommand command23,
            TeamsListReposInOrgCommand command24,
            TeamsCheckPermissionsForRepoInOrgCommand command25,
            TeamsAddOrUpdateRepoPermissionsInOrgCommand command26,
            TeamsRemoveRepoInOrgCommand command27,
            TeamsListChildInOrgCommand command28,
            TeamsGetLegacyCommand command29,
            TeamsUpdateLegacyCommand command30,
            TeamsDeleteLegacyCommand command31,
            TeamsListDiscussionsLegacyCommand command32,
            TeamsCreateDiscussionLegacyCommand command33,
            TeamsGetDiscussionLegacyCommand command34,
            TeamsUpdateDiscussionLegacyCommand command35,
            TeamsDeleteDiscussionLegacyCommand command36,
            TeamsListDiscussionCommentsLegacyCommand command37,
            TeamsCreateDiscussionCommentLegacyCommand command38,
            TeamsGetDiscussionCommentLegacyCommand command39,
            TeamsUpdateDiscussionCommentLegacyCommand command40,
            TeamsDeleteDiscussionCommentLegacyCommand command41,
            TeamsListPendingInvitationsLegacyCommand command42,
            TeamsListMembersLegacyCommand command43,
            TeamsGetMemberLegacyCommand command44,
            TeamsAddMemberLegacyCommand command45,
            TeamsRemoveMemberLegacyCommand command46,
            TeamsGetMembershipForUserLegacyCommand command47,
            TeamsAddOrUpdateMembershipForUserLegacyCommand command48,
            TeamsRemoveMembershipForUserLegacyCommand command49,
            TeamsListProjectsLegacyCommand command50,
            TeamsCheckPermissionsForProjectLegacyCommand command51,
            TeamsAddOrUpdateProjectPermissionsLegacyCommand command52,
            TeamsRemoveProjectLegacyCommand command53,
            TeamsListReposLegacyCommand command54,
            TeamsCheckPermissionsForRepoLegacyCommand command55,
            TeamsAddOrUpdateRepoPermissionsLegacyCommand command56,
            TeamsRemoveRepoLegacyCommand command57,
            TeamsListChildLegacyCommand command58,
            TeamsListForAuthenticatedUserCommand command59)
            : base(
                name: "team")
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
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
            Subcommands.Add(command33);
            Subcommands.Add(command34);
            Subcommands.Add(command35);
            Subcommands.Add(command36);
            Subcommands.Add(command37);
            Subcommands.Add(command38);
            Subcommands.Add(command39);
            Subcommands.Add(command40);
            Subcommands.Add(command41);
            Subcommands.Add(command42);
            Subcommands.Add(command43);
            Subcommands.Add(command44);
            Subcommands.Add(command45);
            Subcommands.Add(command46);
            Subcommands.Add(command47);
            Subcommands.Add(command48);
            Subcommands.Add(command49);
            Subcommands.Add(command50);
            Subcommands.Add(command51);
            Subcommands.Add(command52);
            Subcommands.Add(command53);
            Subcommands.Add(command54);
            Subcommands.Add(command55);
            Subcommands.Add(command56);
            Subcommands.Add(command57);
            Subcommands.Add(command58);
            Subcommands.Add(command59);
        }
    }
}