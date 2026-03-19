//HintName: G.Models.ServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
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
        ConversationCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCleared,
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
        ResponseCreated,
        /// <summary>
        /// 
        /// </summary>
        ResponseDone,
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
        ResponseContentPartAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
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
        ResponseAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDone,
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
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.SessionCreated => "session.created",
                ServerEventDiscriminatorType.SessionUpdated => "session.updated",
                ServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                ServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                ServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                ServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                ServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                ServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                ServerEventDiscriminatorType.ResponseCreated => "response.created",
                ServerEventDiscriminatorType.ResponseDone => "response.done",
                ServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                ServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                ServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                ServerEventDiscriminatorType.ResponseTextDelta => "response.text.delta",
                ServerEventDiscriminatorType.ResponseTextDone => "response.text.done",
                ServerEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                ServerEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                ServerEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                ServerEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ServerEventDiscriminatorType.Error,
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "session.updated" => ServerEventDiscriminatorType.SessionUpdated,
                "conversation.created" => ServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.created" => ServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.input_audio_transcription.completed" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.failed" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.truncated" => ServerEventDiscriminatorType.ConversationItemTruncated,
                "conversation.item.deleted" => ServerEventDiscriminatorType.ConversationItemDeleted,
                "input_audio_buffer.committed" => ServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.cleared" => ServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.speech_started" => ServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => ServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "response.created" => ServerEventDiscriminatorType.ResponseCreated,
                "response.done" => ServerEventDiscriminatorType.ResponseDone,
                "response.output_item.added" => ServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => ServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.content_part.added" => ServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => ServerEventDiscriminatorType.ResponseContentPartDone,
                "response.text.delta" => ServerEventDiscriminatorType.ResponseTextDelta,
                "response.text.done" => ServerEventDiscriminatorType.ResponseTextDone,
                "response.audio_transcript.delta" => ServerEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => ServerEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.audio.delta" => ServerEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => ServerEventDiscriminatorType.ResponseAudioDone,
                "response.function_call_arguments.delta" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "rate_limits.updated" => ServerEventDiscriminatorType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}