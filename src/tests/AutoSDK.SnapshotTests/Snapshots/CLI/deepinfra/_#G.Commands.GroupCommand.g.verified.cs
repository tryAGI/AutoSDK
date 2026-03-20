//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            AccountEmailValuesV1MeEmailsGetCommand command0,
            AccountRateLimitV1MeRateLimitGetCommand command1,
            AccountUpdateDetailsV1MePatchCommand command2,
            AddFundsPaymentFundsPostCommand command3,
            BillingPortalPaymentBillingPortalGetCommand command4,
            CliVersionCliVersionGetCommand command5,
            CreateApiTokenV1ApiTokensPostCommand command6,
            CreateLoraV1LoraCreatePostCommand command7,
            CreateOpenaiBatchV1OpenaiBatchesPostCommand command8,
            CreateScopedJwtV1ScopedJwtPostCommand command9,
            CreateVoiceV1VoicesAddPostCommand command10,
            DeepstartApplyPaymentDeepstartApplicationPostCommand command11,
            DeleteAccountV1MeDeleteCommand command12,
            DeleteApiTokenV1ApiTokensApiTokenDeleteCommand command13,
            DeleteLoraModelLoraModelLoraModelNameDeleteCommand command14,
            DeleteLoraV1LoraLoraNameDeleteCommand command15,
            DeleteVoiceV1VoicesVoiceIdDeleteCommand command16,
            DeployCreateHfDeployHfPostCommand command17,
            DeployCreateLlmDeployLlmPostCommand command18,
            DeployCreateV1DeployPostCommand command19,
            DeployDeleteDeployDeployIdDeleteCommand command20,
            DeployDetailedStatsDeployDeployIdStats2GetCommand command21,
            DeployGpuAvailabilityDeployLlmGpuAvailabilityGetCommand command22,
            DeployListDeployListGetCommand command23,
            DeployListDeployListGet2Command command24,
            DeployStatsDeployDeployIdStatsGetCommand command25,
            DeployStatusDeployDeployIdGetCommand command26,
            DeployUpdateDeployDeployIdPutCommand command27,
            DeploymentLogsQueryV1DeploymentLogsQueryGetCommand command28,
            ExportApiTokenToVercelV1ApiTokensApiTokenVercelExportPostCommand command29,
            GetApiTokenV1ApiTokensApiTokenGetCommand command30,
            GetApiTokensV1ApiTokensGetCommand command31,
            GetChecklistPaymentChecklistGetCommand command32,
            GetConfigPaymentConfigGetCommand command33,
            GetLoraStatusV1LoraLoraNameStatusGetCommand command34,
            GetLoraV1LoraLoraNameGetCommand command35,
            GetModelLorasV1ModelModelNameLorasGetCommand command36,
            GetUserLorasV1UserLorasGetCommand command37,
            GetVoiceV1VoicesVoiceIdGetCommand command38,
            GetVoicesV1VoicesGetCommand command39,
            GithubCliLoginGithubCliLoginGetCommand command40,
            GithubLoginGithubLoginGetCommand command41,
            InferenceDeployV1InferenceDeployDeployIdPostCommand command42,
            InferenceModelV1InferenceModelNamePostCommand command43,
            InspectScopedJwtV1ScopedJwtGetCommand command44,
            ListFilesV1OpenaiFilesGetCommand command45,
            LogsQueryV1LogsQueryGetCommand command46,
            MeV1MeGetCommand command47,
            ModelDeleteModelsModelNameDeleteCommand command48,
            ModelMetaUpdateModelsModelNameMetaPostCommand command49,
            ModelPublicityModelsModelNamePublicityPostCommand command50,
            ModelSchemaModelsModelNameSchemaVariantKeyGetCommand command51,
            ModelVersionsModelsModelNameVersionsGetCommand command52,
            ModelsFeaturedModelsFeaturedGetCommand command53,
            ModelsInfoModelsModelNameGetCommand command54,
            ModelsListModelsListGetCommand command55,
            OktaLoginOktaLoginGetCommand command56,
            OpenaiAudioSpeechV1OpenaiAudioSpeechPostCommand command57,
            OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostCommand command58,
            OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostCommand command59,
            OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand command60,
            OpenaiCompletionsV1OpenaiCompletionsPostCommand command61,
            OpenaiEmbeddingsV1OpenaiEmbeddingsPostCommand command62,
            OpenaiFilesV1OpenaiFilesPostCommand command63,
            OpenaiImagesGenerationsV1OpenaiImagesGenerationsPostCommand command64,
            OpenaiImagesVariationsV1OpenaiImagesVariationsPostCommand command65,
            OpenaiModelsV1OpenaiModelsGetCommand command66,
            PrivateModelsListModelsPrivateListGetCommand command67,
            RequestRateLimitIncreaseV1MeRateLimitRequestPostCommand command68,
            RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetCommand command69,
            RetrieveOpenaiBatchesV1OpenaiBatchesGetCommand command70,
            SetConfigPaymentConfigPostCommand command71,
            SubmitFeedbackV1FeedbackPostCommand command72,
            TeamSetDisplayNameV1MeTeamDisplayNamePostCommand command73,
            TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostCommand command74,
            TextToSpeechV1TextToSpeechVoiceIdPostCommand command75,
            UpdateLoraV1LoraLoraNamePatchCommand command76,
            UpdateVoiceV1VoicesVoiceIdEditPostCommand command77,
            UploadLoraModelLoraModelPostCommand command78,
            UsageApiTokenPaymentUsageApiTokenGetCommand command79,
            UsagePaymentUsageGetCommand command80)
            : base(
                name: "")
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
        }
    }
}