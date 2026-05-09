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
        ResponseCodeInterpreterCallCodeDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
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
        ResponseImageGenerationCallCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseImageGenerationCallGenerating,
        /// <summary>
        /// 
        /// </summary>
        ResponseImageGenerationCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        ResponseImageGenerationCallPartialImage,
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
        ResponseMcpCallArgumentsDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDone,
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
        ResponseMcpCallInProgress,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpListToolsCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpListToolsFailed,
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpListToolsInProgress,
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
        ResponseOutputTextDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextAnnotationAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseQueued,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryPartAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryPartDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryTextDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryTextDone,
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
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta => "response.code_interpreter_call_code.delta",
                ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call_code.done",
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
                ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallCompleted => "response.image_generation_call.completed",
                ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallGenerating => "response.image_generation_call.generating",
                ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallInProgress => "response.image_generation_call.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallPartialImage => "response.image_generation_call.partial_image",
                ResponseStreamEventDiscriminatorType.ResponseInProgress => "response.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseIncomplete => "response.incomplete",
                ResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDelta => "response.mcp_call.arguments_delta",
                ResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDone => "response.mcp_call.arguments_done",
                ResponseStreamEventDiscriminatorType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                ResponseStreamEventDiscriminatorType.ResponseMcpCallFailed => "response.mcp_call.failed",
                ResponseStreamEventDiscriminatorType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseMcpListToolsCompleted => "response.mcp_list_tools.completed",
                ResponseStreamEventDiscriminatorType.ResponseMcpListToolsFailed => "response.mcp_list_tools.failed",
                ResponseStreamEventDiscriminatorType.ResponseMcpListToolsInProgress => "response.mcp_list_tools.in_progress",
                ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ResponseStreamEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded => "response.output_text_annotation.added",
                ResponseStreamEventDiscriminatorType.ResponseQueued => "response.queued",
                ResponseStreamEventDiscriminatorType.ResponseReasoningDelta => "response.reasoning.delta",
                ResponseStreamEventDiscriminatorType.ResponseReasoningDone => "response.reasoning.done",
                ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryDelta => "response.reasoning_summary.delta",
                ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryDone => "response.reasoning_summary.done",
                ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
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
                "response.code_interpreter_call.completed" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted,
                "response.code_interpreter_call.in_progress" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress,
                "response.code_interpreter_call.interpreting" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting,
                "response.code_interpreter_call_code.delta" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta,
                "response.code_interpreter_call_code.done" => ResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone,
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
                "response.image_generation_call.completed" => ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallCompleted,
                "response.image_generation_call.generating" => ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallGenerating,
                "response.image_generation_call.in_progress" => ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallInProgress,
                "response.image_generation_call.partial_image" => ResponseStreamEventDiscriminatorType.ResponseImageGenerationCallPartialImage,
                "response.in_progress" => ResponseStreamEventDiscriminatorType.ResponseInProgress,
                "response.incomplete" => ResponseStreamEventDiscriminatorType.ResponseIncomplete,
                "response.mcp_call.arguments_delta" => ResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDelta,
                "response.mcp_call.arguments_done" => ResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDone,
                "response.mcp_call.completed" => ResponseStreamEventDiscriminatorType.ResponseMcpCallCompleted,
                "response.mcp_call.failed" => ResponseStreamEventDiscriminatorType.ResponseMcpCallFailed,
                "response.mcp_call.in_progress" => ResponseStreamEventDiscriminatorType.ResponseMcpCallInProgress,
                "response.mcp_list_tools.completed" => ResponseStreamEventDiscriminatorType.ResponseMcpListToolsCompleted,
                "response.mcp_list_tools.failed" => ResponseStreamEventDiscriminatorType.ResponseMcpListToolsFailed,
                "response.mcp_list_tools.in_progress" => ResponseStreamEventDiscriminatorType.ResponseMcpListToolsInProgress,
                "response.output_item.added" => ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => ResponseStreamEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.delta" => ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => ResponseStreamEventDiscriminatorType.ResponseOutputTextDone,
                "response.output_text_annotation.added" => ResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded,
                "response.queued" => ResponseStreamEventDiscriminatorType.ResponseQueued,
                "response.reasoning.delta" => ResponseStreamEventDiscriminatorType.ResponseReasoningDelta,
                "response.reasoning.done" => ResponseStreamEventDiscriminatorType.ResponseReasoningDone,
                "response.reasoning_summary.delta" => ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryDelta,
                "response.reasoning_summary.done" => ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryDone,
                "response.reasoning_summary_part.added" => ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartAdded,
                "response.reasoning_summary_part.done" => ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartDone,
                "response.reasoning_summary_text.delta" => ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDelta,
                "response.reasoning_summary_text.done" => ResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDone,
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