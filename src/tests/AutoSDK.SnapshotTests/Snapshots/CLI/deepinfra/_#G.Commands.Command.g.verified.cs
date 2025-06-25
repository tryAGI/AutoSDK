//HintName: G.Commands.Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Command : global::System.CommandLine.Command
    {
        public Command(
            CliVersionCliVersionGetCommand command0,
            MeV1MeGetCommand command1,
            DeleteAccountV1MeDeleteCommand command2,
            AccountUpdateDetailsV1MePatchCommand command3,
            AccountEmailValuesV1MeEmailsGetCommand command4,
            TeamSetDisplayNameV1MeTeamDisplayNamePostCommand command5,
            AccountRateLimitV1MeRateLimitGetCommand command6,
            RequestRateLimitIncreaseV1MeRateLimitRequestPostCommand command7,
            DeployCreateV1DeployPostCommand command8,
            DeployCreateHfDeployHfPostCommand command9,
            DeployGpuAvailabilityDeployLlmGpuAvailabilityGetCommand command10,
            DeployCreateLlmDeployLlmPostCommand command11,
            DeployListDeployListGetCommand command12,
            DeployListDeployListGet2Command command13,
            DeployStatusDeployDeployIdGetCommand command14,
            DeployUpdateDeployDeployIdPutCommand command15,
            DeployDeleteDeployDeployIdDeleteCommand command16,
            DeployStatsDeployDeployIdStatsGetCommand command17,
            DeployDetailedStatsDeployDeployIdStats2GetCommand command18,
            PrivateModelsListModelsPrivateListGetCommand command19,
            UploadLoraModelLoraModelPostCommand command20,
            DeleteLoraModelLoraModelLoraModelNameDeleteCommand command21,
            ModelsListModelsListGetCommand command22,
            ModelVersionsModelsModelNameVersionsGetCommand command23,
            ModelPublicityModelsModelNamePublicityPostCommand command24,
            ModelMetaUpdateModelsModelNameMetaPostCommand command25,
            ModelDeleteModelsModelNameDeleteCommand command26,
            ModelsInfoModelsModelNameGetCommand command27,
            ModelsFeaturedModelsFeaturedGetCommand command28,
            ModelSchemaModelsModelNameSchemaVariantKeyGetCommand command29,
            InferenceDeployV1InferenceDeployDeployIdPostCommand command30,
            InferenceModelV1InferenceModelNamePostCommand command31,
            OpenaiCompletionsV1OpenaiCompletionsPostCommand command32,
            ListFilesV1OpenaiFilesGetCommand command33,
            OpenaiFilesV1OpenaiFilesPostCommand command34,
            RetrieveOpenaiBatchesV1OpenaiBatchesGetCommand command35,
            CreateOpenaiBatchV1OpenaiBatchesPostCommand command36,
            RetrieveOpenaiBatchV1OpenaiBatchesBatchIdGetCommand command37,
            OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand command38,
            OpenaiEmbeddingsV1OpenaiEmbeddingsPostCommand command39,
            OpenaiModelsV1OpenaiModelsGetCommand command40,
            OpenaiImagesGenerationsV1OpenaiImagesGenerationsPostCommand command41,
            OpenaiImagesVariationsV1OpenaiImagesVariationsPostCommand command42,
            SubmitFeedbackV1FeedbackPostCommand command43,
            OpenaiAudioSpeechV1OpenaiAudioSpeechPostCommand command44,
            OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostCommand command45,
            OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostCommand command46,
            LogsQueryV1LogsQueryGetCommand command47,
            DeploymentLogsQueryV1DeploymentLogsQueryGetCommand command48,
            GetVoicesV1VoicesGetCommand command49,
            TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostCommand command50,
            TextToSpeechV1TextToSpeechVoiceIdPostCommand command51,
            GetVoiceV1VoicesVoiceIdGetCommand command52,
            DeleteVoiceV1VoicesVoiceIdDeleteCommand command53,
            CreateVoiceV1VoicesAddPostCommand command54,
            UpdateVoiceV1VoicesVoiceIdEditPostCommand command55,
            CreateLoraV1LoraCreatePostCommand command56,
            GetLoraStatusV1LoraLoraNameStatusGetCommand command57,
            GetLoraV1LoraLoraNameGetCommand command58,
            UpdateLoraV1LoraLoraNamePatchCommand command59,
            DeleteLoraV1LoraLoraNameDeleteCommand command60,
            GetModelLorasV1ModelModelNameLorasGetCommand command61,
            GetUserLorasV1UserLorasGetCommand command62,
            GithubLoginGithubLoginGetCommand command63,
            OktaLoginOktaLoginGetCommand command64,
            GithubCliLoginGithubCliLoginGetCommand command65,
            GetApiTokensV1ApiTokensGetCommand command66,
            CreateApiTokenV1ApiTokensPostCommand command67,
            GetApiTokenV1ApiTokensApiTokenGetCommand command68,
            DeleteApiTokenV1ApiTokensApiTokenDeleteCommand command69,
            ExportApiTokenToVercelV1ApiTokensApiTokenVercelExportPostCommand command70,
            CreateScopedJwtV1ScopedJwtPostCommand command71,
            InspectScopedJwtV1ScopedJwtGetCommand command72,
            GetChecklistPaymentChecklistGetCommand command73,
            GetConfigPaymentConfigGetCommand command74,
            SetConfigPaymentConfigPostCommand command75,
            BillingPortalPaymentBillingPortalGetCommand command76,
            UsagePaymentUsageGetCommand command77,
            UsageApiTokenPaymentUsageApiTokenGetCommand command78,
            DeepstartApplyPaymentDeepstartApplicationPostCommand command79,
            AddFundsPaymentFundsPostCommand command80)
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