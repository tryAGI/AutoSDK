//HintName: G.Models.ServerMessageStatusUpdateEndedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the reason the call ended. This is only sent if the status is "ended".
    /// </summary>
    public enum ServerMessageStatusUpdateEndedReason
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantEndedCall,
        /// <summary>
        /// 
        /// </summary>
        AssistantEndedCallAfterMessageSpoken,
        /// <summary>
        /// 
        /// </summary>
        AssistantEndedCallWithHangupTask,
        /// <summary>
        /// 
        /// </summary>
        AssistantForwardedCall,
        /// <summary>
        /// 
        /// </summary>
        AssistantJoinTimedOut,
        /// <summary>
        /// 
        /// </summary>
        AssistantNotFound,
        /// <summary>
        /// 
        /// </summary>
        AssistantNotValid,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedError,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedForwardingPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedInvalidAssistant,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedNoAssistant,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedUnspeakableError,
        /// <summary>
        /// 
        /// </summary>
        AssistantSaidEndCallPhrase,
        /// <summary>
        /// 
        /// </summary>
        CallDeleted,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorNeitherAssistantNorServerSet,
        /// <summary>
        /// 
        /// </summary>
        CallEndingHookExecutedSay,
        /// <summary>
        /// 
        /// </summary>
        CallEndingHookExecutedTransfer,
        /// <summary>
        /// 
        /// </summary>
        CallForwardingOperatorBusy,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorAssistantDidNotReceiveCustomerAudio,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorPipelineNoAvailableLlmModel,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorPipelineWsModelConnectionFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropic500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicVertex500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnyscale500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAnyscaleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAzureOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultBaseten500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultBasetenLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCartesia500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCartesia503ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCartesia522ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCerebras500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCerebrasLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCustomLlm500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultCustomLlmLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepSeek500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepSeekLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepinfra500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultDeepinfraLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultElevenLabs500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultElevenLabs503ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultGoogle500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultGoogleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultGroq500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultGroq503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultGroqLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultInflectionAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultInflectionAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultMistral500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultMistral503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultMistralLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOpenrouter500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOpenrouterLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOutboundSip403Forbidden,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultPerplexityAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultPerplexityAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultPlayht502GatewayError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultPlayht504GatewayError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultRunpod500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultRunpodLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultTogetherAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultTogetherAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultTransportNeverConnected,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultVapi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultVapi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultVapiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultXai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultXai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorProviderfaultXaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorSipInboundCallFailedToConnect,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorSipOutboundCallFailedToConnect,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorTransferFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropic401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropic429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnyscale401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAnyscale429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAzureOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultAzureVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultBaseten401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultBaseten403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultBaseten429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCartesiaRequestedPayment,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCartesiaSocketHangUp,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCartesiaVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCerebras401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCerebras403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCerebras429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultChatPipelineFailedToStart,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCustomLlm401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCustomLlm429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultCustomTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepSeek401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepSeek429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepgramReturning404NotFound,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepgramTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepgramVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepinfra401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultDeepinfra429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsInvalidApiKey,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsQuotaExceeded,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultElevenLabsVoiceNotFound,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGladiaTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGoogle401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGoogle403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGoogle429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGoogleTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGroq401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGroq403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultGroq429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultHumeVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultInflectionAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultInflectionAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultInworldVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultLmntVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultMinimaxVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultMistral401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultMistral403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultMistral429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultNeuphonicVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai401IncorrectApiKey,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenai429RateLimitReached,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenaiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenaiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenrouter401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultOpenrouter429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPerplexityAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayht401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayht429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtInvalidEmotion,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtInvalidVoice,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtOutOfCredits,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtRequestTimedOut,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtUnexpectedError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultRimeAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultRunpod401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultRunpod403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultRunpod429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSesameVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSmallestAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSonioxTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSonioxTranscriberRateLimited,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSonioxTranscriberServerError,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTalkscriberTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTavusVideoFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTogetherAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTogetherAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTransportConnectedButCallNotActive,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultTransportNeverConnected,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultVapi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultVapi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultVapi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultVapiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultWellsaidVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultWorkerDied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultWorkerNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultXai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultXai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultXai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorVapifaultXai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorWarmTransferAssistantCancelled,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorWarmTransferMaxDuration,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorWarmTransferMicrophoneTimeout,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressErrorWarmTransferSilenceTimeout,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressSipCompletedCall,
        /// <summary>
        /// 
        /// </summary>
        CallInProgressTwilioCompletedCall,
        /// <summary>
        /// 
        /// </summary>
        CallRingingErrorSipInboundCallFailedToConnect,
        /// <summary>
        /// 
        /// </summary>
        CallRingingHookExecutedSay,
        /// <summary>
        /// 
        /// </summary>
        CallRingingHookExecutedTransfer,
        /// <summary>
        /// 
        /// </summary>
        CallRingingSipInboundCallerHungupBeforeCallConnect,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorFraudCheckFailed,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorGetAssistant,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorGetCustomer,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorGetPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorGetResourcesValidation,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorGetTransport,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorSubscriptionConcurrencyLimitReached,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorSubscriptionFrozen,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorSubscriptionInsufficientCredits,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorSubscriptionUpgradeFailed,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorSubscriptionWalletDoesNotExist,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorVapiNumberInternational,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorVapiNumberOutboundDailyLimit,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorVapifaultDatabaseError,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorVapifaultGetOrg,
        /// <summary>
        /// 
        /// </summary>
        CallStartErrorVapifaultGetSubscription,
        /// <summary>
        /// 
        /// </summary>
        CustomerBusy,
        /// <summary>
        /// 
        /// </summary>
        CustomerDidNotAnswer,
        /// <summary>
        /// 
        /// </summary>
        CustomerDidNotGiveMicrophonePermission,
        /// <summary>
        /// 
        /// </summary>
        CustomerEndedCall,
        /// <summary>
        /// 
        /// </summary>
        CustomerEndedCallAfterWarmTransferAttempt,
        /// <summary>
        /// 
        /// </summary>
        CustomerEndedCallBeforeWarmTransfer,
        /// <summary>
        /// 
        /// </summary>
        CustomerEndedCallDuringTransfer,
        /// <summary>
        /// 
        /// </summary>
        ExceededMaxDuration,
        /// <summary>
        /// 
        /// </summary>
        ManuallyCanceled,
        /// <summary>
        /// 
        /// </summary>
        PhoneCallProviderBypassEnabledButNoCallReceived,
        /// <summary>
        /// 
        /// </summary>
        PhoneCallProviderClosedWebsocket,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropic400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropic401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropic403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropic429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropic500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropic503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrock400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrock401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrock403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrock429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrock500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrock503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicBedrockLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertex400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertex401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertex403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertex429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertex500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertex503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnthropicVertexLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscale400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscale401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscale403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscale429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscale500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscale503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAnyscaleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAssemblyAiReturning400InsufficentFunds,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAssemblyAiReturning400PaidOnlyFeature,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAssemblyAiReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAssemblyAiReturning500InvalidSchema,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAssemblyAiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureSpeechTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorAzureVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBaseten400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBaseten401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBaseten403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBaseten429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBaseten500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBaseten503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorBasetenLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesia500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesia502ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesia503ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesia522ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesiaRequestedPayment,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesiaSocketHangUp,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCartesiaVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebras400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebras401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebras403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebras429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebras500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebras503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCerebrasLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlm400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlm401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlm403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlm429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlm500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlm503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomLlmLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorCustomVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeek400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeek401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeek403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeek429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeek500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeek503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepSeekLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning404NotFound,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning500InvalidJson,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning502BadGatewayEhostunreach,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturning502NetworkError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramReturningEconnreset,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramTranscriberApiKeyMissing,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepgramVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfra400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfra401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfra403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfra429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfra500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfra503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorDeepinfraLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabs500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabs503ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsBlockedAccountInProbation,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsInvalidApiKey,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsInvalidVoiceSamples,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsMaxCharacterLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsMissingSamplesForVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsQuotaExceeded,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsUnauthorizedAccess,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsUnauthorizedToAccessModel,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVapiVoiceDisabledByOwner,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVoiceDisabledByOwner,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVoiceNotFineTuned,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorElevenLabsVoiceNotFound,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGladiaTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogle400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogle401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogle403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogle429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogle500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogle503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGoogleTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroq400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroq401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroq403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroq429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroq500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroq503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorGroqLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorHumeVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInflectionAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorInworldVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorLmntVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMinimaxVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistral400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistral401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistral403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistral429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistral500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistral503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorMistralLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorNeuphonicVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai401AccountNotInOrganization,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai401IncorrectApiKey,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai429RateLimitReached,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenaiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenaiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouter400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouter401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouter403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouter429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouter500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouter503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorOpenrouterLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPerplexityAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayht401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayht403ForbiddenOutOfCharacters,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayht429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayht502GatewayError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayht504GatewayError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtInvalidEmotion,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtInvalidVoice,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtOutOfCredits,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtRequestTimedOut,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtUnexpectedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRimeAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpod400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpod401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpod403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpod429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpod500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpod503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorRunpodLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSesameVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSmallestAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSonioxTranscriberAuthFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSonioxTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSonioxTranscriberInvalidConfig,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSonioxTranscriberRateLimited,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSonioxTranscriberServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorSpeechmaticsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTalkscriberTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTavusVideoFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorTogetherAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorVapiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorWellsaidVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PipelineErrorXaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        ScheduledCallDeleted,
        /// <summary>
        /// 
        /// </summary>
        SilenceTimedOut,
        /// <summary>
        /// 
        /// </summary>
        TwilioFailedToConnectCall,
        /// <summary>
        /// 
        /// </summary>
        TwilioReportedCustomerMisdialed,
        /// <summary>
        /// 
        /// </summary>
        Voicemail,
        /// <summary>
        /// 
        /// </summary>
        VonageCompleted,
        /// <summary>
        /// 
        /// </summary>
        VonageDisconnected,
        /// <summary>
        /// 
        /// </summary>
        VonageFailedToConnectCall,
        /// <summary>
        /// 
        /// </summary>
        VonageRejected,
        /// <summary>
        /// 
        /// </summary>
        WorkerShutdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageStatusUpdateEndedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageStatusUpdateEndedReason value)
        {
            return value switch
            {
                ServerMessageStatusUpdateEndedReason.AssistantEndedCall => "assistant-ended-call",
                ServerMessageStatusUpdateEndedReason.AssistantEndedCallAfterMessageSpoken => "assistant-ended-call-after-message-spoken",
                ServerMessageStatusUpdateEndedReason.AssistantEndedCallWithHangupTask => "assistant-ended-call-with-hangup-task",
                ServerMessageStatusUpdateEndedReason.AssistantForwardedCall => "assistant-forwarded-call",
                ServerMessageStatusUpdateEndedReason.AssistantJoinTimedOut => "assistant-join-timed-out",
                ServerMessageStatusUpdateEndedReason.AssistantNotFound => "assistant-not-found",
                ServerMessageStatusUpdateEndedReason.AssistantNotValid => "assistant-not-valid",
                ServerMessageStatusUpdateEndedReason.AssistantRequestFailed => "assistant-request-failed",
                ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedError => "assistant-request-returned-error",
                ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedForwardingPhoneNumber => "assistant-request-returned-forwarding-phone-number",
                ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedInvalidAssistant => "assistant-request-returned-invalid-assistant",
                ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedNoAssistant => "assistant-request-returned-no-assistant",
                ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedUnspeakableError => "assistant-request-returned-unspeakable-error",
                ServerMessageStatusUpdateEndedReason.AssistantSaidEndCallPhrase => "assistant-said-end-call-phrase",
                ServerMessageStatusUpdateEndedReason.CallDeleted => "call-deleted",
                ServerMessageStatusUpdateEndedReason.CallStartErrorNeitherAssistantNorServerSet => "call-start-error-neither-assistant-nor-server-set",
                ServerMessageStatusUpdateEndedReason.CallEndingHookExecutedSay => "call.ending.hook-executed-say",
                ServerMessageStatusUpdateEndedReason.CallEndingHookExecutedTransfer => "call.ending.hook-executed-transfer",
                ServerMessageStatusUpdateEndedReason.CallForwardingOperatorBusy => "call.forwarding.operator-busy",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio => "call.in-progress.error-assistant-did-not-receive-customer-audio",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel => "call.in-progress.error-pipeline-no-available-llm-model",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed => "call.in-progress.error-pipeline-ws-model-connection-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError => "call.in-progress.error-providerfault-anthropic-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError => "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed => "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed => "call.in-progress.error-providerfault-anthropic-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError => "call.in-progress.error-providerfault-anthropic-vertex-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed => "call.in-progress.error-providerfault-anthropic-vertex-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError => "call.in-progress.error-providerfault-anyscale-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError => "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed => "call.in-progress.error-providerfault-anyscale-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError => "call.in-progress.error-providerfault-azure-openai-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError => "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed => "call.in-progress.error-providerfault-azure-openai-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError => "call.in-progress.error-providerfault-baseten-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError => "call.in-progress.error-providerfault-baseten-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed => "call.in-progress.error-providerfault-baseten-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError => "call.in-progress.error-providerfault-cartesia-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError => "call.in-progress.error-providerfault-cartesia-503-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError => "call.in-progress.error-providerfault-cartesia-522-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError => "call.in-progress.error-providerfault-cerebras-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError => "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed => "call.in-progress.error-providerfault-cerebras-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError => "call.in-progress.error-providerfault-custom-llm-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError => "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed => "call.in-progress.error-providerfault-custom-llm-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError => "call.in-progress.error-providerfault-deep-seek-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError => "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed => "call.in-progress.error-providerfault-deep-seek-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson => "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach => "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError => "call.in-progress.error-providerfault-deepgram-returning-502-network-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError => "call.in-progress.error-providerfault-deepinfra-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError => "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed => "call.in-progress.error-providerfault-deepinfra-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError => "call.in-progress.error-providerfault-eleven-labs-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError => "call.in-progress.error-providerfault-eleven-labs-503-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade => "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError => "call.in-progress.error-providerfault-google-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError => "call.in-progress.error-providerfault-google-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed => "call.in-progress.error-providerfault-google-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGroq500ServerError => "call.in-progress.error-providerfault-groq-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError => "call.in-progress.error-providerfault-groq-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed => "call.in-progress.error-providerfault-groq-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError => "call.in-progress.error-providerfault-inflection-ai-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError => "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed => "call.in-progress.error-providerfault-inflection-ai-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultMistral500ServerError => "call.in-progress.error-providerfault-mistral-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError => "call.in-progress.error-providerfault-mistral-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed => "call.in-progress.error-providerfault-mistral-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError => "call.in-progress.error-providerfault-openai-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError => "call.in-progress.error-providerfault-openai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed => "call.in-progress.error-providerfault-openai-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError => "call.in-progress.error-providerfault-openrouter-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError => "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed => "call.in-progress.error-providerfault-openrouter-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden => "call.in-progress.error-providerfault-outbound-sip-403-forbidden",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired => "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout => "call.in-progress.error-providerfault-outbound-sip-408-request-timeout",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable => "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable => "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError => "call.in-progress.error-providerfault-perplexity-ai-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError => "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed => "call.in-progress.error-providerfault-perplexity-ai-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError => "call.in-progress.error-providerfault-playht-502-gateway-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError => "call.in-progress.error-providerfault-playht-504-gateway-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError => "call.in-progress.error-providerfault-runpod-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError => "call.in-progress.error-providerfault-runpod-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed => "call.in-progress.error-providerfault-runpod-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError => "call.in-progress.error-providerfault-together-ai-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError => "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed => "call.in-progress.error-providerfault-together-ai-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected => "call.in-progress.error-providerfault-transport-never-connected",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultVapi500ServerError => "call.in-progress.error-providerfault-vapi-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError => "call.in-progress.error-providerfault-vapi-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed => "call.in-progress.error-providerfault-vapi-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultXai500ServerError => "call.in-progress.error-providerfault-xai-500-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError => "call.in-progress.error-providerfault-xai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed => "call.in-progress.error-providerfault-xai-llm-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorSipInboundCallFailedToConnect => "call.in-progress.error-sip-inbound-call-failed-to-connect",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect => "call.in-progress.error-sip-outbound-call-failed-to-connect",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorTransferFailed => "call.in-progress.error-transfer-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized => "call.in-progress.error-vapifault-anthropic-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota => "call.in-progress.error-vapifault-anthropic-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized => "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota => "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized => "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota => "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed => "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized => "call.in-progress.error-vapifault-anyscale-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied => "call.in-progress.error-vapifault-anyscale-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota => "call.in-progress.error-vapifault-anyscale-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds => "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature => "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials => "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema => "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed => "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed => "call.in-progress.error-vapifault-assembly-ai-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed => "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized => "call.in-progress.error-vapifault-azure-openai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied => "call.in-progress.error-vapifault-azure-openai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota => "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed => "call.in-progress.error-vapifault-azure-speech-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed => "call.in-progress.error-vapifault-azure-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed => "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized => "call.in-progress.error-vapifault-baseten-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied => "call.in-progress.error-vapifault-baseten-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota => "call.in-progress.error-vapifault-baseten-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing => "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment => "call.in-progress.error-vapifault-cartesia-requested-payment",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp => "call.in-progress.error-vapifault-cartesia-socket-hang-up",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed => "call.in-progress.error-vapifault-cartesia-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed => "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized => "call.in-progress.error-vapifault-cerebras-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied => "call.in-progress.error-vapifault-cerebras-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota => "call.in-progress.error-vapifault-cerebras-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart => "call.in-progress.error-vapifault-chat-pipeline-failed-to-start",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed => "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized => "call.in-progress.error-vapifault-custom-llm-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied => "call.in-progress.error-vapifault-custom-llm-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota => "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed => "call.in-progress.error-vapifault-custom-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed => "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized => "call.in-progress.error-vapifault-deep-seek-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied => "call.in-progress.error-vapifault-deep-seek-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota => "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination => "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials => "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied => "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound => "call.in-progress.error-vapifault-deepgram-returning-404-not-found",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed => "call.in-progress.error-vapifault-deepgram-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed => "call.in-progress.error-vapifault-deepgram-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed => "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized => "call.in-progress.error-vapifault-deepinfra-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied => "call.in-progress.error-vapifault-deepinfra-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota => "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation => "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy => "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification => "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey => "call.in-progress.error-vapifault-eleven-labs-invalid-api-key",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples => "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded => "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone => "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus => "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded => "call.in-progress.error-vapifault-eleven-labs-quota-exceeded",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed => "call.in-progress.error-vapifault-eleven-labs-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess => "call.in-progress.error-vapifault-eleven-labs-unauthorized-access",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel => "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner => "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed => "call.in-progress.error-vapifault-eleven-labs-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers => "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned => "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed => "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound => "call.in-progress.error-vapifault-eleven-labs-voice-not-found",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed => "call.in-progress.error-vapifault-gladia-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed => "call.in-progress.error-vapifault-google-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized => "call.in-progress.error-vapifault-google-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied => "call.in-progress.error-vapifault-google-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota => "call.in-progress.error-vapifault-google-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed => "call.in-progress.error-vapifault-google-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed => "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized => "call.in-progress.error-vapifault-groq-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied => "call.in-progress.error-vapifault-groq-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota => "call.in-progress.error-vapifault-groq-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed => "call.in-progress.error-vapifault-hume-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized => "call.in-progress.error-vapifault-inflection-ai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied => "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota => "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed => "call.in-progress.error-vapifault-inworld-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed => "call.in-progress.error-vapifault-lmnt-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed => "call.in-progress.error-vapifault-minimax-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed => "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized => "call.in-progress.error-vapifault-mistral-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied => "call.in-progress.error-vapifault-mistral-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota => "call.in-progress.error-vapifault-mistral-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed => "call.in-progress.error-vapifault-neuphonic-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed => "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization => "call.in-progress.error-vapifault-openai-401-account-not-in-organization",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey => "call.in-progress.error-vapifault-openai-401-incorrect-api-key",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized => "call.in-progress.error-vapifault-openai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied => "call.in-progress.error-vapifault-openai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota => "call.in-progress.error-vapifault-openai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached => "call.in-progress.error-vapifault-openai-429-rate-limit-reached",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed => "call.in-progress.error-vapifault-openai-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed => "call.in-progress.error-vapifault-openai-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed => "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized => "call.in-progress.error-vapifault-openrouter-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied => "call.in-progress.error-vapifault-openrouter-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota => "call.in-progress.error-vapifault-openrouter-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized => "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied => "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota => "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized => "call.in-progress.error-vapifault-playht-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable => "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters => "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota => "call.in-progress.error-vapifault-playht-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion => "call.in-progress.error-vapifault-playht-invalid-emotion",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice => "call.in-progress.error-vapifault-playht-invalid-voice",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits => "call.in-progress.error-vapifault-playht-out-of-credits",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut => "call.in-progress.error-vapifault-playht-request-timed-out",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError => "call.in-progress.error-vapifault-playht-unexpected-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed => "call.in-progress.error-vapifault-playht-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri => "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed => "call.in-progress.error-vapifault-rime-ai-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed => "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized => "call.in-progress.error-vapifault-runpod-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied => "call.in-progress.error-vapifault-runpod-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota => "call.in-progress.error-vapifault-runpod-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed => "call.in-progress.error-vapifault-sesame-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed => "call.in-progress.error-vapifault-smallest-ai-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed => "call.in-progress.error-vapifault-soniox-transcriber-auth-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed => "call.in-progress.error-vapifault-soniox-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig => "call.in-progress.error-vapifault-soniox-transcriber-invalid-config",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited => "call.in-progress.error-vapifault-soniox-transcriber-rate-limited",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError => "call.in-progress.error-vapifault-soniox-transcriber-server-error",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed => "call.in-progress.error-vapifault-speechmatics-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed => "call.in-progress.error-vapifault-talkscriber-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTavusVideoFailed => "call.in-progress.error-vapifault-tavus-video-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized => "call.in-progress.error-vapifault-together-ai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied => "call.in-progress.error-vapifault-together-ai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota => "call.in-progress.error-vapifault-together-ai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive => "call.in-progress.error-vapifault-transport-connected-but-call-not-active",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTransportNeverConnected => "call.in-progress.error-vapifault-transport-never-connected",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed => "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized => "call.in-progress.error-vapifault-vapi-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied => "call.in-progress.error-vapifault-vapi-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota => "call.in-progress.error-vapifault-vapi-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed => "call.in-progress.error-vapifault-vapi-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed => "call.in-progress.error-vapifault-wellsaid-voice-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultWorkerDied => "call.in-progress.error-vapifault-worker-died",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable => "call.in-progress.error-vapifault-worker-not-available",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed => "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai401Unauthorized => "call.in-progress.error-vapifault-xai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied => "call.in-progress.error-vapifault-xai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota => "call.in-progress.error-vapifault-xai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferAssistantCancelled => "call.in-progress.error-warm-transfer-assistant-cancelled",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferMaxDuration => "call.in-progress.error-warm-transfer-max-duration",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout => "call.in-progress.error-warm-transfer-microphone-timeout",
                ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferSilenceTimeout => "call.in-progress.error-warm-transfer-silence-timeout",
                ServerMessageStatusUpdateEndedReason.CallInProgressSipCompletedCall => "call.in-progress.sip-completed-call",
                ServerMessageStatusUpdateEndedReason.CallInProgressTwilioCompletedCall => "call.in-progress.twilio-completed-call",
                ServerMessageStatusUpdateEndedReason.CallRingingErrorSipInboundCallFailedToConnect => "call.ringing.error-sip-inbound-call-failed-to-connect",
                ServerMessageStatusUpdateEndedReason.CallRingingHookExecutedSay => "call.ringing.hook-executed-say",
                ServerMessageStatusUpdateEndedReason.CallRingingHookExecutedTransfer => "call.ringing.hook-executed-transfer",
                ServerMessageStatusUpdateEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect => "call.ringing.sip-inbound-caller-hungup-before-call-connect",
                ServerMessageStatusUpdateEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent => "call.start.error-enterprise-feature-not-available-recording-consent",
                ServerMessageStatusUpdateEndedReason.CallStartErrorFraudCheckFailed => "call.start.error-fraud-check-failed",
                ServerMessageStatusUpdateEndedReason.CallStartErrorGetAssistant => "call.start.error-get-assistant",
                ServerMessageStatusUpdateEndedReason.CallStartErrorGetCustomer => "call.start.error-get-customer",
                ServerMessageStatusUpdateEndedReason.CallStartErrorGetPhoneNumber => "call.start.error-get-phone-number",
                ServerMessageStatusUpdateEndedReason.CallStartErrorGetResourcesValidation => "call.start.error-get-resources-validation",
                ServerMessageStatusUpdateEndedReason.CallStartErrorGetTransport => "call.start.error-get-transport",
                ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached => "call.start.error-subscription-concurrency-limit-reached",
                ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionFrozen => "call.start.error-subscription-frozen",
                ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionInsufficientCredits => "call.start.error-subscription-insufficient-credits",
                ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionUpgradeFailed => "call.start.error-subscription-upgrade-failed",
                ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionWalletDoesNotExist => "call.start.error-subscription-wallet-does-not-exist",
                ServerMessageStatusUpdateEndedReason.CallStartErrorVapiNumberInternational => "call.start.error-vapi-number-international",
                ServerMessageStatusUpdateEndedReason.CallStartErrorVapiNumberOutboundDailyLimit => "call.start.error-vapi-number-outbound-daily-limit",
                ServerMessageStatusUpdateEndedReason.CallStartErrorVapifaultDatabaseError => "call.start.error-vapifault-database-error",
                ServerMessageStatusUpdateEndedReason.CallStartErrorVapifaultGetOrg => "call.start.error-vapifault-get-org",
                ServerMessageStatusUpdateEndedReason.CallStartErrorVapifaultGetSubscription => "call.start.error-vapifault-get-subscription",
                ServerMessageStatusUpdateEndedReason.CustomerBusy => "customer-busy",
                ServerMessageStatusUpdateEndedReason.CustomerDidNotAnswer => "customer-did-not-answer",
                ServerMessageStatusUpdateEndedReason.CustomerDidNotGiveMicrophonePermission => "customer-did-not-give-microphone-permission",
                ServerMessageStatusUpdateEndedReason.CustomerEndedCall => "customer-ended-call",
                ServerMessageStatusUpdateEndedReason.CustomerEndedCallAfterWarmTransferAttempt => "customer-ended-call-after-warm-transfer-attempt",
                ServerMessageStatusUpdateEndedReason.CustomerEndedCallBeforeWarmTransfer => "customer-ended-call-before-warm-transfer",
                ServerMessageStatusUpdateEndedReason.CustomerEndedCallDuringTransfer => "customer-ended-call-during-transfer",
                ServerMessageStatusUpdateEndedReason.ExceededMaxDuration => "exceeded-max-duration",
                ServerMessageStatusUpdateEndedReason.ManuallyCanceled => "manually-canceled",
                ServerMessageStatusUpdateEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived => "phone-call-provider-bypass-enabled-but-no-call-received",
                ServerMessageStatusUpdateEndedReason.PhoneCallProviderClosedWebsocket => "phone-call-provider-closed-websocket",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed => "pipeline-error-anthropic-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic401Unauthorized => "pipeline-error-anthropic-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic403ModelAccessDenied => "pipeline-error-anthropic-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic429ExceededQuota => "pipeline-error-anthropic-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic500ServerError => "pipeline-error-anthropic-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic503ServerOverloadedError => "pipeline-error-anthropic-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed => "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock401Unauthorized => "pipeline-error-anthropic-bedrock-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied => "pipeline-error-anthropic-bedrock-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota => "pipeline-error-anthropic-bedrock-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock500ServerError => "pipeline-error-anthropic-bedrock-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError => "pipeline-error-anthropic-bedrock-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrockLlmFailed => "pipeline-error-anthropic-bedrock-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicLlmFailed => "pipeline-error-anthropic-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed => "pipeline-error-anthropic-vertex-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex401Unauthorized => "pipeline-error-anthropic-vertex-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied => "pipeline-error-anthropic-vertex-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex429ExceededQuota => "pipeline-error-anthropic-vertex-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex500ServerError => "pipeline-error-anthropic-vertex-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError => "pipeline-error-anthropic-vertex-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertexLlmFailed => "pipeline-error-anthropic-vertex-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed => "pipeline-error-anyscale-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale401Unauthorized => "pipeline-error-anyscale-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale403ModelAccessDenied => "pipeline-error-anyscale-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale429ExceededQuota => "pipeline-error-anyscale-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale500ServerError => "pipeline-error-anyscale-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale503ServerOverloadedError => "pipeline-error-anyscale-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscaleLlmFailed => "pipeline-error-anyscale-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds => "pipeline-error-assembly-ai-returning-400-insufficent-funds",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature => "pipeline-error-assembly-ai-returning-400-paid-only-feature",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials => "pipeline-error-assembly-ai-returning-401-invalid-credentials",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema => "pipeline-error-assembly-ai-returning-500-invalid-schema",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed => "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiTranscriberFailed => "pipeline-error-assembly-ai-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed => "pipeline-error-azure-openai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai401Unauthorized => "pipeline-error-azure-openai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied => "pipeline-error-azure-openai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai429ExceededQuota => "pipeline-error-azure-openai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai500ServerError => "pipeline-error-azure-openai-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError => "pipeline-error-azure-openai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenaiLlmFailed => "pipeline-error-azure-openai-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureSpeechTranscriberFailed => "pipeline-error-azure-speech-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorAzureVoiceFailed => "pipeline-error-azure-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten400BadRequestValidationFailed => "pipeline-error-baseten-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten401Unauthorized => "pipeline-error-baseten-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten403ModelAccessDenied => "pipeline-error-baseten-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten429ExceededQuota => "pipeline-error-baseten-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten500ServerError => "pipeline-error-baseten-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten503ServerOverloadedError => "pipeline-error-baseten-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorBasetenLlmFailed => "pipeline-error-baseten-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia500ServerError => "pipeline-error-cartesia-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia502ServerError => "pipeline-error-cartesia-502-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia503ServerError => "pipeline-error-cartesia-503-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia522ServerError => "pipeline-error-cartesia-522-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesiaRequestedPayment => "pipeline-error-cartesia-requested-payment",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesiaSocketHangUp => "pipeline-error-cartesia-socket-hang-up",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCartesiaVoiceFailed => "pipeline-error-cartesia-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras400BadRequestValidationFailed => "pipeline-error-cerebras-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras401Unauthorized => "pipeline-error-cerebras-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras403ModelAccessDenied => "pipeline-error-cerebras-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras429ExceededQuota => "pipeline-error-cerebras-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras500ServerError => "pipeline-error-cerebras-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras503ServerOverloadedError => "pipeline-error-cerebras-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCerebrasLlmFailed => "pipeline-error-cerebras-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed => "pipeline-error-custom-llm-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm401Unauthorized => "pipeline-error-custom-llm-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm403ModelAccessDenied => "pipeline-error-custom-llm-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm429ExceededQuota => "pipeline-error-custom-llm-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm500ServerError => "pipeline-error-custom-llm-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm503ServerOverloadedError => "pipeline-error-custom-llm-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlmLlmFailed => "pipeline-error-custom-llm-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomTranscriberFailed => "pipeline-error-custom-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorCustomVoiceFailed => "pipeline-error-custom-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed => "pipeline-error-deep-seek-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek401Unauthorized => "pipeline-error-deep-seek-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek403ModelAccessDenied => "pipeline-error-deep-seek-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek429ExceededQuota => "pipeline-error-deep-seek-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek500ServerError => "pipeline-error-deep-seek-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek503ServerOverloadedError => "pipeline-error-deep-seek-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeekLlmFailed => "pipeline-error-deep-seek-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination => "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials => "pipeline-error-deepgram-returning-401-invalid-credentials",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied => "pipeline-error-deepgram-returning-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning404NotFound => "pipeline-error-deepgram-returning-404-not-found",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning500InvalidJson => "pipeline-error-deepgram-returning-500-invalid-json",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach => "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning502NetworkError => "pipeline-error-deepgram-returning-502-network-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturningEconnreset => "pipeline-error-deepgram-returning-econnreset",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing => "pipeline-error-deepgram-transcriber-api-key-missing",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramTranscriberFailed => "pipeline-error-deepgram-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramVoiceFailed => "pipeline-error-deepgram-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed => "pipeline-error-deepinfra-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra401Unauthorized => "pipeline-error-deepinfra-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra403ModelAccessDenied => "pipeline-error-deepinfra-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra429ExceededQuota => "pipeline-error-deepinfra-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra500ServerError => "pipeline-error-deepinfra-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra503ServerOverloadedError => "pipeline-error-deepinfra-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfraLlmFailed => "pipeline-error-deepinfra-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabs500ServerError => "pipeline-error-eleven-labs-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabs503ServerError => "pipeline-error-eleven-labs-503-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation => "pipeline-error-eleven-labs-blocked-account-in-probation",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy => "pipeline-error-eleven-labs-blocked-content-against-their-policy",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification => "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsInvalidApiKey => "pipeline-error-eleven-labs-invalid-api-key",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples => "pipeline-error-eleven-labs-invalid-voice-samples",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded => "pipeline-error-eleven-labs-max-character-limit-exceeded",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone => "pipeline-error-eleven-labs-missing-samples-for-voice-clone",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus => "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsQuotaExceeded => "pipeline-error-eleven-labs-quota-exceeded",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade => "pipeline-error-eleven-labs-system-busy-and-requested-upgrade",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsTranscriberFailed => "pipeline-error-eleven-labs-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsUnauthorizedAccess => "pipeline-error-eleven-labs-unauthorized-access",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel => "pipeline-error-eleven-labs-unauthorized-to-access-model",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner => "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner => "pipeline-error-eleven-labs-voice-disabled-by-owner",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceFailed => "pipeline-error-eleven-labs-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers => "pipeline-error-eleven-labs-voice-not-allowed-for-free-users",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned => "pipeline-error-eleven-labs-voice-not-fine-tuned",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed => "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
                ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotFound => "pipeline-error-eleven-labs-voice-not-found",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGladiaTranscriberFailed => "pipeline-error-gladia-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle400BadRequestValidationFailed => "pipeline-error-google-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle401Unauthorized => "pipeline-error-google-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle403ModelAccessDenied => "pipeline-error-google-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle429ExceededQuota => "pipeline-error-google-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle500ServerError => "pipeline-error-google-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle503ServerOverloadedError => "pipeline-error-google-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogleLlmFailed => "pipeline-error-google-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGoogleTranscriberFailed => "pipeline-error-google-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroq400BadRequestValidationFailed => "pipeline-error-groq-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroq401Unauthorized => "pipeline-error-groq-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroq403ModelAccessDenied => "pipeline-error-groq-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroq429ExceededQuota => "pipeline-error-groq-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroq500ServerError => "pipeline-error-groq-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroq503ServerOverloadedError => "pipeline-error-groq-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorGroqLlmFailed => "pipeline-error-groq-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorHumeVoiceFailed => "pipeline-error-hume-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed => "pipeline-error-inflection-ai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi401Unauthorized => "pipeline-error-inflection-ai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi403ModelAccessDenied => "pipeline-error-inflection-ai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi429ExceededQuota => "pipeline-error-inflection-ai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi500ServerError => "pipeline-error-inflection-ai-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi503ServerOverloadedError => "pipeline-error-inflection-ai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAiLlmFailed => "pipeline-error-inflection-ai-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorInworldVoiceFailed => "pipeline-error-inworld-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorLmntVoiceFailed => "pipeline-error-lmnt-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMinimaxVoiceFailed => "pipeline-error-minimax-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistral400BadRequestValidationFailed => "pipeline-error-mistral-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistral401Unauthorized => "pipeline-error-mistral-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistral403ModelAccessDenied => "pipeline-error-mistral-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistral429ExceededQuota => "pipeline-error-mistral-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistral500ServerError => "pipeline-error-mistral-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistral503ServerOverloadedError => "pipeline-error-mistral-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorMistralLlmFailed => "pipeline-error-mistral-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorNeuphonicVoiceFailed => "pipeline-error-neuphonic-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai400BadRequestValidationFailed => "pipeline-error-openai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai401AccountNotInOrganization => "pipeline-error-openai-401-account-not-in-organization",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai401IncorrectApiKey => "pipeline-error-openai-401-incorrect-api-key",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai401Unauthorized => "pipeline-error-openai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai403ModelAccessDenied => "pipeline-error-openai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai429ExceededQuota => "pipeline-error-openai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai429RateLimitReached => "pipeline-error-openai-429-rate-limit-reached",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai500ServerError => "pipeline-error-openai-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai503ServerOverloadedError => "pipeline-error-openai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenaiLlmFailed => "pipeline-error-openai-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenaiTranscriberFailed => "pipeline-error-openai-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenaiVoiceFailed => "pipeline-error-openai-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed => "pipeline-error-openrouter-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter401Unauthorized => "pipeline-error-openrouter-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter403ModelAccessDenied => "pipeline-error-openrouter-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter429ExceededQuota => "pipeline-error-openrouter-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter500ServerError => "pipeline-error-openrouter-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter503ServerOverloadedError => "pipeline-error-openrouter-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouterLlmFailed => "pipeline-error-openrouter-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed => "pipeline-error-perplexity-ai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi401Unauthorized => "pipeline-error-perplexity-ai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied => "pipeline-error-perplexity-ai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi429ExceededQuota => "pipeline-error-perplexity-ai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi500ServerError => "pipeline-error-perplexity-ai-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError => "pipeline-error-perplexity-ai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAiLlmFailed => "pipeline-error-perplexity-ai-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht401Unauthorized => "pipeline-error-playht-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable => "pipeline-error-playht-403-forbidden-api-access-not-available",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters => "pipeline-error-playht-403-forbidden-out-of-characters",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht429ExceededQuota => "pipeline-error-playht-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht502GatewayError => "pipeline-error-playht-502-gateway-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht504GatewayError => "pipeline-error-playht-504-gateway-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtInvalidEmotion => "pipeline-error-playht-invalid-emotion",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtInvalidVoice => "pipeline-error-playht-invalid-voice",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtOutOfCredits => "pipeline-error-playht-out-of-credits",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtRequestTimedOut => "pipeline-error-playht-request-timed-out",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtUnexpectedError => "pipeline-error-playht-unexpected-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtVoiceFailed => "pipeline-error-playht-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri => "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRimeAiVoiceFailed => "pipeline-error-rime-ai-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod400BadRequestValidationFailed => "pipeline-error-runpod-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod401Unauthorized => "pipeline-error-runpod-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod403ModelAccessDenied => "pipeline-error-runpod-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod429ExceededQuota => "pipeline-error-runpod-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod500ServerError => "pipeline-error-runpod-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod503ServerOverloadedError => "pipeline-error-runpod-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorRunpodLlmFailed => "pipeline-error-runpod-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSesameVoiceFailed => "pipeline-error-sesame-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSmallestAiVoiceFailed => "pipeline-error-smallest-ai-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberAuthFailed => "pipeline-error-soniox-transcriber-auth-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberFailed => "pipeline-error-soniox-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberInvalidConfig => "pipeline-error-soniox-transcriber-invalid-config",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberRateLimited => "pipeline-error-soniox-transcriber-rate-limited",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberServerError => "pipeline-error-soniox-transcriber-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorSpeechmaticsTranscriberFailed => "pipeline-error-speechmatics-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTalkscriberTranscriberFailed => "pipeline-error-talkscriber-transcriber-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTavusVideoFailed => "pipeline-error-tavus-video-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed => "pipeline-error-together-ai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi401Unauthorized => "pipeline-error-together-ai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi403ModelAccessDenied => "pipeline-error-together-ai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi429ExceededQuota => "pipeline-error-together-ai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi500ServerError => "pipeline-error-together-ai-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi503ServerOverloadedError => "pipeline-error-together-ai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAiLlmFailed => "pipeline-error-together-ai-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapi400BadRequestValidationFailed => "pipeline-error-vapi-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapi401Unauthorized => "pipeline-error-vapi-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapi403ModelAccessDenied => "pipeline-error-vapi-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapi429ExceededQuota => "pipeline-error-vapi-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapi500ServerError => "pipeline-error-vapi-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapi503ServerOverloadedError => "pipeline-error-vapi-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapiLlmFailed => "pipeline-error-vapi-llm-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorVapiVoiceFailed => "pipeline-error-vapi-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorWellsaidVoiceFailed => "pipeline-error-wellsaid-voice-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXai400BadRequestValidationFailed => "pipeline-error-xai-400-bad-request-validation-failed",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXai401Unauthorized => "pipeline-error-xai-401-unauthorized",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXai403ModelAccessDenied => "pipeline-error-xai-403-model-access-denied",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXai429ExceededQuota => "pipeline-error-xai-429-exceeded-quota",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXai500ServerError => "pipeline-error-xai-500-server-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXai503ServerOverloadedError => "pipeline-error-xai-503-server-overloaded-error",
                ServerMessageStatusUpdateEndedReason.PipelineErrorXaiLlmFailed => "pipeline-error-xai-llm-failed",
                ServerMessageStatusUpdateEndedReason.ScheduledCallDeleted => "scheduled-call-deleted",
                ServerMessageStatusUpdateEndedReason.SilenceTimedOut => "silence-timed-out",
                ServerMessageStatusUpdateEndedReason.TwilioFailedToConnectCall => "twilio-failed-to-connect-call",
                ServerMessageStatusUpdateEndedReason.TwilioReportedCustomerMisdialed => "twilio-reported-customer-misdialed",
                ServerMessageStatusUpdateEndedReason.Voicemail => "voicemail",
                ServerMessageStatusUpdateEndedReason.VonageCompleted => "vonage-completed",
                ServerMessageStatusUpdateEndedReason.VonageDisconnected => "vonage-disconnected",
                ServerMessageStatusUpdateEndedReason.VonageFailedToConnectCall => "vonage-failed-to-connect-call",
                ServerMessageStatusUpdateEndedReason.VonageRejected => "vonage-rejected",
                ServerMessageStatusUpdateEndedReason.WorkerShutdown => "worker-shutdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageStatusUpdateEndedReason? ToEnum(string value)
        {
            return value switch
            {
                "assistant-ended-call" => ServerMessageStatusUpdateEndedReason.AssistantEndedCall,
                "assistant-ended-call-after-message-spoken" => ServerMessageStatusUpdateEndedReason.AssistantEndedCallAfterMessageSpoken,
                "assistant-ended-call-with-hangup-task" => ServerMessageStatusUpdateEndedReason.AssistantEndedCallWithHangupTask,
                "assistant-forwarded-call" => ServerMessageStatusUpdateEndedReason.AssistantForwardedCall,
                "assistant-join-timed-out" => ServerMessageStatusUpdateEndedReason.AssistantJoinTimedOut,
                "assistant-not-found" => ServerMessageStatusUpdateEndedReason.AssistantNotFound,
                "assistant-not-valid" => ServerMessageStatusUpdateEndedReason.AssistantNotValid,
                "assistant-request-failed" => ServerMessageStatusUpdateEndedReason.AssistantRequestFailed,
                "assistant-request-returned-error" => ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedError,
                "assistant-request-returned-forwarding-phone-number" => ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedForwardingPhoneNumber,
                "assistant-request-returned-invalid-assistant" => ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedInvalidAssistant,
                "assistant-request-returned-no-assistant" => ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedNoAssistant,
                "assistant-request-returned-unspeakable-error" => ServerMessageStatusUpdateEndedReason.AssistantRequestReturnedUnspeakableError,
                "assistant-said-end-call-phrase" => ServerMessageStatusUpdateEndedReason.AssistantSaidEndCallPhrase,
                "call-deleted" => ServerMessageStatusUpdateEndedReason.CallDeleted,
                "call-start-error-neither-assistant-nor-server-set" => ServerMessageStatusUpdateEndedReason.CallStartErrorNeitherAssistantNorServerSet,
                "call.ending.hook-executed-say" => ServerMessageStatusUpdateEndedReason.CallEndingHookExecutedSay,
                "call.ending.hook-executed-transfer" => ServerMessageStatusUpdateEndedReason.CallEndingHookExecutedTransfer,
                "call.forwarding.operator-busy" => ServerMessageStatusUpdateEndedReason.CallForwardingOperatorBusy,
                "call.in-progress.error-assistant-did-not-receive-customer-audio" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio,
                "call.in-progress.error-pipeline-no-available-llm-model" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel,
                "call.in-progress.error-pipeline-ws-model-connection-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed,
                "call.in-progress.error-providerfault-anthropic-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError,
                "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,
                "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,
                "call.in-progress.error-providerfault-anthropic-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed,
                "call.in-progress.error-providerfault-anthropic-vertex-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError,
                "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-vertex-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,
                "call.in-progress.error-providerfault-anyscale-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError,
                "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,
                "call.in-progress.error-providerfault-anyscale-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed,
                "call.in-progress.error-providerfault-azure-openai-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError,
                "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,
                "call.in-progress.error-providerfault-azure-openai-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,
                "call.in-progress.error-providerfault-baseten-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError,
                "call.in-progress.error-providerfault-baseten-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,
                "call.in-progress.error-providerfault-baseten-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed,
                "call.in-progress.error-providerfault-cartesia-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError,
                "call.in-progress.error-providerfault-cartesia-503-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError,
                "call.in-progress.error-providerfault-cartesia-522-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError,
                "call.in-progress.error-providerfault-cerebras-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError,
                "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,
                "call.in-progress.error-providerfault-cerebras-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed,
                "call.in-progress.error-providerfault-custom-llm-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError,
                "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,
                "call.in-progress.error-providerfault-custom-llm-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed,
                "call.in-progress.error-providerfault-deep-seek-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError,
                "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,
                "call.in-progress.error-providerfault-deep-seek-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed,
                "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,
                "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,
                "call.in-progress.error-providerfault-deepgram-returning-502-network-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,
                "call.in-progress.error-providerfault-deepinfra-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError,
                "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,
                "call.in-progress.error-providerfault-deepinfra-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed,
                "call.in-progress.error-providerfault-eleven-labs-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError,
                "call.in-progress.error-providerfault-eleven-labs-503-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError,
                "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,
                "call.in-progress.error-providerfault-google-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError,
                "call.in-progress.error-providerfault-google-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,
                "call.in-progress.error-providerfault-google-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed,
                "call.in-progress.error-providerfault-groq-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGroq500ServerError,
                "call.in-progress.error-providerfault-groq-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError,
                "call.in-progress.error-providerfault-groq-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed,
                "call.in-progress.error-providerfault-inflection-ai-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError,
                "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-inflection-ai-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed,
                "call.in-progress.error-providerfault-mistral-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultMistral500ServerError,
                "call.in-progress.error-providerfault-mistral-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError,
                "call.in-progress.error-providerfault-mistral-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed,
                "call.in-progress.error-providerfault-openai-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError,
                "call.in-progress.error-providerfault-openai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,
                "call.in-progress.error-providerfault-openai-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed,
                "call.in-progress.error-providerfault-openrouter-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError,
                "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,
                "call.in-progress.error-providerfault-openrouter-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed,
                "call.in-progress.error-providerfault-outbound-sip-403-forbidden" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden,
                "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,
                "call.in-progress.error-providerfault-outbound-sip-408-request-timeout" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,
                "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,
                "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,
                "call.in-progress.error-providerfault-perplexity-ai-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError,
                "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-perplexity-ai-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed,
                "call.in-progress.error-providerfault-playht-502-gateway-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError,
                "call.in-progress.error-providerfault-playht-504-gateway-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError,
                "call.in-progress.error-providerfault-runpod-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError,
                "call.in-progress.error-providerfault-runpod-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,
                "call.in-progress.error-providerfault-runpod-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed,
                "call.in-progress.error-providerfault-together-ai-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError,
                "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-together-ai-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed,
                "call.in-progress.error-providerfault-transport-never-connected" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected,
                "call.in-progress.error-providerfault-vapi-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultVapi500ServerError,
                "call.in-progress.error-providerfault-vapi-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError,
                "call.in-progress.error-providerfault-vapi-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed,
                "call.in-progress.error-providerfault-xai-500-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultXai500ServerError,
                "call.in-progress.error-providerfault-xai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError,
                "call.in-progress.error-providerfault-xai-llm-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed,
                "call.in-progress.error-sip-inbound-call-failed-to-connect" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorSipInboundCallFailedToConnect,
                "call.in-progress.error-sip-outbound-call-failed-to-connect" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect,
                "call.in-progress.error-transfer-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorTransferFailed,
                "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota,
                "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,
                "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,
                "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anyscale-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized,
                "call.in-progress.error-vapifault-anyscale-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,
                "call.in-progress.error-vapifault-anyscale-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota,
                "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,
                "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,
                "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,
                "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,
                "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,
                "call.in-progress.error-vapifault-assembly-ai-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,
                "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-azure-openai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized,
                "call.in-progress.error-vapifault-azure-openai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,
                "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,
                "call.in-progress.error-vapifault-azure-speech-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,
                "call.in-progress.error-vapifault-azure-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed,
                "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-baseten-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized,
                "call.in-progress.error-vapifault-baseten-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied,
                "call.in-progress.error-vapifault-baseten-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota,
                "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,
                "call.in-progress.error-vapifault-cartesia-requested-payment" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment,
                "call.in-progress.error-vapifault-cartesia-socket-hang-up" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp,
                "call.in-progress.error-vapifault-cartesia-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed,
                "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-cerebras-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized,
                "call.in-progress.error-vapifault-cerebras-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied,
                "call.in-progress.error-vapifault-cerebras-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota,
                "call.in-progress.error-vapifault-chat-pipeline-failed-to-start" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart,
                "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-custom-llm-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized,
                "call.in-progress.error-vapifault-custom-llm-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,
                "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota,
                "call.in-progress.error-vapifault-custom-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed,
                "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-deep-seek-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized,
                "call.in-progress.error-vapifault-deep-seek-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,
                "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota,
                "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,
                "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,
                "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,
                "call.in-progress.error-vapifault-deepgram-returning-404-not-found" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound,
                "call.in-progress.error-vapifault-deepgram-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed,
                "call.in-progress.error-vapifault-deepgram-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed,
                "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-deepinfra-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized,
                "call.in-progress.error-vapifault-deepinfra-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,
                "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota,
                "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,
                "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,
                "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
                "call.in-progress.error-vapifault-eleven-labs-invalid-api-key" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey,
                "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,
                "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,
                "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,
                "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,
                "call.in-progress.error-vapifault-eleven-labs-quota-exceeded" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded,
                "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed,
                "call.in-progress.error-vapifault-eleven-labs-unauthorized-access" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,
                "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,
                "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,
                "call.in-progress.error-vapifault-eleven-labs-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-found" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound,
                "call.in-progress.error-vapifault-gladia-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed,
                "call.in-progress.error-vapifault-google-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-google-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized,
                "call.in-progress.error-vapifault-google-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied,
                "call.in-progress.error-vapifault-google-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota,
                "call.in-progress.error-vapifault-google-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed,
                "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-groq-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized,
                "call.in-progress.error-vapifault-groq-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied,
                "call.in-progress.error-vapifault-groq-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota,
                "call.in-progress.error-vapifault-hume-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed,
                "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-inflection-ai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized,
                "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota,
                "call.in-progress.error-vapifault-inworld-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed,
                "call.in-progress.error-vapifault-lmnt-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed,
                "call.in-progress.error-vapifault-minimax-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed,
                "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-mistral-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized,
                "call.in-progress.error-vapifault-mistral-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied,
                "call.in-progress.error-vapifault-mistral-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota,
                "call.in-progress.error-vapifault-neuphonic-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed,
                "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-openai-401-account-not-in-organization" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,
                "call.in-progress.error-vapifault-openai-401-incorrect-api-key" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey,
                "call.in-progress.error-vapifault-openai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized,
                "call.in-progress.error-vapifault-openai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied,
                "call.in-progress.error-vapifault-openai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota,
                "call.in-progress.error-vapifault-openai-429-rate-limit-reached" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached,
                "call.in-progress.error-vapifault-openai-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed,
                "call.in-progress.error-vapifault-openai-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed,
                "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-openrouter-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized,
                "call.in-progress.error-vapifault-openrouter-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,
                "call.in-progress.error-vapifault-openrouter-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota,
                "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized,
                "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,
                "call.in-progress.error-vapifault-playht-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized,
                "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,
                "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,
                "call.in-progress.error-vapifault-playht-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota,
                "call.in-progress.error-vapifault-playht-invalid-emotion" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion,
                "call.in-progress.error-vapifault-playht-invalid-voice" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice,
                "call.in-progress.error-vapifault-playht-out-of-credits" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits,
                "call.in-progress.error-vapifault-playht-request-timed-out" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut,
                "call.in-progress.error-vapifault-playht-unexpected-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError,
                "call.in-progress.error-vapifault-playht-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed,
                "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,
                "call.in-progress.error-vapifault-rime-ai-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed,
                "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-runpod-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized,
                "call.in-progress.error-vapifault-runpod-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied,
                "call.in-progress.error-vapifault-runpod-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota,
                "call.in-progress.error-vapifault-sesame-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed,
                "call.in-progress.error-vapifault-smallest-ai-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-auth-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-invalid-config" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,
                "call.in-progress.error-vapifault-soniox-transcriber-rate-limited" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited,
                "call.in-progress.error-vapifault-soniox-transcriber-server-error" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError,
                "call.in-progress.error-vapifault-speechmatics-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,
                "call.in-progress.error-vapifault-talkscriber-transcriber-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed,
                "call.in-progress.error-vapifault-tavus-video-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTavusVideoFailed,
                "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-together-ai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized,
                "call.in-progress.error-vapifault-together-ai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-together-ai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota,
                "call.in-progress.error-vapifault-transport-connected-but-call-not-active" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive,
                "call.in-progress.error-vapifault-transport-never-connected" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultTransportNeverConnected,
                "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-vapi-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized,
                "call.in-progress.error-vapifault-vapi-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied,
                "call.in-progress.error-vapifault-vapi-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota,
                "call.in-progress.error-vapifault-vapi-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed,
                "call.in-progress.error-vapifault-wellsaid-voice-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed,
                "call.in-progress.error-vapifault-worker-died" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultWorkerDied,
                "call.in-progress.error-vapifault-worker-not-available" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable,
                "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-xai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai401Unauthorized,
                "call.in-progress.error-vapifault-xai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied,
                "call.in-progress.error-vapifault-xai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota,
                "call.in-progress.error-warm-transfer-assistant-cancelled" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferAssistantCancelled,
                "call.in-progress.error-warm-transfer-max-duration" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferMaxDuration,
                "call.in-progress.error-warm-transfer-microphone-timeout" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout,
                "call.in-progress.error-warm-transfer-silence-timeout" => ServerMessageStatusUpdateEndedReason.CallInProgressErrorWarmTransferSilenceTimeout,
                "call.in-progress.sip-completed-call" => ServerMessageStatusUpdateEndedReason.CallInProgressSipCompletedCall,
                "call.in-progress.twilio-completed-call" => ServerMessageStatusUpdateEndedReason.CallInProgressTwilioCompletedCall,
                "call.ringing.error-sip-inbound-call-failed-to-connect" => ServerMessageStatusUpdateEndedReason.CallRingingErrorSipInboundCallFailedToConnect,
                "call.ringing.hook-executed-say" => ServerMessageStatusUpdateEndedReason.CallRingingHookExecutedSay,
                "call.ringing.hook-executed-transfer" => ServerMessageStatusUpdateEndedReason.CallRingingHookExecutedTransfer,
                "call.ringing.sip-inbound-caller-hungup-before-call-connect" => ServerMessageStatusUpdateEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect,
                "call.start.error-enterprise-feature-not-available-recording-consent" => ServerMessageStatusUpdateEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,
                "call.start.error-fraud-check-failed" => ServerMessageStatusUpdateEndedReason.CallStartErrorFraudCheckFailed,
                "call.start.error-get-assistant" => ServerMessageStatusUpdateEndedReason.CallStartErrorGetAssistant,
                "call.start.error-get-customer" => ServerMessageStatusUpdateEndedReason.CallStartErrorGetCustomer,
                "call.start.error-get-phone-number" => ServerMessageStatusUpdateEndedReason.CallStartErrorGetPhoneNumber,
                "call.start.error-get-resources-validation" => ServerMessageStatusUpdateEndedReason.CallStartErrorGetResourcesValidation,
                "call.start.error-get-transport" => ServerMessageStatusUpdateEndedReason.CallStartErrorGetTransport,
                "call.start.error-subscription-concurrency-limit-reached" => ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached,
                "call.start.error-subscription-frozen" => ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionFrozen,
                "call.start.error-subscription-insufficient-credits" => ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionInsufficientCredits,
                "call.start.error-subscription-upgrade-failed" => ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionUpgradeFailed,
                "call.start.error-subscription-wallet-does-not-exist" => ServerMessageStatusUpdateEndedReason.CallStartErrorSubscriptionWalletDoesNotExist,
                "call.start.error-vapi-number-international" => ServerMessageStatusUpdateEndedReason.CallStartErrorVapiNumberInternational,
                "call.start.error-vapi-number-outbound-daily-limit" => ServerMessageStatusUpdateEndedReason.CallStartErrorVapiNumberOutboundDailyLimit,
                "call.start.error-vapifault-database-error" => ServerMessageStatusUpdateEndedReason.CallStartErrorVapifaultDatabaseError,
                "call.start.error-vapifault-get-org" => ServerMessageStatusUpdateEndedReason.CallStartErrorVapifaultGetOrg,
                "call.start.error-vapifault-get-subscription" => ServerMessageStatusUpdateEndedReason.CallStartErrorVapifaultGetSubscription,
                "customer-busy" => ServerMessageStatusUpdateEndedReason.CustomerBusy,
                "customer-did-not-answer" => ServerMessageStatusUpdateEndedReason.CustomerDidNotAnswer,
                "customer-did-not-give-microphone-permission" => ServerMessageStatusUpdateEndedReason.CustomerDidNotGiveMicrophonePermission,
                "customer-ended-call" => ServerMessageStatusUpdateEndedReason.CustomerEndedCall,
                "customer-ended-call-after-warm-transfer-attempt" => ServerMessageStatusUpdateEndedReason.CustomerEndedCallAfterWarmTransferAttempt,
                "customer-ended-call-before-warm-transfer" => ServerMessageStatusUpdateEndedReason.CustomerEndedCallBeforeWarmTransfer,
                "customer-ended-call-during-transfer" => ServerMessageStatusUpdateEndedReason.CustomerEndedCallDuringTransfer,
                "exceeded-max-duration" => ServerMessageStatusUpdateEndedReason.ExceededMaxDuration,
                "manually-canceled" => ServerMessageStatusUpdateEndedReason.ManuallyCanceled,
                "phone-call-provider-bypass-enabled-but-no-call-received" => ServerMessageStatusUpdateEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived,
                "phone-call-provider-closed-websocket" => ServerMessageStatusUpdateEndedReason.PhoneCallProviderClosedWebsocket,
                "pipeline-error-anthropic-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed,
                "pipeline-error-anthropic-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic401Unauthorized,
                "pipeline-error-anthropic-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic403ModelAccessDenied,
                "pipeline-error-anthropic-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic429ExceededQuota,
                "pipeline-error-anthropic-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic500ServerError,
                "pipeline-error-anthropic-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropic503ServerOverloadedError,
                "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed,
                "pipeline-error-anthropic-bedrock-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock401Unauthorized,
                "pipeline-error-anthropic-bedrock-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied,
                "pipeline-error-anthropic-bedrock-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota,
                "pipeline-error-anthropic-bedrock-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock500ServerError,
                "pipeline-error-anthropic-bedrock-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError,
                "pipeline-error-anthropic-bedrock-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicBedrockLlmFailed,
                "pipeline-error-anthropic-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicLlmFailed,
                "pipeline-error-anthropic-vertex-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed,
                "pipeline-error-anthropic-vertex-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex401Unauthorized,
                "pipeline-error-anthropic-vertex-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied,
                "pipeline-error-anthropic-vertex-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex429ExceededQuota,
                "pipeline-error-anthropic-vertex-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex500ServerError,
                "pipeline-error-anthropic-vertex-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError,
                "pipeline-error-anthropic-vertex-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnthropicVertexLlmFailed,
                "pipeline-error-anyscale-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed,
                "pipeline-error-anyscale-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale401Unauthorized,
                "pipeline-error-anyscale-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale403ModelAccessDenied,
                "pipeline-error-anyscale-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale429ExceededQuota,
                "pipeline-error-anyscale-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale500ServerError,
                "pipeline-error-anyscale-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscale503ServerOverloadedError,
                "pipeline-error-anyscale-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAnyscaleLlmFailed,
                "pipeline-error-assembly-ai-returning-400-insufficent-funds" => ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds,
                "pipeline-error-assembly-ai-returning-400-paid-only-feature" => ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature,
                "pipeline-error-assembly-ai-returning-401-invalid-credentials" => ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials,
                "pipeline-error-assembly-ai-returning-500-invalid-schema" => ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema,
                "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,
                "pipeline-error-assembly-ai-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAssemblyAiTranscriberFailed,
                "pipeline-error-azure-openai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed,
                "pipeline-error-azure-openai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai401Unauthorized,
                "pipeline-error-azure-openai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied,
                "pipeline-error-azure-openai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai429ExceededQuota,
                "pipeline-error-azure-openai-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai500ServerError,
                "pipeline-error-azure-openai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError,
                "pipeline-error-azure-openai-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureOpenaiLlmFailed,
                "pipeline-error-azure-speech-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureSpeechTranscriberFailed,
                "pipeline-error-azure-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorAzureVoiceFailed,
                "pipeline-error-baseten-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten400BadRequestValidationFailed,
                "pipeline-error-baseten-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten401Unauthorized,
                "pipeline-error-baseten-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten403ModelAccessDenied,
                "pipeline-error-baseten-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten429ExceededQuota,
                "pipeline-error-baseten-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten500ServerError,
                "pipeline-error-baseten-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorBaseten503ServerOverloadedError,
                "pipeline-error-baseten-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorBasetenLlmFailed,
                "pipeline-error-cartesia-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia500ServerError,
                "pipeline-error-cartesia-502-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia502ServerError,
                "pipeline-error-cartesia-503-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia503ServerError,
                "pipeline-error-cartesia-522-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesia522ServerError,
                "pipeline-error-cartesia-requested-payment" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesiaRequestedPayment,
                "pipeline-error-cartesia-socket-hang-up" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesiaSocketHangUp,
                "pipeline-error-cartesia-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCartesiaVoiceFailed,
                "pipeline-error-cerebras-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras400BadRequestValidationFailed,
                "pipeline-error-cerebras-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras401Unauthorized,
                "pipeline-error-cerebras-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras403ModelAccessDenied,
                "pipeline-error-cerebras-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras429ExceededQuota,
                "pipeline-error-cerebras-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras500ServerError,
                "pipeline-error-cerebras-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebras503ServerOverloadedError,
                "pipeline-error-cerebras-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCerebrasLlmFailed,
                "pipeline-error-custom-llm-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed,
                "pipeline-error-custom-llm-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm401Unauthorized,
                "pipeline-error-custom-llm-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm403ModelAccessDenied,
                "pipeline-error-custom-llm-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm429ExceededQuota,
                "pipeline-error-custom-llm-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm500ServerError,
                "pipeline-error-custom-llm-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlm503ServerOverloadedError,
                "pipeline-error-custom-llm-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomLlmLlmFailed,
                "pipeline-error-custom-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomTranscriberFailed,
                "pipeline-error-custom-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorCustomVoiceFailed,
                "pipeline-error-deep-seek-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed,
                "pipeline-error-deep-seek-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek401Unauthorized,
                "pipeline-error-deep-seek-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek403ModelAccessDenied,
                "pipeline-error-deep-seek-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek429ExceededQuota,
                "pipeline-error-deep-seek-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek500ServerError,
                "pipeline-error-deep-seek-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeek503ServerOverloadedError,
                "pipeline-error-deep-seek-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepSeekLlmFailed,
                "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,
                "pipeline-error-deepgram-returning-401-invalid-credentials" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials,
                "pipeline-error-deepgram-returning-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied,
                "pipeline-error-deepgram-returning-404-not-found" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning404NotFound,
                "pipeline-error-deepgram-returning-500-invalid-json" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning500InvalidJson,
                "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach,
                "pipeline-error-deepgram-returning-502-network-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturning502NetworkError,
                "pipeline-error-deepgram-returning-econnreset" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramReturningEconnreset,
                "pipeline-error-deepgram-transcriber-api-key-missing" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing,
                "pipeline-error-deepgram-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramTranscriberFailed,
                "pipeline-error-deepgram-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepgramVoiceFailed,
                "pipeline-error-deepinfra-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed,
                "pipeline-error-deepinfra-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra401Unauthorized,
                "pipeline-error-deepinfra-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra403ModelAccessDenied,
                "pipeline-error-deepinfra-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra429ExceededQuota,
                "pipeline-error-deepinfra-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra500ServerError,
                "pipeline-error-deepinfra-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfra503ServerOverloadedError,
                "pipeline-error-deepinfra-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorDeepinfraLlmFailed,
                "pipeline-error-eleven-labs-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabs500ServerError,
                "pipeline-error-eleven-labs-503-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabs503ServerError,
                "pipeline-error-eleven-labs-blocked-account-in-probation" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation,
                "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-content-against-their-policy" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,
                "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
                "pipeline-error-eleven-labs-invalid-api-key" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsInvalidApiKey,
                "pipeline-error-eleven-labs-invalid-voice-samples" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples,
                "pipeline-error-eleven-labs-max-character-limit-exceeded" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded,
                "pipeline-error-eleven-labs-missing-samples-for-voice-clone" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone,
                "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,
                "pipeline-error-eleven-labs-quota-exceeded" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsQuotaExceeded,
                "pipeline-error-eleven-labs-system-busy-and-requested-upgrade" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,
                "pipeline-error-eleven-labs-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsTranscriberFailed,
                "pipeline-error-eleven-labs-unauthorized-access" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsUnauthorizedAccess,
                "pipeline-error-eleven-labs-unauthorized-to-access-model" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel,
                "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner,
                "pipeline-error-eleven-labs-voice-disabled-by-owner" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner,
                "pipeline-error-eleven-labs-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceFailed,
                "pipeline-error-eleven-labs-voice-not-allowed-for-free-users" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,
                "pipeline-error-eleven-labs-voice-not-fine-tuned" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned,
                "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,
                "pipeline-error-eleven-labs-voice-not-found" => ServerMessageStatusUpdateEndedReason.PipelineErrorElevenLabsVoiceNotFound,
                "pipeline-error-gladia-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorGladiaTranscriberFailed,
                "pipeline-error-google-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle400BadRequestValidationFailed,
                "pipeline-error-google-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle401Unauthorized,
                "pipeline-error-google-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle403ModelAccessDenied,
                "pipeline-error-google-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle429ExceededQuota,
                "pipeline-error-google-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle500ServerError,
                "pipeline-error-google-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogle503ServerOverloadedError,
                "pipeline-error-google-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogleLlmFailed,
                "pipeline-error-google-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorGoogleTranscriberFailed,
                "pipeline-error-groq-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroq400BadRequestValidationFailed,
                "pipeline-error-groq-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroq401Unauthorized,
                "pipeline-error-groq-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroq403ModelAccessDenied,
                "pipeline-error-groq-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroq429ExceededQuota,
                "pipeline-error-groq-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroq500ServerError,
                "pipeline-error-groq-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroq503ServerOverloadedError,
                "pipeline-error-groq-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorGroqLlmFailed,
                "pipeline-error-hume-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorHumeVoiceFailed,
                "pipeline-error-inflection-ai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed,
                "pipeline-error-inflection-ai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi401Unauthorized,
                "pipeline-error-inflection-ai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi403ModelAccessDenied,
                "pipeline-error-inflection-ai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi429ExceededQuota,
                "pipeline-error-inflection-ai-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi500ServerError,
                "pipeline-error-inflection-ai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAi503ServerOverloadedError,
                "pipeline-error-inflection-ai-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorInflectionAiLlmFailed,
                "pipeline-error-inworld-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorInworldVoiceFailed,
                "pipeline-error-lmnt-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorLmntVoiceFailed,
                "pipeline-error-minimax-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorMinimaxVoiceFailed,
                "pipeline-error-mistral-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistral400BadRequestValidationFailed,
                "pipeline-error-mistral-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistral401Unauthorized,
                "pipeline-error-mistral-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistral403ModelAccessDenied,
                "pipeline-error-mistral-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistral429ExceededQuota,
                "pipeline-error-mistral-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistral500ServerError,
                "pipeline-error-mistral-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistral503ServerOverloadedError,
                "pipeline-error-mistral-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorMistralLlmFailed,
                "pipeline-error-neuphonic-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorNeuphonicVoiceFailed,
                "pipeline-error-openai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai400BadRequestValidationFailed,
                "pipeline-error-openai-401-account-not-in-organization" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai401AccountNotInOrganization,
                "pipeline-error-openai-401-incorrect-api-key" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai401IncorrectApiKey,
                "pipeline-error-openai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai401Unauthorized,
                "pipeline-error-openai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai403ModelAccessDenied,
                "pipeline-error-openai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai429ExceededQuota,
                "pipeline-error-openai-429-rate-limit-reached" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai429RateLimitReached,
                "pipeline-error-openai-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai500ServerError,
                "pipeline-error-openai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenai503ServerOverloadedError,
                "pipeline-error-openai-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenaiLlmFailed,
                "pipeline-error-openai-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenaiTranscriberFailed,
                "pipeline-error-openai-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenaiVoiceFailed,
                "pipeline-error-openrouter-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed,
                "pipeline-error-openrouter-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter401Unauthorized,
                "pipeline-error-openrouter-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter403ModelAccessDenied,
                "pipeline-error-openrouter-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter429ExceededQuota,
                "pipeline-error-openrouter-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter500ServerError,
                "pipeline-error-openrouter-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouter503ServerOverloadedError,
                "pipeline-error-openrouter-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorOpenrouterLlmFailed,
                "pipeline-error-perplexity-ai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed,
                "pipeline-error-perplexity-ai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi401Unauthorized,
                "pipeline-error-perplexity-ai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied,
                "pipeline-error-perplexity-ai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi429ExceededQuota,
                "pipeline-error-perplexity-ai-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi500ServerError,
                "pipeline-error-perplexity-ai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError,
                "pipeline-error-perplexity-ai-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorPerplexityAiLlmFailed,
                "pipeline-error-playht-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht401Unauthorized,
                "pipeline-error-playht-403-forbidden-api-access-not-available" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,
                "pipeline-error-playht-403-forbidden-out-of-characters" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters,
                "pipeline-error-playht-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht429ExceededQuota,
                "pipeline-error-playht-502-gateway-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht502GatewayError,
                "pipeline-error-playht-504-gateway-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayht504GatewayError,
                "pipeline-error-playht-invalid-emotion" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtInvalidEmotion,
                "pipeline-error-playht-invalid-voice" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtInvalidVoice,
                "pipeline-error-playht-out-of-credits" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtOutOfCredits,
                "pipeline-error-playht-request-timed-out" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtRequestTimedOut,
                "pipeline-error-playht-unexpected-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtUnexpectedError,
                "pipeline-error-playht-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtVoiceFailed,
                "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri" => ServerMessageStatusUpdateEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,
                "pipeline-error-rime-ai-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorRimeAiVoiceFailed,
                "pipeline-error-runpod-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod400BadRequestValidationFailed,
                "pipeline-error-runpod-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod401Unauthorized,
                "pipeline-error-runpod-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod403ModelAccessDenied,
                "pipeline-error-runpod-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod429ExceededQuota,
                "pipeline-error-runpod-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod500ServerError,
                "pipeline-error-runpod-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpod503ServerOverloadedError,
                "pipeline-error-runpod-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorRunpodLlmFailed,
                "pipeline-error-sesame-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorSesameVoiceFailed,
                "pipeline-error-smallest-ai-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorSmallestAiVoiceFailed,
                "pipeline-error-soniox-transcriber-auth-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberAuthFailed,
                "pipeline-error-soniox-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberFailed,
                "pipeline-error-soniox-transcriber-invalid-config" => ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberInvalidConfig,
                "pipeline-error-soniox-transcriber-rate-limited" => ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberRateLimited,
                "pipeline-error-soniox-transcriber-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorSonioxTranscriberServerError,
                "pipeline-error-speechmatics-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorSpeechmaticsTranscriberFailed,
                "pipeline-error-talkscriber-transcriber-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorTalkscriberTranscriberFailed,
                "pipeline-error-tavus-video-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorTavusVideoFailed,
                "pipeline-error-together-ai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed,
                "pipeline-error-together-ai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi401Unauthorized,
                "pipeline-error-together-ai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi403ModelAccessDenied,
                "pipeline-error-together-ai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi429ExceededQuota,
                "pipeline-error-together-ai-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi500ServerError,
                "pipeline-error-together-ai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAi503ServerOverloadedError,
                "pipeline-error-together-ai-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorTogetherAiLlmFailed,
                "pipeline-error-vapi-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapi400BadRequestValidationFailed,
                "pipeline-error-vapi-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapi401Unauthorized,
                "pipeline-error-vapi-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapi403ModelAccessDenied,
                "pipeline-error-vapi-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapi429ExceededQuota,
                "pipeline-error-vapi-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapi500ServerError,
                "pipeline-error-vapi-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapi503ServerOverloadedError,
                "pipeline-error-vapi-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapiLlmFailed,
                "pipeline-error-vapi-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorVapiVoiceFailed,
                "pipeline-error-wellsaid-voice-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorWellsaidVoiceFailed,
                "pipeline-error-xai-400-bad-request-validation-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorXai400BadRequestValidationFailed,
                "pipeline-error-xai-401-unauthorized" => ServerMessageStatusUpdateEndedReason.PipelineErrorXai401Unauthorized,
                "pipeline-error-xai-403-model-access-denied" => ServerMessageStatusUpdateEndedReason.PipelineErrorXai403ModelAccessDenied,
                "pipeline-error-xai-429-exceeded-quota" => ServerMessageStatusUpdateEndedReason.PipelineErrorXai429ExceededQuota,
                "pipeline-error-xai-500-server-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorXai500ServerError,
                "pipeline-error-xai-503-server-overloaded-error" => ServerMessageStatusUpdateEndedReason.PipelineErrorXai503ServerOverloadedError,
                "pipeline-error-xai-llm-failed" => ServerMessageStatusUpdateEndedReason.PipelineErrorXaiLlmFailed,
                "scheduled-call-deleted" => ServerMessageStatusUpdateEndedReason.ScheduledCallDeleted,
                "silence-timed-out" => ServerMessageStatusUpdateEndedReason.SilenceTimedOut,
                "twilio-failed-to-connect-call" => ServerMessageStatusUpdateEndedReason.TwilioFailedToConnectCall,
                "twilio-reported-customer-misdialed" => ServerMessageStatusUpdateEndedReason.TwilioReportedCustomerMisdialed,
                "voicemail" => ServerMessageStatusUpdateEndedReason.Voicemail,
                "vonage-completed" => ServerMessageStatusUpdateEndedReason.VonageCompleted,
                "vonage-disconnected" => ServerMessageStatusUpdateEndedReason.VonageDisconnected,
                "vonage-failed-to-connect-call" => ServerMessageStatusUpdateEndedReason.VonageFailedToConnectCall,
                "vonage-rejected" => ServerMessageStatusUpdateEndedReason.VonageRejected,
                "worker-shutdown" => ServerMessageStatusUpdateEndedReason.WorkerShutdown,
                _ => null,
            };
        }
    }
}