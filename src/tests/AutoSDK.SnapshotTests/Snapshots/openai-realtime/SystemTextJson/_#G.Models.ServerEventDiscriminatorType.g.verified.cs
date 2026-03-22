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
        ConversationItemInputAudioTranscriptionFailed,
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
                ServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                ServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                ServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                ServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                ServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                ServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                ServerEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                ServerEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                ServerEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                ServerEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                ServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                ServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                ServerEventDiscriminatorType.ResponseCreated => "response.created",
                ServerEventDiscriminatorType.ResponseDone => "response.done",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                ServerEventDiscriminatorType.ResponseTextDelta => "response.text.delta",
                ServerEventDiscriminatorType.ResponseTextDone => "response.text.done",
                ServerEventDiscriminatorType.SessionCreated => "session.created",
                ServerEventDiscriminatorType.SessionUpdated => "session.updated",
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
                "conversation.created" => ServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.created" => ServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.deleted" => ServerEventDiscriminatorType.ConversationItemDeleted,
                "conversation.item.input_audio_transcription.completed" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.failed" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.truncated" => ServerEventDiscriminatorType.ConversationItemTruncated,
                "error" => ServerEventDiscriminatorType.Error,
                "input_audio_buffer.cleared" => ServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.committed" => ServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.speech_started" => ServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => ServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "rate_limits.updated" => ServerEventDiscriminatorType.RateLimitsUpdated,
                "response.audio.delta" => ServerEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => ServerEventDiscriminatorType.ResponseAudioDone,
                "response.audio_transcript.delta" => ServerEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => ServerEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.content_part.added" => ServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => ServerEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => ServerEventDiscriminatorType.ResponseCreated,
                "response.done" => ServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.delta" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.output_item.added" => ServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => ServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.text.delta" => ServerEventDiscriminatorType.ResponseTextDelta,
                "response.text.done" => ServerEventDiscriminatorType.ResponseTextDone,
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "session.updated" => ServerEventDiscriminatorType.SessionUpdated,
                _ => null,
            };
        }
    }
}