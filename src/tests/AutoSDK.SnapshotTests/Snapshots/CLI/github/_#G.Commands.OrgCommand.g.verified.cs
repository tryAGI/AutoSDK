//HintName: G.Commands.OrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgCommand : global::System.CommandLine.Command
    {
        public OrgCommand(
            OrgsListCommand command0,
            OrgsGetCommand command1,
            OrgsUpdateCommand command2,
            OrgsDeleteCommand command3,
            OrgsListAttestationsCommand command4,
            OrgsListBlockedUsersCommand command5,
            OrgsCheckBlockedUserCommand command6,
            OrgsBlockUserCommand command7,
            OrgsUnblockUserCommand command8,
            OrgsListFailedInvitationsCommand command9,
            OrgsListWebhooksCommand command10,
            OrgsCreateWebhookCommand command11,
            OrgsGetWebhookCommand command12,
            OrgsUpdateWebhookCommand command13,
            OrgsDeleteWebhookCommand command14,
            OrgsGetWebhookConfigForOrgCommand command15,
            OrgsUpdateWebhookConfigForOrgCommand command16,
            OrgsListWebhookDeliveriesCommand command17,
            OrgsGetWebhookDeliveryCommand command18,
            OrgsRedeliverWebhookDeliveryCommand command19,
            OrgsPingWebhookCommand command20,
            OrgsListAppInstallationsCommand command21,
            OrgsListPendingInvitationsCommand command22,
            OrgsCreateInvitationCommand command23,
            OrgsCancelInvitationCommand command24,
            OrgsListInvitationTeamsCommand command25,
            OrgsListMembersCommand command26,
            OrgsCheckMembershipForUserCommand command27,
            OrgsRemoveMemberCommand command28,
            OrgsGetMembershipForUserCommand command29,
            OrgsSetMembershipForUserCommand command30,
            OrgsRemoveMembershipForUserCommand command31,
            OrgsListOrgRolesCommand command32,
            OrgsRevokeAllOrgRolesTeamCommand command33,
            OrgsAssignTeamToOrgRoleCommand command34,
            OrgsRevokeOrgRoleTeamCommand command35,
            OrgsRevokeAllOrgRolesUserCommand command36,
            OrgsAssignUserToOrgRoleCommand command37,
            OrgsRevokeOrgRoleUserCommand command38,
            OrgsGetOrgRoleCommand command39,
            OrgsListOrgRoleTeamsCommand command40,
            OrgsListOrgRoleUsersCommand command41,
            OrgsListOutsideCollaboratorsCommand command42,
            OrgsConvertMemberToOutsideCollaboratorCommand command43,
            OrgsRemoveOutsideCollaboratorCommand command44,
            OrgsListPatGrantRequestsCommand command45,
            OrgsReviewPatGrantRequestsInBulkCommand command46,
            OrgsReviewPatGrantRequestCommand command47,
            OrgsListPatGrantRequestRepositoriesCommand command48,
            OrgsListPatGrantsCommand command49,
            OrgsUpdatePatAccessesCommand command50,
            OrgsUpdatePatAccessCommand command51,
            OrgsListPatGrantRepositoriesCommand command52,
            OrgsGetAllCustomPropertiesCommand command53,
            OrgsCreateOrUpdateCustomPropertiesCommand command54,
            OrgsGetCustomPropertyCommand command55,
            OrgsCreateOrUpdateCustomPropertyCommand command56,
            OrgsRemoveCustomPropertyCommand command57,
            OrgsListCustomPropertiesValuesForReposCommand command58,
            OrgsCreateOrUpdateCustomPropertiesValuesForReposCommand command59,
            OrgsListPublicMembersCommand command60,
            OrgsCheckPublicMembershipForUserCommand command61,
            OrgsSetPublicMembershipForAuthenticatedUserCommand command62,
            OrgsRemovePublicMembershipForAuthenticatedUserCommand command63,
            OrgsListSecurityManagerTeamsCommand command64,
            OrgsAddSecurityManagerTeamCommand command65,
            OrgsRemoveSecurityManagerTeamCommand command66,
            OrgsEnableOrDisableSecurityProductOnAllOrgReposCommand command67,
            OrgsListMembershipsForAuthenticatedUserCommand command68,
            OrgsGetMembershipForAuthenticatedUserCommand command69,
            OrgsUpdateMembershipForAuthenticatedUserCommand command70,
            OrgsListForAuthenticatedUserCommand command71,
            OrgsListForUserCommand command72)
            : base(
                name: "org")
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
            Subcommands.Add(command60);
            Subcommands.Add(command61);
            Subcommands.Add(command62);
            Subcommands.Add(command63);
            Subcommands.Add(command64);
            Subcommands.Add(command65);
            Subcommands.Add(command66);
            Subcommands.Add(command67);
            Subcommands.Add(command68);
            Subcommands.Add(command69);
            Subcommands.Add(command70);
            Subcommands.Add(command71);
            Subcommands.Add(command72);
        }
    }
}