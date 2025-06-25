//HintName: G.Commands.RepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RepoCommand : global::System.CommandLine.Command
    {
        public RepoCommand(
            ReposListForOrgCommand command0,
            ReposCreateInOrgCommand command1,
            ReposGetOrgRulesetsCommand command2,
            ReposCreateOrgRulesetCommand command3,
            ReposGetOrgRuleSuitesCommand command4,
            ReposGetOrgRuleSuiteCommand command5,
            ReposGetOrgRulesetCommand command6,
            ReposUpdateOrgRulesetCommand command7,
            ReposDeleteOrgRulesetCommand command8,
            ReposGetCommand command9,
            ReposUpdateCommand command10,
            ReposDeleteCommand command11,
            ReposListActivitiesCommand command12,
            ReposCreateAttestationCommand command13,
            ReposListAttestationsCommand command14,
            ReposListAutolinksCommand command15,
            ReposCreateAutolinkCommand command16,
            ReposGetAutolinkCommand command17,
            ReposDeleteAutolinkCommand command18,
            ReposCheckAutomatedSecurityFixesCommand command19,
            ReposEnableAutomatedSecurityFixesCommand command20,
            ReposDisableAutomatedSecurityFixesCommand command21,
            ReposListBranchesCommand command22,
            ReposGetBranchCommand command23,
            ReposGetBranchProtectionCommand command24,
            ReposUpdateBranchProtectionCommand command25,
            ReposDeleteBranchProtectionCommand command26,
            ReposGetAdminBranchProtectionCommand command27,
            ReposSetAdminBranchProtectionCommand command28,
            ReposDeleteAdminBranchProtectionCommand command29,
            ReposGetPullRequestReviewProtectionCommand command30,
            ReposUpdatePullRequestReviewProtectionCommand command31,
            ReposDeletePullRequestReviewProtectionCommand command32,
            ReposGetCommitSignatureProtectionCommand command33,
            ReposCreateCommitSignatureProtectionCommand command34,
            ReposDeleteCommitSignatureProtectionCommand command35,
            ReposGetStatusChecksProtectionCommand command36,
            ReposUpdateStatusCheckProtectionCommand command37,
            ReposRemoveStatusCheckProtectionCommand command38,
            ReposGetAllStatusCheckContextsCommand command39,
            ReposAddStatusCheckContextsCommand command40,
            ReposSetStatusCheckContextsCommand command41,
            ReposRemoveStatusCheckContextsCommand command42,
            ReposGetAccessRestrictionsCommand command43,
            ReposDeleteAccessRestrictionsCommand command44,
            ReposGetAppsWithAccessToProtectedBranchCommand command45,
            ReposAddAppAccessRestrictionsCommand command46,
            ReposSetAppAccessRestrictionsCommand command47,
            ReposRemoveAppAccessRestrictionsCommand command48,
            ReposGetTeamsWithAccessToProtectedBranchCommand command49,
            ReposAddTeamAccessRestrictionsCommand command50,
            ReposSetTeamAccessRestrictionsCommand command51,
            ReposRemoveTeamAccessRestrictionsCommand command52,
            ReposGetUsersWithAccessToProtectedBranchCommand command53,
            ReposAddUserAccessRestrictionsCommand command54,
            ReposSetUserAccessRestrictionsCommand command55,
            ReposRemoveUserAccessRestrictionsCommand command56,
            ReposRenameBranchCommand command57,
            ReposCodeownersErrorsCommand command58,
            ReposListCollaboratorsCommand command59,
            ReposCheckCollaboratorCommand command60,
            ReposAddCollaboratorCommand command61,
            ReposRemoveCollaboratorCommand command62,
            ReposGetCollaboratorPermissionLevelCommand command63,
            ReposListCommitCommentsForRepoCommand command64,
            ReposGetCommitCommentCommand command65,
            ReposUpdateCommitCommentCommand command66,
            ReposDeleteCommitCommentCommand command67,
            ReposListCommitsCommand command68,
            ReposListBranchesForHeadCommitCommand command69,
            ReposListCommentsForCommitCommand command70,
            ReposCreateCommitCommentCommand command71,
            ReposListPullRequestsAssociatedWithCommitCommand command72,
            ReposGetCommitCommand command73,
            ReposGetCombinedStatusForRefCommand command74,
            ReposListCommitStatusesForRefCommand command75,
            ReposGetCommunityProfileMetricsCommand command76,
            ReposCompareCommitsCommand command77,
            ReposGetContentCommand command78,
            ReposCreateOrUpdateFileContentsCommand command79,
            ReposDeleteFileCommand command80,
            ReposListContributorsCommand command81,
            ReposListDeploymentsCommand command82,
            ReposCreateDeploymentCommand command83,
            ReposGetDeploymentCommand command84,
            ReposDeleteDeploymentCommand command85,
            ReposListDeploymentStatusesCommand command86,
            ReposCreateDeploymentStatusCommand command87,
            ReposGetDeploymentStatusCommand command88,
            ReposCreateDispatchEventCommand command89,
            ReposGetAllEnvironmentsCommand command90,
            ReposGetEnvironmentCommand command91,
            ReposCreateOrUpdateEnvironmentCommand command92,
            ReposDeleteAnEnvironmentCommand command93,
            ReposListDeploymentBranchPoliciesCommand command94,
            ReposCreateDeploymentBranchPolicyCommand command95,
            ReposGetDeploymentBranchPolicyCommand command96,
            ReposUpdateDeploymentBranchPolicyCommand command97,
            ReposDeleteDeploymentBranchPolicyCommand command98,
            ReposGetAllDeploymentProtectionRulesCommand command99,
            ReposCreateDeploymentProtectionRuleCommand command100,
            ReposListCustomDeploymentRuleIntegrationsCommand command101,
            ReposGetCustomDeploymentProtectionRuleCommand command102,
            ReposDisableDeploymentProtectionRuleCommand command103,
            ReposListForksCommand command104,
            ReposCreateForkCommand command105,
            ReposListWebhooksCommand command106,
            ReposCreateWebhookCommand command107,
            ReposGetWebhookCommand command108,
            ReposUpdateWebhookCommand command109,
            ReposDeleteWebhookCommand command110,
            ReposGetWebhookConfigForRepoCommand command111,
            ReposUpdateWebhookConfigForRepoCommand command112,
            ReposListWebhookDeliveriesCommand command113,
            ReposGetWebhookDeliveryCommand command114,
            ReposRedeliverWebhookDeliveryCommand command115,
            ReposPingWebhookCommand command116,
            ReposTestPushWebhookCommand command117,
            ReposListInvitationsCommand command118,
            ReposUpdateInvitationCommand command119,
            ReposDeleteInvitationCommand command120,
            ReposListDeployKeysCommand command121,
            ReposCreateDeployKeyCommand command122,
            ReposGetDeployKeyCommand command123,
            ReposDeleteDeployKeyCommand command124,
            ReposListLanguagesCommand command125,
            ReposMergeUpstreamCommand command126,
            ReposMergeCommand command127,
            ReposGetPagesCommand command128,
            ReposCreatePagesSiteCommand command129,
            ReposUpdateInformationAboutPagesSiteCommand command130,
            ReposDeletePagesSiteCommand command131,
            ReposListPagesBuildsCommand command132,
            ReposRequestPagesBuildCommand command133,
            ReposGetLatestPagesBuildCommand command134,
            ReposGetPagesBuildCommand command135,
            ReposCreatePagesDeploymentCommand command136,
            ReposGetPagesDeploymentCommand command137,
            ReposCancelPagesDeploymentCommand command138,
            ReposGetPagesHealthCheckCommand command139,
            ReposCheckPrivateVulnerabilityReportingCommand command140,
            ReposEnablePrivateVulnerabilityReportingCommand command141,
            ReposDisablePrivateVulnerabilityReportingCommand command142,
            ReposGetCustomPropertiesValuesCommand command143,
            ReposCreateOrUpdateCustomPropertiesValuesCommand command144,
            ReposGetReadmeCommand command145,
            ReposGetReadmeInDirectoryCommand command146,
            ReposListReleasesCommand command147,
            ReposCreateReleaseCommand command148,
            ReposGetReleaseAssetCommand command149,
            ReposUpdateReleaseAssetCommand command150,
            ReposDeleteReleaseAssetCommand command151,
            ReposGenerateReleaseNotesCommand command152,
            ReposGetLatestReleaseCommand command153,
            ReposGetReleaseByTagCommand command154,
            ReposGetReleaseCommand command155,
            ReposUpdateReleaseCommand command156,
            ReposDeleteReleaseCommand command157,
            ReposListReleaseAssetsCommand command158,
            ReposUploadReleaseAssetCommand command159,
            ReposGetBranchRulesCommand command160,
            ReposGetRepoRulesetsCommand command161,
            ReposCreateRepoRulesetCommand command162,
            ReposGetRepoRuleSuitesCommand command163,
            ReposGetRepoRuleSuiteCommand command164,
            ReposGetRepoRulesetCommand command165,
            ReposUpdateRepoRulesetCommand command166,
            ReposDeleteRepoRulesetCommand command167,
            ReposGetCodeFrequencyStatsCommand command168,
            ReposGetCommitActivityStatsCommand command169,
            ReposGetContributorsStatsCommand command170,
            ReposGetParticipationStatsCommand command171,
            ReposGetPunchCardStatsCommand command172,
            ReposCreateCommitStatusCommand command173,
            ReposListTagsCommand command174,
            ReposListTagProtectionCommand command175,
            ReposCreateTagProtectionCommand command176,
            ReposDeleteTagProtectionCommand command177,
            ReposDownloadTarballArchiveCommand command178,
            ReposListTeamsCommand command179,
            ReposGetAllTopicsCommand command180,
            ReposReplaceAllTopicsCommand command181,
            ReposGetClonesCommand command182,
            ReposGetTopPathsCommand command183,
            ReposGetTopReferrersCommand command184,
            ReposGetViewsCommand command185,
            ReposTransferCommand command186,
            ReposCheckVulnerabilityAlertsCommand command187,
            ReposEnableVulnerabilityAlertsCommand command188,
            ReposDisableVulnerabilityAlertsCommand command189,
            ReposDownloadZipballArchiveCommand command190,
            ReposCreateUsingTemplateCommand command191,
            ReposListPublicCommand command192,
            ReposListForAuthenticatedUserCommand command193,
            ReposCreateForAuthenticatedUserCommand command194,
            ReposListInvitationsForAuthenticatedUserCommand command195,
            ReposAcceptInvitationForAuthenticatedUserCommand command196,
            ReposDeclineInvitationForAuthenticatedUserCommand command197,
            ReposListForUserCommand command198)
            : base(
                name: "repo")
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
            Subcommands.Add(command73);
            Subcommands.Add(command74);
            Subcommands.Add(command75);
            Subcommands.Add(command76);
            Subcommands.Add(command77);
            Subcommands.Add(command78);
            Subcommands.Add(command79);
            Subcommands.Add(command80);
            Subcommands.Add(command81);
            Subcommands.Add(command82);
            Subcommands.Add(command83);
            Subcommands.Add(command84);
            Subcommands.Add(command85);
            Subcommands.Add(command86);
            Subcommands.Add(command87);
            Subcommands.Add(command88);
            Subcommands.Add(command89);
            Subcommands.Add(command90);
            Subcommands.Add(command91);
            Subcommands.Add(command92);
            Subcommands.Add(command93);
            Subcommands.Add(command94);
            Subcommands.Add(command95);
            Subcommands.Add(command96);
            Subcommands.Add(command97);
            Subcommands.Add(command98);
            Subcommands.Add(command99);
            Subcommands.Add(command100);
            Subcommands.Add(command101);
            Subcommands.Add(command102);
            Subcommands.Add(command103);
            Subcommands.Add(command104);
            Subcommands.Add(command105);
            Subcommands.Add(command106);
            Subcommands.Add(command107);
            Subcommands.Add(command108);
            Subcommands.Add(command109);
            Subcommands.Add(command110);
            Subcommands.Add(command111);
            Subcommands.Add(command112);
            Subcommands.Add(command113);
            Subcommands.Add(command114);
            Subcommands.Add(command115);
            Subcommands.Add(command116);
            Subcommands.Add(command117);
            Subcommands.Add(command118);
            Subcommands.Add(command119);
            Subcommands.Add(command120);
            Subcommands.Add(command121);
            Subcommands.Add(command122);
            Subcommands.Add(command123);
            Subcommands.Add(command124);
            Subcommands.Add(command125);
            Subcommands.Add(command126);
            Subcommands.Add(command127);
            Subcommands.Add(command128);
            Subcommands.Add(command129);
            Subcommands.Add(command130);
            Subcommands.Add(command131);
            Subcommands.Add(command132);
            Subcommands.Add(command133);
            Subcommands.Add(command134);
            Subcommands.Add(command135);
            Subcommands.Add(command136);
            Subcommands.Add(command137);
            Subcommands.Add(command138);
            Subcommands.Add(command139);
            Subcommands.Add(command140);
            Subcommands.Add(command141);
            Subcommands.Add(command142);
            Subcommands.Add(command143);
            Subcommands.Add(command144);
            Subcommands.Add(command145);
            Subcommands.Add(command146);
            Subcommands.Add(command147);
            Subcommands.Add(command148);
            Subcommands.Add(command149);
            Subcommands.Add(command150);
            Subcommands.Add(command151);
            Subcommands.Add(command152);
            Subcommands.Add(command153);
            Subcommands.Add(command154);
            Subcommands.Add(command155);
            Subcommands.Add(command156);
            Subcommands.Add(command157);
            Subcommands.Add(command158);
            Subcommands.Add(command159);
            Subcommands.Add(command160);
            Subcommands.Add(command161);
            Subcommands.Add(command162);
            Subcommands.Add(command163);
            Subcommands.Add(command164);
            Subcommands.Add(command165);
            Subcommands.Add(command166);
            Subcommands.Add(command167);
            Subcommands.Add(command168);
            Subcommands.Add(command169);
            Subcommands.Add(command170);
            Subcommands.Add(command171);
            Subcommands.Add(command172);
            Subcommands.Add(command173);
            Subcommands.Add(command174);
            Subcommands.Add(command175);
            Subcommands.Add(command176);
            Subcommands.Add(command177);
            Subcommands.Add(command178);
            Subcommands.Add(command179);
            Subcommands.Add(command180);
            Subcommands.Add(command181);
            Subcommands.Add(command182);
            Subcommands.Add(command183);
            Subcommands.Add(command184);
            Subcommands.Add(command185);
            Subcommands.Add(command186);
            Subcommands.Add(command187);
            Subcommands.Add(command188);
            Subcommands.Add(command189);
            Subcommands.Add(command190);
            Subcommands.Add(command191);
            Subcommands.Add(command192);
            Subcommands.Add(command193);
            Subcommands.Add(command194);
            Subcommands.Add(command195);
            Subcommands.Add(command196);
            Subcommands.Add(command197);
            Subcommands.Add(command198);
        }
    }
}