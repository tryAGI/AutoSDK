//HintName: G.Models.ServerMessageEndOfCallReportEndedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the reason the call ended. This can also be found at `call.endedReason` on GET /call/:id.
    /// </summary>
    public enum ServerMessageEndOfCallReportEndedReason
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
    public static class ServerMessageEndOfCallReportEndedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageEndOfCallReportEndedReason value)
        {
            return value switch
            {
                ServerMessageEndOfCallReportEndedReason.AssistantEndedCall => "assistant-ended-call",
                ServerMessageEndOfCallReportEndedReason.AssistantEndedCallAfterMessageSpoken => "assistant-ended-call-after-message-spoken",
                ServerMessageEndOfCallReportEndedReason.AssistantEndedCallWithHangupTask => "assistant-ended-call-with-hangup-task",
                ServerMessageEndOfCallReportEndedReason.AssistantForwardedCall => "assistant-forwarded-call",
                ServerMessageEndOfCallReportEndedReason.AssistantJoinTimedOut => "assistant-join-timed-out",
                ServerMessageEndOfCallReportEndedReason.AssistantNotFound => "assistant-not-found",
                ServerMessageEndOfCallReportEndedReason.AssistantNotValid => "assistant-not-valid",
                ServerMessageEndOfCallReportEndedReason.AssistantRequestFailed => "assistant-request-failed",
                ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedError => "assistant-request-returned-error",
                ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedForwardingPhoneNumber => "assistant-request-returned-forwarding-phone-number",
                ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedInvalidAssistant => "assistant-request-returned-invalid-assistant",
                ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedNoAssistant => "assistant-request-returned-no-assistant",
                ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedUnspeakableError => "assistant-request-returned-unspeakable-error",
                ServerMessageEndOfCallReportEndedReason.AssistantSaidEndCallPhrase => "assistant-said-end-call-phrase",
                ServerMessageEndOfCallReportEndedReason.CallDeleted => "call-deleted",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorNeitherAssistantNorServerSet => "call-start-error-neither-assistant-nor-server-set",
                ServerMessageEndOfCallReportEndedReason.CallEndingHookExecutedSay => "call.ending.hook-executed-say",
                ServerMessageEndOfCallReportEndedReason.CallEndingHookExecutedTransfer => "call.ending.hook-executed-transfer",
                ServerMessageEndOfCallReportEndedReason.CallForwardingOperatorBusy => "call.forwarding.operator-busy",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio => "call.in-progress.error-assistant-did-not-receive-customer-audio",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel => "call.in-progress.error-pipeline-no-available-llm-model",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed => "call.in-progress.error-pipeline-ws-model-connection-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError => "call.in-progress.error-providerfault-anthropic-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError => "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed => "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed => "call.in-progress.error-providerfault-anthropic-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError => "call.in-progress.error-providerfault-anthropic-vertex-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed => "call.in-progress.error-providerfault-anthropic-vertex-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError => "call.in-progress.error-providerfault-anyscale-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError => "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed => "call.in-progress.error-providerfault-anyscale-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError => "call.in-progress.error-providerfault-azure-openai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError => "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed => "call.in-progress.error-providerfault-azure-openai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError => "call.in-progress.error-providerfault-baseten-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError => "call.in-progress.error-providerfault-baseten-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed => "call.in-progress.error-providerfault-baseten-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError => "call.in-progress.error-providerfault-cartesia-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError => "call.in-progress.error-providerfault-cartesia-503-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError => "call.in-progress.error-providerfault-cartesia-522-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError => "call.in-progress.error-providerfault-cerebras-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError => "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed => "call.in-progress.error-providerfault-cerebras-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError => "call.in-progress.error-providerfault-custom-llm-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError => "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed => "call.in-progress.error-providerfault-custom-llm-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError => "call.in-progress.error-providerfault-deep-seek-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError => "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed => "call.in-progress.error-providerfault-deep-seek-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson => "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach => "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError => "call.in-progress.error-providerfault-deepgram-returning-502-network-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError => "call.in-progress.error-providerfault-deepinfra-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError => "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed => "call.in-progress.error-providerfault-deepinfra-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError => "call.in-progress.error-providerfault-eleven-labs-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError => "call.in-progress.error-providerfault-eleven-labs-503-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade => "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError => "call.in-progress.error-providerfault-google-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError => "call.in-progress.error-providerfault-google-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed => "call.in-progress.error-providerfault-google-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGroq500ServerError => "call.in-progress.error-providerfault-groq-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError => "call.in-progress.error-providerfault-groq-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed => "call.in-progress.error-providerfault-groq-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError => "call.in-progress.error-providerfault-inflection-ai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError => "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed => "call.in-progress.error-providerfault-inflection-ai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultMistral500ServerError => "call.in-progress.error-providerfault-mistral-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError => "call.in-progress.error-providerfault-mistral-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed => "call.in-progress.error-providerfault-mistral-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError => "call.in-progress.error-providerfault-openai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError => "call.in-progress.error-providerfault-openai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed => "call.in-progress.error-providerfault-openai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError => "call.in-progress.error-providerfault-openrouter-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError => "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed => "call.in-progress.error-providerfault-openrouter-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden => "call.in-progress.error-providerfault-outbound-sip-403-forbidden",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired => "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout => "call.in-progress.error-providerfault-outbound-sip-408-request-timeout",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable => "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable => "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError => "call.in-progress.error-providerfault-perplexity-ai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError => "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed => "call.in-progress.error-providerfault-perplexity-ai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError => "call.in-progress.error-providerfault-playht-502-gateway-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError => "call.in-progress.error-providerfault-playht-504-gateway-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError => "call.in-progress.error-providerfault-runpod-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError => "call.in-progress.error-providerfault-runpod-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed => "call.in-progress.error-providerfault-runpod-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError => "call.in-progress.error-providerfault-together-ai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError => "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed => "call.in-progress.error-providerfault-together-ai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected => "call.in-progress.error-providerfault-transport-never-connected",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultVapi500ServerError => "call.in-progress.error-providerfault-vapi-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError => "call.in-progress.error-providerfault-vapi-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed => "call.in-progress.error-providerfault-vapi-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultXai500ServerError => "call.in-progress.error-providerfault-xai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError => "call.in-progress.error-providerfault-xai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed => "call.in-progress.error-providerfault-xai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorSipInboundCallFailedToConnect => "call.in-progress.error-sip-inbound-call-failed-to-connect",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect => "call.in-progress.error-sip-outbound-call-failed-to-connect",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorTransferFailed => "call.in-progress.error-transfer-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized => "call.in-progress.error-vapifault-anthropic-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota => "call.in-progress.error-vapifault-anthropic-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized => "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota => "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized => "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota => "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed => "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized => "call.in-progress.error-vapifault-anyscale-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied => "call.in-progress.error-vapifault-anyscale-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota => "call.in-progress.error-vapifault-anyscale-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds => "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature => "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials => "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema => "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed => "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed => "call.in-progress.error-vapifault-assembly-ai-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed => "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized => "call.in-progress.error-vapifault-azure-openai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied => "call.in-progress.error-vapifault-azure-openai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota => "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed => "call.in-progress.error-vapifault-azure-speech-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed => "call.in-progress.error-vapifault-azure-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed => "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized => "call.in-progress.error-vapifault-baseten-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied => "call.in-progress.error-vapifault-baseten-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota => "call.in-progress.error-vapifault-baseten-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing => "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment => "call.in-progress.error-vapifault-cartesia-requested-payment",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp => "call.in-progress.error-vapifault-cartesia-socket-hang-up",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed => "call.in-progress.error-vapifault-cartesia-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed => "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized => "call.in-progress.error-vapifault-cerebras-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied => "call.in-progress.error-vapifault-cerebras-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota => "call.in-progress.error-vapifault-cerebras-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart => "call.in-progress.error-vapifault-chat-pipeline-failed-to-start",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed => "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized => "call.in-progress.error-vapifault-custom-llm-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied => "call.in-progress.error-vapifault-custom-llm-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota => "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed => "call.in-progress.error-vapifault-custom-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed => "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized => "call.in-progress.error-vapifault-deep-seek-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied => "call.in-progress.error-vapifault-deep-seek-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota => "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination => "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials => "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied => "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound => "call.in-progress.error-vapifault-deepgram-returning-404-not-found",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed => "call.in-progress.error-vapifault-deepgram-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed => "call.in-progress.error-vapifault-deepgram-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed => "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized => "call.in-progress.error-vapifault-deepinfra-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied => "call.in-progress.error-vapifault-deepinfra-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota => "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation => "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy => "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification => "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey => "call.in-progress.error-vapifault-eleven-labs-invalid-api-key",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples => "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded => "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone => "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus => "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded => "call.in-progress.error-vapifault-eleven-labs-quota-exceeded",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed => "call.in-progress.error-vapifault-eleven-labs-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess => "call.in-progress.error-vapifault-eleven-labs-unauthorized-access",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel => "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner => "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed => "call.in-progress.error-vapifault-eleven-labs-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers => "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned => "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed => "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound => "call.in-progress.error-vapifault-eleven-labs-voice-not-found",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed => "call.in-progress.error-vapifault-gladia-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed => "call.in-progress.error-vapifault-google-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized => "call.in-progress.error-vapifault-google-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied => "call.in-progress.error-vapifault-google-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota => "call.in-progress.error-vapifault-google-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed => "call.in-progress.error-vapifault-google-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed => "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized => "call.in-progress.error-vapifault-groq-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied => "call.in-progress.error-vapifault-groq-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota => "call.in-progress.error-vapifault-groq-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed => "call.in-progress.error-vapifault-hume-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized => "call.in-progress.error-vapifault-inflection-ai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied => "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota => "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed => "call.in-progress.error-vapifault-inworld-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed => "call.in-progress.error-vapifault-lmnt-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed => "call.in-progress.error-vapifault-minimax-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed => "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized => "call.in-progress.error-vapifault-mistral-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied => "call.in-progress.error-vapifault-mistral-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota => "call.in-progress.error-vapifault-mistral-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed => "call.in-progress.error-vapifault-neuphonic-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed => "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization => "call.in-progress.error-vapifault-openai-401-account-not-in-organization",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey => "call.in-progress.error-vapifault-openai-401-incorrect-api-key",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized => "call.in-progress.error-vapifault-openai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied => "call.in-progress.error-vapifault-openai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota => "call.in-progress.error-vapifault-openai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached => "call.in-progress.error-vapifault-openai-429-rate-limit-reached",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed => "call.in-progress.error-vapifault-openai-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed => "call.in-progress.error-vapifault-openai-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed => "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized => "call.in-progress.error-vapifault-openrouter-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied => "call.in-progress.error-vapifault-openrouter-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota => "call.in-progress.error-vapifault-openrouter-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized => "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied => "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota => "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized => "call.in-progress.error-vapifault-playht-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable => "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters => "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota => "call.in-progress.error-vapifault-playht-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion => "call.in-progress.error-vapifault-playht-invalid-emotion",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice => "call.in-progress.error-vapifault-playht-invalid-voice",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits => "call.in-progress.error-vapifault-playht-out-of-credits",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut => "call.in-progress.error-vapifault-playht-request-timed-out",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError => "call.in-progress.error-vapifault-playht-unexpected-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed => "call.in-progress.error-vapifault-playht-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri => "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed => "call.in-progress.error-vapifault-rime-ai-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed => "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized => "call.in-progress.error-vapifault-runpod-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied => "call.in-progress.error-vapifault-runpod-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota => "call.in-progress.error-vapifault-runpod-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed => "call.in-progress.error-vapifault-sesame-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed => "call.in-progress.error-vapifault-smallest-ai-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed => "call.in-progress.error-vapifault-soniox-transcriber-auth-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed => "call.in-progress.error-vapifault-soniox-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig => "call.in-progress.error-vapifault-soniox-transcriber-invalid-config",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited => "call.in-progress.error-vapifault-soniox-transcriber-rate-limited",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError => "call.in-progress.error-vapifault-soniox-transcriber-server-error",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed => "call.in-progress.error-vapifault-speechmatics-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed => "call.in-progress.error-vapifault-talkscriber-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTavusVideoFailed => "call.in-progress.error-vapifault-tavus-video-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized => "call.in-progress.error-vapifault-together-ai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied => "call.in-progress.error-vapifault-together-ai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota => "call.in-progress.error-vapifault-together-ai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive => "call.in-progress.error-vapifault-transport-connected-but-call-not-active",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTransportNeverConnected => "call.in-progress.error-vapifault-transport-never-connected",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed => "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized => "call.in-progress.error-vapifault-vapi-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied => "call.in-progress.error-vapifault-vapi-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota => "call.in-progress.error-vapifault-vapi-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed => "call.in-progress.error-vapifault-vapi-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed => "call.in-progress.error-vapifault-wellsaid-voice-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultWorkerDied => "call.in-progress.error-vapifault-worker-died",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable => "call.in-progress.error-vapifault-worker-not-available",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed => "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai401Unauthorized => "call.in-progress.error-vapifault-xai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied => "call.in-progress.error-vapifault-xai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota => "call.in-progress.error-vapifault-xai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferAssistantCancelled => "call.in-progress.error-warm-transfer-assistant-cancelled",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferMaxDuration => "call.in-progress.error-warm-transfer-max-duration",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout => "call.in-progress.error-warm-transfer-microphone-timeout",
                ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferSilenceTimeout => "call.in-progress.error-warm-transfer-silence-timeout",
                ServerMessageEndOfCallReportEndedReason.CallInProgressSipCompletedCall => "call.in-progress.sip-completed-call",
                ServerMessageEndOfCallReportEndedReason.CallInProgressTwilioCompletedCall => "call.in-progress.twilio-completed-call",
                ServerMessageEndOfCallReportEndedReason.CallRingingErrorSipInboundCallFailedToConnect => "call.ringing.error-sip-inbound-call-failed-to-connect",
                ServerMessageEndOfCallReportEndedReason.CallRingingHookExecutedSay => "call.ringing.hook-executed-say",
                ServerMessageEndOfCallReportEndedReason.CallRingingHookExecutedTransfer => "call.ringing.hook-executed-transfer",
                ServerMessageEndOfCallReportEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect => "call.ringing.sip-inbound-caller-hungup-before-call-connect",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent => "call.start.error-enterprise-feature-not-available-recording-consent",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorFraudCheckFailed => "call.start.error-fraud-check-failed",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorGetAssistant => "call.start.error-get-assistant",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorGetCustomer => "call.start.error-get-customer",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorGetPhoneNumber => "call.start.error-get-phone-number",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorGetResourcesValidation => "call.start.error-get-resources-validation",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorGetTransport => "call.start.error-get-transport",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached => "call.start.error-subscription-concurrency-limit-reached",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionFrozen => "call.start.error-subscription-frozen",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionInsufficientCredits => "call.start.error-subscription-insufficient-credits",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionUpgradeFailed => "call.start.error-subscription-upgrade-failed",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionWalletDoesNotExist => "call.start.error-subscription-wallet-does-not-exist",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorVapiNumberInternational => "call.start.error-vapi-number-international",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorVapiNumberOutboundDailyLimit => "call.start.error-vapi-number-outbound-daily-limit",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorVapifaultDatabaseError => "call.start.error-vapifault-database-error",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorVapifaultGetOrg => "call.start.error-vapifault-get-org",
                ServerMessageEndOfCallReportEndedReason.CallStartErrorVapifaultGetSubscription => "call.start.error-vapifault-get-subscription",
                ServerMessageEndOfCallReportEndedReason.CustomerBusy => "customer-busy",
                ServerMessageEndOfCallReportEndedReason.CustomerDidNotAnswer => "customer-did-not-answer",
                ServerMessageEndOfCallReportEndedReason.CustomerDidNotGiveMicrophonePermission => "customer-did-not-give-microphone-permission",
                ServerMessageEndOfCallReportEndedReason.CustomerEndedCall => "customer-ended-call",
                ServerMessageEndOfCallReportEndedReason.CustomerEndedCallAfterWarmTransferAttempt => "customer-ended-call-after-warm-transfer-attempt",
                ServerMessageEndOfCallReportEndedReason.CustomerEndedCallBeforeWarmTransfer => "customer-ended-call-before-warm-transfer",
                ServerMessageEndOfCallReportEndedReason.CustomerEndedCallDuringTransfer => "customer-ended-call-during-transfer",
                ServerMessageEndOfCallReportEndedReason.ExceededMaxDuration => "exceeded-max-duration",
                ServerMessageEndOfCallReportEndedReason.ManuallyCanceled => "manually-canceled",
                ServerMessageEndOfCallReportEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived => "phone-call-provider-bypass-enabled-but-no-call-received",
                ServerMessageEndOfCallReportEndedReason.PhoneCallProviderClosedWebsocket => "phone-call-provider-closed-websocket",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed => "pipeline-error-anthropic-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic401Unauthorized => "pipeline-error-anthropic-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic403ModelAccessDenied => "pipeline-error-anthropic-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic429ExceededQuota => "pipeline-error-anthropic-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic500ServerError => "pipeline-error-anthropic-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic503ServerOverloadedError => "pipeline-error-anthropic-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed => "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock401Unauthorized => "pipeline-error-anthropic-bedrock-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied => "pipeline-error-anthropic-bedrock-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota => "pipeline-error-anthropic-bedrock-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock500ServerError => "pipeline-error-anthropic-bedrock-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError => "pipeline-error-anthropic-bedrock-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrockLlmFailed => "pipeline-error-anthropic-bedrock-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicLlmFailed => "pipeline-error-anthropic-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed => "pipeline-error-anthropic-vertex-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex401Unauthorized => "pipeline-error-anthropic-vertex-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied => "pipeline-error-anthropic-vertex-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex429ExceededQuota => "pipeline-error-anthropic-vertex-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex500ServerError => "pipeline-error-anthropic-vertex-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError => "pipeline-error-anthropic-vertex-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertexLlmFailed => "pipeline-error-anthropic-vertex-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed => "pipeline-error-anyscale-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale401Unauthorized => "pipeline-error-anyscale-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale403ModelAccessDenied => "pipeline-error-anyscale-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale429ExceededQuota => "pipeline-error-anyscale-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale500ServerError => "pipeline-error-anyscale-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale503ServerOverloadedError => "pipeline-error-anyscale-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscaleLlmFailed => "pipeline-error-anyscale-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds => "pipeline-error-assembly-ai-returning-400-insufficent-funds",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature => "pipeline-error-assembly-ai-returning-400-paid-only-feature",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials => "pipeline-error-assembly-ai-returning-401-invalid-credentials",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema => "pipeline-error-assembly-ai-returning-500-invalid-schema",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed => "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiTranscriberFailed => "pipeline-error-assembly-ai-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed => "pipeline-error-azure-openai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai401Unauthorized => "pipeline-error-azure-openai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied => "pipeline-error-azure-openai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai429ExceededQuota => "pipeline-error-azure-openai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai500ServerError => "pipeline-error-azure-openai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError => "pipeline-error-azure-openai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenaiLlmFailed => "pipeline-error-azure-openai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureSpeechTranscriberFailed => "pipeline-error-azure-speech-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureVoiceFailed => "pipeline-error-azure-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten400BadRequestValidationFailed => "pipeline-error-baseten-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten401Unauthorized => "pipeline-error-baseten-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten403ModelAccessDenied => "pipeline-error-baseten-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten429ExceededQuota => "pipeline-error-baseten-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten500ServerError => "pipeline-error-baseten-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten503ServerOverloadedError => "pipeline-error-baseten-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorBasetenLlmFailed => "pipeline-error-baseten-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia500ServerError => "pipeline-error-cartesia-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia502ServerError => "pipeline-error-cartesia-502-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia503ServerError => "pipeline-error-cartesia-503-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia522ServerError => "pipeline-error-cartesia-522-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesiaRequestedPayment => "pipeline-error-cartesia-requested-payment",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesiaSocketHangUp => "pipeline-error-cartesia-socket-hang-up",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesiaVoiceFailed => "pipeline-error-cartesia-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras400BadRequestValidationFailed => "pipeline-error-cerebras-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras401Unauthorized => "pipeline-error-cerebras-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras403ModelAccessDenied => "pipeline-error-cerebras-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras429ExceededQuota => "pipeline-error-cerebras-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras500ServerError => "pipeline-error-cerebras-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras503ServerOverloadedError => "pipeline-error-cerebras-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebrasLlmFailed => "pipeline-error-cerebras-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed => "pipeline-error-custom-llm-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm401Unauthorized => "pipeline-error-custom-llm-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm403ModelAccessDenied => "pipeline-error-custom-llm-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm429ExceededQuota => "pipeline-error-custom-llm-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm500ServerError => "pipeline-error-custom-llm-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm503ServerOverloadedError => "pipeline-error-custom-llm-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlmLlmFailed => "pipeline-error-custom-llm-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomTranscriberFailed => "pipeline-error-custom-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomVoiceFailed => "pipeline-error-custom-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed => "pipeline-error-deep-seek-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek401Unauthorized => "pipeline-error-deep-seek-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek403ModelAccessDenied => "pipeline-error-deep-seek-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek429ExceededQuota => "pipeline-error-deep-seek-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek500ServerError => "pipeline-error-deep-seek-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek503ServerOverloadedError => "pipeline-error-deep-seek-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeekLlmFailed => "pipeline-error-deep-seek-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination => "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials => "pipeline-error-deepgram-returning-401-invalid-credentials",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied => "pipeline-error-deepgram-returning-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning404NotFound => "pipeline-error-deepgram-returning-404-not-found",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning500InvalidJson => "pipeline-error-deepgram-returning-500-invalid-json",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach => "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning502NetworkError => "pipeline-error-deepgram-returning-502-network-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturningEconnreset => "pipeline-error-deepgram-returning-econnreset",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing => "pipeline-error-deepgram-transcriber-api-key-missing",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramTranscriberFailed => "pipeline-error-deepgram-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramVoiceFailed => "pipeline-error-deepgram-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed => "pipeline-error-deepinfra-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra401Unauthorized => "pipeline-error-deepinfra-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra403ModelAccessDenied => "pipeline-error-deepinfra-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra429ExceededQuota => "pipeline-error-deepinfra-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra500ServerError => "pipeline-error-deepinfra-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra503ServerOverloadedError => "pipeline-error-deepinfra-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfraLlmFailed => "pipeline-error-deepinfra-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabs500ServerError => "pipeline-error-eleven-labs-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabs503ServerError => "pipeline-error-eleven-labs-503-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation => "pipeline-error-eleven-labs-blocked-account-in-probation",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy => "pipeline-error-eleven-labs-blocked-content-against-their-policy",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification => "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsInvalidApiKey => "pipeline-error-eleven-labs-invalid-api-key",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples => "pipeline-error-eleven-labs-invalid-voice-samples",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded => "pipeline-error-eleven-labs-max-character-limit-exceeded",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone => "pipeline-error-eleven-labs-missing-samples-for-voice-clone",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus => "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsQuotaExceeded => "pipeline-error-eleven-labs-quota-exceeded",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade => "pipeline-error-eleven-labs-system-busy-and-requested-upgrade",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsTranscriberFailed => "pipeline-error-eleven-labs-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsUnauthorizedAccess => "pipeline-error-eleven-labs-unauthorized-access",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel => "pipeline-error-eleven-labs-unauthorized-to-access-model",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner => "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner => "pipeline-error-eleven-labs-voice-disabled-by-owner",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceFailed => "pipeline-error-eleven-labs-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers => "pipeline-error-eleven-labs-voice-not-allowed-for-free-users",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned => "pipeline-error-eleven-labs-voice-not-fine-tuned",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed => "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotFound => "pipeline-error-eleven-labs-voice-not-found",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGladiaTranscriberFailed => "pipeline-error-gladia-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle400BadRequestValidationFailed => "pipeline-error-google-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle401Unauthorized => "pipeline-error-google-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle403ModelAccessDenied => "pipeline-error-google-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle429ExceededQuota => "pipeline-error-google-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle500ServerError => "pipeline-error-google-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle503ServerOverloadedError => "pipeline-error-google-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogleLlmFailed => "pipeline-error-google-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogleTranscriberFailed => "pipeline-error-google-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq400BadRequestValidationFailed => "pipeline-error-groq-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq401Unauthorized => "pipeline-error-groq-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq403ModelAccessDenied => "pipeline-error-groq-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq429ExceededQuota => "pipeline-error-groq-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq500ServerError => "pipeline-error-groq-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq503ServerOverloadedError => "pipeline-error-groq-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorGroqLlmFailed => "pipeline-error-groq-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorHumeVoiceFailed => "pipeline-error-hume-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed => "pipeline-error-inflection-ai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi401Unauthorized => "pipeline-error-inflection-ai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi403ModelAccessDenied => "pipeline-error-inflection-ai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi429ExceededQuota => "pipeline-error-inflection-ai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi500ServerError => "pipeline-error-inflection-ai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi503ServerOverloadedError => "pipeline-error-inflection-ai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAiLlmFailed => "pipeline-error-inflection-ai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorInworldVoiceFailed => "pipeline-error-inworld-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorLmntVoiceFailed => "pipeline-error-lmnt-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMinimaxVoiceFailed => "pipeline-error-minimax-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral400BadRequestValidationFailed => "pipeline-error-mistral-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral401Unauthorized => "pipeline-error-mistral-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral403ModelAccessDenied => "pipeline-error-mistral-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral429ExceededQuota => "pipeline-error-mistral-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral500ServerError => "pipeline-error-mistral-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral503ServerOverloadedError => "pipeline-error-mistral-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorMistralLlmFailed => "pipeline-error-mistral-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorNeuphonicVoiceFailed => "pipeline-error-neuphonic-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai400BadRequestValidationFailed => "pipeline-error-openai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai401AccountNotInOrganization => "pipeline-error-openai-401-account-not-in-organization",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai401IncorrectApiKey => "pipeline-error-openai-401-incorrect-api-key",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai401Unauthorized => "pipeline-error-openai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai403ModelAccessDenied => "pipeline-error-openai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai429ExceededQuota => "pipeline-error-openai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai429RateLimitReached => "pipeline-error-openai-429-rate-limit-reached",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai500ServerError => "pipeline-error-openai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai503ServerOverloadedError => "pipeline-error-openai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenaiLlmFailed => "pipeline-error-openai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenaiTranscriberFailed => "pipeline-error-openai-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenaiVoiceFailed => "pipeline-error-openai-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed => "pipeline-error-openrouter-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter401Unauthorized => "pipeline-error-openrouter-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter403ModelAccessDenied => "pipeline-error-openrouter-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter429ExceededQuota => "pipeline-error-openrouter-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter500ServerError => "pipeline-error-openrouter-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter503ServerOverloadedError => "pipeline-error-openrouter-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouterLlmFailed => "pipeline-error-openrouter-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed => "pipeline-error-perplexity-ai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi401Unauthorized => "pipeline-error-perplexity-ai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied => "pipeline-error-perplexity-ai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi429ExceededQuota => "pipeline-error-perplexity-ai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi500ServerError => "pipeline-error-perplexity-ai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError => "pipeline-error-perplexity-ai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAiLlmFailed => "pipeline-error-perplexity-ai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht401Unauthorized => "pipeline-error-playht-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable => "pipeline-error-playht-403-forbidden-api-access-not-available",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters => "pipeline-error-playht-403-forbidden-out-of-characters",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht429ExceededQuota => "pipeline-error-playht-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht502GatewayError => "pipeline-error-playht-502-gateway-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht504GatewayError => "pipeline-error-playht-504-gateway-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtInvalidEmotion => "pipeline-error-playht-invalid-emotion",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtInvalidVoice => "pipeline-error-playht-invalid-voice",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtOutOfCredits => "pipeline-error-playht-out-of-credits",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtRequestTimedOut => "pipeline-error-playht-request-timed-out",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtUnexpectedError => "pipeline-error-playht-unexpected-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtVoiceFailed => "pipeline-error-playht-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri => "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRimeAiVoiceFailed => "pipeline-error-rime-ai-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod400BadRequestValidationFailed => "pipeline-error-runpod-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod401Unauthorized => "pipeline-error-runpod-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod403ModelAccessDenied => "pipeline-error-runpod-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod429ExceededQuota => "pipeline-error-runpod-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod500ServerError => "pipeline-error-runpod-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod503ServerOverloadedError => "pipeline-error-runpod-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpodLlmFailed => "pipeline-error-runpod-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSesameVoiceFailed => "pipeline-error-sesame-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSmallestAiVoiceFailed => "pipeline-error-smallest-ai-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberAuthFailed => "pipeline-error-soniox-transcriber-auth-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberFailed => "pipeline-error-soniox-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberInvalidConfig => "pipeline-error-soniox-transcriber-invalid-config",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberRateLimited => "pipeline-error-soniox-transcriber-rate-limited",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberServerError => "pipeline-error-soniox-transcriber-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorSpeechmaticsTranscriberFailed => "pipeline-error-speechmatics-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTalkscriberTranscriberFailed => "pipeline-error-talkscriber-transcriber-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTavusVideoFailed => "pipeline-error-tavus-video-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed => "pipeline-error-together-ai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi401Unauthorized => "pipeline-error-together-ai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi403ModelAccessDenied => "pipeline-error-together-ai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi429ExceededQuota => "pipeline-error-together-ai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi500ServerError => "pipeline-error-together-ai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi503ServerOverloadedError => "pipeline-error-together-ai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAiLlmFailed => "pipeline-error-together-ai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi400BadRequestValidationFailed => "pipeline-error-vapi-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi401Unauthorized => "pipeline-error-vapi-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi403ModelAccessDenied => "pipeline-error-vapi-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi429ExceededQuota => "pipeline-error-vapi-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi500ServerError => "pipeline-error-vapi-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi503ServerOverloadedError => "pipeline-error-vapi-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapiLlmFailed => "pipeline-error-vapi-llm-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorVapiVoiceFailed => "pipeline-error-vapi-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorWellsaidVoiceFailed => "pipeline-error-wellsaid-voice-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXai400BadRequestValidationFailed => "pipeline-error-xai-400-bad-request-validation-failed",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXai401Unauthorized => "pipeline-error-xai-401-unauthorized",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXai403ModelAccessDenied => "pipeline-error-xai-403-model-access-denied",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXai429ExceededQuota => "pipeline-error-xai-429-exceeded-quota",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXai500ServerError => "pipeline-error-xai-500-server-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXai503ServerOverloadedError => "pipeline-error-xai-503-server-overloaded-error",
                ServerMessageEndOfCallReportEndedReason.PipelineErrorXaiLlmFailed => "pipeline-error-xai-llm-failed",
                ServerMessageEndOfCallReportEndedReason.ScheduledCallDeleted => "scheduled-call-deleted",
                ServerMessageEndOfCallReportEndedReason.SilenceTimedOut => "silence-timed-out",
                ServerMessageEndOfCallReportEndedReason.TwilioFailedToConnectCall => "twilio-failed-to-connect-call",
                ServerMessageEndOfCallReportEndedReason.TwilioReportedCustomerMisdialed => "twilio-reported-customer-misdialed",
                ServerMessageEndOfCallReportEndedReason.Voicemail => "voicemail",
                ServerMessageEndOfCallReportEndedReason.VonageCompleted => "vonage-completed",
                ServerMessageEndOfCallReportEndedReason.VonageDisconnected => "vonage-disconnected",
                ServerMessageEndOfCallReportEndedReason.VonageFailedToConnectCall => "vonage-failed-to-connect-call",
                ServerMessageEndOfCallReportEndedReason.VonageRejected => "vonage-rejected",
                ServerMessageEndOfCallReportEndedReason.WorkerShutdown => "worker-shutdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageEndOfCallReportEndedReason? ToEnum(string value)
        {
            return value switch
            {
                "assistant-ended-call" => ServerMessageEndOfCallReportEndedReason.AssistantEndedCall,
                "assistant-ended-call-after-message-spoken" => ServerMessageEndOfCallReportEndedReason.AssistantEndedCallAfterMessageSpoken,
                "assistant-ended-call-with-hangup-task" => ServerMessageEndOfCallReportEndedReason.AssistantEndedCallWithHangupTask,
                "assistant-forwarded-call" => ServerMessageEndOfCallReportEndedReason.AssistantForwardedCall,
                "assistant-join-timed-out" => ServerMessageEndOfCallReportEndedReason.AssistantJoinTimedOut,
                "assistant-not-found" => ServerMessageEndOfCallReportEndedReason.AssistantNotFound,
                "assistant-not-valid" => ServerMessageEndOfCallReportEndedReason.AssistantNotValid,
                "assistant-request-failed" => ServerMessageEndOfCallReportEndedReason.AssistantRequestFailed,
                "assistant-request-returned-error" => ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedError,
                "assistant-request-returned-forwarding-phone-number" => ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedForwardingPhoneNumber,
                "assistant-request-returned-invalid-assistant" => ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedInvalidAssistant,
                "assistant-request-returned-no-assistant" => ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedNoAssistant,
                "assistant-request-returned-unspeakable-error" => ServerMessageEndOfCallReportEndedReason.AssistantRequestReturnedUnspeakableError,
                "assistant-said-end-call-phrase" => ServerMessageEndOfCallReportEndedReason.AssistantSaidEndCallPhrase,
                "call-deleted" => ServerMessageEndOfCallReportEndedReason.CallDeleted,
                "call-start-error-neither-assistant-nor-server-set" => ServerMessageEndOfCallReportEndedReason.CallStartErrorNeitherAssistantNorServerSet,
                "call.ending.hook-executed-say" => ServerMessageEndOfCallReportEndedReason.CallEndingHookExecutedSay,
                "call.ending.hook-executed-transfer" => ServerMessageEndOfCallReportEndedReason.CallEndingHookExecutedTransfer,
                "call.forwarding.operator-busy" => ServerMessageEndOfCallReportEndedReason.CallForwardingOperatorBusy,
                "call.in-progress.error-assistant-did-not-receive-customer-audio" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio,
                "call.in-progress.error-pipeline-no-available-llm-model" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel,
                "call.in-progress.error-pipeline-ws-model-connection-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed,
                "call.in-progress.error-providerfault-anthropic-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError,
                "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,
                "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,
                "call.in-progress.error-providerfault-anthropic-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed,
                "call.in-progress.error-providerfault-anthropic-vertex-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError,
                "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-vertex-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,
                "call.in-progress.error-providerfault-anyscale-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError,
                "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,
                "call.in-progress.error-providerfault-anyscale-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed,
                "call.in-progress.error-providerfault-azure-openai-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError,
                "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,
                "call.in-progress.error-providerfault-azure-openai-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,
                "call.in-progress.error-providerfault-baseten-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError,
                "call.in-progress.error-providerfault-baseten-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,
                "call.in-progress.error-providerfault-baseten-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed,
                "call.in-progress.error-providerfault-cartesia-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError,
                "call.in-progress.error-providerfault-cartesia-503-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError,
                "call.in-progress.error-providerfault-cartesia-522-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError,
                "call.in-progress.error-providerfault-cerebras-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError,
                "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,
                "call.in-progress.error-providerfault-cerebras-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed,
                "call.in-progress.error-providerfault-custom-llm-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError,
                "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,
                "call.in-progress.error-providerfault-custom-llm-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed,
                "call.in-progress.error-providerfault-deep-seek-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError,
                "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,
                "call.in-progress.error-providerfault-deep-seek-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed,
                "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,
                "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,
                "call.in-progress.error-providerfault-deepgram-returning-502-network-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,
                "call.in-progress.error-providerfault-deepinfra-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError,
                "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,
                "call.in-progress.error-providerfault-deepinfra-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed,
                "call.in-progress.error-providerfault-eleven-labs-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError,
                "call.in-progress.error-providerfault-eleven-labs-503-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError,
                "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,
                "call.in-progress.error-providerfault-google-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError,
                "call.in-progress.error-providerfault-google-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,
                "call.in-progress.error-providerfault-google-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed,
                "call.in-progress.error-providerfault-groq-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGroq500ServerError,
                "call.in-progress.error-providerfault-groq-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError,
                "call.in-progress.error-providerfault-groq-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed,
                "call.in-progress.error-providerfault-inflection-ai-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError,
                "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-inflection-ai-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed,
                "call.in-progress.error-providerfault-mistral-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultMistral500ServerError,
                "call.in-progress.error-providerfault-mistral-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError,
                "call.in-progress.error-providerfault-mistral-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed,
                "call.in-progress.error-providerfault-openai-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError,
                "call.in-progress.error-providerfault-openai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,
                "call.in-progress.error-providerfault-openai-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed,
                "call.in-progress.error-providerfault-openrouter-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError,
                "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,
                "call.in-progress.error-providerfault-openrouter-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed,
                "call.in-progress.error-providerfault-outbound-sip-403-forbidden" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden,
                "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,
                "call.in-progress.error-providerfault-outbound-sip-408-request-timeout" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,
                "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,
                "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,
                "call.in-progress.error-providerfault-perplexity-ai-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError,
                "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-perplexity-ai-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed,
                "call.in-progress.error-providerfault-playht-502-gateway-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError,
                "call.in-progress.error-providerfault-playht-504-gateway-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError,
                "call.in-progress.error-providerfault-runpod-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError,
                "call.in-progress.error-providerfault-runpod-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,
                "call.in-progress.error-providerfault-runpod-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed,
                "call.in-progress.error-providerfault-together-ai-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError,
                "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-together-ai-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed,
                "call.in-progress.error-providerfault-transport-never-connected" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected,
                "call.in-progress.error-providerfault-vapi-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultVapi500ServerError,
                "call.in-progress.error-providerfault-vapi-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError,
                "call.in-progress.error-providerfault-vapi-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed,
                "call.in-progress.error-providerfault-xai-500-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultXai500ServerError,
                "call.in-progress.error-providerfault-xai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError,
                "call.in-progress.error-providerfault-xai-llm-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed,
                "call.in-progress.error-sip-inbound-call-failed-to-connect" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorSipInboundCallFailedToConnect,
                "call.in-progress.error-sip-outbound-call-failed-to-connect" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect,
                "call.in-progress.error-transfer-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorTransferFailed,
                "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota,
                "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,
                "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,
                "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anyscale-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized,
                "call.in-progress.error-vapifault-anyscale-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,
                "call.in-progress.error-vapifault-anyscale-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota,
                "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,
                "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,
                "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,
                "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,
                "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,
                "call.in-progress.error-vapifault-assembly-ai-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,
                "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-azure-openai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized,
                "call.in-progress.error-vapifault-azure-openai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,
                "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,
                "call.in-progress.error-vapifault-azure-speech-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,
                "call.in-progress.error-vapifault-azure-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed,
                "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-baseten-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized,
                "call.in-progress.error-vapifault-baseten-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied,
                "call.in-progress.error-vapifault-baseten-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota,
                "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,
                "call.in-progress.error-vapifault-cartesia-requested-payment" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment,
                "call.in-progress.error-vapifault-cartesia-socket-hang-up" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp,
                "call.in-progress.error-vapifault-cartesia-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed,
                "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-cerebras-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized,
                "call.in-progress.error-vapifault-cerebras-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied,
                "call.in-progress.error-vapifault-cerebras-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota,
                "call.in-progress.error-vapifault-chat-pipeline-failed-to-start" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart,
                "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-custom-llm-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized,
                "call.in-progress.error-vapifault-custom-llm-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,
                "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota,
                "call.in-progress.error-vapifault-custom-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed,
                "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-deep-seek-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized,
                "call.in-progress.error-vapifault-deep-seek-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,
                "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota,
                "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,
                "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,
                "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,
                "call.in-progress.error-vapifault-deepgram-returning-404-not-found" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound,
                "call.in-progress.error-vapifault-deepgram-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed,
                "call.in-progress.error-vapifault-deepgram-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed,
                "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-deepinfra-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized,
                "call.in-progress.error-vapifault-deepinfra-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,
                "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota,
                "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,
                "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,
                "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
                "call.in-progress.error-vapifault-eleven-labs-invalid-api-key" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey,
                "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,
                "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,
                "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,
                "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,
                "call.in-progress.error-vapifault-eleven-labs-quota-exceeded" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded,
                "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed,
                "call.in-progress.error-vapifault-eleven-labs-unauthorized-access" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,
                "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,
                "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,
                "call.in-progress.error-vapifault-eleven-labs-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-found" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound,
                "call.in-progress.error-vapifault-gladia-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed,
                "call.in-progress.error-vapifault-google-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-google-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized,
                "call.in-progress.error-vapifault-google-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied,
                "call.in-progress.error-vapifault-google-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota,
                "call.in-progress.error-vapifault-google-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed,
                "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-groq-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized,
                "call.in-progress.error-vapifault-groq-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied,
                "call.in-progress.error-vapifault-groq-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota,
                "call.in-progress.error-vapifault-hume-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed,
                "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-inflection-ai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized,
                "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota,
                "call.in-progress.error-vapifault-inworld-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed,
                "call.in-progress.error-vapifault-lmnt-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed,
                "call.in-progress.error-vapifault-minimax-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed,
                "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-mistral-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized,
                "call.in-progress.error-vapifault-mistral-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied,
                "call.in-progress.error-vapifault-mistral-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota,
                "call.in-progress.error-vapifault-neuphonic-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed,
                "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-openai-401-account-not-in-organization" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,
                "call.in-progress.error-vapifault-openai-401-incorrect-api-key" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey,
                "call.in-progress.error-vapifault-openai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized,
                "call.in-progress.error-vapifault-openai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied,
                "call.in-progress.error-vapifault-openai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota,
                "call.in-progress.error-vapifault-openai-429-rate-limit-reached" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached,
                "call.in-progress.error-vapifault-openai-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed,
                "call.in-progress.error-vapifault-openai-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed,
                "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-openrouter-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized,
                "call.in-progress.error-vapifault-openrouter-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,
                "call.in-progress.error-vapifault-openrouter-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota,
                "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized,
                "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,
                "call.in-progress.error-vapifault-playht-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized,
                "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,
                "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,
                "call.in-progress.error-vapifault-playht-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota,
                "call.in-progress.error-vapifault-playht-invalid-emotion" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion,
                "call.in-progress.error-vapifault-playht-invalid-voice" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice,
                "call.in-progress.error-vapifault-playht-out-of-credits" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits,
                "call.in-progress.error-vapifault-playht-request-timed-out" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut,
                "call.in-progress.error-vapifault-playht-unexpected-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError,
                "call.in-progress.error-vapifault-playht-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed,
                "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,
                "call.in-progress.error-vapifault-rime-ai-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed,
                "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-runpod-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized,
                "call.in-progress.error-vapifault-runpod-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied,
                "call.in-progress.error-vapifault-runpod-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota,
                "call.in-progress.error-vapifault-sesame-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed,
                "call.in-progress.error-vapifault-smallest-ai-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-auth-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-invalid-config" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,
                "call.in-progress.error-vapifault-soniox-transcriber-rate-limited" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited,
                "call.in-progress.error-vapifault-soniox-transcriber-server-error" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError,
                "call.in-progress.error-vapifault-speechmatics-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,
                "call.in-progress.error-vapifault-talkscriber-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed,
                "call.in-progress.error-vapifault-tavus-video-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTavusVideoFailed,
                "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-together-ai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized,
                "call.in-progress.error-vapifault-together-ai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-together-ai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota,
                "call.in-progress.error-vapifault-transport-connected-but-call-not-active" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive,
                "call.in-progress.error-vapifault-transport-never-connected" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultTransportNeverConnected,
                "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-vapi-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized,
                "call.in-progress.error-vapifault-vapi-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied,
                "call.in-progress.error-vapifault-vapi-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota,
                "call.in-progress.error-vapifault-vapi-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed,
                "call.in-progress.error-vapifault-wellsaid-voice-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed,
                "call.in-progress.error-vapifault-worker-died" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultWorkerDied,
                "call.in-progress.error-vapifault-worker-not-available" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable,
                "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-xai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai401Unauthorized,
                "call.in-progress.error-vapifault-xai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied,
                "call.in-progress.error-vapifault-xai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota,
                "call.in-progress.error-warm-transfer-assistant-cancelled" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferAssistantCancelled,
                "call.in-progress.error-warm-transfer-max-duration" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferMaxDuration,
                "call.in-progress.error-warm-transfer-microphone-timeout" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout,
                "call.in-progress.error-warm-transfer-silence-timeout" => ServerMessageEndOfCallReportEndedReason.CallInProgressErrorWarmTransferSilenceTimeout,
                "call.in-progress.sip-completed-call" => ServerMessageEndOfCallReportEndedReason.CallInProgressSipCompletedCall,
                "call.in-progress.twilio-completed-call" => ServerMessageEndOfCallReportEndedReason.CallInProgressTwilioCompletedCall,
                "call.ringing.error-sip-inbound-call-failed-to-connect" => ServerMessageEndOfCallReportEndedReason.CallRingingErrorSipInboundCallFailedToConnect,
                "call.ringing.hook-executed-say" => ServerMessageEndOfCallReportEndedReason.CallRingingHookExecutedSay,
                "call.ringing.hook-executed-transfer" => ServerMessageEndOfCallReportEndedReason.CallRingingHookExecutedTransfer,
                "call.ringing.sip-inbound-caller-hungup-before-call-connect" => ServerMessageEndOfCallReportEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect,
                "call.start.error-enterprise-feature-not-available-recording-consent" => ServerMessageEndOfCallReportEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,
                "call.start.error-fraud-check-failed" => ServerMessageEndOfCallReportEndedReason.CallStartErrorFraudCheckFailed,
                "call.start.error-get-assistant" => ServerMessageEndOfCallReportEndedReason.CallStartErrorGetAssistant,
                "call.start.error-get-customer" => ServerMessageEndOfCallReportEndedReason.CallStartErrorGetCustomer,
                "call.start.error-get-phone-number" => ServerMessageEndOfCallReportEndedReason.CallStartErrorGetPhoneNumber,
                "call.start.error-get-resources-validation" => ServerMessageEndOfCallReportEndedReason.CallStartErrorGetResourcesValidation,
                "call.start.error-get-transport" => ServerMessageEndOfCallReportEndedReason.CallStartErrorGetTransport,
                "call.start.error-subscription-concurrency-limit-reached" => ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached,
                "call.start.error-subscription-frozen" => ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionFrozen,
                "call.start.error-subscription-insufficient-credits" => ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionInsufficientCredits,
                "call.start.error-subscription-upgrade-failed" => ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionUpgradeFailed,
                "call.start.error-subscription-wallet-does-not-exist" => ServerMessageEndOfCallReportEndedReason.CallStartErrorSubscriptionWalletDoesNotExist,
                "call.start.error-vapi-number-international" => ServerMessageEndOfCallReportEndedReason.CallStartErrorVapiNumberInternational,
                "call.start.error-vapi-number-outbound-daily-limit" => ServerMessageEndOfCallReportEndedReason.CallStartErrorVapiNumberOutboundDailyLimit,
                "call.start.error-vapifault-database-error" => ServerMessageEndOfCallReportEndedReason.CallStartErrorVapifaultDatabaseError,
                "call.start.error-vapifault-get-org" => ServerMessageEndOfCallReportEndedReason.CallStartErrorVapifaultGetOrg,
                "call.start.error-vapifault-get-subscription" => ServerMessageEndOfCallReportEndedReason.CallStartErrorVapifaultGetSubscription,
                "customer-busy" => ServerMessageEndOfCallReportEndedReason.CustomerBusy,
                "customer-did-not-answer" => ServerMessageEndOfCallReportEndedReason.CustomerDidNotAnswer,
                "customer-did-not-give-microphone-permission" => ServerMessageEndOfCallReportEndedReason.CustomerDidNotGiveMicrophonePermission,
                "customer-ended-call" => ServerMessageEndOfCallReportEndedReason.CustomerEndedCall,
                "customer-ended-call-after-warm-transfer-attempt" => ServerMessageEndOfCallReportEndedReason.CustomerEndedCallAfterWarmTransferAttempt,
                "customer-ended-call-before-warm-transfer" => ServerMessageEndOfCallReportEndedReason.CustomerEndedCallBeforeWarmTransfer,
                "customer-ended-call-during-transfer" => ServerMessageEndOfCallReportEndedReason.CustomerEndedCallDuringTransfer,
                "exceeded-max-duration" => ServerMessageEndOfCallReportEndedReason.ExceededMaxDuration,
                "manually-canceled" => ServerMessageEndOfCallReportEndedReason.ManuallyCanceled,
                "phone-call-provider-bypass-enabled-but-no-call-received" => ServerMessageEndOfCallReportEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived,
                "phone-call-provider-closed-websocket" => ServerMessageEndOfCallReportEndedReason.PhoneCallProviderClosedWebsocket,
                "pipeline-error-anthropic-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed,
                "pipeline-error-anthropic-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic401Unauthorized,
                "pipeline-error-anthropic-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic403ModelAccessDenied,
                "pipeline-error-anthropic-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic429ExceededQuota,
                "pipeline-error-anthropic-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic500ServerError,
                "pipeline-error-anthropic-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropic503ServerOverloadedError,
                "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed,
                "pipeline-error-anthropic-bedrock-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock401Unauthorized,
                "pipeline-error-anthropic-bedrock-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied,
                "pipeline-error-anthropic-bedrock-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota,
                "pipeline-error-anthropic-bedrock-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock500ServerError,
                "pipeline-error-anthropic-bedrock-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError,
                "pipeline-error-anthropic-bedrock-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicBedrockLlmFailed,
                "pipeline-error-anthropic-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicLlmFailed,
                "pipeline-error-anthropic-vertex-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed,
                "pipeline-error-anthropic-vertex-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex401Unauthorized,
                "pipeline-error-anthropic-vertex-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied,
                "pipeline-error-anthropic-vertex-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex429ExceededQuota,
                "pipeline-error-anthropic-vertex-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex500ServerError,
                "pipeline-error-anthropic-vertex-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError,
                "pipeline-error-anthropic-vertex-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnthropicVertexLlmFailed,
                "pipeline-error-anyscale-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed,
                "pipeline-error-anyscale-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale401Unauthorized,
                "pipeline-error-anyscale-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale403ModelAccessDenied,
                "pipeline-error-anyscale-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale429ExceededQuota,
                "pipeline-error-anyscale-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale500ServerError,
                "pipeline-error-anyscale-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscale503ServerOverloadedError,
                "pipeline-error-anyscale-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAnyscaleLlmFailed,
                "pipeline-error-assembly-ai-returning-400-insufficent-funds" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds,
                "pipeline-error-assembly-ai-returning-400-paid-only-feature" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature,
                "pipeline-error-assembly-ai-returning-401-invalid-credentials" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials,
                "pipeline-error-assembly-ai-returning-500-invalid-schema" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema,
                "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,
                "pipeline-error-assembly-ai-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAssemblyAiTranscriberFailed,
                "pipeline-error-azure-openai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed,
                "pipeline-error-azure-openai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai401Unauthorized,
                "pipeline-error-azure-openai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied,
                "pipeline-error-azure-openai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai429ExceededQuota,
                "pipeline-error-azure-openai-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai500ServerError,
                "pipeline-error-azure-openai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError,
                "pipeline-error-azure-openai-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureOpenaiLlmFailed,
                "pipeline-error-azure-speech-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureSpeechTranscriberFailed,
                "pipeline-error-azure-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorAzureVoiceFailed,
                "pipeline-error-baseten-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten400BadRequestValidationFailed,
                "pipeline-error-baseten-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten401Unauthorized,
                "pipeline-error-baseten-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten403ModelAccessDenied,
                "pipeline-error-baseten-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten429ExceededQuota,
                "pipeline-error-baseten-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten500ServerError,
                "pipeline-error-baseten-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBaseten503ServerOverloadedError,
                "pipeline-error-baseten-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorBasetenLlmFailed,
                "pipeline-error-cartesia-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia500ServerError,
                "pipeline-error-cartesia-502-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia502ServerError,
                "pipeline-error-cartesia-503-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia503ServerError,
                "pipeline-error-cartesia-522-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesia522ServerError,
                "pipeline-error-cartesia-requested-payment" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesiaRequestedPayment,
                "pipeline-error-cartesia-socket-hang-up" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesiaSocketHangUp,
                "pipeline-error-cartesia-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCartesiaVoiceFailed,
                "pipeline-error-cerebras-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras400BadRequestValidationFailed,
                "pipeline-error-cerebras-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras401Unauthorized,
                "pipeline-error-cerebras-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras403ModelAccessDenied,
                "pipeline-error-cerebras-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras429ExceededQuota,
                "pipeline-error-cerebras-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras500ServerError,
                "pipeline-error-cerebras-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebras503ServerOverloadedError,
                "pipeline-error-cerebras-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCerebrasLlmFailed,
                "pipeline-error-custom-llm-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed,
                "pipeline-error-custom-llm-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm401Unauthorized,
                "pipeline-error-custom-llm-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm403ModelAccessDenied,
                "pipeline-error-custom-llm-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm429ExceededQuota,
                "pipeline-error-custom-llm-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm500ServerError,
                "pipeline-error-custom-llm-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlm503ServerOverloadedError,
                "pipeline-error-custom-llm-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomLlmLlmFailed,
                "pipeline-error-custom-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomTranscriberFailed,
                "pipeline-error-custom-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorCustomVoiceFailed,
                "pipeline-error-deep-seek-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed,
                "pipeline-error-deep-seek-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek401Unauthorized,
                "pipeline-error-deep-seek-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek403ModelAccessDenied,
                "pipeline-error-deep-seek-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek429ExceededQuota,
                "pipeline-error-deep-seek-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek500ServerError,
                "pipeline-error-deep-seek-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeek503ServerOverloadedError,
                "pipeline-error-deep-seek-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepSeekLlmFailed,
                "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,
                "pipeline-error-deepgram-returning-401-invalid-credentials" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials,
                "pipeline-error-deepgram-returning-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied,
                "pipeline-error-deepgram-returning-404-not-found" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning404NotFound,
                "pipeline-error-deepgram-returning-500-invalid-json" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning500InvalidJson,
                "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach,
                "pipeline-error-deepgram-returning-502-network-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturning502NetworkError,
                "pipeline-error-deepgram-returning-econnreset" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramReturningEconnreset,
                "pipeline-error-deepgram-transcriber-api-key-missing" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing,
                "pipeline-error-deepgram-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramTranscriberFailed,
                "pipeline-error-deepgram-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepgramVoiceFailed,
                "pipeline-error-deepinfra-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed,
                "pipeline-error-deepinfra-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra401Unauthorized,
                "pipeline-error-deepinfra-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra403ModelAccessDenied,
                "pipeline-error-deepinfra-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra429ExceededQuota,
                "pipeline-error-deepinfra-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra500ServerError,
                "pipeline-error-deepinfra-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfra503ServerOverloadedError,
                "pipeline-error-deepinfra-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorDeepinfraLlmFailed,
                "pipeline-error-eleven-labs-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabs500ServerError,
                "pipeline-error-eleven-labs-503-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabs503ServerError,
                "pipeline-error-eleven-labs-blocked-account-in-probation" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation,
                "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-content-against-their-policy" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,
                "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
                "pipeline-error-eleven-labs-invalid-api-key" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsInvalidApiKey,
                "pipeline-error-eleven-labs-invalid-voice-samples" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples,
                "pipeline-error-eleven-labs-max-character-limit-exceeded" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded,
                "pipeline-error-eleven-labs-missing-samples-for-voice-clone" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone,
                "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,
                "pipeline-error-eleven-labs-quota-exceeded" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsQuotaExceeded,
                "pipeline-error-eleven-labs-system-busy-and-requested-upgrade" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,
                "pipeline-error-eleven-labs-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsTranscriberFailed,
                "pipeline-error-eleven-labs-unauthorized-access" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsUnauthorizedAccess,
                "pipeline-error-eleven-labs-unauthorized-to-access-model" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel,
                "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner,
                "pipeline-error-eleven-labs-voice-disabled-by-owner" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner,
                "pipeline-error-eleven-labs-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceFailed,
                "pipeline-error-eleven-labs-voice-not-allowed-for-free-users" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,
                "pipeline-error-eleven-labs-voice-not-fine-tuned" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned,
                "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,
                "pipeline-error-eleven-labs-voice-not-found" => ServerMessageEndOfCallReportEndedReason.PipelineErrorElevenLabsVoiceNotFound,
                "pipeline-error-gladia-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGladiaTranscriberFailed,
                "pipeline-error-google-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle400BadRequestValidationFailed,
                "pipeline-error-google-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle401Unauthorized,
                "pipeline-error-google-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle403ModelAccessDenied,
                "pipeline-error-google-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle429ExceededQuota,
                "pipeline-error-google-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle500ServerError,
                "pipeline-error-google-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogle503ServerOverloadedError,
                "pipeline-error-google-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogleLlmFailed,
                "pipeline-error-google-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGoogleTranscriberFailed,
                "pipeline-error-groq-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq400BadRequestValidationFailed,
                "pipeline-error-groq-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq401Unauthorized,
                "pipeline-error-groq-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq403ModelAccessDenied,
                "pipeline-error-groq-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq429ExceededQuota,
                "pipeline-error-groq-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq500ServerError,
                "pipeline-error-groq-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroq503ServerOverloadedError,
                "pipeline-error-groq-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorGroqLlmFailed,
                "pipeline-error-hume-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorHumeVoiceFailed,
                "pipeline-error-inflection-ai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed,
                "pipeline-error-inflection-ai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi401Unauthorized,
                "pipeline-error-inflection-ai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi403ModelAccessDenied,
                "pipeline-error-inflection-ai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi429ExceededQuota,
                "pipeline-error-inflection-ai-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi500ServerError,
                "pipeline-error-inflection-ai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAi503ServerOverloadedError,
                "pipeline-error-inflection-ai-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInflectionAiLlmFailed,
                "pipeline-error-inworld-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorInworldVoiceFailed,
                "pipeline-error-lmnt-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorLmntVoiceFailed,
                "pipeline-error-minimax-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMinimaxVoiceFailed,
                "pipeline-error-mistral-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral400BadRequestValidationFailed,
                "pipeline-error-mistral-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral401Unauthorized,
                "pipeline-error-mistral-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral403ModelAccessDenied,
                "pipeline-error-mistral-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral429ExceededQuota,
                "pipeline-error-mistral-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral500ServerError,
                "pipeline-error-mistral-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistral503ServerOverloadedError,
                "pipeline-error-mistral-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorMistralLlmFailed,
                "pipeline-error-neuphonic-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorNeuphonicVoiceFailed,
                "pipeline-error-openai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai400BadRequestValidationFailed,
                "pipeline-error-openai-401-account-not-in-organization" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai401AccountNotInOrganization,
                "pipeline-error-openai-401-incorrect-api-key" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai401IncorrectApiKey,
                "pipeline-error-openai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai401Unauthorized,
                "pipeline-error-openai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai403ModelAccessDenied,
                "pipeline-error-openai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai429ExceededQuota,
                "pipeline-error-openai-429-rate-limit-reached" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai429RateLimitReached,
                "pipeline-error-openai-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai500ServerError,
                "pipeline-error-openai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenai503ServerOverloadedError,
                "pipeline-error-openai-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenaiLlmFailed,
                "pipeline-error-openai-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenaiTranscriberFailed,
                "pipeline-error-openai-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenaiVoiceFailed,
                "pipeline-error-openrouter-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed,
                "pipeline-error-openrouter-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter401Unauthorized,
                "pipeline-error-openrouter-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter403ModelAccessDenied,
                "pipeline-error-openrouter-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter429ExceededQuota,
                "pipeline-error-openrouter-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter500ServerError,
                "pipeline-error-openrouter-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouter503ServerOverloadedError,
                "pipeline-error-openrouter-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorOpenrouterLlmFailed,
                "pipeline-error-perplexity-ai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed,
                "pipeline-error-perplexity-ai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi401Unauthorized,
                "pipeline-error-perplexity-ai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied,
                "pipeline-error-perplexity-ai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi429ExceededQuota,
                "pipeline-error-perplexity-ai-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi500ServerError,
                "pipeline-error-perplexity-ai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError,
                "pipeline-error-perplexity-ai-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPerplexityAiLlmFailed,
                "pipeline-error-playht-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht401Unauthorized,
                "pipeline-error-playht-403-forbidden-api-access-not-available" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,
                "pipeline-error-playht-403-forbidden-out-of-characters" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters,
                "pipeline-error-playht-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht429ExceededQuota,
                "pipeline-error-playht-502-gateway-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht502GatewayError,
                "pipeline-error-playht-504-gateway-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayht504GatewayError,
                "pipeline-error-playht-invalid-emotion" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtInvalidEmotion,
                "pipeline-error-playht-invalid-voice" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtInvalidVoice,
                "pipeline-error-playht-out-of-credits" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtOutOfCredits,
                "pipeline-error-playht-request-timed-out" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtRequestTimedOut,
                "pipeline-error-playht-unexpected-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtUnexpectedError,
                "pipeline-error-playht-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtVoiceFailed,
                "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri" => ServerMessageEndOfCallReportEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,
                "pipeline-error-rime-ai-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRimeAiVoiceFailed,
                "pipeline-error-runpod-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod400BadRequestValidationFailed,
                "pipeline-error-runpod-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod401Unauthorized,
                "pipeline-error-runpod-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod403ModelAccessDenied,
                "pipeline-error-runpod-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod429ExceededQuota,
                "pipeline-error-runpod-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod500ServerError,
                "pipeline-error-runpod-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpod503ServerOverloadedError,
                "pipeline-error-runpod-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorRunpodLlmFailed,
                "pipeline-error-sesame-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSesameVoiceFailed,
                "pipeline-error-smallest-ai-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSmallestAiVoiceFailed,
                "pipeline-error-soniox-transcriber-auth-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberAuthFailed,
                "pipeline-error-soniox-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberFailed,
                "pipeline-error-soniox-transcriber-invalid-config" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberInvalidConfig,
                "pipeline-error-soniox-transcriber-rate-limited" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberRateLimited,
                "pipeline-error-soniox-transcriber-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSonioxTranscriberServerError,
                "pipeline-error-speechmatics-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorSpeechmaticsTranscriberFailed,
                "pipeline-error-talkscriber-transcriber-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTalkscriberTranscriberFailed,
                "pipeline-error-tavus-video-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTavusVideoFailed,
                "pipeline-error-together-ai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed,
                "pipeline-error-together-ai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi401Unauthorized,
                "pipeline-error-together-ai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi403ModelAccessDenied,
                "pipeline-error-together-ai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi429ExceededQuota,
                "pipeline-error-together-ai-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi500ServerError,
                "pipeline-error-together-ai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAi503ServerOverloadedError,
                "pipeline-error-together-ai-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorTogetherAiLlmFailed,
                "pipeline-error-vapi-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi400BadRequestValidationFailed,
                "pipeline-error-vapi-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi401Unauthorized,
                "pipeline-error-vapi-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi403ModelAccessDenied,
                "pipeline-error-vapi-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi429ExceededQuota,
                "pipeline-error-vapi-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi500ServerError,
                "pipeline-error-vapi-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapi503ServerOverloadedError,
                "pipeline-error-vapi-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapiLlmFailed,
                "pipeline-error-vapi-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorVapiVoiceFailed,
                "pipeline-error-wellsaid-voice-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorWellsaidVoiceFailed,
                "pipeline-error-xai-400-bad-request-validation-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXai400BadRequestValidationFailed,
                "pipeline-error-xai-401-unauthorized" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXai401Unauthorized,
                "pipeline-error-xai-403-model-access-denied" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXai403ModelAccessDenied,
                "pipeline-error-xai-429-exceeded-quota" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXai429ExceededQuota,
                "pipeline-error-xai-500-server-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXai500ServerError,
                "pipeline-error-xai-503-server-overloaded-error" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXai503ServerOverloadedError,
                "pipeline-error-xai-llm-failed" => ServerMessageEndOfCallReportEndedReason.PipelineErrorXaiLlmFailed,
                "scheduled-call-deleted" => ServerMessageEndOfCallReportEndedReason.ScheduledCallDeleted,
                "silence-timed-out" => ServerMessageEndOfCallReportEndedReason.SilenceTimedOut,
                "twilio-failed-to-connect-call" => ServerMessageEndOfCallReportEndedReason.TwilioFailedToConnectCall,
                "twilio-reported-customer-misdialed" => ServerMessageEndOfCallReportEndedReason.TwilioReportedCustomerMisdialed,
                "voicemail" => ServerMessageEndOfCallReportEndedReason.Voicemail,
                "vonage-completed" => ServerMessageEndOfCallReportEndedReason.VonageCompleted,
                "vonage-disconnected" => ServerMessageEndOfCallReportEndedReason.VonageDisconnected,
                "vonage-failed-to-connect-call" => ServerMessageEndOfCallReportEndedReason.VonageFailedToConnectCall,
                "vonage-rejected" => ServerMessageEndOfCallReportEndedReason.VonageRejected,
                "worker-shutdown" => ServerMessageEndOfCallReportEndedReason.WorkerShutdown,
                _ => null,
            };
        }
    }
}