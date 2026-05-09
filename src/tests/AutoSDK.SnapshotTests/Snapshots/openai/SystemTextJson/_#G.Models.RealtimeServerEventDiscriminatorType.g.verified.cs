//HintName: G.Models.RealtimeServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionDelta,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieved,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStopped,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferStarted,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferStopped,
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
        /// <summary>
        /// 
        /// </summary>
        ResponseDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDone,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                RealtimeServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                RealtimeServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                RealtimeServerEventDiscriminatorType.ConversationItemRetrieved => "conversation.item.retrieved",
                RealtimeServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                RealtimeServerEventDiscriminatorType.Error => "error",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted => "output_audio_buffer.started",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                RealtimeServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                RealtimeServerEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                RealtimeServerEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                RealtimeServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                RealtimeServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                RealtimeServerEventDiscriminatorType.ResponseCreated => "response.created",
                RealtimeServerEventDiscriminatorType.ResponseDone => "response.done",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                RealtimeServerEventDiscriminatorType.ResponseTextDelta => "response.text.delta",
                RealtimeServerEventDiscriminatorType.ResponseTextDone => "response.text.done",
                RealtimeServerEventDiscriminatorType.SessionCreated => "session.created",
                RealtimeServerEventDiscriminatorType.SessionUpdated => "session.updated",
                RealtimeServerEventDiscriminatorType.TranscriptionSessionUpdated => "transcription_session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => RealtimeServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.created" => RealtimeServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.deleted" => RealtimeServerEventDiscriminatorType.ConversationItemDeleted,
                "conversation.item.input_audio_transcription.completed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.delta" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta,
                "conversation.item.input_audio_transcription.failed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.retrieved" => RealtimeServerEventDiscriminatorType.ConversationItemRetrieved,
                "conversation.item.truncated" => RealtimeServerEventDiscriminatorType.ConversationItemTruncated,
                "error" => RealtimeServerEventDiscriminatorType.Error,
                "input_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.committed" => RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.speech_started" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "output_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared,
                "output_audio_buffer.started" => RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted,
                "output_audio_buffer.stopped" => RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped,
                "rate_limits.updated" => RealtimeServerEventDiscriminatorType.RateLimitsUpdated,
                "response.audio.delta" => RealtimeServerEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => RealtimeServerEventDiscriminatorType.ResponseAudioDone,
                "response.audio_transcript.delta" => RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.content_part.added" => RealtimeServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => RealtimeServerEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => RealtimeServerEventDiscriminatorType.ResponseCreated,
                "response.done" => RealtimeServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.delta" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.output_item.added" => RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => RealtimeServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.text.delta" => RealtimeServerEventDiscriminatorType.ResponseTextDelta,
                "response.text.done" => RealtimeServerEventDiscriminatorType.ResponseTextDone,
                "session.created" => RealtimeServerEventDiscriminatorType.SessionCreated,
                "session.updated" => RealtimeServerEventDiscriminatorType.SessionUpdated,
                "transcription_session.updated" => RealtimeServerEventDiscriminatorType.TranscriptionSessionUpdated,
                _ => null,
            };
        }
    }
}