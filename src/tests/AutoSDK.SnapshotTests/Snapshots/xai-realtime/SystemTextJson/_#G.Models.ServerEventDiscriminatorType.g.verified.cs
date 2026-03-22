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
        ConversationItemAdded,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
        InputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        McpListToolsCompleted,
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
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallFailed,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioTranscriptDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
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
                ServerEventDiscriminatorType.ConversationItemAdded => "conversation.item.added",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                ServerEventDiscriminatorType.InputAudioTranscriptionCompleted => "input_audio_transcription.completed",
                ServerEventDiscriminatorType.McpListToolsCompleted => "mcp_list_tools.completed",
                ServerEventDiscriminatorType.ResponseCreated => "response.created",
                ServerEventDiscriminatorType.ResponseDone => "response.done",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ServerEventDiscriminatorType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                ServerEventDiscriminatorType.ResponseMcpCallFailed => "response.mcp_call.failed",
                ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                ServerEventDiscriminatorType.ResponseOutputAudioDelta => "response.output_audio.delta",
                ServerEventDiscriminatorType.ResponseOutputAudioDone => "response.output_audio.done",
                ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                ServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
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
                "conversation.item.added" => ServerEventDiscriminatorType.ConversationItemAdded,
                "error" => ServerEventDiscriminatorType.Error,
                "input_audio_buffer.committed" => ServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.speech_started" => ServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => ServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "input_audio_transcription.completed" => ServerEventDiscriminatorType.InputAudioTranscriptionCompleted,
                "mcp_list_tools.completed" => ServerEventDiscriminatorType.McpListToolsCompleted,
                "response.created" => ServerEventDiscriminatorType.ResponseCreated,
                "response.done" => ServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.done" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.mcp_call.completed" => ServerEventDiscriminatorType.ResponseMcpCallCompleted,
                "response.mcp_call.failed" => ServerEventDiscriminatorType.ResponseMcpCallFailed,
                "response.mcp_call_arguments.done" => ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone,
                "response.output_audio.delta" => ServerEventDiscriminatorType.ResponseOutputAudioDelta,
                "response.output_audio.done" => ServerEventDiscriminatorType.ResponseOutputAudioDone,
                "response.output_audio_transcript.delta" => ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta,
                "response.output_audio_transcript.done" => ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone,
                "response.output_item.added" => ServerEventDiscriminatorType.ResponseOutputItemAdded,
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "session.updated" => ServerEventDiscriminatorType.SessionUpdated,
                _ => null,
            };
        }
    }
}