//HintName: G.Models.JSONQueryOnEventsTableOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type to query<br/>
    /// Example: assistant.model.requestFailed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnEventsTableOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.analysis.structuredOutputGenerated")]
        AssistantAnalysisStructuredOutputGenerated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.cleanup")]
        AssistantModelCleanup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.clearing")]
        AssistantModelClearing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.connectionClosed")]
        AssistantModelConnectionClosed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.connectionOpened")]
        AssistantModelConnectionOpened,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.firstTokenReceived")]
        AssistantModelFirstTokenReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.reconnecting")]
        AssistantModelReconnecting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.requestAttemptFailed")]
        AssistantModelRequestAttemptFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.requestAttemptStarted")]
        AssistantModelRequestAttemptStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.requestAttemptSucceeded")]
        AssistantModelRequestAttemptSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.requestFailed")]
        AssistantModelRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.requestStarted")]
        AssistantModelRequestStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.requestSucceeded")]
        AssistantModelRequestSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.responseFailed")]
        AssistantModelResponseFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.responseSucceeded")]
        AssistantModelResponseSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.tokenReceived")]
        AssistantModelTokenReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.model.toolCallsReceived")]
        AssistantModelToolCallsReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.tool.asyncCallbackReceived")]
        AssistantToolAsyncCallbackReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.tool.completed")]
        AssistantToolCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.tool.delayedMessageSent")]
        AssistantToolDelayedMessageSent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.tool.failed")]
        AssistantToolFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.tool.started")]
        AssistantToolStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.tool.timeout")]
        AssistantToolTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.cleanup")]
        AssistantTranscriberCleanup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.clearing")]
        AssistantTranscriberClearing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.connectionClosed")]
        AssistantTranscriberConnectionClosed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.connectionOpened")]
        AssistantTranscriberConnectionOpened,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.finalTranscript")]
        AssistantTranscriberFinalTranscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.keepAlive")]
        AssistantTranscriberKeepAlive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.languageSwitched")]
        AssistantTranscriberLanguageSwitched,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.partialTranscript")]
        AssistantTranscriberPartialTranscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.reconnecting")]
        AssistantTranscriberReconnecting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.requestFailed")]
        AssistantTranscriberRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.requestStarted")]
        AssistantTranscriberRequestStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.requestSucceeded")]
        AssistantTranscriberRequestSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.transcriber.transcriptIgnored")]
        AssistantTranscriberTranscriptIgnored,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.audioChunkReceived")]
        AssistantVoiceAudioChunkReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.cleanup")]
        AssistantVoiceCleanup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.clearing")]
        AssistantVoiceClearing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.connectionClosed")]
        AssistantVoiceConnectionClosed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.connectionOpened")]
        AssistantVoiceConnectionOpened,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.firstAudioReceived")]
        AssistantVoiceFirstAudioReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.generationFailed")]
        AssistantVoiceGenerationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.generationSucceeded")]
        AssistantVoiceGenerationSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.reconnecting")]
        AssistantVoiceReconnecting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.requestFailed")]
        AssistantVoiceRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.requestStarted")]
        AssistantVoiceRequestStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.requestSucceeded")]
        AssistantVoiceRequestSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.textPushed")]
        AssistantVoiceTextPushed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.voice.voiceSwitched")]
        AssistantVoiceVoiceSwitched,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.amdDetected")]
        CallAmdDetected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.assistantStarted")]
        CallAssistantStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.assistantSwapped")]
        CallAssistantSwapped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.controlReceived")]
        CallControlReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.customerJoined")]
        CallCustomerJoined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.customerLeft")]
        CallCustomerLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.dtmfReceived")]
        CallDtmfReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.dtmfSent")]
        CallDtmfSent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ended")]
        CallEnded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.handoffCompleted")]
        CallHandoffCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.handoffFailed")]
        CallHandoffFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.handoffInitiated")]
        CallHandoffInitiated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.hookFailed")]
        CallHookFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.hookSucceeded")]
        CallHookSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.hookTriggered")]
        CallHookTriggered,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.inProgress")]
        CallInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.listenStarted")]
        CallListenStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.maxDurationReached")]
        CallMaxDurationReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.microphoneTimeout")]
        CallMicrophoneTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.queued")]
        CallQueued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.recordingPaused")]
        CallRecordingPaused,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.recordingResumed")]
        CallRecordingResumed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.recordingStarted")]
        CallRecordingStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.silenceTimeout")]
        CallSilenceTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.started")]
        CallStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.statusReceived")]
        CallStatusReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transferCancelled")]
        CallTransferCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transferCompleted")]
        CallTransferCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transferFailed")]
        CallTransferFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transferInitiated")]
        CallTransferInitiated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transportConnected")]
        CallTransportConnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transportDisconnected")]
        CallTransportDisconnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.transportReconnected")]
        CallTransportReconnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.voicemailDetected")]
        CallVoicemailDetected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.voicemailNotDetected")]
        CallVoicemailNotDetected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.botSpeechStarted")]
        PipelineBotSpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.botSpeechStopped")]
        PipelineBotSpeechStopped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.cleared")]
        PipelineCleared,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.endpointingTriggered")]
        PipelineEndpointingTriggered,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.firstMessageCompleted")]
        PipelineFirstMessageCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.firstMessageStarted")]
        PipelineFirstMessageStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.turnStarted")]
        PipelineTurnStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.userSpeechStarted")]
        PipelineUserSpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline.userSpeechStopped")]
        PipelineUserSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnEventsTableOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnEventsTableOn value)
        {
            return value switch
            {
                JSONQueryOnEventsTableOn.AssistantAnalysisStructuredOutputGenerated => "assistant.analysis.structuredOutputGenerated",
                JSONQueryOnEventsTableOn.AssistantModelCleanup => "assistant.model.cleanup",
                JSONQueryOnEventsTableOn.AssistantModelClearing => "assistant.model.clearing",
                JSONQueryOnEventsTableOn.AssistantModelConnectionClosed => "assistant.model.connectionClosed",
                JSONQueryOnEventsTableOn.AssistantModelConnectionOpened => "assistant.model.connectionOpened",
                JSONQueryOnEventsTableOn.AssistantModelFirstTokenReceived => "assistant.model.firstTokenReceived",
                JSONQueryOnEventsTableOn.AssistantModelReconnecting => "assistant.model.reconnecting",
                JSONQueryOnEventsTableOn.AssistantModelRequestAttemptFailed => "assistant.model.requestAttemptFailed",
                JSONQueryOnEventsTableOn.AssistantModelRequestAttemptStarted => "assistant.model.requestAttemptStarted",
                JSONQueryOnEventsTableOn.AssistantModelRequestAttemptSucceeded => "assistant.model.requestAttemptSucceeded",
                JSONQueryOnEventsTableOn.AssistantModelRequestFailed => "assistant.model.requestFailed",
                JSONQueryOnEventsTableOn.AssistantModelRequestStarted => "assistant.model.requestStarted",
                JSONQueryOnEventsTableOn.AssistantModelRequestSucceeded => "assistant.model.requestSucceeded",
                JSONQueryOnEventsTableOn.AssistantModelResponseFailed => "assistant.model.responseFailed",
                JSONQueryOnEventsTableOn.AssistantModelResponseSucceeded => "assistant.model.responseSucceeded",
                JSONQueryOnEventsTableOn.AssistantModelTokenReceived => "assistant.model.tokenReceived",
                JSONQueryOnEventsTableOn.AssistantModelToolCallsReceived => "assistant.model.toolCallsReceived",
                JSONQueryOnEventsTableOn.AssistantToolAsyncCallbackReceived => "assistant.tool.asyncCallbackReceived",
                JSONQueryOnEventsTableOn.AssistantToolCompleted => "assistant.tool.completed",
                JSONQueryOnEventsTableOn.AssistantToolDelayedMessageSent => "assistant.tool.delayedMessageSent",
                JSONQueryOnEventsTableOn.AssistantToolFailed => "assistant.tool.failed",
                JSONQueryOnEventsTableOn.AssistantToolStarted => "assistant.tool.started",
                JSONQueryOnEventsTableOn.AssistantToolTimeout => "assistant.tool.timeout",
                JSONQueryOnEventsTableOn.AssistantTranscriberCleanup => "assistant.transcriber.cleanup",
                JSONQueryOnEventsTableOn.AssistantTranscriberClearing => "assistant.transcriber.clearing",
                JSONQueryOnEventsTableOn.AssistantTranscriberConnectionClosed => "assistant.transcriber.connectionClosed",
                JSONQueryOnEventsTableOn.AssistantTranscriberConnectionOpened => "assistant.transcriber.connectionOpened",
                JSONQueryOnEventsTableOn.AssistantTranscriberFinalTranscript => "assistant.transcriber.finalTranscript",
                JSONQueryOnEventsTableOn.AssistantTranscriberKeepAlive => "assistant.transcriber.keepAlive",
                JSONQueryOnEventsTableOn.AssistantTranscriberLanguageSwitched => "assistant.transcriber.languageSwitched",
                JSONQueryOnEventsTableOn.AssistantTranscriberPartialTranscript => "assistant.transcriber.partialTranscript",
                JSONQueryOnEventsTableOn.AssistantTranscriberReconnecting => "assistant.transcriber.reconnecting",
                JSONQueryOnEventsTableOn.AssistantTranscriberRequestFailed => "assistant.transcriber.requestFailed",
                JSONQueryOnEventsTableOn.AssistantTranscriberRequestStarted => "assistant.transcriber.requestStarted",
                JSONQueryOnEventsTableOn.AssistantTranscriberRequestSucceeded => "assistant.transcriber.requestSucceeded",
                JSONQueryOnEventsTableOn.AssistantTranscriberTranscriptIgnored => "assistant.transcriber.transcriptIgnored",
                JSONQueryOnEventsTableOn.AssistantVoiceAudioChunkReceived => "assistant.voice.audioChunkReceived",
                JSONQueryOnEventsTableOn.AssistantVoiceCleanup => "assistant.voice.cleanup",
                JSONQueryOnEventsTableOn.AssistantVoiceClearing => "assistant.voice.clearing",
                JSONQueryOnEventsTableOn.AssistantVoiceConnectionClosed => "assistant.voice.connectionClosed",
                JSONQueryOnEventsTableOn.AssistantVoiceConnectionOpened => "assistant.voice.connectionOpened",
                JSONQueryOnEventsTableOn.AssistantVoiceFirstAudioReceived => "assistant.voice.firstAudioReceived",
                JSONQueryOnEventsTableOn.AssistantVoiceGenerationFailed => "assistant.voice.generationFailed",
                JSONQueryOnEventsTableOn.AssistantVoiceGenerationSucceeded => "assistant.voice.generationSucceeded",
                JSONQueryOnEventsTableOn.AssistantVoiceReconnecting => "assistant.voice.reconnecting",
                JSONQueryOnEventsTableOn.AssistantVoiceRequestFailed => "assistant.voice.requestFailed",
                JSONQueryOnEventsTableOn.AssistantVoiceRequestStarted => "assistant.voice.requestStarted",
                JSONQueryOnEventsTableOn.AssistantVoiceRequestSucceeded => "assistant.voice.requestSucceeded",
                JSONQueryOnEventsTableOn.AssistantVoiceTextPushed => "assistant.voice.textPushed",
                JSONQueryOnEventsTableOn.AssistantVoiceVoiceSwitched => "assistant.voice.voiceSwitched",
                JSONQueryOnEventsTableOn.CallAmdDetected => "call.amdDetected",
                JSONQueryOnEventsTableOn.CallAssistantStarted => "call.assistantStarted",
                JSONQueryOnEventsTableOn.CallAssistantSwapped => "call.assistantSwapped",
                JSONQueryOnEventsTableOn.CallControlReceived => "call.controlReceived",
                JSONQueryOnEventsTableOn.CallCustomerJoined => "call.customerJoined",
                JSONQueryOnEventsTableOn.CallCustomerLeft => "call.customerLeft",
                JSONQueryOnEventsTableOn.CallDtmfReceived => "call.dtmfReceived",
                JSONQueryOnEventsTableOn.CallDtmfSent => "call.dtmfSent",
                JSONQueryOnEventsTableOn.CallEnded => "call.ended",
                JSONQueryOnEventsTableOn.CallHandoffCompleted => "call.handoffCompleted",
                JSONQueryOnEventsTableOn.CallHandoffFailed => "call.handoffFailed",
                JSONQueryOnEventsTableOn.CallHandoffInitiated => "call.handoffInitiated",
                JSONQueryOnEventsTableOn.CallHookFailed => "call.hookFailed",
                JSONQueryOnEventsTableOn.CallHookSucceeded => "call.hookSucceeded",
                JSONQueryOnEventsTableOn.CallHookTriggered => "call.hookTriggered",
                JSONQueryOnEventsTableOn.CallInProgress => "call.inProgress",
                JSONQueryOnEventsTableOn.CallListenStarted => "call.listenStarted",
                JSONQueryOnEventsTableOn.CallMaxDurationReached => "call.maxDurationReached",
                JSONQueryOnEventsTableOn.CallMicrophoneTimeout => "call.microphoneTimeout",
                JSONQueryOnEventsTableOn.CallQueued => "call.queued",
                JSONQueryOnEventsTableOn.CallRecordingPaused => "call.recordingPaused",
                JSONQueryOnEventsTableOn.CallRecordingResumed => "call.recordingResumed",
                JSONQueryOnEventsTableOn.CallRecordingStarted => "call.recordingStarted",
                JSONQueryOnEventsTableOn.CallSilenceTimeout => "call.silenceTimeout",
                JSONQueryOnEventsTableOn.CallStarted => "call.started",
                JSONQueryOnEventsTableOn.CallStatusReceived => "call.statusReceived",
                JSONQueryOnEventsTableOn.CallTransferCancelled => "call.transferCancelled",
                JSONQueryOnEventsTableOn.CallTransferCompleted => "call.transferCompleted",
                JSONQueryOnEventsTableOn.CallTransferFailed => "call.transferFailed",
                JSONQueryOnEventsTableOn.CallTransferInitiated => "call.transferInitiated",
                JSONQueryOnEventsTableOn.CallTransportConnected => "call.transportConnected",
                JSONQueryOnEventsTableOn.CallTransportDisconnected => "call.transportDisconnected",
                JSONQueryOnEventsTableOn.CallTransportReconnected => "call.transportReconnected",
                JSONQueryOnEventsTableOn.CallVoicemailDetected => "call.voicemailDetected",
                JSONQueryOnEventsTableOn.CallVoicemailNotDetected => "call.voicemailNotDetected",
                JSONQueryOnEventsTableOn.PipelineBotSpeechStarted => "pipeline.botSpeechStarted",
                JSONQueryOnEventsTableOn.PipelineBotSpeechStopped => "pipeline.botSpeechStopped",
                JSONQueryOnEventsTableOn.PipelineCleared => "pipeline.cleared",
                JSONQueryOnEventsTableOn.PipelineEndpointingTriggered => "pipeline.endpointingTriggered",
                JSONQueryOnEventsTableOn.PipelineFirstMessageCompleted => "pipeline.firstMessageCompleted",
                JSONQueryOnEventsTableOn.PipelineFirstMessageStarted => "pipeline.firstMessageStarted",
                JSONQueryOnEventsTableOn.PipelineTurnStarted => "pipeline.turnStarted",
                JSONQueryOnEventsTableOn.PipelineUserSpeechStarted => "pipeline.userSpeechStarted",
                JSONQueryOnEventsTableOn.PipelineUserSpeechStopped => "pipeline.userSpeechStopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnEventsTableOn? ToEnum(string value)
        {
            return value switch
            {
                "assistant.analysis.structuredOutputGenerated" => JSONQueryOnEventsTableOn.AssistantAnalysisStructuredOutputGenerated,
                "assistant.model.cleanup" => JSONQueryOnEventsTableOn.AssistantModelCleanup,
                "assistant.model.clearing" => JSONQueryOnEventsTableOn.AssistantModelClearing,
                "assistant.model.connectionClosed" => JSONQueryOnEventsTableOn.AssistantModelConnectionClosed,
                "assistant.model.connectionOpened" => JSONQueryOnEventsTableOn.AssistantModelConnectionOpened,
                "assistant.model.firstTokenReceived" => JSONQueryOnEventsTableOn.AssistantModelFirstTokenReceived,
                "assistant.model.reconnecting" => JSONQueryOnEventsTableOn.AssistantModelReconnecting,
                "assistant.model.requestAttemptFailed" => JSONQueryOnEventsTableOn.AssistantModelRequestAttemptFailed,
                "assistant.model.requestAttemptStarted" => JSONQueryOnEventsTableOn.AssistantModelRequestAttemptStarted,
                "assistant.model.requestAttemptSucceeded" => JSONQueryOnEventsTableOn.AssistantModelRequestAttemptSucceeded,
                "assistant.model.requestFailed" => JSONQueryOnEventsTableOn.AssistantModelRequestFailed,
                "assistant.model.requestStarted" => JSONQueryOnEventsTableOn.AssistantModelRequestStarted,
                "assistant.model.requestSucceeded" => JSONQueryOnEventsTableOn.AssistantModelRequestSucceeded,
                "assistant.model.responseFailed" => JSONQueryOnEventsTableOn.AssistantModelResponseFailed,
                "assistant.model.responseSucceeded" => JSONQueryOnEventsTableOn.AssistantModelResponseSucceeded,
                "assistant.model.tokenReceived" => JSONQueryOnEventsTableOn.AssistantModelTokenReceived,
                "assistant.model.toolCallsReceived" => JSONQueryOnEventsTableOn.AssistantModelToolCallsReceived,
                "assistant.tool.asyncCallbackReceived" => JSONQueryOnEventsTableOn.AssistantToolAsyncCallbackReceived,
                "assistant.tool.completed" => JSONQueryOnEventsTableOn.AssistantToolCompleted,
                "assistant.tool.delayedMessageSent" => JSONQueryOnEventsTableOn.AssistantToolDelayedMessageSent,
                "assistant.tool.failed" => JSONQueryOnEventsTableOn.AssistantToolFailed,
                "assistant.tool.started" => JSONQueryOnEventsTableOn.AssistantToolStarted,
                "assistant.tool.timeout" => JSONQueryOnEventsTableOn.AssistantToolTimeout,
                "assistant.transcriber.cleanup" => JSONQueryOnEventsTableOn.AssistantTranscriberCleanup,
                "assistant.transcriber.clearing" => JSONQueryOnEventsTableOn.AssistantTranscriberClearing,
                "assistant.transcriber.connectionClosed" => JSONQueryOnEventsTableOn.AssistantTranscriberConnectionClosed,
                "assistant.transcriber.connectionOpened" => JSONQueryOnEventsTableOn.AssistantTranscriberConnectionOpened,
                "assistant.transcriber.finalTranscript" => JSONQueryOnEventsTableOn.AssistantTranscriberFinalTranscript,
                "assistant.transcriber.keepAlive" => JSONQueryOnEventsTableOn.AssistantTranscriberKeepAlive,
                "assistant.transcriber.languageSwitched" => JSONQueryOnEventsTableOn.AssistantTranscriberLanguageSwitched,
                "assistant.transcriber.partialTranscript" => JSONQueryOnEventsTableOn.AssistantTranscriberPartialTranscript,
                "assistant.transcriber.reconnecting" => JSONQueryOnEventsTableOn.AssistantTranscriberReconnecting,
                "assistant.transcriber.requestFailed" => JSONQueryOnEventsTableOn.AssistantTranscriberRequestFailed,
                "assistant.transcriber.requestStarted" => JSONQueryOnEventsTableOn.AssistantTranscriberRequestStarted,
                "assistant.transcriber.requestSucceeded" => JSONQueryOnEventsTableOn.AssistantTranscriberRequestSucceeded,
                "assistant.transcriber.transcriptIgnored" => JSONQueryOnEventsTableOn.AssistantTranscriberTranscriptIgnored,
                "assistant.voice.audioChunkReceived" => JSONQueryOnEventsTableOn.AssistantVoiceAudioChunkReceived,
                "assistant.voice.cleanup" => JSONQueryOnEventsTableOn.AssistantVoiceCleanup,
                "assistant.voice.clearing" => JSONQueryOnEventsTableOn.AssistantVoiceClearing,
                "assistant.voice.connectionClosed" => JSONQueryOnEventsTableOn.AssistantVoiceConnectionClosed,
                "assistant.voice.connectionOpened" => JSONQueryOnEventsTableOn.AssistantVoiceConnectionOpened,
                "assistant.voice.firstAudioReceived" => JSONQueryOnEventsTableOn.AssistantVoiceFirstAudioReceived,
                "assistant.voice.generationFailed" => JSONQueryOnEventsTableOn.AssistantVoiceGenerationFailed,
                "assistant.voice.generationSucceeded" => JSONQueryOnEventsTableOn.AssistantVoiceGenerationSucceeded,
                "assistant.voice.reconnecting" => JSONQueryOnEventsTableOn.AssistantVoiceReconnecting,
                "assistant.voice.requestFailed" => JSONQueryOnEventsTableOn.AssistantVoiceRequestFailed,
                "assistant.voice.requestStarted" => JSONQueryOnEventsTableOn.AssistantVoiceRequestStarted,
                "assistant.voice.requestSucceeded" => JSONQueryOnEventsTableOn.AssistantVoiceRequestSucceeded,
                "assistant.voice.textPushed" => JSONQueryOnEventsTableOn.AssistantVoiceTextPushed,
                "assistant.voice.voiceSwitched" => JSONQueryOnEventsTableOn.AssistantVoiceVoiceSwitched,
                "call.amdDetected" => JSONQueryOnEventsTableOn.CallAmdDetected,
                "call.assistantStarted" => JSONQueryOnEventsTableOn.CallAssistantStarted,
                "call.assistantSwapped" => JSONQueryOnEventsTableOn.CallAssistantSwapped,
                "call.controlReceived" => JSONQueryOnEventsTableOn.CallControlReceived,
                "call.customerJoined" => JSONQueryOnEventsTableOn.CallCustomerJoined,
                "call.customerLeft" => JSONQueryOnEventsTableOn.CallCustomerLeft,
                "call.dtmfReceived" => JSONQueryOnEventsTableOn.CallDtmfReceived,
                "call.dtmfSent" => JSONQueryOnEventsTableOn.CallDtmfSent,
                "call.ended" => JSONQueryOnEventsTableOn.CallEnded,
                "call.handoffCompleted" => JSONQueryOnEventsTableOn.CallHandoffCompleted,
                "call.handoffFailed" => JSONQueryOnEventsTableOn.CallHandoffFailed,
                "call.handoffInitiated" => JSONQueryOnEventsTableOn.CallHandoffInitiated,
                "call.hookFailed" => JSONQueryOnEventsTableOn.CallHookFailed,
                "call.hookSucceeded" => JSONQueryOnEventsTableOn.CallHookSucceeded,
                "call.hookTriggered" => JSONQueryOnEventsTableOn.CallHookTriggered,
                "call.inProgress" => JSONQueryOnEventsTableOn.CallInProgress,
                "call.listenStarted" => JSONQueryOnEventsTableOn.CallListenStarted,
                "call.maxDurationReached" => JSONQueryOnEventsTableOn.CallMaxDurationReached,
                "call.microphoneTimeout" => JSONQueryOnEventsTableOn.CallMicrophoneTimeout,
                "call.queued" => JSONQueryOnEventsTableOn.CallQueued,
                "call.recordingPaused" => JSONQueryOnEventsTableOn.CallRecordingPaused,
                "call.recordingResumed" => JSONQueryOnEventsTableOn.CallRecordingResumed,
                "call.recordingStarted" => JSONQueryOnEventsTableOn.CallRecordingStarted,
                "call.silenceTimeout" => JSONQueryOnEventsTableOn.CallSilenceTimeout,
                "call.started" => JSONQueryOnEventsTableOn.CallStarted,
                "call.statusReceived" => JSONQueryOnEventsTableOn.CallStatusReceived,
                "call.transferCancelled" => JSONQueryOnEventsTableOn.CallTransferCancelled,
                "call.transferCompleted" => JSONQueryOnEventsTableOn.CallTransferCompleted,
                "call.transferFailed" => JSONQueryOnEventsTableOn.CallTransferFailed,
                "call.transferInitiated" => JSONQueryOnEventsTableOn.CallTransferInitiated,
                "call.transportConnected" => JSONQueryOnEventsTableOn.CallTransportConnected,
                "call.transportDisconnected" => JSONQueryOnEventsTableOn.CallTransportDisconnected,
                "call.transportReconnected" => JSONQueryOnEventsTableOn.CallTransportReconnected,
                "call.voicemailDetected" => JSONQueryOnEventsTableOn.CallVoicemailDetected,
                "call.voicemailNotDetected" => JSONQueryOnEventsTableOn.CallVoicemailNotDetected,
                "pipeline.botSpeechStarted" => JSONQueryOnEventsTableOn.PipelineBotSpeechStarted,
                "pipeline.botSpeechStopped" => JSONQueryOnEventsTableOn.PipelineBotSpeechStopped,
                "pipeline.cleared" => JSONQueryOnEventsTableOn.PipelineCleared,
                "pipeline.endpointingTriggered" => JSONQueryOnEventsTableOn.PipelineEndpointingTriggered,
                "pipeline.firstMessageCompleted" => JSONQueryOnEventsTableOn.PipelineFirstMessageCompleted,
                "pipeline.firstMessageStarted" => JSONQueryOnEventsTableOn.PipelineFirstMessageStarted,
                "pipeline.turnStarted" => JSONQueryOnEventsTableOn.PipelineTurnStarted,
                "pipeline.userSpeechStarted" => JSONQueryOnEventsTableOn.PipelineUserSpeechStarted,
                "pipeline.userSpeechStopped" => JSONQueryOnEventsTableOn.PipelineUserSpeechStopped,
                _ => null,
            };
        }
    }
}