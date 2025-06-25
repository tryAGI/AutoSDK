//HintName: G.Commands.ActionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionCommand : global::System.CommandLine.Command
    {
        public ActionCommand(
            ActionsGetActionsCacheUsageForOrgCommand command0,
            ActionsGetActionsCacheUsageByRepoForOrgCommand command1,
            ActionsGetGithubActionsPermissionsOrganizationCommand command2,
            ActionsSetGithubActionsPermissionsOrganizationCommand command3,
            ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationCommand command4,
            ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationCommand command5,
            ActionsEnableSelectedRepositoryGithubActionsOrganizationCommand command6,
            ActionsDisableSelectedRepositoryGithubActionsOrganizationCommand command7,
            ActionsGetAllowedActionsOrganizationCommand command8,
            ActionsSetAllowedActionsOrganizationCommand command9,
            ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationCommand command10,
            ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationCommand command11,
            ActionsListSelfHostedRunnerGroupsForOrgCommand command12,
            ActionsCreateSelfHostedRunnerGroupForOrgCommand command13,
            ActionsGetSelfHostedRunnerGroupForOrgCommand command14,
            ActionsUpdateSelfHostedRunnerGroupForOrgCommand command15,
            ActionsDeleteSelfHostedRunnerGroupFromOrgCommand command16,
            ActionsListRepoAccessToSelfHostedRunnerGroupInOrgCommand command17,
            ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgCommand command18,
            ActionsAddRepoAccessToSelfHostedRunnerGroupInOrgCommand command19,
            ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrgCommand command20,
            ActionsListSelfHostedRunnersInGroupForOrgCommand command21,
            ActionsSetSelfHostedRunnersInGroupForOrgCommand command22,
            ActionsAddSelfHostedRunnerToGroupForOrgCommand command23,
            ActionsRemoveSelfHostedRunnerFromGroupForOrgCommand command24,
            ActionsListSelfHostedRunnersForOrgCommand command25,
            ActionsListRunnerApplicationsForOrgCommand command26,
            ActionsGenerateRunnerJitconfigForOrgCommand command27,
            ActionsCreateRegistrationTokenForOrgCommand command28,
            ActionsCreateRemoveTokenForOrgCommand command29,
            ActionsGetSelfHostedRunnerForOrgCommand command30,
            ActionsDeleteSelfHostedRunnerFromOrgCommand command31,
            ActionsListLabelsForSelfHostedRunnerForOrgCommand command32,
            ActionsAddCustomLabelsToSelfHostedRunnerForOrgCommand command33,
            ActionsSetCustomLabelsForSelfHostedRunnerForOrgCommand command34,
            ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrgCommand command35,
            ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgCommand command36,
            ActionsListOrgSecretsCommand command37,
            ActionsGetOrgPublicKeyCommand command38,
            ActionsGetOrgSecretCommand command39,
            ActionsCreateOrUpdateOrgSecretCommand command40,
            ActionsDeleteOrgSecretCommand command41,
            ActionsListSelectedReposForOrgSecretCommand command42,
            ActionsSetSelectedReposForOrgSecretCommand command43,
            ActionsAddSelectedRepoToOrgSecretCommand command44,
            ActionsRemoveSelectedRepoFromOrgSecretCommand command45,
            ActionsListOrgVariablesCommand command46,
            ActionsCreateOrgVariableCommand command47,
            ActionsGetOrgVariableCommand command48,
            ActionsUpdateOrgVariableCommand command49,
            ActionsDeleteOrgVariableCommand command50,
            ActionsListSelectedReposForOrgVariableCommand command51,
            ActionsSetSelectedReposForOrgVariableCommand command52,
            ActionsAddSelectedRepoToOrgVariableCommand command53,
            ActionsRemoveSelectedRepoFromOrgVariableCommand command54,
            ActionsListArtifactsForRepoCommand command55,
            ActionsGetArtifactCommand command56,
            ActionsDeleteArtifactCommand command57,
            ActionsDownloadArtifactCommand command58,
            ActionsGetActionsCacheUsageCommand command59,
            ActionsGetActionsCacheListCommand command60,
            ActionsDeleteActionsCacheByKeyCommand command61,
            ActionsDeleteActionsCacheByIdCommand command62,
            ActionsGetJobForWorkflowRunCommand command63,
            ActionsDownloadJobLogsForWorkflowRunCommand command64,
            ActionsReRunJobForWorkflowRunCommand command65,
            ActionsGetCustomOidcSubClaimForRepoCommand command66,
            ActionsSetCustomOidcSubClaimForRepoCommand command67,
            ActionsListRepoOrganizationSecretsCommand command68,
            ActionsListRepoOrganizationVariablesCommand command69,
            ActionsGetGithubActionsPermissionsRepositoryCommand command70,
            ActionsSetGithubActionsPermissionsRepositoryCommand command71,
            ActionsGetWorkflowAccessToRepositoryCommand command72,
            ActionsSetWorkflowAccessToRepositoryCommand command73,
            ActionsGetAllowedActionsRepositoryCommand command74,
            ActionsSetAllowedActionsRepositoryCommand command75,
            ActionsGetGithubActionsDefaultWorkflowPermissionsRepositoryCommand command76,
            ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryCommand command77,
            ActionsListSelfHostedRunnersForRepoCommand command78,
            ActionsListRunnerApplicationsForRepoCommand command79,
            ActionsGenerateRunnerJitconfigForRepoCommand command80,
            ActionsCreateRegistrationTokenForRepoCommand command81,
            ActionsCreateRemoveTokenForRepoCommand command82,
            ActionsGetSelfHostedRunnerForRepoCommand command83,
            ActionsDeleteSelfHostedRunnerFromRepoCommand command84,
            ActionsListLabelsForSelfHostedRunnerForRepoCommand command85,
            ActionsAddCustomLabelsToSelfHostedRunnerForRepoCommand command86,
            ActionsSetCustomLabelsForSelfHostedRunnerForRepoCommand command87,
            ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoCommand command88,
            ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoCommand command89,
            ActionsListWorkflowRunsForRepoCommand command90,
            ActionsGetWorkflowRunCommand command91,
            ActionsDeleteWorkflowRunCommand command92,
            ActionsGetReviewsForRunCommand command93,
            ActionsApproveWorkflowRunCommand command94,
            ActionsListWorkflowRunArtifactsCommand command95,
            ActionsGetWorkflowRunAttemptCommand command96,
            ActionsListJobsForWorkflowRunAttemptCommand command97,
            ActionsDownloadWorkflowRunAttemptLogsCommand command98,
            ActionsCancelWorkflowRunCommand command99,
            ActionsReviewCustomGatesForRunCommand command100,
            ActionsForceCancelWorkflowRunCommand command101,
            ActionsListJobsForWorkflowRunCommand command102,
            ActionsDownloadWorkflowRunLogsCommand command103,
            ActionsDeleteWorkflowRunLogsCommand command104,
            ActionsGetPendingDeploymentsForRunCommand command105,
            ActionsReviewPendingDeploymentsForRunCommand command106,
            ActionsReRunWorkflowCommand command107,
            ActionsReRunWorkflowFailedJobsCommand command108,
            ActionsGetWorkflowRunUsageCommand command109,
            ActionsListRepoSecretsCommand command110,
            ActionsGetRepoPublicKeyCommand command111,
            ActionsGetRepoSecretCommand command112,
            ActionsCreateOrUpdateRepoSecretCommand command113,
            ActionsDeleteRepoSecretCommand command114,
            ActionsListRepoVariablesCommand command115,
            ActionsCreateRepoVariableCommand command116,
            ActionsGetRepoVariableCommand command117,
            ActionsUpdateRepoVariableCommand command118,
            ActionsDeleteRepoVariableCommand command119,
            ActionsListRepoWorkflowsCommand command120,
            ActionsGetWorkflowCommand command121,
            ActionsDisableWorkflowCommand command122,
            ActionsCreateWorkflowDispatchCommand command123,
            ActionsEnableWorkflowCommand command124,
            ActionsListWorkflowRunsCommand command125,
            ActionsGetWorkflowUsageCommand command126,
            ActionsListEnvironmentSecretsCommand command127,
            ActionsGetEnvironmentPublicKeyCommand command128,
            ActionsGetEnvironmentSecretCommand command129,
            ActionsCreateOrUpdateEnvironmentSecretCommand command130,
            ActionsDeleteEnvironmentSecretCommand command131,
            ActionsListEnvironmentVariablesCommand command132,
            ActionsCreateEnvironmentVariableCommand command133,
            ActionsGetEnvironmentVariableCommand command134,
            ActionsUpdateEnvironmentVariableCommand command135,
            ActionsDeleteEnvironmentVariableCommand command136)
            : base(
                name: "action")
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
        }
    }
}