//HintName: G.Models.ServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.created")]
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.updated")]
        SessionUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.created")]
        ConversationCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.created")]
        ConversationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.completed")]
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.failed")]
        ConversationItemInputAudioTranscriptionFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.truncated")]
        ConversationItemTruncated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.deleted")]
        ConversationItemDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.committed")]
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.cleared")]
        InputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.speech_started")]
        InputAudioBufferSpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.speech_stopped")]
        InputAudioBufferSpeechStopped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.created")]
        ResponseCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.done")]
        ResponseDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_item.added")]
        ResponseOutputItemAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_item.done")]
        ResponseOutputItemDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.added")]
        ResponseContentPartAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.done")]
        ResponseContentPartDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.text.delta")]
        ResponseTextDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.text.done")]
        ResponseTextDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio_transcript.delta")]
        ResponseAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio_transcript.done")]
        ResponseAudioTranscriptDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.delta")]
        ResponseAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.done")]
        ResponseAudioDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.function_call_arguments.delta")]
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.function_call_arguments.done")]
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limits.updated")]
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