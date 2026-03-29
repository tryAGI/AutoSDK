//HintName: G.Models.CallEndedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the explanation for how the call ended.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallEndedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-ended-call")]
        AssistantEndedCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-ended-call-after-message-spoken")]
        AssistantEndedCallAfterMessageSpoken,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-ended-call-with-hangup-task")]
        AssistantEndedCallWithHangupTask,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-forwarded-call")]
        AssistantForwardedCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-join-timed-out")]
        AssistantJoinTimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-not-found")]
        AssistantNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-not-valid")]
        AssistantNotValid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-failed")]
        AssistantRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-error")]
        AssistantRequestReturnedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-forwarding-phone-number")]
        AssistantRequestReturnedForwardingPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-invalid-assistant")]
        AssistantRequestReturnedInvalidAssistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-no-assistant")]
        AssistantRequestReturnedNoAssistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-unspeakable-error")]
        AssistantRequestReturnedUnspeakableError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-said-end-call-phrase")]
        AssistantSaidEndCallPhrase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call-deleted")]
        CallDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call-start-error-neither-assistant-nor-server-set")]
        CallStartErrorNeitherAssistantNorServerSet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ending.hook-executed-say")]
        CallEndingHookExecutedSay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ending.hook-executed-transfer")]
        CallEndingHookExecutedTransfer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.forwarding.operator-busy")]
        CallForwardingOperatorBusy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-assistant-did-not-receive-customer-audio")]
        CallInProgressErrorAssistantDidNotReceiveCustomerAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-pipeline-no-available-llm-model")]
        CallInProgressErrorPipelineNoAvailableLlmModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-pipeline-ws-model-connection-failed")]
        CallInProgressErrorPipelineWsModelConnectionFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-500-server-error")]
        CallInProgressErrorProviderfaultAnthropic500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-bedrock-500-server-error")]
        CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-bedrock-llm-failed")]
        CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-llm-failed")]
        CallInProgressErrorProviderfaultAnthropicLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-vertex-500-server-error")]
        CallInProgressErrorProviderfaultAnthropicVertex500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anthropic-vertex-llm-failed")]
        CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anyscale-500-server-error")]
        CallInProgressErrorProviderfaultAnyscale500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anyscale-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-anyscale-llm-failed")]
        CallInProgressErrorProviderfaultAnyscaleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-azure-openai-500-server-error")]
        CallInProgressErrorProviderfaultAzureOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-azure-openai-llm-failed")]
        CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-baseten-500-server-error")]
        CallInProgressErrorProviderfaultBaseten500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-baseten-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-baseten-llm-failed")]
        CallInProgressErrorProviderfaultBasetenLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-cartesia-500-server-error")]
        CallInProgressErrorProviderfaultCartesia500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-cartesia-503-server-error")]
        CallInProgressErrorProviderfaultCartesia503ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-cartesia-522-server-error")]
        CallInProgressErrorProviderfaultCartesia522ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-cerebras-500-server-error")]
        CallInProgressErrorProviderfaultCerebras500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-cerebras-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-cerebras-llm-failed")]
        CallInProgressErrorProviderfaultCerebrasLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-custom-llm-500-server-error")]
        CallInProgressErrorProviderfaultCustomLlm500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-custom-llm-llm-failed")]
        CallInProgressErrorProviderfaultCustomLlmLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deep-seek-500-server-error")]
        CallInProgressErrorProviderfaultDeepSeek500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deep-seek-llm-failed")]
        CallInProgressErrorProviderfaultDeepSeekLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deepgram-returning-500-invalid-json")]
        CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach")]
        CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deepgram-returning-502-network-error")]
        CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deepinfra-500-server-error")]
        CallInProgressErrorProviderfaultDeepinfra500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-deepinfra-llm-failed")]
        CallInProgressErrorProviderfaultDeepinfraLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-eleven-labs-500-server-error")]
        CallInProgressErrorProviderfaultElevenLabs500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-eleven-labs-503-server-error")]
        CallInProgressErrorProviderfaultElevenLabs503ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade")]
        CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-google-500-server-error")]
        CallInProgressErrorProviderfaultGoogle500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-google-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-google-llm-failed")]
        CallInProgressErrorProviderfaultGoogleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-groq-500-server-error")]
        CallInProgressErrorProviderfaultGroq500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-groq-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultGroq503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-groq-llm-failed")]
        CallInProgressErrorProviderfaultGroqLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-inflection-ai-500-server-error")]
        CallInProgressErrorProviderfaultInflectionAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-inflection-ai-llm-failed")]
        CallInProgressErrorProviderfaultInflectionAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-mistral-500-server-error")]
        CallInProgressErrorProviderfaultMistral500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-mistral-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultMistral503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-mistral-llm-failed")]
        CallInProgressErrorProviderfaultMistralLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-openai-500-server-error")]
        CallInProgressErrorProviderfaultOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-openai-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-openai-llm-failed")]
        CallInProgressErrorProviderfaultOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-openrouter-500-server-error")]
        CallInProgressErrorProviderfaultOpenrouter500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-openrouter-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-openrouter-llm-failed")]
        CallInProgressErrorProviderfaultOpenrouterLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-outbound-sip-403-forbidden")]
        CallInProgressErrorProviderfaultOutboundSip403Forbidden,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required")]
        CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-outbound-sip-408-request-timeout")]
        CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable")]
        CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-outbound-sip-503-service-unavailable")]
        CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-perplexity-ai-500-server-error")]
        CallInProgressErrorProviderfaultPerplexityAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-perplexity-ai-llm-failed")]
        CallInProgressErrorProviderfaultPerplexityAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-playht-502-gateway-error")]
        CallInProgressErrorProviderfaultPlayht502GatewayError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-playht-504-gateway-error")]
        CallInProgressErrorProviderfaultPlayht504GatewayError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-runpod-500-server-error")]
        CallInProgressErrorProviderfaultRunpod500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-runpod-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-runpod-llm-failed")]
        CallInProgressErrorProviderfaultRunpodLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-together-ai-500-server-error")]
        CallInProgressErrorProviderfaultTogetherAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-together-ai-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-together-ai-llm-failed")]
        CallInProgressErrorProviderfaultTogetherAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-transport-never-connected")]
        CallInProgressErrorProviderfaultTransportNeverConnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-vapi-500-server-error")]
        CallInProgressErrorProviderfaultVapi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-vapi-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultVapi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-vapi-llm-failed")]
        CallInProgressErrorProviderfaultVapiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-xai-500-server-error")]
        CallInProgressErrorProviderfaultXai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-xai-503-server-overloaded-error")]
        CallInProgressErrorProviderfaultXai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-providerfault-xai-llm-failed")]
        CallInProgressErrorProviderfaultXaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-sip-inbound-call-failed-to-connect")]
        CallInProgressErrorSipInboundCallFailedToConnect,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-sip-outbound-call-failed-to-connect")]
        CallInProgressErrorSipOutboundCallFailedToConnect,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-transfer-failed")]
        CallInProgressErrorTransferFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-401-unauthorized")]
        CallInProgressErrorVapifaultAnthropic401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-403-model-access-denied")]
        CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-429-exceeded-quota")]
        CallInProgressErrorVapifaultAnthropic429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized")]
        CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied")]
        CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota")]
        CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized")]
        CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied")]
        CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota")]
        CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anyscale-401-unauthorized")]
        CallInProgressErrorVapifaultAnyscale401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anyscale-403-model-access-denied")]
        CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-anyscale-429-exceeded-quota")]
        CallInProgressErrorVapifaultAnyscale429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds")]
        CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature")]
        CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials")]
        CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema")]
        CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed")]
        CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-assembly-ai-transcriber-failed")]
        CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-azure-openai-401-unauthorized")]
        CallInProgressErrorVapifaultAzureOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-azure-openai-403-model-access-denied")]
        CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-azure-openai-429-exceeded-quota")]
        CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-azure-speech-transcriber-failed")]
        CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-azure-voice-failed")]
        CallInProgressErrorVapifaultAzureVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-baseten-401-unauthorized")]
        CallInProgressErrorVapifaultBaseten401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-baseten-403-model-access-denied")]
        CallInProgressErrorVapifaultBaseten403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-baseten-429-exceeded-quota")]
        CallInProgressErrorVapifaultBaseten429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing")]
        CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cartesia-requested-payment")]
        CallInProgressErrorVapifaultCartesiaRequestedPayment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cartesia-socket-hang-up")]
        CallInProgressErrorVapifaultCartesiaSocketHangUp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cartesia-voice-failed")]
        CallInProgressErrorVapifaultCartesiaVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cerebras-401-unauthorized")]
        CallInProgressErrorVapifaultCerebras401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cerebras-403-model-access-denied")]
        CallInProgressErrorVapifaultCerebras403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-cerebras-429-exceeded-quota")]
        CallInProgressErrorVapifaultCerebras429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-chat-pipeline-failed-to-start")]
        CallInProgressErrorVapifaultChatPipelineFailedToStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-custom-llm-401-unauthorized")]
        CallInProgressErrorVapifaultCustomLlm401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-custom-llm-403-model-access-denied")]
        CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-custom-llm-429-exceeded-quota")]
        CallInProgressErrorVapifaultCustomLlm429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-custom-transcriber-failed")]
        CallInProgressErrorVapifaultCustomTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deep-seek-401-unauthorized")]
        CallInProgressErrorVapifaultDeepSeek401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deep-seek-403-model-access-denied")]
        CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deep-seek-429-exceeded-quota")]
        CallInProgressErrorVapifaultDeepSeek429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination")]
        CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials")]
        CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied")]
        CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepgram-returning-404-not-found")]
        CallInProgressErrorVapifaultDeepgramReturning404NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepgram-transcriber-failed")]
        CallInProgressErrorVapifaultDeepgramTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepgram-voice-failed")]
        CallInProgressErrorVapifaultDeepgramVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepinfra-401-unauthorized")]
        CallInProgressErrorVapifaultDeepinfra401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepinfra-403-model-access-denied")]
        CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-deepinfra-429-exceeded-quota")]
        CallInProgressErrorVapifaultDeepinfra429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation")]
        CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade")]
        CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy")]
        CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade")]
        CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade")]
        CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification")]
        CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-invalid-api-key")]
        CallInProgressErrorVapifaultElevenLabsInvalidApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples")]
        CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded")]
        CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone")]
        CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus")]
        CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-quota-exceeded")]
        CallInProgressErrorVapifaultElevenLabsQuotaExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade")]
        CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-transcriber-failed")]
        CallInProgressErrorVapifaultElevenLabsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-unauthorized-access")]
        CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model")]
        CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner")]
        CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-voice-failed")]
        CallInProgressErrorVapifaultElevenLabsVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users")]
        CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned")]
        CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used")]
        CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-eleven-labs-voice-not-found")]
        CallInProgressErrorVapifaultElevenLabsVoiceNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-gladia-transcriber-failed")]
        CallInProgressErrorVapifaultGladiaTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-google-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-google-401-unauthorized")]
        CallInProgressErrorVapifaultGoogle401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-google-403-model-access-denied")]
        CallInProgressErrorVapifaultGoogle403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-google-429-exceeded-quota")]
        CallInProgressErrorVapifaultGoogle429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-google-transcriber-failed")]
        CallInProgressErrorVapifaultGoogleTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-groq-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-groq-401-unauthorized")]
        CallInProgressErrorVapifaultGroq401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-groq-403-model-access-denied")]
        CallInProgressErrorVapifaultGroq403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-groq-429-exceeded-quota")]
        CallInProgressErrorVapifaultGroq429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-hume-voice-failed")]
        CallInProgressErrorVapifaultHumeVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-inflection-ai-401-unauthorized")]
        CallInProgressErrorVapifaultInflectionAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-inflection-ai-403-model-access-denied")]
        CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota")]
        CallInProgressErrorVapifaultInflectionAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-inworld-voice-failed")]
        CallInProgressErrorVapifaultInworldVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-lmnt-voice-failed")]
        CallInProgressErrorVapifaultLmntVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-minimax-voice-failed")]
        CallInProgressErrorVapifaultMinimaxVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-mistral-401-unauthorized")]
        CallInProgressErrorVapifaultMistral401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-mistral-403-model-access-denied")]
        CallInProgressErrorVapifaultMistral403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-mistral-429-exceeded-quota")]
        CallInProgressErrorVapifaultMistral429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-neuphonic-voice-failed")]
        CallInProgressErrorVapifaultNeuphonicVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-401-account-not-in-organization")]
        CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-401-incorrect-api-key")]
        CallInProgressErrorVapifaultOpenai401IncorrectApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-401-unauthorized")]
        CallInProgressErrorVapifaultOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-403-model-access-denied")]
        CallInProgressErrorVapifaultOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-429-exceeded-quota")]
        CallInProgressErrorVapifaultOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-429-rate-limit-reached")]
        CallInProgressErrorVapifaultOpenai429RateLimitReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-transcriber-failed")]
        CallInProgressErrorVapifaultOpenaiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openai-voice-failed")]
        CallInProgressErrorVapifaultOpenaiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openrouter-401-unauthorized")]
        CallInProgressErrorVapifaultOpenrouter401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openrouter-403-model-access-denied")]
        CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-openrouter-429-exceeded-quota")]
        CallInProgressErrorVapifaultOpenrouter429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-perplexity-ai-401-unauthorized")]
        CallInProgressErrorVapifaultPerplexityAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied")]
        CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota")]
        CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-401-unauthorized")]
        CallInProgressErrorVapifaultPlayht401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available")]
        CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters")]
        CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-429-exceeded-quota")]
        CallInProgressErrorVapifaultPlayht429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-invalid-emotion")]
        CallInProgressErrorVapifaultPlayhtInvalidEmotion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-invalid-voice")]
        CallInProgressErrorVapifaultPlayhtInvalidVoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-out-of-credits")]
        CallInProgressErrorVapifaultPlayhtOutOfCredits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-request-timed-out")]
        CallInProgressErrorVapifaultPlayhtRequestTimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-unexpected-error")]
        CallInProgressErrorVapifaultPlayhtUnexpectedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-voice-failed")]
        CallInProgressErrorVapifaultPlayhtVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri")]
        CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-rime-ai-voice-failed")]
        CallInProgressErrorVapifaultRimeAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-runpod-401-unauthorized")]
        CallInProgressErrorVapifaultRunpod401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-runpod-403-model-access-denied")]
        CallInProgressErrorVapifaultRunpod403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-runpod-429-exceeded-quota")]
        CallInProgressErrorVapifaultRunpod429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-sesame-voice-failed")]
        CallInProgressErrorVapifaultSesameVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-smallest-ai-voice-failed")]
        CallInProgressErrorVapifaultSmallestAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-soniox-transcriber-auth-failed")]
        CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-soniox-transcriber-failed")]
        CallInProgressErrorVapifaultSonioxTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-soniox-transcriber-invalid-config")]
        CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-soniox-transcriber-rate-limited")]
        CallInProgressErrorVapifaultSonioxTranscriberRateLimited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-soniox-transcriber-server-error")]
        CallInProgressErrorVapifaultSonioxTranscriberServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-speechmatics-transcriber-failed")]
        CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-talkscriber-transcriber-failed")]
        CallInProgressErrorVapifaultTalkscriberTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-tavus-video-failed")]
        CallInProgressErrorVapifaultTavusVideoFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-together-ai-401-unauthorized")]
        CallInProgressErrorVapifaultTogetherAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-together-ai-403-model-access-denied")]
        CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-together-ai-429-exceeded-quota")]
        CallInProgressErrorVapifaultTogetherAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-transport-connected-but-call-not-active")]
        CallInProgressErrorVapifaultTransportConnectedButCallNotActive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-transport-never-connected")]
        CallInProgressErrorVapifaultTransportNeverConnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-vapi-401-unauthorized")]
        CallInProgressErrorVapifaultVapi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-vapi-403-model-access-denied")]
        CallInProgressErrorVapifaultVapi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-vapi-429-exceeded-quota")]
        CallInProgressErrorVapifaultVapi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-vapi-voice-failed")]
        CallInProgressErrorVapifaultVapiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-wellsaid-voice-failed")]
        CallInProgressErrorVapifaultWellsaidVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-worker-died")]
        CallInProgressErrorVapifaultWorkerDied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-worker-not-available")]
        CallInProgressErrorVapifaultWorkerNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-xai-400-bad-request-validation-failed")]
        CallInProgressErrorVapifaultXai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-xai-401-unauthorized")]
        CallInProgressErrorVapifaultXai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-xai-403-model-access-denied")]
        CallInProgressErrorVapifaultXai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-vapifault-xai-429-exceeded-quota")]
        CallInProgressErrorVapifaultXai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-warm-transfer-assistant-cancelled")]
        CallInProgressErrorWarmTransferAssistantCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-warm-transfer-max-duration")]
        CallInProgressErrorWarmTransferMaxDuration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-warm-transfer-microphone-timeout")]
        CallInProgressErrorWarmTransferMicrophoneTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.error-warm-transfer-silence-timeout")]
        CallInProgressErrorWarmTransferSilenceTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.sip-completed-call")]
        CallInProgressSipCompletedCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.in-progress.twilio-completed-call")]
        CallInProgressTwilioCompletedCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ringing.error-sip-inbound-call-failed-to-connect")]
        CallRingingErrorSipInboundCallFailedToConnect,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ringing.hook-executed-say")]
        CallRingingHookExecutedSay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ringing.hook-executed-transfer")]
        CallRingingHookExecutedTransfer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ringing.sip-inbound-caller-hungup-before-call-connect")]
        CallRingingSipInboundCallerHungupBeforeCallConnect,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-enterprise-feature-not-available-recording-consent")]
        CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-fraud-check-failed")]
        CallStartErrorFraudCheckFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-get-assistant")]
        CallStartErrorGetAssistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-get-customer")]
        CallStartErrorGetCustomer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-get-phone-number")]
        CallStartErrorGetPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-get-resources-validation")]
        CallStartErrorGetResourcesValidation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-get-transport")]
        CallStartErrorGetTransport,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-subscription-concurrency-limit-reached")]
        CallStartErrorSubscriptionConcurrencyLimitReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-subscription-frozen")]
        CallStartErrorSubscriptionFrozen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-subscription-insufficient-credits")]
        CallStartErrorSubscriptionInsufficientCredits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-subscription-upgrade-failed")]
        CallStartErrorSubscriptionUpgradeFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-subscription-wallet-does-not-exist")]
        CallStartErrorSubscriptionWalletDoesNotExist,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-vapi-number-international")]
        CallStartErrorVapiNumberInternational,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-vapi-number-outbound-daily-limit")]
        CallStartErrorVapiNumberOutboundDailyLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-vapifault-database-error")]
        CallStartErrorVapifaultDatabaseError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-vapifault-get-org")]
        CallStartErrorVapifaultGetOrg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.start.error-vapifault-get-subscription")]
        CallStartErrorVapifaultGetSubscription,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-busy")]
        CustomerBusy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-did-not-answer")]
        CustomerDidNotAnswer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-did-not-give-microphone-permission")]
        CustomerDidNotGiveMicrophonePermission,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-ended-call")]
        CustomerEndedCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-ended-call-after-warm-transfer-attempt")]
        CustomerEndedCallAfterWarmTransferAttempt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-ended-call-before-warm-transfer")]
        CustomerEndedCallBeforeWarmTransfer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customer-ended-call-during-transfer")]
        CustomerEndedCallDuringTransfer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exceeded-max-duration")]
        ExceededMaxDuration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manually-canceled")]
        ManuallyCanceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone-call-provider-bypass-enabled-but-no-call-received")]
        PhoneCallProviderBypassEnabledButNoCallReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone-call-provider-closed-websocket")]
        PhoneCallProviderClosedWebsocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-400-bad-request-validation-failed")]
        PipelineErrorAnthropic400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-401-unauthorized")]
        PipelineErrorAnthropic401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-403-model-access-denied")]
        PipelineErrorAnthropic403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-429-exceeded-quota")]
        PipelineErrorAnthropic429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-500-server-error")]
        PipelineErrorAnthropic500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-503-server-overloaded-error")]
        PipelineErrorAnthropic503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-400-bad-request-validation-failed")]
        PipelineErrorAnthropicBedrock400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-401-unauthorized")]
        PipelineErrorAnthropicBedrock401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-403-model-access-denied")]
        PipelineErrorAnthropicBedrock403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-429-exceeded-quota")]
        PipelineErrorAnthropicBedrock429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-500-server-error")]
        PipelineErrorAnthropicBedrock500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-503-server-overloaded-error")]
        PipelineErrorAnthropicBedrock503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-bedrock-llm-failed")]
        PipelineErrorAnthropicBedrockLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-llm-failed")]
        PipelineErrorAnthropicLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-400-bad-request-validation-failed")]
        PipelineErrorAnthropicVertex400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-401-unauthorized")]
        PipelineErrorAnthropicVertex401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-403-model-access-denied")]
        PipelineErrorAnthropicVertex403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-429-exceeded-quota")]
        PipelineErrorAnthropicVertex429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-500-server-error")]
        PipelineErrorAnthropicVertex500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-503-server-overloaded-error")]
        PipelineErrorAnthropicVertex503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anthropic-vertex-llm-failed")]
        PipelineErrorAnthropicVertexLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-400-bad-request-validation-failed")]
        PipelineErrorAnyscale400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-401-unauthorized")]
        PipelineErrorAnyscale401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-403-model-access-denied")]
        PipelineErrorAnyscale403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-429-exceeded-quota")]
        PipelineErrorAnyscale429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-500-server-error")]
        PipelineErrorAnyscale500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-503-server-overloaded-error")]
        PipelineErrorAnyscale503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-anyscale-llm-failed")]
        PipelineErrorAnyscaleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-assembly-ai-returning-400-insufficent-funds")]
        PipelineErrorAssemblyAiReturning400InsufficentFunds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-assembly-ai-returning-400-paid-only-feature")]
        PipelineErrorAssemblyAiReturning400PaidOnlyFeature,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-assembly-ai-returning-401-invalid-credentials")]
        PipelineErrorAssemblyAiReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-assembly-ai-returning-500-invalid-schema")]
        PipelineErrorAssemblyAiReturning500InvalidSchema,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed")]
        PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-assembly-ai-transcriber-failed")]
        PipelineErrorAssemblyAiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-400-bad-request-validation-failed")]
        PipelineErrorAzureOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-401-unauthorized")]
        PipelineErrorAzureOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-403-model-access-denied")]
        PipelineErrorAzureOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-429-exceeded-quota")]
        PipelineErrorAzureOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-500-server-error")]
        PipelineErrorAzureOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-503-server-overloaded-error")]
        PipelineErrorAzureOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-openai-llm-failed")]
        PipelineErrorAzureOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-speech-transcriber-failed")]
        PipelineErrorAzureSpeechTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-azure-voice-failed")]
        PipelineErrorAzureVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-400-bad-request-validation-failed")]
        PipelineErrorBaseten400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-401-unauthorized")]
        PipelineErrorBaseten401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-403-model-access-denied")]
        PipelineErrorBaseten403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-429-exceeded-quota")]
        PipelineErrorBaseten429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-500-server-error")]
        PipelineErrorBaseten500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-503-server-overloaded-error")]
        PipelineErrorBaseten503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-baseten-llm-failed")]
        PipelineErrorBasetenLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-500-server-error")]
        PipelineErrorCartesia500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-502-server-error")]
        PipelineErrorCartesia502ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-503-server-error")]
        PipelineErrorCartesia503ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-522-server-error")]
        PipelineErrorCartesia522ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-requested-payment")]
        PipelineErrorCartesiaRequestedPayment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-socket-hang-up")]
        PipelineErrorCartesiaSocketHangUp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cartesia-voice-failed")]
        PipelineErrorCartesiaVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-400-bad-request-validation-failed")]
        PipelineErrorCerebras400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-401-unauthorized")]
        PipelineErrorCerebras401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-403-model-access-denied")]
        PipelineErrorCerebras403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-429-exceeded-quota")]
        PipelineErrorCerebras429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-500-server-error")]
        PipelineErrorCerebras500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-503-server-overloaded-error")]
        PipelineErrorCerebras503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-cerebras-llm-failed")]
        PipelineErrorCerebrasLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-400-bad-request-validation-failed")]
        PipelineErrorCustomLlm400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-401-unauthorized")]
        PipelineErrorCustomLlm401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-403-model-access-denied")]
        PipelineErrorCustomLlm403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-429-exceeded-quota")]
        PipelineErrorCustomLlm429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-500-server-error")]
        PipelineErrorCustomLlm500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-503-server-overloaded-error")]
        PipelineErrorCustomLlm503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-llm-llm-failed")]
        PipelineErrorCustomLlmLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-transcriber-failed")]
        PipelineErrorCustomTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-custom-voice-failed")]
        PipelineErrorCustomVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-400-bad-request-validation-failed")]
        PipelineErrorDeepSeek400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-401-unauthorized")]
        PipelineErrorDeepSeek401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-403-model-access-denied")]
        PipelineErrorDeepSeek403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-429-exceeded-quota")]
        PipelineErrorDeepSeek429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-500-server-error")]
        PipelineErrorDeepSeek500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-503-server-overloaded-error")]
        PipelineErrorDeepSeek503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deep-seek-llm-failed")]
        PipelineErrorDeepSeekLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination")]
        PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-401-invalid-credentials")]
        PipelineErrorDeepgramReturning401InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-403-model-access-denied")]
        PipelineErrorDeepgramReturning403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-404-not-found")]
        PipelineErrorDeepgramReturning404NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-500-invalid-json")]
        PipelineErrorDeepgramReturning500InvalidJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach")]
        PipelineErrorDeepgramReturning502BadGatewayEhostunreach,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-502-network-error")]
        PipelineErrorDeepgramReturning502NetworkError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-returning-econnreset")]
        PipelineErrorDeepgramReturningEconnreset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-transcriber-api-key-missing")]
        PipelineErrorDeepgramTranscriberApiKeyMissing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-transcriber-failed")]
        PipelineErrorDeepgramTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepgram-voice-failed")]
        PipelineErrorDeepgramVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-400-bad-request-validation-failed")]
        PipelineErrorDeepinfra400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-401-unauthorized")]
        PipelineErrorDeepinfra401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-403-model-access-denied")]
        PipelineErrorDeepinfra403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-429-exceeded-quota")]
        PipelineErrorDeepinfra429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-500-server-error")]
        PipelineErrorDeepinfra500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-503-server-overloaded-error")]
        PipelineErrorDeepinfra503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-deepinfra-llm-failed")]
        PipelineErrorDeepinfraLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-500-server-error")]
        PipelineErrorElevenLabs500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-503-server-error")]
        PipelineErrorElevenLabs503ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-blocked-account-in-probation")]
        PipelineErrorElevenLabsBlockedAccountInProbation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade")]
        PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-blocked-content-against-their-policy")]
        PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade")]
        PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade")]
        PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification")]
        PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-invalid-api-key")]
        PipelineErrorElevenLabsInvalidApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-invalid-voice-samples")]
        PipelineErrorElevenLabsInvalidVoiceSamples,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-max-character-limit-exceeded")]
        PipelineErrorElevenLabsMaxCharacterLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-missing-samples-for-voice-clone")]
        PipelineErrorElevenLabsMissingSamplesForVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-professional-voices-only-for-creator-plus")]
        PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-quota-exceeded")]
        PipelineErrorElevenLabsQuotaExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-system-busy-and-requested-upgrade")]
        PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-transcriber-failed")]
        PipelineErrorElevenLabsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-unauthorized-access")]
        PipelineErrorElevenLabsUnauthorizedAccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-unauthorized-to-access-model")]
        PipelineErrorElevenLabsUnauthorizedToAccessModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-vapi-voice-disabled-by-owner")]
        PipelineErrorElevenLabsVapiVoiceDisabledByOwner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-voice-disabled-by-owner")]
        PipelineErrorElevenLabsVoiceDisabledByOwner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-voice-failed")]
        PipelineErrorElevenLabsVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-voice-not-allowed-for-free-users")]
        PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-voice-not-fine-tuned")]
        PipelineErrorElevenLabsVoiceNotFineTuned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used")]
        PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-eleven-labs-voice-not-found")]
        PipelineErrorElevenLabsVoiceNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-gladia-transcriber-failed")]
        PipelineErrorGladiaTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-400-bad-request-validation-failed")]
        PipelineErrorGoogle400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-401-unauthorized")]
        PipelineErrorGoogle401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-403-model-access-denied")]
        PipelineErrorGoogle403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-429-exceeded-quota")]
        PipelineErrorGoogle429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-500-server-error")]
        PipelineErrorGoogle500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-503-server-overloaded-error")]
        PipelineErrorGoogle503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-llm-failed")]
        PipelineErrorGoogleLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-google-transcriber-failed")]
        PipelineErrorGoogleTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-400-bad-request-validation-failed")]
        PipelineErrorGroq400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-401-unauthorized")]
        PipelineErrorGroq401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-403-model-access-denied")]
        PipelineErrorGroq403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-429-exceeded-quota")]
        PipelineErrorGroq429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-500-server-error")]
        PipelineErrorGroq500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-503-server-overloaded-error")]
        PipelineErrorGroq503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-groq-llm-failed")]
        PipelineErrorGroqLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-hume-voice-failed")]
        PipelineErrorHumeVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-400-bad-request-validation-failed")]
        PipelineErrorInflectionAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-401-unauthorized")]
        PipelineErrorInflectionAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-403-model-access-denied")]
        PipelineErrorInflectionAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-429-exceeded-quota")]
        PipelineErrorInflectionAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-500-server-error")]
        PipelineErrorInflectionAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-503-server-overloaded-error")]
        PipelineErrorInflectionAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inflection-ai-llm-failed")]
        PipelineErrorInflectionAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-inworld-voice-failed")]
        PipelineErrorInworldVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-lmnt-voice-failed")]
        PipelineErrorLmntVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-minimax-voice-failed")]
        PipelineErrorMinimaxVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-400-bad-request-validation-failed")]
        PipelineErrorMistral400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-401-unauthorized")]
        PipelineErrorMistral401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-403-model-access-denied")]
        PipelineErrorMistral403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-429-exceeded-quota")]
        PipelineErrorMistral429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-500-server-error")]
        PipelineErrorMistral500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-503-server-overloaded-error")]
        PipelineErrorMistral503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-mistral-llm-failed")]
        PipelineErrorMistralLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-neuphonic-voice-failed")]
        PipelineErrorNeuphonicVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-400-bad-request-validation-failed")]
        PipelineErrorOpenai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-401-account-not-in-organization")]
        PipelineErrorOpenai401AccountNotInOrganization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-401-incorrect-api-key")]
        PipelineErrorOpenai401IncorrectApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-401-unauthorized")]
        PipelineErrorOpenai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-403-model-access-denied")]
        PipelineErrorOpenai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-429-exceeded-quota")]
        PipelineErrorOpenai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-429-rate-limit-reached")]
        PipelineErrorOpenai429RateLimitReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-500-server-error")]
        PipelineErrorOpenai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-503-server-overloaded-error")]
        PipelineErrorOpenai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-llm-failed")]
        PipelineErrorOpenaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-transcriber-failed")]
        PipelineErrorOpenaiTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openai-voice-failed")]
        PipelineErrorOpenaiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-400-bad-request-validation-failed")]
        PipelineErrorOpenrouter400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-401-unauthorized")]
        PipelineErrorOpenrouter401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-403-model-access-denied")]
        PipelineErrorOpenrouter403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-429-exceeded-quota")]
        PipelineErrorOpenrouter429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-500-server-error")]
        PipelineErrorOpenrouter500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-503-server-overloaded-error")]
        PipelineErrorOpenrouter503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-openrouter-llm-failed")]
        PipelineErrorOpenrouterLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-400-bad-request-validation-failed")]
        PipelineErrorPerplexityAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-401-unauthorized")]
        PipelineErrorPerplexityAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-403-model-access-denied")]
        PipelineErrorPerplexityAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-429-exceeded-quota")]
        PipelineErrorPerplexityAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-500-server-error")]
        PipelineErrorPerplexityAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-503-server-overloaded-error")]
        PipelineErrorPerplexityAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-perplexity-ai-llm-failed")]
        PipelineErrorPerplexityAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-401-unauthorized")]
        PipelineErrorPlayht401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-403-forbidden-api-access-not-available")]
        PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-403-forbidden-out-of-characters")]
        PipelineErrorPlayht403ForbiddenOutOfCharacters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-429-exceeded-quota")]
        PipelineErrorPlayht429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-502-gateway-error")]
        PipelineErrorPlayht502GatewayError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-504-gateway-error")]
        PipelineErrorPlayht504GatewayError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-invalid-emotion")]
        PipelineErrorPlayhtInvalidEmotion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-invalid-voice")]
        PipelineErrorPlayhtInvalidVoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-out-of-credits")]
        PipelineErrorPlayhtOutOfCredits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-request-timed-out")]
        PipelineErrorPlayhtRequestTimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-unexpected-error")]
        PipelineErrorPlayhtUnexpectedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-voice-failed")]
        PipelineErrorPlayhtVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri")]
        PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-rime-ai-voice-failed")]
        PipelineErrorRimeAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-400-bad-request-validation-failed")]
        PipelineErrorRunpod400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-401-unauthorized")]
        PipelineErrorRunpod401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-403-model-access-denied")]
        PipelineErrorRunpod403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-429-exceeded-quota")]
        PipelineErrorRunpod429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-500-server-error")]
        PipelineErrorRunpod500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-503-server-overloaded-error")]
        PipelineErrorRunpod503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-runpod-llm-failed")]
        PipelineErrorRunpodLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-sesame-voice-failed")]
        PipelineErrorSesameVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-smallest-ai-voice-failed")]
        PipelineErrorSmallestAiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-soniox-transcriber-auth-failed")]
        PipelineErrorSonioxTranscriberAuthFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-soniox-transcriber-failed")]
        PipelineErrorSonioxTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-soniox-transcriber-invalid-config")]
        PipelineErrorSonioxTranscriberInvalidConfig,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-soniox-transcriber-rate-limited")]
        PipelineErrorSonioxTranscriberRateLimited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-soniox-transcriber-server-error")]
        PipelineErrorSonioxTranscriberServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-speechmatics-transcriber-failed")]
        PipelineErrorSpeechmaticsTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-talkscriber-transcriber-failed")]
        PipelineErrorTalkscriberTranscriberFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-tavus-video-failed")]
        PipelineErrorTavusVideoFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-400-bad-request-validation-failed")]
        PipelineErrorTogetherAi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-401-unauthorized")]
        PipelineErrorTogetherAi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-403-model-access-denied")]
        PipelineErrorTogetherAi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-429-exceeded-quota")]
        PipelineErrorTogetherAi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-500-server-error")]
        PipelineErrorTogetherAi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-503-server-overloaded-error")]
        PipelineErrorTogetherAi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-together-ai-llm-failed")]
        PipelineErrorTogetherAiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-400-bad-request-validation-failed")]
        PipelineErrorVapi400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-401-unauthorized")]
        PipelineErrorVapi401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-403-model-access-denied")]
        PipelineErrorVapi403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-429-exceeded-quota")]
        PipelineErrorVapi429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-500-server-error")]
        PipelineErrorVapi500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-503-server-overloaded-error")]
        PipelineErrorVapi503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-llm-failed")]
        PipelineErrorVapiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-vapi-voice-failed")]
        PipelineErrorVapiVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-wellsaid-voice-failed")]
        PipelineErrorWellsaidVoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-400-bad-request-validation-failed")]
        PipelineErrorXai400BadRequestValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-401-unauthorized")]
        PipelineErrorXai401Unauthorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-403-model-access-denied")]
        PipelineErrorXai403ModelAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-429-exceeded-quota")]
        PipelineErrorXai429ExceededQuota,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-500-server-error")]
        PipelineErrorXai500ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-503-server-overloaded-error")]
        PipelineErrorXai503ServerOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline-error-xai-llm-failed")]
        PipelineErrorXaiLlmFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scheduled-call-deleted")]
        ScheduledCallDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="silence-timed-out")]
        SilenceTimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio-failed-to-connect-call")]
        TwilioFailedToConnectCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio-reported-customer-misdialed")]
        TwilioReportedCustomerMisdialed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail")]
        Voicemail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage-completed")]
        VonageCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage-disconnected")]
        VonageDisconnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage-failed-to-connect-call")]
        VonageFailedToConnectCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage-rejected")]
        VonageRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="worker-shutdown")]
        WorkerShutdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallEndedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallEndedReason value)
        {
            return value switch
            {
                CallEndedReason.AssistantEndedCall => "assistant-ended-call",
                CallEndedReason.AssistantEndedCallAfterMessageSpoken => "assistant-ended-call-after-message-spoken",
                CallEndedReason.AssistantEndedCallWithHangupTask => "assistant-ended-call-with-hangup-task",
                CallEndedReason.AssistantForwardedCall => "assistant-forwarded-call",
                CallEndedReason.AssistantJoinTimedOut => "assistant-join-timed-out",
                CallEndedReason.AssistantNotFound => "assistant-not-found",
                CallEndedReason.AssistantNotValid => "assistant-not-valid",
                CallEndedReason.AssistantRequestFailed => "assistant-request-failed",
                CallEndedReason.AssistantRequestReturnedError => "assistant-request-returned-error",
                CallEndedReason.AssistantRequestReturnedForwardingPhoneNumber => "assistant-request-returned-forwarding-phone-number",
                CallEndedReason.AssistantRequestReturnedInvalidAssistant => "assistant-request-returned-invalid-assistant",
                CallEndedReason.AssistantRequestReturnedNoAssistant => "assistant-request-returned-no-assistant",
                CallEndedReason.AssistantRequestReturnedUnspeakableError => "assistant-request-returned-unspeakable-error",
                CallEndedReason.AssistantSaidEndCallPhrase => "assistant-said-end-call-phrase",
                CallEndedReason.CallDeleted => "call-deleted",
                CallEndedReason.CallStartErrorNeitherAssistantNorServerSet => "call-start-error-neither-assistant-nor-server-set",
                CallEndedReason.CallEndingHookExecutedSay => "call.ending.hook-executed-say",
                CallEndedReason.CallEndingHookExecutedTransfer => "call.ending.hook-executed-transfer",
                CallEndedReason.CallForwardingOperatorBusy => "call.forwarding.operator-busy",
                CallEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio => "call.in-progress.error-assistant-did-not-receive-customer-audio",
                CallEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel => "call.in-progress.error-pipeline-no-available-llm-model",
                CallEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed => "call.in-progress.error-pipeline-ws-model-connection-failed",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError => "call.in-progress.error-providerfault-anthropic-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError => "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed => "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed => "call.in-progress.error-providerfault-anthropic-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError => "call.in-progress.error-providerfault-anthropic-vertex-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError => "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed => "call.in-progress.error-providerfault-anthropic-vertex-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError => "call.in-progress.error-providerfault-anyscale-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError => "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed => "call.in-progress.error-providerfault-anyscale-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError => "call.in-progress.error-providerfault-azure-openai-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError => "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed => "call.in-progress.error-providerfault-azure-openai-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError => "call.in-progress.error-providerfault-baseten-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError => "call.in-progress.error-providerfault-baseten-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed => "call.in-progress.error-providerfault-baseten-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError => "call.in-progress.error-providerfault-cartesia-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError => "call.in-progress.error-providerfault-cartesia-503-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError => "call.in-progress.error-providerfault-cartesia-522-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError => "call.in-progress.error-providerfault-cerebras-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError => "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed => "call.in-progress.error-providerfault-cerebras-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError => "call.in-progress.error-providerfault-custom-llm-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError => "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed => "call.in-progress.error-providerfault-custom-llm-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError => "call.in-progress.error-providerfault-deep-seek-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError => "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed => "call.in-progress.error-providerfault-deep-seek-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson => "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json",
                CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach => "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach",
                CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError => "call.in-progress.error-providerfault-deepgram-returning-502-network-error",
                CallEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError => "call.in-progress.error-providerfault-deepinfra-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError => "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed => "call.in-progress.error-providerfault-deepinfra-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError => "call.in-progress.error-providerfault-eleven-labs-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError => "call.in-progress.error-providerfault-eleven-labs-503-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade => "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade",
                CallEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError => "call.in-progress.error-providerfault-google-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError => "call.in-progress.error-providerfault-google-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed => "call.in-progress.error-providerfault-google-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultGroq500ServerError => "call.in-progress.error-providerfault-groq-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError => "call.in-progress.error-providerfault-groq-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed => "call.in-progress.error-providerfault-groq-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError => "call.in-progress.error-providerfault-inflection-ai-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError => "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed => "call.in-progress.error-providerfault-inflection-ai-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultMistral500ServerError => "call.in-progress.error-providerfault-mistral-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError => "call.in-progress.error-providerfault-mistral-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed => "call.in-progress.error-providerfault-mistral-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError => "call.in-progress.error-providerfault-openai-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError => "call.in-progress.error-providerfault-openai-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed => "call.in-progress.error-providerfault-openai-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError => "call.in-progress.error-providerfault-openrouter-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError => "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed => "call.in-progress.error-providerfault-openrouter-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden => "call.in-progress.error-providerfault-outbound-sip-403-forbidden",
                CallEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired => "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required",
                CallEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout => "call.in-progress.error-providerfault-outbound-sip-408-request-timeout",
                CallEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable => "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable",
                CallEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable => "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable",
                CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError => "call.in-progress.error-providerfault-perplexity-ai-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError => "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed => "call.in-progress.error-providerfault-perplexity-ai-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError => "call.in-progress.error-providerfault-playht-502-gateway-error",
                CallEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError => "call.in-progress.error-providerfault-playht-504-gateway-error",
                CallEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError => "call.in-progress.error-providerfault-runpod-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError => "call.in-progress.error-providerfault-runpod-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed => "call.in-progress.error-providerfault-runpod-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError => "call.in-progress.error-providerfault-together-ai-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError => "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed => "call.in-progress.error-providerfault-together-ai-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected => "call.in-progress.error-providerfault-transport-never-connected",
                CallEndedReason.CallInProgressErrorProviderfaultVapi500ServerError => "call.in-progress.error-providerfault-vapi-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError => "call.in-progress.error-providerfault-vapi-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed => "call.in-progress.error-providerfault-vapi-llm-failed",
                CallEndedReason.CallInProgressErrorProviderfaultXai500ServerError => "call.in-progress.error-providerfault-xai-500-server-error",
                CallEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError => "call.in-progress.error-providerfault-xai-503-server-overloaded-error",
                CallEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed => "call.in-progress.error-providerfault-xai-llm-failed",
                CallEndedReason.CallInProgressErrorSipInboundCallFailedToConnect => "call.in-progress.error-sip-inbound-call-failed-to-connect",
                CallEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect => "call.in-progress.error-sip-outbound-call-failed-to-connect",
                CallEndedReason.CallInProgressErrorTransferFailed => "call.in-progress.error-transfer-failed",
                CallEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized => "call.in-progress.error-vapifault-anthropic-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota => "call.in-progress.error-vapifault-anthropic-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized => "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota => "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed => "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized => "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied => "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota => "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed => "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized => "call.in-progress.error-vapifault-anyscale-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied => "call.in-progress.error-vapifault-anyscale-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota => "call.in-progress.error-vapifault-anyscale-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds => "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds",
                CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature => "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature",
                CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials => "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials",
                CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema => "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema",
                CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed => "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed",
                CallEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed => "call.in-progress.error-vapifault-assembly-ai-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed => "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized => "call.in-progress.error-vapifault-azure-openai-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied => "call.in-progress.error-vapifault-azure-openai-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota => "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed => "call.in-progress.error-vapifault-azure-speech-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed => "call.in-progress.error-vapifault-azure-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed => "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized => "call.in-progress.error-vapifault-baseten-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied => "call.in-progress.error-vapifault-baseten-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota => "call.in-progress.error-vapifault-baseten-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing => "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing",
                CallEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment => "call.in-progress.error-vapifault-cartesia-requested-payment",
                CallEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp => "call.in-progress.error-vapifault-cartesia-socket-hang-up",
                CallEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed => "call.in-progress.error-vapifault-cartesia-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed => "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized => "call.in-progress.error-vapifault-cerebras-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied => "call.in-progress.error-vapifault-cerebras-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota => "call.in-progress.error-vapifault-cerebras-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart => "call.in-progress.error-vapifault-chat-pipeline-failed-to-start",
                CallEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed => "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized => "call.in-progress.error-vapifault-custom-llm-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied => "call.in-progress.error-vapifault-custom-llm-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota => "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed => "call.in-progress.error-vapifault-custom-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed => "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized => "call.in-progress.error-vapifault-deep-seek-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied => "call.in-progress.error-vapifault-deep-seek-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota => "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination => "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination",
                CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials => "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials",
                CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied => "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound => "call.in-progress.error-vapifault-deepgram-returning-404-not-found",
                CallEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed => "call.in-progress.error-vapifault-deepgram-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed => "call.in-progress.error-vapifault-deepgram-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed => "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized => "call.in-progress.error-vapifault-deepinfra-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied => "call.in-progress.error-vapifault-deepinfra-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota => "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation => "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy => "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification => "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey => "call.in-progress.error-vapifault-eleven-labs-invalid-api-key",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples => "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded => "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone => "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus => "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded => "call.in-progress.error-vapifault-eleven-labs-quota-exceeded",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade => "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed => "call.in-progress.error-vapifault-eleven-labs-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess => "call.in-progress.error-vapifault-eleven-labs-unauthorized-access",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel => "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner => "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed => "call.in-progress.error-vapifault-eleven-labs-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers => "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned => "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed => "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
                CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound => "call.in-progress.error-vapifault-eleven-labs-voice-not-found",
                CallEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed => "call.in-progress.error-vapifault-gladia-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed => "call.in-progress.error-vapifault-google-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized => "call.in-progress.error-vapifault-google-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied => "call.in-progress.error-vapifault-google-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota => "call.in-progress.error-vapifault-google-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed => "call.in-progress.error-vapifault-google-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed => "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized => "call.in-progress.error-vapifault-groq-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied => "call.in-progress.error-vapifault-groq-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota => "call.in-progress.error-vapifault-groq-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed => "call.in-progress.error-vapifault-hume-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized => "call.in-progress.error-vapifault-inflection-ai-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied => "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota => "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed => "call.in-progress.error-vapifault-inworld-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed => "call.in-progress.error-vapifault-lmnt-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed => "call.in-progress.error-vapifault-minimax-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed => "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized => "call.in-progress.error-vapifault-mistral-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied => "call.in-progress.error-vapifault-mistral-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota => "call.in-progress.error-vapifault-mistral-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed => "call.in-progress.error-vapifault-neuphonic-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed => "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization => "call.in-progress.error-vapifault-openai-401-account-not-in-organization",
                CallEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey => "call.in-progress.error-vapifault-openai-401-incorrect-api-key",
                CallEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized => "call.in-progress.error-vapifault-openai-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied => "call.in-progress.error-vapifault-openai-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota => "call.in-progress.error-vapifault-openai-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached => "call.in-progress.error-vapifault-openai-429-rate-limit-reached",
                CallEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed => "call.in-progress.error-vapifault-openai-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed => "call.in-progress.error-vapifault-openai-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed => "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized => "call.in-progress.error-vapifault-openrouter-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied => "call.in-progress.error-vapifault-openrouter-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota => "call.in-progress.error-vapifault-openrouter-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized => "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied => "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota => "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized => "call.in-progress.error-vapifault-playht-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable => "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available",
                CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters => "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters",
                CallEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota => "call.in-progress.error-vapifault-playht-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion => "call.in-progress.error-vapifault-playht-invalid-emotion",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice => "call.in-progress.error-vapifault-playht-invalid-voice",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits => "call.in-progress.error-vapifault-playht-out-of-credits",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut => "call.in-progress.error-vapifault-playht-request-timed-out",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError => "call.in-progress.error-vapifault-playht-unexpected-error",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed => "call.in-progress.error-vapifault-playht-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri => "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri",
                CallEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed => "call.in-progress.error-vapifault-rime-ai-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed => "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized => "call.in-progress.error-vapifault-runpod-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied => "call.in-progress.error-vapifault-runpod-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota => "call.in-progress.error-vapifault-runpod-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed => "call.in-progress.error-vapifault-sesame-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed => "call.in-progress.error-vapifault-smallest-ai-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed => "call.in-progress.error-vapifault-soniox-transcriber-auth-failed",
                CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed => "call.in-progress.error-vapifault-soniox-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig => "call.in-progress.error-vapifault-soniox-transcriber-invalid-config",
                CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited => "call.in-progress.error-vapifault-soniox-transcriber-rate-limited",
                CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError => "call.in-progress.error-vapifault-soniox-transcriber-server-error",
                CallEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed => "call.in-progress.error-vapifault-speechmatics-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed => "call.in-progress.error-vapifault-talkscriber-transcriber-failed",
                CallEndedReason.CallInProgressErrorVapifaultTavusVideoFailed => "call.in-progress.error-vapifault-tavus-video-failed",
                CallEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed => "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized => "call.in-progress.error-vapifault-together-ai-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied => "call.in-progress.error-vapifault-together-ai-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota => "call.in-progress.error-vapifault-together-ai-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive => "call.in-progress.error-vapifault-transport-connected-but-call-not-active",
                CallEndedReason.CallInProgressErrorVapifaultTransportNeverConnected => "call.in-progress.error-vapifault-transport-never-connected",
                CallEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed => "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized => "call.in-progress.error-vapifault-vapi-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied => "call.in-progress.error-vapifault-vapi-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota => "call.in-progress.error-vapifault-vapi-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed => "call.in-progress.error-vapifault-vapi-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed => "call.in-progress.error-vapifault-wellsaid-voice-failed",
                CallEndedReason.CallInProgressErrorVapifaultWorkerDied => "call.in-progress.error-vapifault-worker-died",
                CallEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable => "call.in-progress.error-vapifault-worker-not-available",
                CallEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed => "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed",
                CallEndedReason.CallInProgressErrorVapifaultXai401Unauthorized => "call.in-progress.error-vapifault-xai-401-unauthorized",
                CallEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied => "call.in-progress.error-vapifault-xai-403-model-access-denied",
                CallEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota => "call.in-progress.error-vapifault-xai-429-exceeded-quota",
                CallEndedReason.CallInProgressErrorWarmTransferAssistantCancelled => "call.in-progress.error-warm-transfer-assistant-cancelled",
                CallEndedReason.CallInProgressErrorWarmTransferMaxDuration => "call.in-progress.error-warm-transfer-max-duration",
                CallEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout => "call.in-progress.error-warm-transfer-microphone-timeout",
                CallEndedReason.CallInProgressErrorWarmTransferSilenceTimeout => "call.in-progress.error-warm-transfer-silence-timeout",
                CallEndedReason.CallInProgressSipCompletedCall => "call.in-progress.sip-completed-call",
                CallEndedReason.CallInProgressTwilioCompletedCall => "call.in-progress.twilio-completed-call",
                CallEndedReason.CallRingingErrorSipInboundCallFailedToConnect => "call.ringing.error-sip-inbound-call-failed-to-connect",
                CallEndedReason.CallRingingHookExecutedSay => "call.ringing.hook-executed-say",
                CallEndedReason.CallRingingHookExecutedTransfer => "call.ringing.hook-executed-transfer",
                CallEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect => "call.ringing.sip-inbound-caller-hungup-before-call-connect",
                CallEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent => "call.start.error-enterprise-feature-not-available-recording-consent",
                CallEndedReason.CallStartErrorFraudCheckFailed => "call.start.error-fraud-check-failed",
                CallEndedReason.CallStartErrorGetAssistant => "call.start.error-get-assistant",
                CallEndedReason.CallStartErrorGetCustomer => "call.start.error-get-customer",
                CallEndedReason.CallStartErrorGetPhoneNumber => "call.start.error-get-phone-number",
                CallEndedReason.CallStartErrorGetResourcesValidation => "call.start.error-get-resources-validation",
                CallEndedReason.CallStartErrorGetTransport => "call.start.error-get-transport",
                CallEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached => "call.start.error-subscription-concurrency-limit-reached",
                CallEndedReason.CallStartErrorSubscriptionFrozen => "call.start.error-subscription-frozen",
                CallEndedReason.CallStartErrorSubscriptionInsufficientCredits => "call.start.error-subscription-insufficient-credits",
                CallEndedReason.CallStartErrorSubscriptionUpgradeFailed => "call.start.error-subscription-upgrade-failed",
                CallEndedReason.CallStartErrorSubscriptionWalletDoesNotExist => "call.start.error-subscription-wallet-does-not-exist",
                CallEndedReason.CallStartErrorVapiNumberInternational => "call.start.error-vapi-number-international",
                CallEndedReason.CallStartErrorVapiNumberOutboundDailyLimit => "call.start.error-vapi-number-outbound-daily-limit",
                CallEndedReason.CallStartErrorVapifaultDatabaseError => "call.start.error-vapifault-database-error",
                CallEndedReason.CallStartErrorVapifaultGetOrg => "call.start.error-vapifault-get-org",
                CallEndedReason.CallStartErrorVapifaultGetSubscription => "call.start.error-vapifault-get-subscription",
                CallEndedReason.CustomerBusy => "customer-busy",
                CallEndedReason.CustomerDidNotAnswer => "customer-did-not-answer",
                CallEndedReason.CustomerDidNotGiveMicrophonePermission => "customer-did-not-give-microphone-permission",
                CallEndedReason.CustomerEndedCall => "customer-ended-call",
                CallEndedReason.CustomerEndedCallAfterWarmTransferAttempt => "customer-ended-call-after-warm-transfer-attempt",
                CallEndedReason.CustomerEndedCallBeforeWarmTransfer => "customer-ended-call-before-warm-transfer",
                CallEndedReason.CustomerEndedCallDuringTransfer => "customer-ended-call-during-transfer",
                CallEndedReason.ExceededMaxDuration => "exceeded-max-duration",
                CallEndedReason.ManuallyCanceled => "manually-canceled",
                CallEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived => "phone-call-provider-bypass-enabled-but-no-call-received",
                CallEndedReason.PhoneCallProviderClosedWebsocket => "phone-call-provider-closed-websocket",
                CallEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed => "pipeline-error-anthropic-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorAnthropic401Unauthorized => "pipeline-error-anthropic-401-unauthorized",
                CallEndedReason.PipelineErrorAnthropic403ModelAccessDenied => "pipeline-error-anthropic-403-model-access-denied",
                CallEndedReason.PipelineErrorAnthropic429ExceededQuota => "pipeline-error-anthropic-429-exceeded-quota",
                CallEndedReason.PipelineErrorAnthropic500ServerError => "pipeline-error-anthropic-500-server-error",
                CallEndedReason.PipelineErrorAnthropic503ServerOverloadedError => "pipeline-error-anthropic-503-server-overloaded-error",
                CallEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed => "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorAnthropicBedrock401Unauthorized => "pipeline-error-anthropic-bedrock-401-unauthorized",
                CallEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied => "pipeline-error-anthropic-bedrock-403-model-access-denied",
                CallEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota => "pipeline-error-anthropic-bedrock-429-exceeded-quota",
                CallEndedReason.PipelineErrorAnthropicBedrock500ServerError => "pipeline-error-anthropic-bedrock-500-server-error",
                CallEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError => "pipeline-error-anthropic-bedrock-503-server-overloaded-error",
                CallEndedReason.PipelineErrorAnthropicBedrockLlmFailed => "pipeline-error-anthropic-bedrock-llm-failed",
                CallEndedReason.PipelineErrorAnthropicLlmFailed => "pipeline-error-anthropic-llm-failed",
                CallEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed => "pipeline-error-anthropic-vertex-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorAnthropicVertex401Unauthorized => "pipeline-error-anthropic-vertex-401-unauthorized",
                CallEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied => "pipeline-error-anthropic-vertex-403-model-access-denied",
                CallEndedReason.PipelineErrorAnthropicVertex429ExceededQuota => "pipeline-error-anthropic-vertex-429-exceeded-quota",
                CallEndedReason.PipelineErrorAnthropicVertex500ServerError => "pipeline-error-anthropic-vertex-500-server-error",
                CallEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError => "pipeline-error-anthropic-vertex-503-server-overloaded-error",
                CallEndedReason.PipelineErrorAnthropicVertexLlmFailed => "pipeline-error-anthropic-vertex-llm-failed",
                CallEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed => "pipeline-error-anyscale-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorAnyscale401Unauthorized => "pipeline-error-anyscale-401-unauthorized",
                CallEndedReason.PipelineErrorAnyscale403ModelAccessDenied => "pipeline-error-anyscale-403-model-access-denied",
                CallEndedReason.PipelineErrorAnyscale429ExceededQuota => "pipeline-error-anyscale-429-exceeded-quota",
                CallEndedReason.PipelineErrorAnyscale500ServerError => "pipeline-error-anyscale-500-server-error",
                CallEndedReason.PipelineErrorAnyscale503ServerOverloadedError => "pipeline-error-anyscale-503-server-overloaded-error",
                CallEndedReason.PipelineErrorAnyscaleLlmFailed => "pipeline-error-anyscale-llm-failed",
                CallEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds => "pipeline-error-assembly-ai-returning-400-insufficent-funds",
                CallEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature => "pipeline-error-assembly-ai-returning-400-paid-only-feature",
                CallEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials => "pipeline-error-assembly-ai-returning-401-invalid-credentials",
                CallEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema => "pipeline-error-assembly-ai-returning-500-invalid-schema",
                CallEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed => "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed",
                CallEndedReason.PipelineErrorAssemblyAiTranscriberFailed => "pipeline-error-assembly-ai-transcriber-failed",
                CallEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed => "pipeline-error-azure-openai-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorAzureOpenai401Unauthorized => "pipeline-error-azure-openai-401-unauthorized",
                CallEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied => "pipeline-error-azure-openai-403-model-access-denied",
                CallEndedReason.PipelineErrorAzureOpenai429ExceededQuota => "pipeline-error-azure-openai-429-exceeded-quota",
                CallEndedReason.PipelineErrorAzureOpenai500ServerError => "pipeline-error-azure-openai-500-server-error",
                CallEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError => "pipeline-error-azure-openai-503-server-overloaded-error",
                CallEndedReason.PipelineErrorAzureOpenaiLlmFailed => "pipeline-error-azure-openai-llm-failed",
                CallEndedReason.PipelineErrorAzureSpeechTranscriberFailed => "pipeline-error-azure-speech-transcriber-failed",
                CallEndedReason.PipelineErrorAzureVoiceFailed => "pipeline-error-azure-voice-failed",
                CallEndedReason.PipelineErrorBaseten400BadRequestValidationFailed => "pipeline-error-baseten-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorBaseten401Unauthorized => "pipeline-error-baseten-401-unauthorized",
                CallEndedReason.PipelineErrorBaseten403ModelAccessDenied => "pipeline-error-baseten-403-model-access-denied",
                CallEndedReason.PipelineErrorBaseten429ExceededQuota => "pipeline-error-baseten-429-exceeded-quota",
                CallEndedReason.PipelineErrorBaseten500ServerError => "pipeline-error-baseten-500-server-error",
                CallEndedReason.PipelineErrorBaseten503ServerOverloadedError => "pipeline-error-baseten-503-server-overloaded-error",
                CallEndedReason.PipelineErrorBasetenLlmFailed => "pipeline-error-baseten-llm-failed",
                CallEndedReason.PipelineErrorCartesia500ServerError => "pipeline-error-cartesia-500-server-error",
                CallEndedReason.PipelineErrorCartesia502ServerError => "pipeline-error-cartesia-502-server-error",
                CallEndedReason.PipelineErrorCartesia503ServerError => "pipeline-error-cartesia-503-server-error",
                CallEndedReason.PipelineErrorCartesia522ServerError => "pipeline-error-cartesia-522-server-error",
                CallEndedReason.PipelineErrorCartesiaRequestedPayment => "pipeline-error-cartesia-requested-payment",
                CallEndedReason.PipelineErrorCartesiaSocketHangUp => "pipeline-error-cartesia-socket-hang-up",
                CallEndedReason.PipelineErrorCartesiaVoiceFailed => "pipeline-error-cartesia-voice-failed",
                CallEndedReason.PipelineErrorCerebras400BadRequestValidationFailed => "pipeline-error-cerebras-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorCerebras401Unauthorized => "pipeline-error-cerebras-401-unauthorized",
                CallEndedReason.PipelineErrorCerebras403ModelAccessDenied => "pipeline-error-cerebras-403-model-access-denied",
                CallEndedReason.PipelineErrorCerebras429ExceededQuota => "pipeline-error-cerebras-429-exceeded-quota",
                CallEndedReason.PipelineErrorCerebras500ServerError => "pipeline-error-cerebras-500-server-error",
                CallEndedReason.PipelineErrorCerebras503ServerOverloadedError => "pipeline-error-cerebras-503-server-overloaded-error",
                CallEndedReason.PipelineErrorCerebrasLlmFailed => "pipeline-error-cerebras-llm-failed",
                CallEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed => "pipeline-error-custom-llm-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorCustomLlm401Unauthorized => "pipeline-error-custom-llm-401-unauthorized",
                CallEndedReason.PipelineErrorCustomLlm403ModelAccessDenied => "pipeline-error-custom-llm-403-model-access-denied",
                CallEndedReason.PipelineErrorCustomLlm429ExceededQuota => "pipeline-error-custom-llm-429-exceeded-quota",
                CallEndedReason.PipelineErrorCustomLlm500ServerError => "pipeline-error-custom-llm-500-server-error",
                CallEndedReason.PipelineErrorCustomLlm503ServerOverloadedError => "pipeline-error-custom-llm-503-server-overloaded-error",
                CallEndedReason.PipelineErrorCustomLlmLlmFailed => "pipeline-error-custom-llm-llm-failed",
                CallEndedReason.PipelineErrorCustomTranscriberFailed => "pipeline-error-custom-transcriber-failed",
                CallEndedReason.PipelineErrorCustomVoiceFailed => "pipeline-error-custom-voice-failed",
                CallEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed => "pipeline-error-deep-seek-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorDeepSeek401Unauthorized => "pipeline-error-deep-seek-401-unauthorized",
                CallEndedReason.PipelineErrorDeepSeek403ModelAccessDenied => "pipeline-error-deep-seek-403-model-access-denied",
                CallEndedReason.PipelineErrorDeepSeek429ExceededQuota => "pipeline-error-deep-seek-429-exceeded-quota",
                CallEndedReason.PipelineErrorDeepSeek500ServerError => "pipeline-error-deep-seek-500-server-error",
                CallEndedReason.PipelineErrorDeepSeek503ServerOverloadedError => "pipeline-error-deep-seek-503-server-overloaded-error",
                CallEndedReason.PipelineErrorDeepSeekLlmFailed => "pipeline-error-deep-seek-llm-failed",
                CallEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination => "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination",
                CallEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials => "pipeline-error-deepgram-returning-401-invalid-credentials",
                CallEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied => "pipeline-error-deepgram-returning-403-model-access-denied",
                CallEndedReason.PipelineErrorDeepgramReturning404NotFound => "pipeline-error-deepgram-returning-404-not-found",
                CallEndedReason.PipelineErrorDeepgramReturning500InvalidJson => "pipeline-error-deepgram-returning-500-invalid-json",
                CallEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach => "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach",
                CallEndedReason.PipelineErrorDeepgramReturning502NetworkError => "pipeline-error-deepgram-returning-502-network-error",
                CallEndedReason.PipelineErrorDeepgramReturningEconnreset => "pipeline-error-deepgram-returning-econnreset",
                CallEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing => "pipeline-error-deepgram-transcriber-api-key-missing",
                CallEndedReason.PipelineErrorDeepgramTranscriberFailed => "pipeline-error-deepgram-transcriber-failed",
                CallEndedReason.PipelineErrorDeepgramVoiceFailed => "pipeline-error-deepgram-voice-failed",
                CallEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed => "pipeline-error-deepinfra-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorDeepinfra401Unauthorized => "pipeline-error-deepinfra-401-unauthorized",
                CallEndedReason.PipelineErrorDeepinfra403ModelAccessDenied => "pipeline-error-deepinfra-403-model-access-denied",
                CallEndedReason.PipelineErrorDeepinfra429ExceededQuota => "pipeline-error-deepinfra-429-exceeded-quota",
                CallEndedReason.PipelineErrorDeepinfra500ServerError => "pipeline-error-deepinfra-500-server-error",
                CallEndedReason.PipelineErrorDeepinfra503ServerOverloadedError => "pipeline-error-deepinfra-503-server-overloaded-error",
                CallEndedReason.PipelineErrorDeepinfraLlmFailed => "pipeline-error-deepinfra-llm-failed",
                CallEndedReason.PipelineErrorElevenLabs500ServerError => "pipeline-error-eleven-labs-500-server-error",
                CallEndedReason.PipelineErrorElevenLabs503ServerError => "pipeline-error-eleven-labs-503-server-error",
                CallEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation => "pipeline-error-eleven-labs-blocked-account-in-probation",
                CallEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade",
                CallEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy => "pipeline-error-eleven-labs-blocked-content-against-their-policy",
                CallEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade",
                CallEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade => "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade",
                CallEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification => "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification",
                CallEndedReason.PipelineErrorElevenLabsInvalidApiKey => "pipeline-error-eleven-labs-invalid-api-key",
                CallEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples => "pipeline-error-eleven-labs-invalid-voice-samples",
                CallEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded => "pipeline-error-eleven-labs-max-character-limit-exceeded",
                CallEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone => "pipeline-error-eleven-labs-missing-samples-for-voice-clone",
                CallEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus => "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus",
                CallEndedReason.PipelineErrorElevenLabsQuotaExceeded => "pipeline-error-eleven-labs-quota-exceeded",
                CallEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade => "pipeline-error-eleven-labs-system-busy-and-requested-upgrade",
                CallEndedReason.PipelineErrorElevenLabsTranscriberFailed => "pipeline-error-eleven-labs-transcriber-failed",
                CallEndedReason.PipelineErrorElevenLabsUnauthorizedAccess => "pipeline-error-eleven-labs-unauthorized-access",
                CallEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel => "pipeline-error-eleven-labs-unauthorized-to-access-model",
                CallEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner => "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner",
                CallEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner => "pipeline-error-eleven-labs-voice-disabled-by-owner",
                CallEndedReason.PipelineErrorElevenLabsVoiceFailed => "pipeline-error-eleven-labs-voice-failed",
                CallEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers => "pipeline-error-eleven-labs-voice-not-allowed-for-free-users",
                CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned => "pipeline-error-eleven-labs-voice-not-fine-tuned",
                CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed => "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used",
                CallEndedReason.PipelineErrorElevenLabsVoiceNotFound => "pipeline-error-eleven-labs-voice-not-found",
                CallEndedReason.PipelineErrorGladiaTranscriberFailed => "pipeline-error-gladia-transcriber-failed",
                CallEndedReason.PipelineErrorGoogle400BadRequestValidationFailed => "pipeline-error-google-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorGoogle401Unauthorized => "pipeline-error-google-401-unauthorized",
                CallEndedReason.PipelineErrorGoogle403ModelAccessDenied => "pipeline-error-google-403-model-access-denied",
                CallEndedReason.PipelineErrorGoogle429ExceededQuota => "pipeline-error-google-429-exceeded-quota",
                CallEndedReason.PipelineErrorGoogle500ServerError => "pipeline-error-google-500-server-error",
                CallEndedReason.PipelineErrorGoogle503ServerOverloadedError => "pipeline-error-google-503-server-overloaded-error",
                CallEndedReason.PipelineErrorGoogleLlmFailed => "pipeline-error-google-llm-failed",
                CallEndedReason.PipelineErrorGoogleTranscriberFailed => "pipeline-error-google-transcriber-failed",
                CallEndedReason.PipelineErrorGroq400BadRequestValidationFailed => "pipeline-error-groq-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorGroq401Unauthorized => "pipeline-error-groq-401-unauthorized",
                CallEndedReason.PipelineErrorGroq403ModelAccessDenied => "pipeline-error-groq-403-model-access-denied",
                CallEndedReason.PipelineErrorGroq429ExceededQuota => "pipeline-error-groq-429-exceeded-quota",
                CallEndedReason.PipelineErrorGroq500ServerError => "pipeline-error-groq-500-server-error",
                CallEndedReason.PipelineErrorGroq503ServerOverloadedError => "pipeline-error-groq-503-server-overloaded-error",
                CallEndedReason.PipelineErrorGroqLlmFailed => "pipeline-error-groq-llm-failed",
                CallEndedReason.PipelineErrorHumeVoiceFailed => "pipeline-error-hume-voice-failed",
                CallEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed => "pipeline-error-inflection-ai-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorInflectionAi401Unauthorized => "pipeline-error-inflection-ai-401-unauthorized",
                CallEndedReason.PipelineErrorInflectionAi403ModelAccessDenied => "pipeline-error-inflection-ai-403-model-access-denied",
                CallEndedReason.PipelineErrorInflectionAi429ExceededQuota => "pipeline-error-inflection-ai-429-exceeded-quota",
                CallEndedReason.PipelineErrorInflectionAi500ServerError => "pipeline-error-inflection-ai-500-server-error",
                CallEndedReason.PipelineErrorInflectionAi503ServerOverloadedError => "pipeline-error-inflection-ai-503-server-overloaded-error",
                CallEndedReason.PipelineErrorInflectionAiLlmFailed => "pipeline-error-inflection-ai-llm-failed",
                CallEndedReason.PipelineErrorInworldVoiceFailed => "pipeline-error-inworld-voice-failed",
                CallEndedReason.PipelineErrorLmntVoiceFailed => "pipeline-error-lmnt-voice-failed",
                CallEndedReason.PipelineErrorMinimaxVoiceFailed => "pipeline-error-minimax-voice-failed",
                CallEndedReason.PipelineErrorMistral400BadRequestValidationFailed => "pipeline-error-mistral-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorMistral401Unauthorized => "pipeline-error-mistral-401-unauthorized",
                CallEndedReason.PipelineErrorMistral403ModelAccessDenied => "pipeline-error-mistral-403-model-access-denied",
                CallEndedReason.PipelineErrorMistral429ExceededQuota => "pipeline-error-mistral-429-exceeded-quota",
                CallEndedReason.PipelineErrorMistral500ServerError => "pipeline-error-mistral-500-server-error",
                CallEndedReason.PipelineErrorMistral503ServerOverloadedError => "pipeline-error-mistral-503-server-overloaded-error",
                CallEndedReason.PipelineErrorMistralLlmFailed => "pipeline-error-mistral-llm-failed",
                CallEndedReason.PipelineErrorNeuphonicVoiceFailed => "pipeline-error-neuphonic-voice-failed",
                CallEndedReason.PipelineErrorOpenai400BadRequestValidationFailed => "pipeline-error-openai-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorOpenai401AccountNotInOrganization => "pipeline-error-openai-401-account-not-in-organization",
                CallEndedReason.PipelineErrorOpenai401IncorrectApiKey => "pipeline-error-openai-401-incorrect-api-key",
                CallEndedReason.PipelineErrorOpenai401Unauthorized => "pipeline-error-openai-401-unauthorized",
                CallEndedReason.PipelineErrorOpenai403ModelAccessDenied => "pipeline-error-openai-403-model-access-denied",
                CallEndedReason.PipelineErrorOpenai429ExceededQuota => "pipeline-error-openai-429-exceeded-quota",
                CallEndedReason.PipelineErrorOpenai429RateLimitReached => "pipeline-error-openai-429-rate-limit-reached",
                CallEndedReason.PipelineErrorOpenai500ServerError => "pipeline-error-openai-500-server-error",
                CallEndedReason.PipelineErrorOpenai503ServerOverloadedError => "pipeline-error-openai-503-server-overloaded-error",
                CallEndedReason.PipelineErrorOpenaiLlmFailed => "pipeline-error-openai-llm-failed",
                CallEndedReason.PipelineErrorOpenaiTranscriberFailed => "pipeline-error-openai-transcriber-failed",
                CallEndedReason.PipelineErrorOpenaiVoiceFailed => "pipeline-error-openai-voice-failed",
                CallEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed => "pipeline-error-openrouter-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorOpenrouter401Unauthorized => "pipeline-error-openrouter-401-unauthorized",
                CallEndedReason.PipelineErrorOpenrouter403ModelAccessDenied => "pipeline-error-openrouter-403-model-access-denied",
                CallEndedReason.PipelineErrorOpenrouter429ExceededQuota => "pipeline-error-openrouter-429-exceeded-quota",
                CallEndedReason.PipelineErrorOpenrouter500ServerError => "pipeline-error-openrouter-500-server-error",
                CallEndedReason.PipelineErrorOpenrouter503ServerOverloadedError => "pipeline-error-openrouter-503-server-overloaded-error",
                CallEndedReason.PipelineErrorOpenrouterLlmFailed => "pipeline-error-openrouter-llm-failed",
                CallEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed => "pipeline-error-perplexity-ai-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorPerplexityAi401Unauthorized => "pipeline-error-perplexity-ai-401-unauthorized",
                CallEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied => "pipeline-error-perplexity-ai-403-model-access-denied",
                CallEndedReason.PipelineErrorPerplexityAi429ExceededQuota => "pipeline-error-perplexity-ai-429-exceeded-quota",
                CallEndedReason.PipelineErrorPerplexityAi500ServerError => "pipeline-error-perplexity-ai-500-server-error",
                CallEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError => "pipeline-error-perplexity-ai-503-server-overloaded-error",
                CallEndedReason.PipelineErrorPerplexityAiLlmFailed => "pipeline-error-perplexity-ai-llm-failed",
                CallEndedReason.PipelineErrorPlayht401Unauthorized => "pipeline-error-playht-401-unauthorized",
                CallEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable => "pipeline-error-playht-403-forbidden-api-access-not-available",
                CallEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters => "pipeline-error-playht-403-forbidden-out-of-characters",
                CallEndedReason.PipelineErrorPlayht429ExceededQuota => "pipeline-error-playht-429-exceeded-quota",
                CallEndedReason.PipelineErrorPlayht502GatewayError => "pipeline-error-playht-502-gateway-error",
                CallEndedReason.PipelineErrorPlayht504GatewayError => "pipeline-error-playht-504-gateway-error",
                CallEndedReason.PipelineErrorPlayhtInvalidEmotion => "pipeline-error-playht-invalid-emotion",
                CallEndedReason.PipelineErrorPlayhtInvalidVoice => "pipeline-error-playht-invalid-voice",
                CallEndedReason.PipelineErrorPlayhtOutOfCredits => "pipeline-error-playht-out-of-credits",
                CallEndedReason.PipelineErrorPlayhtRequestTimedOut => "pipeline-error-playht-request-timed-out",
                CallEndedReason.PipelineErrorPlayhtUnexpectedError => "pipeline-error-playht-unexpected-error",
                CallEndedReason.PipelineErrorPlayhtVoiceFailed => "pipeline-error-playht-voice-failed",
                CallEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri => "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri",
                CallEndedReason.PipelineErrorRimeAiVoiceFailed => "pipeline-error-rime-ai-voice-failed",
                CallEndedReason.PipelineErrorRunpod400BadRequestValidationFailed => "pipeline-error-runpod-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorRunpod401Unauthorized => "pipeline-error-runpod-401-unauthorized",
                CallEndedReason.PipelineErrorRunpod403ModelAccessDenied => "pipeline-error-runpod-403-model-access-denied",
                CallEndedReason.PipelineErrorRunpod429ExceededQuota => "pipeline-error-runpod-429-exceeded-quota",
                CallEndedReason.PipelineErrorRunpod500ServerError => "pipeline-error-runpod-500-server-error",
                CallEndedReason.PipelineErrorRunpod503ServerOverloadedError => "pipeline-error-runpod-503-server-overloaded-error",
                CallEndedReason.PipelineErrorRunpodLlmFailed => "pipeline-error-runpod-llm-failed",
                CallEndedReason.PipelineErrorSesameVoiceFailed => "pipeline-error-sesame-voice-failed",
                CallEndedReason.PipelineErrorSmallestAiVoiceFailed => "pipeline-error-smallest-ai-voice-failed",
                CallEndedReason.PipelineErrorSonioxTranscriberAuthFailed => "pipeline-error-soniox-transcriber-auth-failed",
                CallEndedReason.PipelineErrorSonioxTranscriberFailed => "pipeline-error-soniox-transcriber-failed",
                CallEndedReason.PipelineErrorSonioxTranscriberInvalidConfig => "pipeline-error-soniox-transcriber-invalid-config",
                CallEndedReason.PipelineErrorSonioxTranscriberRateLimited => "pipeline-error-soniox-transcriber-rate-limited",
                CallEndedReason.PipelineErrorSonioxTranscriberServerError => "pipeline-error-soniox-transcriber-server-error",
                CallEndedReason.PipelineErrorSpeechmaticsTranscriberFailed => "pipeline-error-speechmatics-transcriber-failed",
                CallEndedReason.PipelineErrorTalkscriberTranscriberFailed => "pipeline-error-talkscriber-transcriber-failed",
                CallEndedReason.PipelineErrorTavusVideoFailed => "pipeline-error-tavus-video-failed",
                CallEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed => "pipeline-error-together-ai-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorTogetherAi401Unauthorized => "pipeline-error-together-ai-401-unauthorized",
                CallEndedReason.PipelineErrorTogetherAi403ModelAccessDenied => "pipeline-error-together-ai-403-model-access-denied",
                CallEndedReason.PipelineErrorTogetherAi429ExceededQuota => "pipeline-error-together-ai-429-exceeded-quota",
                CallEndedReason.PipelineErrorTogetherAi500ServerError => "pipeline-error-together-ai-500-server-error",
                CallEndedReason.PipelineErrorTogetherAi503ServerOverloadedError => "pipeline-error-together-ai-503-server-overloaded-error",
                CallEndedReason.PipelineErrorTogetherAiLlmFailed => "pipeline-error-together-ai-llm-failed",
                CallEndedReason.PipelineErrorVapi400BadRequestValidationFailed => "pipeline-error-vapi-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorVapi401Unauthorized => "pipeline-error-vapi-401-unauthorized",
                CallEndedReason.PipelineErrorVapi403ModelAccessDenied => "pipeline-error-vapi-403-model-access-denied",
                CallEndedReason.PipelineErrorVapi429ExceededQuota => "pipeline-error-vapi-429-exceeded-quota",
                CallEndedReason.PipelineErrorVapi500ServerError => "pipeline-error-vapi-500-server-error",
                CallEndedReason.PipelineErrorVapi503ServerOverloadedError => "pipeline-error-vapi-503-server-overloaded-error",
                CallEndedReason.PipelineErrorVapiLlmFailed => "pipeline-error-vapi-llm-failed",
                CallEndedReason.PipelineErrorVapiVoiceFailed => "pipeline-error-vapi-voice-failed",
                CallEndedReason.PipelineErrorWellsaidVoiceFailed => "pipeline-error-wellsaid-voice-failed",
                CallEndedReason.PipelineErrorXai400BadRequestValidationFailed => "pipeline-error-xai-400-bad-request-validation-failed",
                CallEndedReason.PipelineErrorXai401Unauthorized => "pipeline-error-xai-401-unauthorized",
                CallEndedReason.PipelineErrorXai403ModelAccessDenied => "pipeline-error-xai-403-model-access-denied",
                CallEndedReason.PipelineErrorXai429ExceededQuota => "pipeline-error-xai-429-exceeded-quota",
                CallEndedReason.PipelineErrorXai500ServerError => "pipeline-error-xai-500-server-error",
                CallEndedReason.PipelineErrorXai503ServerOverloadedError => "pipeline-error-xai-503-server-overloaded-error",
                CallEndedReason.PipelineErrorXaiLlmFailed => "pipeline-error-xai-llm-failed",
                CallEndedReason.ScheduledCallDeleted => "scheduled-call-deleted",
                CallEndedReason.SilenceTimedOut => "silence-timed-out",
                CallEndedReason.TwilioFailedToConnectCall => "twilio-failed-to-connect-call",
                CallEndedReason.TwilioReportedCustomerMisdialed => "twilio-reported-customer-misdialed",
                CallEndedReason.Voicemail => "voicemail",
                CallEndedReason.VonageCompleted => "vonage-completed",
                CallEndedReason.VonageDisconnected => "vonage-disconnected",
                CallEndedReason.VonageFailedToConnectCall => "vonage-failed-to-connect-call",
                CallEndedReason.VonageRejected => "vonage-rejected",
                CallEndedReason.WorkerShutdown => "worker-shutdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallEndedReason? ToEnum(string value)
        {
            return value switch
            {
                "assistant-ended-call" => CallEndedReason.AssistantEndedCall,
                "assistant-ended-call-after-message-spoken" => CallEndedReason.AssistantEndedCallAfterMessageSpoken,
                "assistant-ended-call-with-hangup-task" => CallEndedReason.AssistantEndedCallWithHangupTask,
                "assistant-forwarded-call" => CallEndedReason.AssistantForwardedCall,
                "assistant-join-timed-out" => CallEndedReason.AssistantJoinTimedOut,
                "assistant-not-found" => CallEndedReason.AssistantNotFound,
                "assistant-not-valid" => CallEndedReason.AssistantNotValid,
                "assistant-request-failed" => CallEndedReason.AssistantRequestFailed,
                "assistant-request-returned-error" => CallEndedReason.AssistantRequestReturnedError,
                "assistant-request-returned-forwarding-phone-number" => CallEndedReason.AssistantRequestReturnedForwardingPhoneNumber,
                "assistant-request-returned-invalid-assistant" => CallEndedReason.AssistantRequestReturnedInvalidAssistant,
                "assistant-request-returned-no-assistant" => CallEndedReason.AssistantRequestReturnedNoAssistant,
                "assistant-request-returned-unspeakable-error" => CallEndedReason.AssistantRequestReturnedUnspeakableError,
                "assistant-said-end-call-phrase" => CallEndedReason.AssistantSaidEndCallPhrase,
                "call-deleted" => CallEndedReason.CallDeleted,
                "call-start-error-neither-assistant-nor-server-set" => CallEndedReason.CallStartErrorNeitherAssistantNorServerSet,
                "call.ending.hook-executed-say" => CallEndedReason.CallEndingHookExecutedSay,
                "call.ending.hook-executed-transfer" => CallEndedReason.CallEndingHookExecutedTransfer,
                "call.forwarding.operator-busy" => CallEndedReason.CallForwardingOperatorBusy,
                "call.in-progress.error-assistant-did-not-receive-customer-audio" => CallEndedReason.CallInProgressErrorAssistantDidNotReceiveCustomerAudio,
                "call.in-progress.error-pipeline-no-available-llm-model" => CallEndedReason.CallInProgressErrorPipelineNoAvailableLlmModel,
                "call.in-progress.error-pipeline-ws-model-connection-failed" => CallEndedReason.CallInProgressErrorPipelineWsModelConnectionFailed,
                "call.in-progress.error-providerfault-anthropic-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultAnthropic500ServerError,
                "call.in-progress.error-providerfault-anthropic-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultAnthropic503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-bedrock-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock500ServerError,
                "call.in-progress.error-providerfault-anthropic-bedrock-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrock503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-bedrock-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicBedrockLlmFailed,
                "call.in-progress.error-providerfault-anthropic-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicLlmFailed,
                "call.in-progress.error-providerfault-anthropic-vertex-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex500ServerError,
                "call.in-progress.error-providerfault-anthropic-vertex-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertex503ServerOverloadedError,
                "call.in-progress.error-providerfault-anthropic-vertex-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultAnthropicVertexLlmFailed,
                "call.in-progress.error-providerfault-anyscale-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultAnyscale500ServerError,
                "call.in-progress.error-providerfault-anyscale-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultAnyscale503ServerOverloadedError,
                "call.in-progress.error-providerfault-anyscale-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultAnyscaleLlmFailed,
                "call.in-progress.error-providerfault-azure-openai-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai500ServerError,
                "call.in-progress.error-providerfault-azure-openai-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultAzureOpenai503ServerOverloadedError,
                "call.in-progress.error-providerfault-azure-openai-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultAzureOpenaiLlmFailed,
                "call.in-progress.error-providerfault-baseten-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultBaseten500ServerError,
                "call.in-progress.error-providerfault-baseten-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultBaseten503ServerOverloadedError,
                "call.in-progress.error-providerfault-baseten-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultBasetenLlmFailed,
                "call.in-progress.error-providerfault-cartesia-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultCartesia500ServerError,
                "call.in-progress.error-providerfault-cartesia-503-server-error" => CallEndedReason.CallInProgressErrorProviderfaultCartesia503ServerError,
                "call.in-progress.error-providerfault-cartesia-522-server-error" => CallEndedReason.CallInProgressErrorProviderfaultCartesia522ServerError,
                "call.in-progress.error-providerfault-cerebras-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultCerebras500ServerError,
                "call.in-progress.error-providerfault-cerebras-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultCerebras503ServerOverloadedError,
                "call.in-progress.error-providerfault-cerebras-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultCerebrasLlmFailed,
                "call.in-progress.error-providerfault-custom-llm-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultCustomLlm500ServerError,
                "call.in-progress.error-providerfault-custom-llm-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultCustomLlm503ServerOverloadedError,
                "call.in-progress.error-providerfault-custom-llm-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultCustomLlmLlmFailed,
                "call.in-progress.error-providerfault-deep-seek-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultDeepSeek500ServerError,
                "call.in-progress.error-providerfault-deep-seek-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultDeepSeek503ServerOverloadedError,
                "call.in-progress.error-providerfault-deep-seek-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultDeepSeekLlmFailed,
                "call.in-progress.error-providerfault-deepgram-returning-500-invalid-json" => CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning500InvalidJson,
                "call.in-progress.error-providerfault-deepgram-returning-502-bad-gateway-ehostunreach" => CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502BadGatewayEhostunreach,
                "call.in-progress.error-providerfault-deepgram-returning-502-network-error" => CallEndedReason.CallInProgressErrorProviderfaultDeepgramReturning502NetworkError,
                "call.in-progress.error-providerfault-deepinfra-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultDeepinfra500ServerError,
                "call.in-progress.error-providerfault-deepinfra-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultDeepinfra503ServerOverloadedError,
                "call.in-progress.error-providerfault-deepinfra-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultDeepinfraLlmFailed,
                "call.in-progress.error-providerfault-eleven-labs-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultElevenLabs500ServerError,
                "call.in-progress.error-providerfault-eleven-labs-503-server-error" => CallEndedReason.CallInProgressErrorProviderfaultElevenLabs503ServerError,
                "call.in-progress.error-providerfault-eleven-labs-system-busy-and-requested-upgrade" => CallEndedReason.CallInProgressErrorProviderfaultElevenLabsSystemBusyAndRequestedUpgrade,
                "call.in-progress.error-providerfault-google-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultGoogle500ServerError,
                "call.in-progress.error-providerfault-google-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultGoogle503ServerOverloadedError,
                "call.in-progress.error-providerfault-google-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultGoogleLlmFailed,
                "call.in-progress.error-providerfault-groq-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultGroq500ServerError,
                "call.in-progress.error-providerfault-groq-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultGroq503ServerOverloadedError,
                "call.in-progress.error-providerfault-groq-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultGroqLlmFailed,
                "call.in-progress.error-providerfault-inflection-ai-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultInflectionAi500ServerError,
                "call.in-progress.error-providerfault-inflection-ai-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultInflectionAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-inflection-ai-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultInflectionAiLlmFailed,
                "call.in-progress.error-providerfault-mistral-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultMistral500ServerError,
                "call.in-progress.error-providerfault-mistral-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultMistral503ServerOverloadedError,
                "call.in-progress.error-providerfault-mistral-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultMistralLlmFailed,
                "call.in-progress.error-providerfault-openai-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultOpenai500ServerError,
                "call.in-progress.error-providerfault-openai-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultOpenai503ServerOverloadedError,
                "call.in-progress.error-providerfault-openai-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultOpenaiLlmFailed,
                "call.in-progress.error-providerfault-openrouter-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultOpenrouter500ServerError,
                "call.in-progress.error-providerfault-openrouter-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultOpenrouter503ServerOverloadedError,
                "call.in-progress.error-providerfault-openrouter-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultOpenrouterLlmFailed,
                "call.in-progress.error-providerfault-outbound-sip-403-forbidden" => CallEndedReason.CallInProgressErrorProviderfaultOutboundSip403Forbidden,
                "call.in-progress.error-providerfault-outbound-sip-407-proxy-authentication-required" => CallEndedReason.CallInProgressErrorProviderfaultOutboundSip407ProxyAuthenticationRequired,
                "call.in-progress.error-providerfault-outbound-sip-408-request-timeout" => CallEndedReason.CallInProgressErrorProviderfaultOutboundSip408RequestTimeout,
                "call.in-progress.error-providerfault-outbound-sip-480-temporarily-unavailable" => CallEndedReason.CallInProgressErrorProviderfaultOutboundSip480TemporarilyUnavailable,
                "call.in-progress.error-providerfault-outbound-sip-503-service-unavailable" => CallEndedReason.CallInProgressErrorProviderfaultOutboundSip503ServiceUnavailable,
                "call.in-progress.error-providerfault-perplexity-ai-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi500ServerError,
                "call.in-progress.error-providerfault-perplexity-ai-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultPerplexityAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-perplexity-ai-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultPerplexityAiLlmFailed,
                "call.in-progress.error-providerfault-playht-502-gateway-error" => CallEndedReason.CallInProgressErrorProviderfaultPlayht502GatewayError,
                "call.in-progress.error-providerfault-playht-504-gateway-error" => CallEndedReason.CallInProgressErrorProviderfaultPlayht504GatewayError,
                "call.in-progress.error-providerfault-runpod-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultRunpod500ServerError,
                "call.in-progress.error-providerfault-runpod-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultRunpod503ServerOverloadedError,
                "call.in-progress.error-providerfault-runpod-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultRunpodLlmFailed,
                "call.in-progress.error-providerfault-together-ai-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultTogetherAi500ServerError,
                "call.in-progress.error-providerfault-together-ai-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultTogetherAi503ServerOverloadedError,
                "call.in-progress.error-providerfault-together-ai-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultTogetherAiLlmFailed,
                "call.in-progress.error-providerfault-transport-never-connected" => CallEndedReason.CallInProgressErrorProviderfaultTransportNeverConnected,
                "call.in-progress.error-providerfault-vapi-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultVapi500ServerError,
                "call.in-progress.error-providerfault-vapi-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultVapi503ServerOverloadedError,
                "call.in-progress.error-providerfault-vapi-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultVapiLlmFailed,
                "call.in-progress.error-providerfault-xai-500-server-error" => CallEndedReason.CallInProgressErrorProviderfaultXai500ServerError,
                "call.in-progress.error-providerfault-xai-503-server-overloaded-error" => CallEndedReason.CallInProgressErrorProviderfaultXai503ServerOverloadedError,
                "call.in-progress.error-providerfault-xai-llm-failed" => CallEndedReason.CallInProgressErrorProviderfaultXaiLlmFailed,
                "call.in-progress.error-sip-inbound-call-failed-to-connect" => CallEndedReason.CallInProgressErrorSipInboundCallFailedToConnect,
                "call.in-progress.error-sip-outbound-call-failed-to-connect" => CallEndedReason.CallInProgressErrorSipOutboundCallFailedToConnect,
                "call.in-progress.error-transfer-failed" => CallEndedReason.CallInProgressErrorTransferFailed,
                "call.in-progress.error-vapifault-anthropic-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultAnthropic400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultAnthropic401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultAnthropic403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultAnthropic429ExceededQuota,
                "call.in-progress.error-vapifault-anthropic-bedrock-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-bedrock-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-bedrock-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-bedrock-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultAnthropicBedrock429ExceededQuota,
                "call.in-progress.error-vapifault-anthropic-vertex-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anthropic-vertex-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex401Unauthorized,
                "call.in-progress.error-vapifault-anthropic-vertex-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex403ModelAccessDenied,
                "call.in-progress.error-vapifault-anthropic-vertex-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultAnthropicVertex429ExceededQuota,
                "call.in-progress.error-vapifault-anyscale-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultAnyscale400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-anyscale-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultAnyscale401Unauthorized,
                "call.in-progress.error-vapifault-anyscale-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultAnyscale403ModelAccessDenied,
                "call.in-progress.error-vapifault-anyscale-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultAnyscale429ExceededQuota,
                "call.in-progress.error-vapifault-assembly-ai-returning-400-insufficent-funds" => CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400InsufficentFunds,
                "call.in-progress.error-vapifault-assembly-ai-returning-400-paid-only-feature" => CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning400PaidOnlyFeature,
                "call.in-progress.error-vapifault-assembly-ai-returning-401-invalid-credentials" => CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning401InvalidCredentials,
                "call.in-progress.error-vapifault-assembly-ai-returning-500-invalid-schema" => CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500InvalidSchema,
                "call.in-progress.error-vapifault-assembly-ai-returning-500-word-boost-parsing-failed" => CallEndedReason.CallInProgressErrorVapifaultAssemblyAiReturning500WordBoostParsingFailed,
                "call.in-progress.error-vapifault-assembly-ai-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultAssemblyAiTranscriberFailed,
                "call.in-progress.error-vapifault-azure-openai-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultAzureOpenai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-azure-openai-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultAzureOpenai401Unauthorized,
                "call.in-progress.error-vapifault-azure-openai-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultAzureOpenai403ModelAccessDenied,
                "call.in-progress.error-vapifault-azure-openai-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultAzureOpenai429ExceededQuota,
                "call.in-progress.error-vapifault-azure-speech-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultAzureSpeechTranscriberFailed,
                "call.in-progress.error-vapifault-azure-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultAzureVoiceFailed,
                "call.in-progress.error-vapifault-baseten-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultBaseten400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-baseten-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultBaseten401Unauthorized,
                "call.in-progress.error-vapifault-baseten-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultBaseten403ModelAccessDenied,
                "call.in-progress.error-vapifault-baseten-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultBaseten429ExceededQuota,
                "call.in-progress.error-vapifault-call-started-but-connection-to-transport-missing" => CallEndedReason.CallInProgressErrorVapifaultCallStartedButConnectionToTransportMissing,
                "call.in-progress.error-vapifault-cartesia-requested-payment" => CallEndedReason.CallInProgressErrorVapifaultCartesiaRequestedPayment,
                "call.in-progress.error-vapifault-cartesia-socket-hang-up" => CallEndedReason.CallInProgressErrorVapifaultCartesiaSocketHangUp,
                "call.in-progress.error-vapifault-cartesia-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultCartesiaVoiceFailed,
                "call.in-progress.error-vapifault-cerebras-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultCerebras400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-cerebras-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultCerebras401Unauthorized,
                "call.in-progress.error-vapifault-cerebras-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultCerebras403ModelAccessDenied,
                "call.in-progress.error-vapifault-cerebras-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultCerebras429ExceededQuota,
                "call.in-progress.error-vapifault-chat-pipeline-failed-to-start" => CallEndedReason.CallInProgressErrorVapifaultChatPipelineFailedToStart,
                "call.in-progress.error-vapifault-custom-llm-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultCustomLlm400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-custom-llm-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultCustomLlm401Unauthorized,
                "call.in-progress.error-vapifault-custom-llm-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultCustomLlm403ModelAccessDenied,
                "call.in-progress.error-vapifault-custom-llm-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultCustomLlm429ExceededQuota,
                "call.in-progress.error-vapifault-custom-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultCustomTranscriberFailed,
                "call.in-progress.error-vapifault-deep-seek-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultDeepSeek400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-deep-seek-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultDeepSeek401Unauthorized,
                "call.in-progress.error-vapifault-deep-seek-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultDeepSeek403ModelAccessDenied,
                "call.in-progress.error-vapifault-deep-seek-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultDeepSeek429ExceededQuota,
                "call.in-progress.error-vapifault-deepgram-returning-400-no-such-model-language-tier-combination" => CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning400NoSuchModelLanguageTierCombination,
                "call.in-progress.error-vapifault-deepgram-returning-401-invalid-credentials" => CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning401InvalidCredentials,
                "call.in-progress.error-vapifault-deepgram-returning-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning403ModelAccessDenied,
                "call.in-progress.error-vapifault-deepgram-returning-404-not-found" => CallEndedReason.CallInProgressErrorVapifaultDeepgramReturning404NotFound,
                "call.in-progress.error-vapifault-deepgram-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultDeepgramTranscriberFailed,
                "call.in-progress.error-vapifault-deepgram-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultDeepgramVoiceFailed,
                "call.in-progress.error-vapifault-deepinfra-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultDeepinfra400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-deepinfra-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultDeepinfra401Unauthorized,
                "call.in-progress.error-vapifault-deepinfra-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultDeepinfra403ModelAccessDenied,
                "call.in-progress.error-vapifault-deepinfra-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultDeepinfra429ExceededQuota,
                "call.in-progress.error-vapifault-eleven-labs-blocked-account-in-probation" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedAccountInProbation,
                "call.in-progress.error-vapifault-eleven-labs-blocked-concurrent-requests-and-requested-upgrade" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-content-against-their-policy" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedContentAgainstTheirPolicy,
                "call.in-progress.error-vapifault-eleven-labs-blocked-free-plan-and-requested-upgrade" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedFreePlanAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
                "call.in-progress.error-vapifault-eleven-labs-invalid-api-key" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidApiKey,
                "call.in-progress.error-vapifault-eleven-labs-invalid-voice-samples" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsInvalidVoiceSamples,
                "call.in-progress.error-vapifault-eleven-labs-max-character-limit-exceeded" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsMaxCharacterLimitExceeded,
                "call.in-progress.error-vapifault-eleven-labs-missing-samples-for-voice-clone" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsMissingSamplesForVoiceClone,
                "call.in-progress.error-vapifault-eleven-labs-professional-voices-only-for-creator-plus" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsProfessionalVoicesOnlyForCreatorPlus,
                "call.in-progress.error-vapifault-eleven-labs-quota-exceeded" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsQuotaExceeded,
                "call.in-progress.error-vapifault-eleven-labs-system-busy-and-requested-upgrade" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsSystemBusyAndRequestedUpgrade,
                "call.in-progress.error-vapifault-eleven-labs-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsTranscriberFailed,
                "call.in-progress.error-vapifault-eleven-labs-unauthorized-access" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedAccess,
                "call.in-progress.error-vapifault-eleven-labs-unauthorized-to-access-model" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsUnauthorizedToAccessModel,
                "call.in-progress.error-vapifault-eleven-labs-voice-disabled-by-owner" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceDisabledByOwner,
                "call.in-progress.error-vapifault-eleven-labs-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceFailed,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-allowed-for-free-users" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotAllowedForFreeUsers,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTuned,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-fine-tuned-and-cannot-be-used" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFineTunedAndCannotBeUsed,
                "call.in-progress.error-vapifault-eleven-labs-voice-not-found" => CallEndedReason.CallInProgressErrorVapifaultElevenLabsVoiceNotFound,
                "call.in-progress.error-vapifault-gladia-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultGladiaTranscriberFailed,
                "call.in-progress.error-vapifault-google-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultGoogle400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-google-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultGoogle401Unauthorized,
                "call.in-progress.error-vapifault-google-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultGoogle403ModelAccessDenied,
                "call.in-progress.error-vapifault-google-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultGoogle429ExceededQuota,
                "call.in-progress.error-vapifault-google-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultGoogleTranscriberFailed,
                "call.in-progress.error-vapifault-groq-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultGroq400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-groq-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultGroq401Unauthorized,
                "call.in-progress.error-vapifault-groq-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultGroq403ModelAccessDenied,
                "call.in-progress.error-vapifault-groq-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultGroq429ExceededQuota,
                "call.in-progress.error-vapifault-hume-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultHumeVoiceFailed,
                "call.in-progress.error-vapifault-inflection-ai-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultInflectionAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-inflection-ai-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultInflectionAi401Unauthorized,
                "call.in-progress.error-vapifault-inflection-ai-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultInflectionAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-inflection-ai-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultInflectionAi429ExceededQuota,
                "call.in-progress.error-vapifault-inworld-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultInworldVoiceFailed,
                "call.in-progress.error-vapifault-lmnt-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultLmntVoiceFailed,
                "call.in-progress.error-vapifault-minimax-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultMinimaxVoiceFailed,
                "call.in-progress.error-vapifault-mistral-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultMistral400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-mistral-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultMistral401Unauthorized,
                "call.in-progress.error-vapifault-mistral-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultMistral403ModelAccessDenied,
                "call.in-progress.error-vapifault-mistral-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultMistral429ExceededQuota,
                "call.in-progress.error-vapifault-neuphonic-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultNeuphonicVoiceFailed,
                "call.in-progress.error-vapifault-openai-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultOpenai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-openai-401-account-not-in-organization" => CallEndedReason.CallInProgressErrorVapifaultOpenai401AccountNotInOrganization,
                "call.in-progress.error-vapifault-openai-401-incorrect-api-key" => CallEndedReason.CallInProgressErrorVapifaultOpenai401IncorrectApiKey,
                "call.in-progress.error-vapifault-openai-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultOpenai401Unauthorized,
                "call.in-progress.error-vapifault-openai-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultOpenai403ModelAccessDenied,
                "call.in-progress.error-vapifault-openai-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultOpenai429ExceededQuota,
                "call.in-progress.error-vapifault-openai-429-rate-limit-reached" => CallEndedReason.CallInProgressErrorVapifaultOpenai429RateLimitReached,
                "call.in-progress.error-vapifault-openai-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultOpenaiTranscriberFailed,
                "call.in-progress.error-vapifault-openai-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultOpenaiVoiceFailed,
                "call.in-progress.error-vapifault-openrouter-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultOpenrouter400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-openrouter-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultOpenrouter401Unauthorized,
                "call.in-progress.error-vapifault-openrouter-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultOpenrouter403ModelAccessDenied,
                "call.in-progress.error-vapifault-openrouter-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultOpenrouter429ExceededQuota,
                "call.in-progress.error-vapifault-perplexity-ai-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultPerplexityAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-perplexity-ai-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultPerplexityAi401Unauthorized,
                "call.in-progress.error-vapifault-perplexity-ai-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultPerplexityAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-perplexity-ai-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultPerplexityAi429ExceededQuota,
                "call.in-progress.error-vapifault-playht-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultPlayht401Unauthorized,
                "call.in-progress.error-vapifault-playht-403-forbidden-api-access-not-available" => CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenApiAccessNotAvailable,
                "call.in-progress.error-vapifault-playht-403-forbidden-out-of-characters" => CallEndedReason.CallInProgressErrorVapifaultPlayht403ForbiddenOutOfCharacters,
                "call.in-progress.error-vapifault-playht-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultPlayht429ExceededQuota,
                "call.in-progress.error-vapifault-playht-invalid-emotion" => CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidEmotion,
                "call.in-progress.error-vapifault-playht-invalid-voice" => CallEndedReason.CallInProgressErrorVapifaultPlayhtInvalidVoice,
                "call.in-progress.error-vapifault-playht-out-of-credits" => CallEndedReason.CallInProgressErrorVapifaultPlayhtOutOfCredits,
                "call.in-progress.error-vapifault-playht-request-timed-out" => CallEndedReason.CallInProgressErrorVapifaultPlayhtRequestTimedOut,
                "call.in-progress.error-vapifault-playht-unexpected-error" => CallEndedReason.CallInProgressErrorVapifaultPlayhtUnexpectedError,
                "call.in-progress.error-vapifault-playht-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceFailed,
                "call.in-progress.error-vapifault-playht-voice-must-be-a-valid-voice-manifest-uri" => CallEndedReason.CallInProgressErrorVapifaultPlayhtVoiceMustBeAValidVoiceManifestUri,
                "call.in-progress.error-vapifault-rime-ai-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultRimeAiVoiceFailed,
                "call.in-progress.error-vapifault-runpod-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultRunpod400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-runpod-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultRunpod401Unauthorized,
                "call.in-progress.error-vapifault-runpod-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultRunpod403ModelAccessDenied,
                "call.in-progress.error-vapifault-runpod-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultRunpod429ExceededQuota,
                "call.in-progress.error-vapifault-sesame-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultSesameVoiceFailed,
                "call.in-progress.error-vapifault-smallest-ai-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultSmallestAiVoiceFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-auth-failed" => CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberAuthFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberFailed,
                "call.in-progress.error-vapifault-soniox-transcriber-invalid-config" => CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberInvalidConfig,
                "call.in-progress.error-vapifault-soniox-transcriber-rate-limited" => CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberRateLimited,
                "call.in-progress.error-vapifault-soniox-transcriber-server-error" => CallEndedReason.CallInProgressErrorVapifaultSonioxTranscriberServerError,
                "call.in-progress.error-vapifault-speechmatics-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultSpeechmaticsTranscriberFailed,
                "call.in-progress.error-vapifault-talkscriber-transcriber-failed" => CallEndedReason.CallInProgressErrorVapifaultTalkscriberTranscriberFailed,
                "call.in-progress.error-vapifault-tavus-video-failed" => CallEndedReason.CallInProgressErrorVapifaultTavusVideoFailed,
                "call.in-progress.error-vapifault-together-ai-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultTogetherAi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-together-ai-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultTogetherAi401Unauthorized,
                "call.in-progress.error-vapifault-together-ai-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultTogetherAi403ModelAccessDenied,
                "call.in-progress.error-vapifault-together-ai-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultTogetherAi429ExceededQuota,
                "call.in-progress.error-vapifault-transport-connected-but-call-not-active" => CallEndedReason.CallInProgressErrorVapifaultTransportConnectedButCallNotActive,
                "call.in-progress.error-vapifault-transport-never-connected" => CallEndedReason.CallInProgressErrorVapifaultTransportNeverConnected,
                "call.in-progress.error-vapifault-vapi-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultVapi400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-vapi-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultVapi401Unauthorized,
                "call.in-progress.error-vapifault-vapi-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultVapi403ModelAccessDenied,
                "call.in-progress.error-vapifault-vapi-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultVapi429ExceededQuota,
                "call.in-progress.error-vapifault-vapi-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultVapiVoiceFailed,
                "call.in-progress.error-vapifault-wellsaid-voice-failed" => CallEndedReason.CallInProgressErrorVapifaultWellsaidVoiceFailed,
                "call.in-progress.error-vapifault-worker-died" => CallEndedReason.CallInProgressErrorVapifaultWorkerDied,
                "call.in-progress.error-vapifault-worker-not-available" => CallEndedReason.CallInProgressErrorVapifaultWorkerNotAvailable,
                "call.in-progress.error-vapifault-xai-400-bad-request-validation-failed" => CallEndedReason.CallInProgressErrorVapifaultXai400BadRequestValidationFailed,
                "call.in-progress.error-vapifault-xai-401-unauthorized" => CallEndedReason.CallInProgressErrorVapifaultXai401Unauthorized,
                "call.in-progress.error-vapifault-xai-403-model-access-denied" => CallEndedReason.CallInProgressErrorVapifaultXai403ModelAccessDenied,
                "call.in-progress.error-vapifault-xai-429-exceeded-quota" => CallEndedReason.CallInProgressErrorVapifaultXai429ExceededQuota,
                "call.in-progress.error-warm-transfer-assistant-cancelled" => CallEndedReason.CallInProgressErrorWarmTransferAssistantCancelled,
                "call.in-progress.error-warm-transfer-max-duration" => CallEndedReason.CallInProgressErrorWarmTransferMaxDuration,
                "call.in-progress.error-warm-transfer-microphone-timeout" => CallEndedReason.CallInProgressErrorWarmTransferMicrophoneTimeout,
                "call.in-progress.error-warm-transfer-silence-timeout" => CallEndedReason.CallInProgressErrorWarmTransferSilenceTimeout,
                "call.in-progress.sip-completed-call" => CallEndedReason.CallInProgressSipCompletedCall,
                "call.in-progress.twilio-completed-call" => CallEndedReason.CallInProgressTwilioCompletedCall,
                "call.ringing.error-sip-inbound-call-failed-to-connect" => CallEndedReason.CallRingingErrorSipInboundCallFailedToConnect,
                "call.ringing.hook-executed-say" => CallEndedReason.CallRingingHookExecutedSay,
                "call.ringing.hook-executed-transfer" => CallEndedReason.CallRingingHookExecutedTransfer,
                "call.ringing.sip-inbound-caller-hungup-before-call-connect" => CallEndedReason.CallRingingSipInboundCallerHungupBeforeCallConnect,
                "call.start.error-enterprise-feature-not-available-recording-consent" => CallEndedReason.CallStartErrorEnterpriseFeatureNotAvailableRecordingConsent,
                "call.start.error-fraud-check-failed" => CallEndedReason.CallStartErrorFraudCheckFailed,
                "call.start.error-get-assistant" => CallEndedReason.CallStartErrorGetAssistant,
                "call.start.error-get-customer" => CallEndedReason.CallStartErrorGetCustomer,
                "call.start.error-get-phone-number" => CallEndedReason.CallStartErrorGetPhoneNumber,
                "call.start.error-get-resources-validation" => CallEndedReason.CallStartErrorGetResourcesValidation,
                "call.start.error-get-transport" => CallEndedReason.CallStartErrorGetTransport,
                "call.start.error-subscription-concurrency-limit-reached" => CallEndedReason.CallStartErrorSubscriptionConcurrencyLimitReached,
                "call.start.error-subscription-frozen" => CallEndedReason.CallStartErrorSubscriptionFrozen,
                "call.start.error-subscription-insufficient-credits" => CallEndedReason.CallStartErrorSubscriptionInsufficientCredits,
                "call.start.error-subscription-upgrade-failed" => CallEndedReason.CallStartErrorSubscriptionUpgradeFailed,
                "call.start.error-subscription-wallet-does-not-exist" => CallEndedReason.CallStartErrorSubscriptionWalletDoesNotExist,
                "call.start.error-vapi-number-international" => CallEndedReason.CallStartErrorVapiNumberInternational,
                "call.start.error-vapi-number-outbound-daily-limit" => CallEndedReason.CallStartErrorVapiNumberOutboundDailyLimit,
                "call.start.error-vapifault-database-error" => CallEndedReason.CallStartErrorVapifaultDatabaseError,
                "call.start.error-vapifault-get-org" => CallEndedReason.CallStartErrorVapifaultGetOrg,
                "call.start.error-vapifault-get-subscription" => CallEndedReason.CallStartErrorVapifaultGetSubscription,
                "customer-busy" => CallEndedReason.CustomerBusy,
                "customer-did-not-answer" => CallEndedReason.CustomerDidNotAnswer,
                "customer-did-not-give-microphone-permission" => CallEndedReason.CustomerDidNotGiveMicrophonePermission,
                "customer-ended-call" => CallEndedReason.CustomerEndedCall,
                "customer-ended-call-after-warm-transfer-attempt" => CallEndedReason.CustomerEndedCallAfterWarmTransferAttempt,
                "customer-ended-call-before-warm-transfer" => CallEndedReason.CustomerEndedCallBeforeWarmTransfer,
                "customer-ended-call-during-transfer" => CallEndedReason.CustomerEndedCallDuringTransfer,
                "exceeded-max-duration" => CallEndedReason.ExceededMaxDuration,
                "manually-canceled" => CallEndedReason.ManuallyCanceled,
                "phone-call-provider-bypass-enabled-but-no-call-received" => CallEndedReason.PhoneCallProviderBypassEnabledButNoCallReceived,
                "phone-call-provider-closed-websocket" => CallEndedReason.PhoneCallProviderClosedWebsocket,
                "pipeline-error-anthropic-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorAnthropic400BadRequestValidationFailed,
                "pipeline-error-anthropic-401-unauthorized" => CallEndedReason.PipelineErrorAnthropic401Unauthorized,
                "pipeline-error-anthropic-403-model-access-denied" => CallEndedReason.PipelineErrorAnthropic403ModelAccessDenied,
                "pipeline-error-anthropic-429-exceeded-quota" => CallEndedReason.PipelineErrorAnthropic429ExceededQuota,
                "pipeline-error-anthropic-500-server-error" => CallEndedReason.PipelineErrorAnthropic500ServerError,
                "pipeline-error-anthropic-503-server-overloaded-error" => CallEndedReason.PipelineErrorAnthropic503ServerOverloadedError,
                "pipeline-error-anthropic-bedrock-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorAnthropicBedrock400BadRequestValidationFailed,
                "pipeline-error-anthropic-bedrock-401-unauthorized" => CallEndedReason.PipelineErrorAnthropicBedrock401Unauthorized,
                "pipeline-error-anthropic-bedrock-403-model-access-denied" => CallEndedReason.PipelineErrorAnthropicBedrock403ModelAccessDenied,
                "pipeline-error-anthropic-bedrock-429-exceeded-quota" => CallEndedReason.PipelineErrorAnthropicBedrock429ExceededQuota,
                "pipeline-error-anthropic-bedrock-500-server-error" => CallEndedReason.PipelineErrorAnthropicBedrock500ServerError,
                "pipeline-error-anthropic-bedrock-503-server-overloaded-error" => CallEndedReason.PipelineErrorAnthropicBedrock503ServerOverloadedError,
                "pipeline-error-anthropic-bedrock-llm-failed" => CallEndedReason.PipelineErrorAnthropicBedrockLlmFailed,
                "pipeline-error-anthropic-llm-failed" => CallEndedReason.PipelineErrorAnthropicLlmFailed,
                "pipeline-error-anthropic-vertex-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorAnthropicVertex400BadRequestValidationFailed,
                "pipeline-error-anthropic-vertex-401-unauthorized" => CallEndedReason.PipelineErrorAnthropicVertex401Unauthorized,
                "pipeline-error-anthropic-vertex-403-model-access-denied" => CallEndedReason.PipelineErrorAnthropicVertex403ModelAccessDenied,
                "pipeline-error-anthropic-vertex-429-exceeded-quota" => CallEndedReason.PipelineErrorAnthropicVertex429ExceededQuota,
                "pipeline-error-anthropic-vertex-500-server-error" => CallEndedReason.PipelineErrorAnthropicVertex500ServerError,
                "pipeline-error-anthropic-vertex-503-server-overloaded-error" => CallEndedReason.PipelineErrorAnthropicVertex503ServerOverloadedError,
                "pipeline-error-anthropic-vertex-llm-failed" => CallEndedReason.PipelineErrorAnthropicVertexLlmFailed,
                "pipeline-error-anyscale-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorAnyscale400BadRequestValidationFailed,
                "pipeline-error-anyscale-401-unauthorized" => CallEndedReason.PipelineErrorAnyscale401Unauthorized,
                "pipeline-error-anyscale-403-model-access-denied" => CallEndedReason.PipelineErrorAnyscale403ModelAccessDenied,
                "pipeline-error-anyscale-429-exceeded-quota" => CallEndedReason.PipelineErrorAnyscale429ExceededQuota,
                "pipeline-error-anyscale-500-server-error" => CallEndedReason.PipelineErrorAnyscale500ServerError,
                "pipeline-error-anyscale-503-server-overloaded-error" => CallEndedReason.PipelineErrorAnyscale503ServerOverloadedError,
                "pipeline-error-anyscale-llm-failed" => CallEndedReason.PipelineErrorAnyscaleLlmFailed,
                "pipeline-error-assembly-ai-returning-400-insufficent-funds" => CallEndedReason.PipelineErrorAssemblyAiReturning400InsufficentFunds,
                "pipeline-error-assembly-ai-returning-400-paid-only-feature" => CallEndedReason.PipelineErrorAssemblyAiReturning400PaidOnlyFeature,
                "pipeline-error-assembly-ai-returning-401-invalid-credentials" => CallEndedReason.PipelineErrorAssemblyAiReturning401InvalidCredentials,
                "pipeline-error-assembly-ai-returning-500-invalid-schema" => CallEndedReason.PipelineErrorAssemblyAiReturning500InvalidSchema,
                "pipeline-error-assembly-ai-returning-500-word-boost-parsing-failed" => CallEndedReason.PipelineErrorAssemblyAiReturning500WordBoostParsingFailed,
                "pipeline-error-assembly-ai-transcriber-failed" => CallEndedReason.PipelineErrorAssemblyAiTranscriberFailed,
                "pipeline-error-azure-openai-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorAzureOpenai400BadRequestValidationFailed,
                "pipeline-error-azure-openai-401-unauthorized" => CallEndedReason.PipelineErrorAzureOpenai401Unauthorized,
                "pipeline-error-azure-openai-403-model-access-denied" => CallEndedReason.PipelineErrorAzureOpenai403ModelAccessDenied,
                "pipeline-error-azure-openai-429-exceeded-quota" => CallEndedReason.PipelineErrorAzureOpenai429ExceededQuota,
                "pipeline-error-azure-openai-500-server-error" => CallEndedReason.PipelineErrorAzureOpenai500ServerError,
                "pipeline-error-azure-openai-503-server-overloaded-error" => CallEndedReason.PipelineErrorAzureOpenai503ServerOverloadedError,
                "pipeline-error-azure-openai-llm-failed" => CallEndedReason.PipelineErrorAzureOpenaiLlmFailed,
                "pipeline-error-azure-speech-transcriber-failed" => CallEndedReason.PipelineErrorAzureSpeechTranscriberFailed,
                "pipeline-error-azure-voice-failed" => CallEndedReason.PipelineErrorAzureVoiceFailed,
                "pipeline-error-baseten-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorBaseten400BadRequestValidationFailed,
                "pipeline-error-baseten-401-unauthorized" => CallEndedReason.PipelineErrorBaseten401Unauthorized,
                "pipeline-error-baseten-403-model-access-denied" => CallEndedReason.PipelineErrorBaseten403ModelAccessDenied,
                "pipeline-error-baseten-429-exceeded-quota" => CallEndedReason.PipelineErrorBaseten429ExceededQuota,
                "pipeline-error-baseten-500-server-error" => CallEndedReason.PipelineErrorBaseten500ServerError,
                "pipeline-error-baseten-503-server-overloaded-error" => CallEndedReason.PipelineErrorBaseten503ServerOverloadedError,
                "pipeline-error-baseten-llm-failed" => CallEndedReason.PipelineErrorBasetenLlmFailed,
                "pipeline-error-cartesia-500-server-error" => CallEndedReason.PipelineErrorCartesia500ServerError,
                "pipeline-error-cartesia-502-server-error" => CallEndedReason.PipelineErrorCartesia502ServerError,
                "pipeline-error-cartesia-503-server-error" => CallEndedReason.PipelineErrorCartesia503ServerError,
                "pipeline-error-cartesia-522-server-error" => CallEndedReason.PipelineErrorCartesia522ServerError,
                "pipeline-error-cartesia-requested-payment" => CallEndedReason.PipelineErrorCartesiaRequestedPayment,
                "pipeline-error-cartesia-socket-hang-up" => CallEndedReason.PipelineErrorCartesiaSocketHangUp,
                "pipeline-error-cartesia-voice-failed" => CallEndedReason.PipelineErrorCartesiaVoiceFailed,
                "pipeline-error-cerebras-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorCerebras400BadRequestValidationFailed,
                "pipeline-error-cerebras-401-unauthorized" => CallEndedReason.PipelineErrorCerebras401Unauthorized,
                "pipeline-error-cerebras-403-model-access-denied" => CallEndedReason.PipelineErrorCerebras403ModelAccessDenied,
                "pipeline-error-cerebras-429-exceeded-quota" => CallEndedReason.PipelineErrorCerebras429ExceededQuota,
                "pipeline-error-cerebras-500-server-error" => CallEndedReason.PipelineErrorCerebras500ServerError,
                "pipeline-error-cerebras-503-server-overloaded-error" => CallEndedReason.PipelineErrorCerebras503ServerOverloadedError,
                "pipeline-error-cerebras-llm-failed" => CallEndedReason.PipelineErrorCerebrasLlmFailed,
                "pipeline-error-custom-llm-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorCustomLlm400BadRequestValidationFailed,
                "pipeline-error-custom-llm-401-unauthorized" => CallEndedReason.PipelineErrorCustomLlm401Unauthorized,
                "pipeline-error-custom-llm-403-model-access-denied" => CallEndedReason.PipelineErrorCustomLlm403ModelAccessDenied,
                "pipeline-error-custom-llm-429-exceeded-quota" => CallEndedReason.PipelineErrorCustomLlm429ExceededQuota,
                "pipeline-error-custom-llm-500-server-error" => CallEndedReason.PipelineErrorCustomLlm500ServerError,
                "pipeline-error-custom-llm-503-server-overloaded-error" => CallEndedReason.PipelineErrorCustomLlm503ServerOverloadedError,
                "pipeline-error-custom-llm-llm-failed" => CallEndedReason.PipelineErrorCustomLlmLlmFailed,
                "pipeline-error-custom-transcriber-failed" => CallEndedReason.PipelineErrorCustomTranscriberFailed,
                "pipeline-error-custom-voice-failed" => CallEndedReason.PipelineErrorCustomVoiceFailed,
                "pipeline-error-deep-seek-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorDeepSeek400BadRequestValidationFailed,
                "pipeline-error-deep-seek-401-unauthorized" => CallEndedReason.PipelineErrorDeepSeek401Unauthorized,
                "pipeline-error-deep-seek-403-model-access-denied" => CallEndedReason.PipelineErrorDeepSeek403ModelAccessDenied,
                "pipeline-error-deep-seek-429-exceeded-quota" => CallEndedReason.PipelineErrorDeepSeek429ExceededQuota,
                "pipeline-error-deep-seek-500-server-error" => CallEndedReason.PipelineErrorDeepSeek500ServerError,
                "pipeline-error-deep-seek-503-server-overloaded-error" => CallEndedReason.PipelineErrorDeepSeek503ServerOverloadedError,
                "pipeline-error-deep-seek-llm-failed" => CallEndedReason.PipelineErrorDeepSeekLlmFailed,
                "pipeline-error-deepgram-returning-400-no-such-model-language-tier-combination" => CallEndedReason.PipelineErrorDeepgramReturning400NoSuchModelLanguageTierCombination,
                "pipeline-error-deepgram-returning-401-invalid-credentials" => CallEndedReason.PipelineErrorDeepgramReturning401InvalidCredentials,
                "pipeline-error-deepgram-returning-403-model-access-denied" => CallEndedReason.PipelineErrorDeepgramReturning403ModelAccessDenied,
                "pipeline-error-deepgram-returning-404-not-found" => CallEndedReason.PipelineErrorDeepgramReturning404NotFound,
                "pipeline-error-deepgram-returning-500-invalid-json" => CallEndedReason.PipelineErrorDeepgramReturning500InvalidJson,
                "pipeline-error-deepgram-returning-502-bad-gateway-ehostunreach" => CallEndedReason.PipelineErrorDeepgramReturning502BadGatewayEhostunreach,
                "pipeline-error-deepgram-returning-502-network-error" => CallEndedReason.PipelineErrorDeepgramReturning502NetworkError,
                "pipeline-error-deepgram-returning-econnreset" => CallEndedReason.PipelineErrorDeepgramReturningEconnreset,
                "pipeline-error-deepgram-transcriber-api-key-missing" => CallEndedReason.PipelineErrorDeepgramTranscriberApiKeyMissing,
                "pipeline-error-deepgram-transcriber-failed" => CallEndedReason.PipelineErrorDeepgramTranscriberFailed,
                "pipeline-error-deepgram-voice-failed" => CallEndedReason.PipelineErrorDeepgramVoiceFailed,
                "pipeline-error-deepinfra-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorDeepinfra400BadRequestValidationFailed,
                "pipeline-error-deepinfra-401-unauthorized" => CallEndedReason.PipelineErrorDeepinfra401Unauthorized,
                "pipeline-error-deepinfra-403-model-access-denied" => CallEndedReason.PipelineErrorDeepinfra403ModelAccessDenied,
                "pipeline-error-deepinfra-429-exceeded-quota" => CallEndedReason.PipelineErrorDeepinfra429ExceededQuota,
                "pipeline-error-deepinfra-500-server-error" => CallEndedReason.PipelineErrorDeepinfra500ServerError,
                "pipeline-error-deepinfra-503-server-overloaded-error" => CallEndedReason.PipelineErrorDeepinfra503ServerOverloadedError,
                "pipeline-error-deepinfra-llm-failed" => CallEndedReason.PipelineErrorDeepinfraLlmFailed,
                "pipeline-error-eleven-labs-500-server-error" => CallEndedReason.PipelineErrorElevenLabs500ServerError,
                "pipeline-error-eleven-labs-503-server-error" => CallEndedReason.PipelineErrorElevenLabs503ServerError,
                "pipeline-error-eleven-labs-blocked-account-in-probation" => CallEndedReason.PipelineErrorElevenLabsBlockedAccountInProbation,
                "pipeline-error-eleven-labs-blocked-concurrent-requests-and-requested-upgrade" => CallEndedReason.PipelineErrorElevenLabsBlockedConcurrentRequestsAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-content-against-their-policy" => CallEndedReason.PipelineErrorElevenLabsBlockedContentAgainstTheirPolicy,
                "pipeline-error-eleven-labs-blocked-free-plan-and-requested-upgrade" => CallEndedReason.PipelineErrorElevenLabsBlockedFreePlanAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-using-instant-voice-clone-and-requested-upgrade" => CallEndedReason.PipelineErrorElevenLabsBlockedUsingInstantVoiceCloneAndRequestedUpgrade,
                "pipeline-error-eleven-labs-blocked-voice-potentially-against-terms-of-service-and-awaiting-verification" => CallEndedReason.PipelineErrorElevenLabsBlockedVoicePotentiallyAgainstTermsOfServiceAndAwaitingVerification,
                "pipeline-error-eleven-labs-invalid-api-key" => CallEndedReason.PipelineErrorElevenLabsInvalidApiKey,
                "pipeline-error-eleven-labs-invalid-voice-samples" => CallEndedReason.PipelineErrorElevenLabsInvalidVoiceSamples,
                "pipeline-error-eleven-labs-max-character-limit-exceeded" => CallEndedReason.PipelineErrorElevenLabsMaxCharacterLimitExceeded,
                "pipeline-error-eleven-labs-missing-samples-for-voice-clone" => CallEndedReason.PipelineErrorElevenLabsMissingSamplesForVoiceClone,
                "pipeline-error-eleven-labs-professional-voices-only-for-creator-plus" => CallEndedReason.PipelineErrorElevenLabsProfessionalVoicesOnlyForCreatorPlus,
                "pipeline-error-eleven-labs-quota-exceeded" => CallEndedReason.PipelineErrorElevenLabsQuotaExceeded,
                "pipeline-error-eleven-labs-system-busy-and-requested-upgrade" => CallEndedReason.PipelineErrorElevenLabsSystemBusyAndRequestedUpgrade,
                "pipeline-error-eleven-labs-transcriber-failed" => CallEndedReason.PipelineErrorElevenLabsTranscriberFailed,
                "pipeline-error-eleven-labs-unauthorized-access" => CallEndedReason.PipelineErrorElevenLabsUnauthorizedAccess,
                "pipeline-error-eleven-labs-unauthorized-to-access-model" => CallEndedReason.PipelineErrorElevenLabsUnauthorizedToAccessModel,
                "pipeline-error-eleven-labs-vapi-voice-disabled-by-owner" => CallEndedReason.PipelineErrorElevenLabsVapiVoiceDisabledByOwner,
                "pipeline-error-eleven-labs-voice-disabled-by-owner" => CallEndedReason.PipelineErrorElevenLabsVoiceDisabledByOwner,
                "pipeline-error-eleven-labs-voice-failed" => CallEndedReason.PipelineErrorElevenLabsVoiceFailed,
                "pipeline-error-eleven-labs-voice-not-allowed-for-free-users" => CallEndedReason.PipelineErrorElevenLabsVoiceNotAllowedForFreeUsers,
                "pipeline-error-eleven-labs-voice-not-fine-tuned" => CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTuned,
                "pipeline-error-eleven-labs-voice-not-fine-tuned-and-cannot-be-used" => CallEndedReason.PipelineErrorElevenLabsVoiceNotFineTunedAndCannotBeUsed,
                "pipeline-error-eleven-labs-voice-not-found" => CallEndedReason.PipelineErrorElevenLabsVoiceNotFound,
                "pipeline-error-gladia-transcriber-failed" => CallEndedReason.PipelineErrorGladiaTranscriberFailed,
                "pipeline-error-google-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorGoogle400BadRequestValidationFailed,
                "pipeline-error-google-401-unauthorized" => CallEndedReason.PipelineErrorGoogle401Unauthorized,
                "pipeline-error-google-403-model-access-denied" => CallEndedReason.PipelineErrorGoogle403ModelAccessDenied,
                "pipeline-error-google-429-exceeded-quota" => CallEndedReason.PipelineErrorGoogle429ExceededQuota,
                "pipeline-error-google-500-server-error" => CallEndedReason.PipelineErrorGoogle500ServerError,
                "pipeline-error-google-503-server-overloaded-error" => CallEndedReason.PipelineErrorGoogle503ServerOverloadedError,
                "pipeline-error-google-llm-failed" => CallEndedReason.PipelineErrorGoogleLlmFailed,
                "pipeline-error-google-transcriber-failed" => CallEndedReason.PipelineErrorGoogleTranscriberFailed,
                "pipeline-error-groq-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorGroq400BadRequestValidationFailed,
                "pipeline-error-groq-401-unauthorized" => CallEndedReason.PipelineErrorGroq401Unauthorized,
                "pipeline-error-groq-403-model-access-denied" => CallEndedReason.PipelineErrorGroq403ModelAccessDenied,
                "pipeline-error-groq-429-exceeded-quota" => CallEndedReason.PipelineErrorGroq429ExceededQuota,
                "pipeline-error-groq-500-server-error" => CallEndedReason.PipelineErrorGroq500ServerError,
                "pipeline-error-groq-503-server-overloaded-error" => CallEndedReason.PipelineErrorGroq503ServerOverloadedError,
                "pipeline-error-groq-llm-failed" => CallEndedReason.PipelineErrorGroqLlmFailed,
                "pipeline-error-hume-voice-failed" => CallEndedReason.PipelineErrorHumeVoiceFailed,
                "pipeline-error-inflection-ai-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorInflectionAi400BadRequestValidationFailed,
                "pipeline-error-inflection-ai-401-unauthorized" => CallEndedReason.PipelineErrorInflectionAi401Unauthorized,
                "pipeline-error-inflection-ai-403-model-access-denied" => CallEndedReason.PipelineErrorInflectionAi403ModelAccessDenied,
                "pipeline-error-inflection-ai-429-exceeded-quota" => CallEndedReason.PipelineErrorInflectionAi429ExceededQuota,
                "pipeline-error-inflection-ai-500-server-error" => CallEndedReason.PipelineErrorInflectionAi500ServerError,
                "pipeline-error-inflection-ai-503-server-overloaded-error" => CallEndedReason.PipelineErrorInflectionAi503ServerOverloadedError,
                "pipeline-error-inflection-ai-llm-failed" => CallEndedReason.PipelineErrorInflectionAiLlmFailed,
                "pipeline-error-inworld-voice-failed" => CallEndedReason.PipelineErrorInworldVoiceFailed,
                "pipeline-error-lmnt-voice-failed" => CallEndedReason.PipelineErrorLmntVoiceFailed,
                "pipeline-error-minimax-voice-failed" => CallEndedReason.PipelineErrorMinimaxVoiceFailed,
                "pipeline-error-mistral-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorMistral400BadRequestValidationFailed,
                "pipeline-error-mistral-401-unauthorized" => CallEndedReason.PipelineErrorMistral401Unauthorized,
                "pipeline-error-mistral-403-model-access-denied" => CallEndedReason.PipelineErrorMistral403ModelAccessDenied,
                "pipeline-error-mistral-429-exceeded-quota" => CallEndedReason.PipelineErrorMistral429ExceededQuota,
                "pipeline-error-mistral-500-server-error" => CallEndedReason.PipelineErrorMistral500ServerError,
                "pipeline-error-mistral-503-server-overloaded-error" => CallEndedReason.PipelineErrorMistral503ServerOverloadedError,
                "pipeline-error-mistral-llm-failed" => CallEndedReason.PipelineErrorMistralLlmFailed,
                "pipeline-error-neuphonic-voice-failed" => CallEndedReason.PipelineErrorNeuphonicVoiceFailed,
                "pipeline-error-openai-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorOpenai400BadRequestValidationFailed,
                "pipeline-error-openai-401-account-not-in-organization" => CallEndedReason.PipelineErrorOpenai401AccountNotInOrganization,
                "pipeline-error-openai-401-incorrect-api-key" => CallEndedReason.PipelineErrorOpenai401IncorrectApiKey,
                "pipeline-error-openai-401-unauthorized" => CallEndedReason.PipelineErrorOpenai401Unauthorized,
                "pipeline-error-openai-403-model-access-denied" => CallEndedReason.PipelineErrorOpenai403ModelAccessDenied,
                "pipeline-error-openai-429-exceeded-quota" => CallEndedReason.PipelineErrorOpenai429ExceededQuota,
                "pipeline-error-openai-429-rate-limit-reached" => CallEndedReason.PipelineErrorOpenai429RateLimitReached,
                "pipeline-error-openai-500-server-error" => CallEndedReason.PipelineErrorOpenai500ServerError,
                "pipeline-error-openai-503-server-overloaded-error" => CallEndedReason.PipelineErrorOpenai503ServerOverloadedError,
                "pipeline-error-openai-llm-failed" => CallEndedReason.PipelineErrorOpenaiLlmFailed,
                "pipeline-error-openai-transcriber-failed" => CallEndedReason.PipelineErrorOpenaiTranscriberFailed,
                "pipeline-error-openai-voice-failed" => CallEndedReason.PipelineErrorOpenaiVoiceFailed,
                "pipeline-error-openrouter-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorOpenrouter400BadRequestValidationFailed,
                "pipeline-error-openrouter-401-unauthorized" => CallEndedReason.PipelineErrorOpenrouter401Unauthorized,
                "pipeline-error-openrouter-403-model-access-denied" => CallEndedReason.PipelineErrorOpenrouter403ModelAccessDenied,
                "pipeline-error-openrouter-429-exceeded-quota" => CallEndedReason.PipelineErrorOpenrouter429ExceededQuota,
                "pipeline-error-openrouter-500-server-error" => CallEndedReason.PipelineErrorOpenrouter500ServerError,
                "pipeline-error-openrouter-503-server-overloaded-error" => CallEndedReason.PipelineErrorOpenrouter503ServerOverloadedError,
                "pipeline-error-openrouter-llm-failed" => CallEndedReason.PipelineErrorOpenrouterLlmFailed,
                "pipeline-error-perplexity-ai-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorPerplexityAi400BadRequestValidationFailed,
                "pipeline-error-perplexity-ai-401-unauthorized" => CallEndedReason.PipelineErrorPerplexityAi401Unauthorized,
                "pipeline-error-perplexity-ai-403-model-access-denied" => CallEndedReason.PipelineErrorPerplexityAi403ModelAccessDenied,
                "pipeline-error-perplexity-ai-429-exceeded-quota" => CallEndedReason.PipelineErrorPerplexityAi429ExceededQuota,
                "pipeline-error-perplexity-ai-500-server-error" => CallEndedReason.PipelineErrorPerplexityAi500ServerError,
                "pipeline-error-perplexity-ai-503-server-overloaded-error" => CallEndedReason.PipelineErrorPerplexityAi503ServerOverloadedError,
                "pipeline-error-perplexity-ai-llm-failed" => CallEndedReason.PipelineErrorPerplexityAiLlmFailed,
                "pipeline-error-playht-401-unauthorized" => CallEndedReason.PipelineErrorPlayht401Unauthorized,
                "pipeline-error-playht-403-forbidden-api-access-not-available" => CallEndedReason.PipelineErrorPlayht403ForbiddenApiAccessNotAvailable,
                "pipeline-error-playht-403-forbidden-out-of-characters" => CallEndedReason.PipelineErrorPlayht403ForbiddenOutOfCharacters,
                "pipeline-error-playht-429-exceeded-quota" => CallEndedReason.PipelineErrorPlayht429ExceededQuota,
                "pipeline-error-playht-502-gateway-error" => CallEndedReason.PipelineErrorPlayht502GatewayError,
                "pipeline-error-playht-504-gateway-error" => CallEndedReason.PipelineErrorPlayht504GatewayError,
                "pipeline-error-playht-invalid-emotion" => CallEndedReason.PipelineErrorPlayhtInvalidEmotion,
                "pipeline-error-playht-invalid-voice" => CallEndedReason.PipelineErrorPlayhtInvalidVoice,
                "pipeline-error-playht-out-of-credits" => CallEndedReason.PipelineErrorPlayhtOutOfCredits,
                "pipeline-error-playht-request-timed-out" => CallEndedReason.PipelineErrorPlayhtRequestTimedOut,
                "pipeline-error-playht-unexpected-error" => CallEndedReason.PipelineErrorPlayhtUnexpectedError,
                "pipeline-error-playht-voice-failed" => CallEndedReason.PipelineErrorPlayhtVoiceFailed,
                "pipeline-error-playht-voice-must-be-a-valid-voice-manifest-uri" => CallEndedReason.PipelineErrorPlayhtVoiceMustBeAValidVoiceManifestUri,
                "pipeline-error-rime-ai-voice-failed" => CallEndedReason.PipelineErrorRimeAiVoiceFailed,
                "pipeline-error-runpod-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorRunpod400BadRequestValidationFailed,
                "pipeline-error-runpod-401-unauthorized" => CallEndedReason.PipelineErrorRunpod401Unauthorized,
                "pipeline-error-runpod-403-model-access-denied" => CallEndedReason.PipelineErrorRunpod403ModelAccessDenied,
                "pipeline-error-runpod-429-exceeded-quota" => CallEndedReason.PipelineErrorRunpod429ExceededQuota,
                "pipeline-error-runpod-500-server-error" => CallEndedReason.PipelineErrorRunpod500ServerError,
                "pipeline-error-runpod-503-server-overloaded-error" => CallEndedReason.PipelineErrorRunpod503ServerOverloadedError,
                "pipeline-error-runpod-llm-failed" => CallEndedReason.PipelineErrorRunpodLlmFailed,
                "pipeline-error-sesame-voice-failed" => CallEndedReason.PipelineErrorSesameVoiceFailed,
                "pipeline-error-smallest-ai-voice-failed" => CallEndedReason.PipelineErrorSmallestAiVoiceFailed,
                "pipeline-error-soniox-transcriber-auth-failed" => CallEndedReason.PipelineErrorSonioxTranscriberAuthFailed,
                "pipeline-error-soniox-transcriber-failed" => CallEndedReason.PipelineErrorSonioxTranscriberFailed,
                "pipeline-error-soniox-transcriber-invalid-config" => CallEndedReason.PipelineErrorSonioxTranscriberInvalidConfig,
                "pipeline-error-soniox-transcriber-rate-limited" => CallEndedReason.PipelineErrorSonioxTranscriberRateLimited,
                "pipeline-error-soniox-transcriber-server-error" => CallEndedReason.PipelineErrorSonioxTranscriberServerError,
                "pipeline-error-speechmatics-transcriber-failed" => CallEndedReason.PipelineErrorSpeechmaticsTranscriberFailed,
                "pipeline-error-talkscriber-transcriber-failed" => CallEndedReason.PipelineErrorTalkscriberTranscriberFailed,
                "pipeline-error-tavus-video-failed" => CallEndedReason.PipelineErrorTavusVideoFailed,
                "pipeline-error-together-ai-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorTogetherAi400BadRequestValidationFailed,
                "pipeline-error-together-ai-401-unauthorized" => CallEndedReason.PipelineErrorTogetherAi401Unauthorized,
                "pipeline-error-together-ai-403-model-access-denied" => CallEndedReason.PipelineErrorTogetherAi403ModelAccessDenied,
                "pipeline-error-together-ai-429-exceeded-quota" => CallEndedReason.PipelineErrorTogetherAi429ExceededQuota,
                "pipeline-error-together-ai-500-server-error" => CallEndedReason.PipelineErrorTogetherAi500ServerError,
                "pipeline-error-together-ai-503-server-overloaded-error" => CallEndedReason.PipelineErrorTogetherAi503ServerOverloadedError,
                "pipeline-error-together-ai-llm-failed" => CallEndedReason.PipelineErrorTogetherAiLlmFailed,
                "pipeline-error-vapi-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorVapi400BadRequestValidationFailed,
                "pipeline-error-vapi-401-unauthorized" => CallEndedReason.PipelineErrorVapi401Unauthorized,
                "pipeline-error-vapi-403-model-access-denied" => CallEndedReason.PipelineErrorVapi403ModelAccessDenied,
                "pipeline-error-vapi-429-exceeded-quota" => CallEndedReason.PipelineErrorVapi429ExceededQuota,
                "pipeline-error-vapi-500-server-error" => CallEndedReason.PipelineErrorVapi500ServerError,
                "pipeline-error-vapi-503-server-overloaded-error" => CallEndedReason.PipelineErrorVapi503ServerOverloadedError,
                "pipeline-error-vapi-llm-failed" => CallEndedReason.PipelineErrorVapiLlmFailed,
                "pipeline-error-vapi-voice-failed" => CallEndedReason.PipelineErrorVapiVoiceFailed,
                "pipeline-error-wellsaid-voice-failed" => CallEndedReason.PipelineErrorWellsaidVoiceFailed,
                "pipeline-error-xai-400-bad-request-validation-failed" => CallEndedReason.PipelineErrorXai400BadRequestValidationFailed,
                "pipeline-error-xai-401-unauthorized" => CallEndedReason.PipelineErrorXai401Unauthorized,
                "pipeline-error-xai-403-model-access-denied" => CallEndedReason.PipelineErrorXai403ModelAccessDenied,
                "pipeline-error-xai-429-exceeded-quota" => CallEndedReason.PipelineErrorXai429ExceededQuota,
                "pipeline-error-xai-500-server-error" => CallEndedReason.PipelineErrorXai500ServerError,
                "pipeline-error-xai-503-server-overloaded-error" => CallEndedReason.PipelineErrorXai503ServerOverloadedError,
                "pipeline-error-xai-llm-failed" => CallEndedReason.PipelineErrorXaiLlmFailed,
                "scheduled-call-deleted" => CallEndedReason.ScheduledCallDeleted,
                "silence-timed-out" => CallEndedReason.SilenceTimedOut,
                "twilio-failed-to-connect-call" => CallEndedReason.TwilioFailedToConnectCall,
                "twilio-reported-customer-misdialed" => CallEndedReason.TwilioReportedCustomerMisdialed,
                "voicemail" => CallEndedReason.Voicemail,
                "vonage-completed" => CallEndedReason.VonageCompleted,
                "vonage-disconnected" => CallEndedReason.VonageDisconnected,
                "vonage-failed-to-connect-call" => CallEndedReason.VonageFailedToConnectCall,
                "vonage-rejected" => CallEndedReason.VonageRejected,
                "worker-shutdown" => CallEndedReason.WorkerShutdown,
                _ => null,
            };
        }
    }
}