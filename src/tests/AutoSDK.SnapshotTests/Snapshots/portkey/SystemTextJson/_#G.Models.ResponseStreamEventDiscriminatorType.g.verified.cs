//HintName: G.Models.ResponseStreamEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
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
        ResponseCodeInterpreterCallCodeDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallInterpreting,
        /// <summary>
        /// 
        /// </summary>
        ResponseCompleted,
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
        ResponseFailed,
        /// <summary>
        /// 
        /// </summary>
        ResponseFileSearchCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseFileSearchCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        ResponseFileSearchCallSearching,
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
        ResponseInProgress,
        /// <summary>
        /// 
        /// </summary>
        ResponseIncomplete,
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
        ResponseOutputTextAnnotationAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseRefusalDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseRefusalDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallInProgress,
        /// <summary>
        /// 
        /// </summary>
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