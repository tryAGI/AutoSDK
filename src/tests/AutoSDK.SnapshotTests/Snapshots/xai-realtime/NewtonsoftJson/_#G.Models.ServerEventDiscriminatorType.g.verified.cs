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
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.added")]
        ConversationItemAdded,
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
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.committed")]
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_transcription.completed")]
        InputAudioTranscriptionCompleted,
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
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_audio_transcript.delta")]
        ResponseOutputAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_audio_transcript.done")]
        ResponseOutputAudioTranscriptDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_audio.delta")]
        ResponseOutputAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_audio.done")]
        ResponseOutputAudioDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.function_call_arguments.done")]
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_call_arguments.done")]
        ResponseMcpCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_call.completed")]
        ResponseMcpCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_call.failed")]
        ResponseMcpCallFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_list_tools.completed")]
        McpListToolsCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
                ServerEventDiscriminatorType.SessionCreated => "session.created",
                ServerEventDiscriminatorType.SessionUpdated => "session.updated",
                ServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                ServerEventDiscriminatorType.ConversationItemAdded => "conversation.item.added",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                ServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                ServerEventDiscriminatorType.InputAudioTranscriptionCompleted => "input_audio_transcription.completed",
                ServerEventDiscriminatorType.ResponseCreated => "response.created",
                ServerEventDiscriminatorType.ResponseDone => "response.done",
                ServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                ServerEventDiscriminatorType.ResponseOutputAudioDelta => "response.output_audio.delta",
                ServerEventDiscriminatorType.ResponseOutputAudioDone => "response.output_audio.done",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                ServerEventDiscriminatorType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                ServerEventDiscriminatorType.ResponseMcpCallFailed => "response.mcp_call.failed",
                ServerEventDiscriminatorType.McpListToolsCompleted => "mcp_list_tools.completed",
                ServerEventDiscriminatorType.Error => "error",
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
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "session.updated" => ServerEventDiscriminatorType.SessionUpdated,
                "conversation.created" => ServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.added" => ServerEventDiscriminatorType.ConversationItemAdded,
                "input_audio_buffer.speech_started" => ServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => ServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "input_audio_buffer.committed" => ServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_transcription.completed" => ServerEventDiscriminatorType.InputAudioTranscriptionCompleted,
                "response.created" => ServerEventDiscriminatorType.ResponseCreated,
                "response.done" => ServerEventDiscriminatorType.ResponseDone,
                "response.output_item.added" => ServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_audio_transcript.delta" => ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta,
                "response.output_audio_transcript.done" => ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone,
                "response.output_audio.delta" => ServerEventDiscriminatorType.ResponseOutputAudioDelta,
                "response.output_audio.done" => ServerEventDiscriminatorType.ResponseOutputAudioDone,
                "response.function_call_arguments.done" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.mcp_call_arguments.done" => ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone,
                "response.mcp_call.completed" => ServerEventDiscriminatorType.ResponseMcpCallCompleted,
                "response.mcp_call.failed" => ServerEventDiscriminatorType.ResponseMcpCallFailed,
                "mcp_list_tools.completed" => ServerEventDiscriminatorType.McpListToolsCompleted,
                "error" => ServerEventDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}