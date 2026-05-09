//HintName: G.Models.ResponseStreamEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.transcript.delta")]
        ResponseAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.transcript.done")]
        ResponseAudioTranscriptDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.code.delta")]
        ResponseCodeInterpreterCallCodeDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.code.done")]
        ResponseCodeInterpreterCallCodeDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.completed")]
        ResponseCodeInterpreterCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.in_progress")]
        ResponseCodeInterpreterCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.code_interpreter_call.interpreting")]
        ResponseCodeInterpreterCallInterpreting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.completed")]
        ResponseCompleted,
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
        [global::System.Runtime.Serialization.EnumMember(Value="response.created")]
        ResponseCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.failed")]
        ResponseFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.file_search_call.completed")]
        ResponseFileSearchCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.file_search_call.in_progress")]
        ResponseFileSearchCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.file_search_call.searching")]
        ResponseFileSearchCallSearching,
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
        [global::System.Runtime.Serialization.EnumMember(Value="response.in_progress")]
        ResponseInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.incomplete")]
        ResponseIncomplete,
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
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_text.annotation.added")]
        ResponseOutputTextAnnotationAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_text.delta")]
        ResponseOutputTextDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_text.done")]
        ResponseOutputTextDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.refusal.delta")]
        ResponseRefusalDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.refusal.done")]
        ResponseRefusalDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.web_search_call.completed")]
        ResponseWebSearchCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.web_search_call.in_progress")]
        ResponseWebSearchCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.web_search_call.searching")]
        ResponseWebSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamEventDiscriminatorType value)
        {
            return value switch
            {
                ResponseStreamEventDiscriminatorType.Error => "error",
                ResponseStreamEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                ResponseStreamEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio.transcript.delta",
                ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio.transcript.done",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta => "response.code_interpreter_call.code.delta",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call.code.done",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                ResponseStreamEventDiscriminatorType.ResponseCompleted => "response.completed",
                ResponseStreamEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                ResponseStreamEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                ResponseStreamEventDiscriminatorType.ResponseCreated => "response.created",
                ResponseStreamEventDiscriminatorType.ResponseFailed => "response.failed",
                ResponseStreamEventDiscriminatorType.ResponseFileSearchCallCompleted => "response.file_search_call.completed",
                ResponseStreamEventDiscriminatorType.ResponseFileSearchCallInProgress => "response.file_search_call.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseFileSearchCallSearching => "response.file_search_call.searching",
                ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ResponseStreamEventDiscriminatorType.ResponseInProgress => "response.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseIncomplete => "response.incomplete",
                ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ResponseStreamEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded => "response.output_text.annotation.added",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                ResponseStreamEventDiscriminatorType.ResponseRefusalDelta => "response.refusal.delta",
                ResponseStreamEventDiscriminatorType.ResponseRefusalDone => "response.refusal.done",
                ResponseStreamEventDiscriminatorType.ResponseWebSearchCallCompleted => "response.web_search_call.completed",
                ResponseStreamEventDiscriminatorType.ResponseWebSearchCallInProgress => "response.web_search_call.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseWebSearchCallSearching => "response.web_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ResponseStreamEventDiscriminatorType.Error,
                "response.audio.delta" => ResponseStreamEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => ResponseStreamEventDiscriminatorType.ResponseAudioDone,
                "response.audio.transcript.delta" => ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio.transcript.done" => ResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.code_interpreter_call.code.delta" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta,
                "response.code_interpreter_call.code.done" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone,
                "response.code_interpreter_call.completed" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted,
                "response.code_interpreter_call.in_progress" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress,
                "response.code_interpreter_call.interpreting" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting,
                "response.completed" => ResponseStreamEventDiscriminatorType.ResponseCompleted,
                "response.content_part.added" => ResponseStreamEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => ResponseStreamEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => ResponseStreamEventDiscriminatorType.ResponseCreated,
                "response.failed" => ResponseStreamEventDiscriminatorType.ResponseFailed,
                "response.file_search_call.completed" => ResponseStreamEventDiscriminatorType.ResponseFileSearchCallCompleted,
                "response.file_search_call.in_progress" => ResponseStreamEventDiscriminatorType.ResponseFileSearchCallInProgress,
                "response.file_search_call.searching" => ResponseStreamEventDiscriminatorType.ResponseFileSearchCallSearching,
                "response.function_call_arguments.delta" => ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.in_progress" => ResponseStreamEventDiscriminatorType.ResponseInProgress,
                "response.incomplete" => ResponseStreamEventDiscriminatorType.ResponseIncomplete,
                "response.output_item.added" => ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => ResponseStreamEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.annotation.added" => ResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded,
                "response.output_text.delta" => ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => ResponseStreamEventDiscriminatorType.ResponseOutputTextDone,
                "response.refusal.delta" => ResponseStreamEventDiscriminatorType.ResponseRefusalDelta,
                "response.refusal.done" => ResponseStreamEventDiscriminatorType.ResponseRefusalDone,
                "response.web_search_call.completed" => ResponseStreamEventDiscriminatorType.ResponseWebSearchCallCompleted,
                "response.web_search_call.in_progress" => ResponseStreamEventDiscriminatorType.ResponseWebSearchCallInProgress,
                "response.web_search_call.searching" => ResponseStreamEventDiscriminatorType.ResponseWebSearchCallSearching,
                _ => null,
            };
        }
    }
}