//HintName: G.Commands.ConversationalAICommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConversationalAICommand : global::System.CommandLine.Command
    {
        public ConversationalAICommand(
            GetConvaiConversationGetSignedUrlCommand command0,
            GetConvaiConversationGetSignedUrl2Command command1,
            CreateConvaiTwilioOutboundCallCommand command2,
            CreateConvaiAgentsCreateCommand command3,
            GetConvaiAgentsByAgentIdCommand command4,
            EditConvaiAgentsByAgentIdCommand command5,
            DeleteConvaiAgentsByAgentIdCommand command6,
            GetConvaiAgentsByAgentIdWidgetCommand command7,
            GetConvaiAgentsByAgentIdLinkCommand command8,
            CreateConvaiAgentsByAgentIdAvatarCommand command9,
            GetConvaiAgentsCommand command10,
            GetConvaiAgentByAgentIdKnowledgeBaseSizeCommand command11,
            CreateConvaiAgentByAgentIdLlmUsageCalculateCommand command12,
            CreateConvaiAgentsByAgentIdSimulateConversationCommand command13,
            CreateConvaiAgentsByAgentIdSimulateConversationStreamCommand command14,
            GetConvaiConversationsCommand command15,
            GetConvaiConversationsByConversationIdCommand command16,
            DeleteConvaiConversationsByConversationIdCommand command17,
            GetConvaiConversationsByConversationIdAudioCommand command18,
            CreateConvaiConversationsByConversationIdFeedbackCommand command19,
            CreateConvaiPhoneNumbersCreateCommand command20,
            GetConvaiPhoneNumbersByPhoneNumberIdCommand command21,
            DeleteConvaiPhoneNumbersByPhoneNumberIdCommand command22,
            EditConvaiPhoneNumbersByPhoneNumberIdCommand command23,
            GetConvaiPhoneNumbersCommand command24,
            CreateConvaiLlmUsageCalculateCommand command25,
            CreateConvaiKnowledgeBaseCommand command26,
            GetConvaiKnowledgeBaseCommand command27,
            CreateConvaiAddToKnowledgeBaseCommand command28,
            CreateConvaiAgentsByAgentIdAddToKnowledgeBaseCommand command29,
            CreateConvaiKnowledgeBaseUrlCommand command30,
            CreateConvaiKnowledgeBaseFileCommand command31,
            CreateConvaiKnowledgeBaseTextCommand command32,
            EditConvaiKnowledgeBaseByDocumentationIdCommand command33,
            GetConvaiKnowledgeBaseByDocumentationIdCommand command34,
            DeleteConvaiKnowledgeBaseByDocumentationIdCommand command35,
            CreateConvaiKnowledgeBaseByDocumentationIdRagIndexCommand command36,
            GetConvaiKnowledgeBaseByDocumentationIdRagIndexCommand command37,
            DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexIdCommand command38,
            GetConvaiKnowledgeBaseRagIndexCommand command39,
            GetConvaiAgentsByAgentIdKnowledgeBaseByDocumentationIdCommand command40,
            GetConvaiKnowledgeBaseByDocumentationIdDependentAgentsCommand command41,
            GetConvaiKnowledgeBaseByDocumentationIdContentCommand command42,
            GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkIdCommand command43,
            GetConvaiSettingsCommand command44,
            EditConvaiSettingsCommand command45,
            GetConvaiSettingsDashboardCommand command46,
            EditConvaiSettingsDashboardCommand command47,
            CreateConvaiSecretsCommand command48,
            DeleteConvaiSecretsBySecretIdCommand command49,
            EditConvaiSecretsBySecretIdCommand command50,
            CreateConvaiBatchCallingSubmitCommand command51,
            GetConvaiBatchCallingWorkspaceCommand command52,
            GetConvaiBatchCallingByBatchIdCommand command53,
            CreateConvaiBatchCallingByBatchIdCancelCommand command54,
            CreateConvaiBatchCallingByBatchIdRetryCommand command55,
            CreateConvaiSipTrunkOutboundCallCommand command56,
            CreateConvaiMcpServersCommand command57,
            GetConvaiMcpServersCommand command58,
            GetConvaiMcpServersByMcpServerIdCommand command59,
            GetConvaiMcpServersByMcpServerIdToolsCommand command60,
            EditConvaiMcpServersByMcpServerIdApprovalPolicyCommand command61,
            CreateConvaiMcpServersByMcpServerIdToolApprovalsCommand command62,
            DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolNameCommand command63)
            : base(
                name: "conversationalai")
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
        }
    }
}