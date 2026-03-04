//HintName: G.Models.ResponseStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseStreamEvent : global::System.IEquatable<ResponseStreamEvent>
    {
        /// <summary>
        /// Emitted when there is a partial audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioDeltaEvent? ResponseAudioDelta { get; init; }
#else
        public global::G.ResponseAudioDeltaEvent? ResponseAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDelta))]
#endif
        public bool IsResponseAudioDelta => ResponseAudioDelta != null;

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioDoneEvent? ResponseAudioDone { get; init; }
#else
        public global::G.ResponseAudioDoneEvent? ResponseAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDone))]
#endif
        public bool IsResponseAudioDone => ResponseAudioDone != null;

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::G.ResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDelta))]
#endif
        public bool IsResponseAudioTranscriptDelta => ResponseAudioTranscriptDelta != null;

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; init; }
#else
        public global::G.ResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDone))]
#endif
        public bool IsResponseAudioTranscriptDone => ResponseAudioTranscriptDone != null;

        /// <summary>
        /// Emitted when a partial code snippet is added by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDelta))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDelta => ResponseCodeInterpreterCallCodeDelta != null;

        /// <summary>
        /// Emitted when code snippet output is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDone))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDone => ResponseCodeInterpreterCallCodeDone != null;

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCompleted))]
#endif
        public bool IsResponseCodeInterpreterCallCompleted => ResponseCodeInterpreterCallCompleted != null;

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInProgress))]
#endif
        public bool IsResponseCodeInterpreterCallInProgress => ResponseCodeInterpreterCallInProgress != null;

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInterpreting))]
#endif
        public bool IsResponseCodeInterpreterCallInterpreting => ResponseCodeInterpreterCallInterpreting != null;

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCompletedEvent? ResponseCompleted { get; init; }
#else
        public global::G.ResponseCompletedEvent? ResponseCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCompleted))]
#endif
        public bool IsResponseCompleted => ResponseCompleted != null;

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentPartAddedEvent? ResponseContentPartAdded { get; init; }
#else
        public global::G.ResponseContentPartAddedEvent? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentPartDoneEvent? ResponseContentPartDone { get; init; }
#else
        public global::G.ResponseContentPartDoneEvent? ResponseContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCreatedEvent? ResponseCreated { get; init; }
#else
        public global::G.ResponseCreatedEvent? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// Emitted when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseErrorEvent? Error { get; init; }
#else
        public global::G.ResponseErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; init; }
#else
        public global::G.ResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallCompleted))]
#endif
        public bool IsResponseFileSearchCallCompleted => ResponseFileSearchCallCompleted != null;

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; init; }
#else
        public global::G.ResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallInProgress))]
#endif
        public bool IsResponseFileSearchCallInProgress => ResponseFileSearchCallInProgress != null;

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; init; }
#else
        public global::G.ResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallSearching))]
#endif
        public bool IsResponseFileSearchCallSearching => ResponseFileSearchCallSearching != null;

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::G.ResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::G.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseInProgressEvent? ResponseInProgress { get; init; }
#else
        public global::G.ResponseInProgressEvent? ResponseInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInProgress))]
#endif
        public bool IsResponseInProgress => ResponseInProgress != null;

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFailedEvent? ResponseFailed { get; init; }
#else
        public global::G.ResponseFailedEvent? ResponseFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFailed))]
#endif
        public bool IsResponseFailed => ResponseFailed != null;

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseIncompleteEvent? ResponseIncomplete { get; init; }
#else
        public global::G.ResponseIncompleteEvent? ResponseIncomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseIncomplete))]
#endif
        public bool IsResponseIncomplete => ResponseIncomplete != null;

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; init; }
#else
        public global::G.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputItemDoneEvent? ResponseOutputItemDone { get; init; }
#else
        public global::G.ResponseOutputItemDoneEvent? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; init; }
#else
        public global::G.ResponseReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartAdded))]
#endif
        public bool IsResponseReasoningSummaryPartAdded => ResponseReasoningSummaryPartAdded != null;

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; init; }
#else
        public global::G.ResponseReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartDone))]
#endif
        public bool IsResponseReasoningSummaryPartDone => ResponseReasoningSummaryPartDone != null;

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; init; }
#else
        public global::G.ResponseReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextDelta))]
#endif
        public bool IsResponseReasoningSummaryTextDelta => ResponseReasoningSummaryTextDelta != null;

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; init; }
#else
        public global::G.ResponseReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextDone))]
#endif
        public bool IsResponseReasoningSummaryTextDone => ResponseReasoningSummaryTextDone != null;

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseRefusalDeltaEvent? ResponseRefusalDelta { get; init; }
#else
        public global::G.ResponseRefusalDeltaEvent? ResponseRefusalDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDelta))]
#endif
        public bool IsResponseRefusalDelta => ResponseRefusalDelta != null;

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseRefusalDoneEvent? ResponseRefusalDone { get; init; }
#else
        public global::G.ResponseRefusalDoneEvent? ResponseRefusalDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDone))]
#endif
        public bool IsResponseRefusalDone => ResponseRefusalDone != null;

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextDeltaEvent? ResponseOutputTextDelta { get; init; }
#else
        public global::G.ResponseTextDeltaEvent? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextDoneEvent? ResponseOutputTextDone { get; init; }
#else
        public global::G.ResponseTextDoneEvent? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; init; }
#else
        public global::G.ResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallCompleted))]
#endif
        public bool IsResponseWebSearchCallCompleted => ResponseWebSearchCallCompleted != null;

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; init; }
#else
        public global::G.ResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallInProgress))]
#endif
        public bool IsResponseWebSearchCallInProgress => ResponseWebSearchCallInProgress != null;

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; init; }
#else
        public global::G.ResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallSearching))]
#endif
        public bool IsResponseWebSearchCallSearching => ResponseWebSearchCallSearching != null;

        /// <summary>
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; init; }
#else
        public global::G.ResponseImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallCompleted))]
#endif
        public bool IsResponseImageGenerationCallCompleted => ResponseImageGenerationCallCompleted != null;

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; init; }
#else
        public global::G.ResponseImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallGenerating))]
#endif
        public bool IsResponseImageGenerationCallGenerating => ResponseImageGenerationCallGenerating != null;

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; init; }
#else
        public global::G.ResponseImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallInProgress))]
#endif
        public bool IsResponseImageGenerationCallInProgress => ResponseImageGenerationCallInProgress != null;

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; init; }
#else
        public global::G.ResponseImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallPartialImage))]
#endif
        public bool IsResponseImageGenerationCallPartialImage => ResponseImageGenerationCallPartialImage != null;

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallArgumentsDeltaEvent? ResponseMcpCallArgumentsDelta { get; init; }
#else
        public global::G.ResponseMCPCallArgumentsDeltaEvent? ResponseMcpCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDelta))]
#endif
        public bool IsResponseMcpCallArgumentsDelta => ResponseMcpCallArgumentsDelta != null;

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::G.ResponseMCPCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDone))]
#endif
        public bool IsResponseMcpCallArgumentsDone => ResponseMcpCallArgumentsDone != null;

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallCompletedEvent? ResponseMcpCallCompleted { get; init; }
#else
        public global::G.ResponseMCPCallCompletedEvent? ResponseMcpCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallCompleted))]
#endif
        public bool IsResponseMcpCallCompleted => ResponseMcpCallCompleted != null;

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallFailedEvent? ResponseMcpCallFailed { get; init; }
#else
        public global::G.ResponseMCPCallFailedEvent? ResponseMcpCallFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallFailed))]
#endif
        public bool IsResponseMcpCallFailed => ResponseMcpCallFailed != null;

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallInProgressEvent? ResponseMcpCallInProgress { get; init; }
#else
        public global::G.ResponseMCPCallInProgressEvent? ResponseMcpCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallInProgress))]
#endif
        public bool IsResponseMcpCallInProgress => ResponseMcpCallInProgress != null;

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPListToolsCompletedEvent? ResponseMcpListToolsCompleted { get; init; }
#else
        public global::G.ResponseMCPListToolsCompletedEvent? ResponseMcpListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsCompleted))]
#endif
        public bool IsResponseMcpListToolsCompleted => ResponseMcpListToolsCompleted != null;

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPListToolsFailedEvent? ResponseMcpListToolsFailed { get; init; }
#else
        public global::G.ResponseMCPListToolsFailedEvent? ResponseMcpListToolsFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsFailed))]
#endif
        public bool IsResponseMcpListToolsFailed => ResponseMcpListToolsFailed != null;

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPListToolsInProgressEvent? ResponseMcpListToolsInProgress { get; init; }
#else
        public global::G.ResponseMCPListToolsInProgressEvent? ResponseMcpListToolsInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsInProgress))]
#endif
        public bool IsResponseMcpListToolsInProgress => ResponseMcpListToolsInProgress != null;

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputTextAnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; init; }
#else
        public global::G.ResponseOutputTextAnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextAnnotationAdded))]
#endif
        public bool IsResponseOutputTextAnnotationAdded => ResponseOutputTextAnnotationAdded != null;

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseQueuedEvent? ResponseQueued { get; init; }
#else
        public global::G.ResponseQueuedEvent? ResponseQueued { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseQueued))]
#endif
        public bool IsResponseQueued => ResponseQueued != null;

        /// <summary>
        /// Emitted when there is a delta (partial update) to the reasoning content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningDeltaEvent? ResponseReasoningDelta { get; init; }
#else
        public global::G.ResponseReasoningDeltaEvent? ResponseReasoningDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningDelta))]
#endif
        public bool IsResponseReasoningDelta => ResponseReasoningDelta != null;

        /// <summary>
        /// Emitted when the reasoning content is finalized for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningDoneEvent? ResponseReasoningDone { get; init; }
#else
        public global::G.ResponseReasoningDoneEvent? ResponseReasoningDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningDone))]
#endif
        public bool IsResponseReasoningDone => ResponseReasoningDone != null;

        /// <summary>
        /// Emitted when there is a delta (partial update) to the reasoning summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryDeltaEvent? ResponseReasoningSummaryDelta { get; init; }
#else
        public global::G.ResponseReasoningSummaryDeltaEvent? ResponseReasoningSummaryDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryDelta))]
#endif
        public bool IsResponseReasoningSummaryDelta => ResponseReasoningSummaryDelta != null;

        /// <summary>
        /// Emitted when the reasoning summary content is finalized for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryDoneEvent? ResponseReasoningSummaryDone { get; init; }
#else
        public global::G.ResponseReasoningSummaryDoneEvent? ResponseReasoningSummaryDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryDone))]
#endif
        public bool IsResponseReasoningSummaryDone => ResponseReasoningSummaryDone != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioDeltaEvent? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioDoneEvent value) => new ResponseStreamEvent((global::G.ResponseAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioDoneEvent?(ResponseStreamEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioDoneEvent? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioTranscriptDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseAudioTranscriptDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioTranscriptDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioTranscriptDeltaEvent? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioTranscriptDoneEvent value) => new ResponseStreamEvent((global::G.ResponseAudioTranscriptDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioTranscriptDoneEvent?(ResponseStreamEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioTranscriptDoneEvent? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallCodeDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallCodeDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            ResponseCodeInterpreterCallCodeDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDoneEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallCodeDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallCodeDoneEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            ResponseCodeInterpreterCallCodeDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            ResponseCodeInterpreterCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            ResponseCodeInterpreterCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInterpretingEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallInterpretingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallInterpretingEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInterpreting;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            ResponseCodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCompletedEvent? value)
        {
            ResponseCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseContentPartAddedEvent value) => new ResponseStreamEvent((global::G.ResponseContentPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentPartAddedEvent?(ResponseStreamEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseContentPartAddedEvent? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseContentPartDoneEvent value) => new ResponseStreamEvent((global::G.ResponseContentPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentPartDoneEvent?(ResponseStreamEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseContentPartDoneEvent? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCreatedEvent value) => new ResponseStreamEvent((global::G.ResponseCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCreatedEvent?(ResponseStreamEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseErrorEvent value) => new ResponseStreamEvent((global::G.ResponseErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseErrorEvent?(ResponseStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFileSearchCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseFileSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFileSearchCallCompletedEvent? value)
        {
            ResponseFileSearchCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFileSearchCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseFileSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFileSearchCallInProgressEvent? value)
        {
            ResponseFileSearchCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFileSearchCallSearchingEvent value) => new ResponseStreamEvent((global::G.ResponseFileSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFileSearchCallSearchingEvent? value)
        {
            ResponseFileSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseFunctionCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::G.ResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseInProgressEvent? value)
        {
            ResponseInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFailedEvent value) => new ResponseStreamEvent((global::G.ResponseFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFailedEvent?(ResponseStreamEvent @this) => @this.ResponseFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFailedEvent? value)
        {
            ResponseFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseIncompleteEvent value) => new ResponseStreamEvent((global::G.ResponseIncompleteEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseIncompleteEvent?(ResponseStreamEvent @this) => @this.ResponseIncomplete;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseIncompleteEvent? value)
        {
            ResponseIncomplete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseOutputItemAddedEvent value) => new ResponseStreamEvent((global::G.ResponseOutputItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemAddedEvent?(ResponseStreamEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseOutputItemAddedEvent? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseOutputItemDoneEvent value) => new ResponseStreamEvent((global::G.ResponseOutputItemDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemDoneEvent?(ResponseStreamEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseOutputItemDoneEvent? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryPartAddedEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryPartAddedEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryPartAddedEvent? value)
        {
            ResponseReasoningSummaryPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryPartDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryPartDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryPartDoneEvent? value)
        {
            ResponseReasoningSummaryPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryTextDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDeltaEvent? value)
        {
            ResponseReasoningSummaryTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryTextDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDoneEvent? value)
        {
            ResponseReasoningSummaryTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseRefusalDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseRefusalDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseRefusalDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseRefusalDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseRefusalDeltaEvent? value)
        {
            ResponseRefusalDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseRefusalDoneEvent value) => new ResponseStreamEvent((global::G.ResponseRefusalDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseRefusalDoneEvent?(ResponseStreamEvent @this) => @this.ResponseRefusalDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseRefusalDoneEvent? value)
        {
            ResponseRefusalDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseTextDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseTextDeltaEvent? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseTextDoneEvent value) => new ResponseStreamEvent((global::G.ResponseTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextDoneEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseTextDoneEvent? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseWebSearchCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseWebSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseWebSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseWebSearchCallCompletedEvent? value)
        {
            ResponseWebSearchCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseWebSearchCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseWebSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseWebSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseWebSearchCallInProgressEvent? value)
        {
            ResponseWebSearchCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseWebSearchCallSearchingEvent value) => new ResponseStreamEvent((global::G.ResponseWebSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseWebSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseWebSearchCallSearchingEvent? value)
        {
            ResponseWebSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallCompletedEvent? value)
        {
            ResponseImageGenerationCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallGeneratingEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallGeneratingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallGeneratingEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallGenerating;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallGeneratingEvent? value)
        {
            ResponseImageGenerationCallGenerating = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallInProgressEvent? value)
        {
            ResponseImageGenerationCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallPartialImageEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallPartialImageEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallPartialImage;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallPartialImageEvent? value)
        {
            ResponseImageGenerationCallPartialImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDeltaEvent? value)
        {
            ResponseMcpCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDoneEvent? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallCompletedEvent? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallFailedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallFailedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallFailedEvent? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallInProgressEvent? value)
        {
            ResponseMcpCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPListToolsCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPListToolsCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPListToolsCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPListToolsCompletedEvent? value)
        {
            ResponseMcpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPListToolsFailedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPListToolsFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPListToolsFailedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPListToolsFailedEvent? value)
        {
            ResponseMcpListToolsFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPListToolsInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseMCPListToolsInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPListToolsInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseMcpListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPListToolsInProgressEvent? value)
        {
            ResponseMcpListToolsInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseOutputTextAnnotationAddedEvent value) => new ResponseStreamEvent((global::G.ResponseOutputTextAnnotationAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputTextAnnotationAddedEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextAnnotationAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseOutputTextAnnotationAddedEvent? value)
        {
            ResponseOutputTextAnnotationAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseQueuedEvent value) => new ResponseStreamEvent((global::G.ResponseQueuedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseQueuedEvent?(ResponseStreamEvent @this) => @this.ResponseQueued;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseQueuedEvent? value)
        {
            ResponseQueued = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningDeltaEvent? value)
        {
            ResponseReasoningDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningDoneEvent? value)
        {
            ResponseReasoningDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryDeltaEvent? value)
        {
            ResponseReasoningSummaryDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryDoneEvent? value)
        {
            ResponseReasoningSummaryDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(
            global::G.ResponseAudioDeltaEvent? responseAudioDelta,
            global::G.ResponseAudioDoneEvent? responseAudioDone,
            global::G.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta,
            global::G.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone,
            global::G.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta,
            global::G.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone,
            global::G.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted,
            global::G.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress,
            global::G.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting,
            global::G.ResponseCompletedEvent? responseCompleted,
            global::G.ResponseContentPartAddedEvent? responseContentPartAdded,
            global::G.ResponseContentPartDoneEvent? responseContentPartDone,
            global::G.ResponseCreatedEvent? responseCreated,
            global::G.ResponseErrorEvent? error,
            global::G.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted,
            global::G.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress,
            global::G.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching,
            global::G.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta,
            global::G.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone,
            global::G.ResponseInProgressEvent? responseInProgress,
            global::G.ResponseFailedEvent? responseFailed,
            global::G.ResponseIncompleteEvent? responseIncomplete,
            global::G.ResponseOutputItemAddedEvent? responseOutputItemAdded,
            global::G.ResponseOutputItemDoneEvent? responseOutputItemDone,
            global::G.ResponseReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded,
            global::G.ResponseReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone,
            global::G.ResponseReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta,
            global::G.ResponseReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone,
            global::G.ResponseRefusalDeltaEvent? responseRefusalDelta,
            global::G.ResponseRefusalDoneEvent? responseRefusalDone,
            global::G.ResponseTextDeltaEvent? responseOutputTextDelta,
            global::G.ResponseTextDoneEvent? responseOutputTextDone,
            global::G.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted,
            global::G.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress,
            global::G.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching,
            global::G.ResponseImageGenCallCompletedEvent? responseImageGenerationCallCompleted,
            global::G.ResponseImageGenCallGeneratingEvent? responseImageGenerationCallGenerating,
            global::G.ResponseImageGenCallInProgressEvent? responseImageGenerationCallInProgress,
            global::G.ResponseImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage,
            global::G.ResponseMCPCallArgumentsDeltaEvent? responseMcpCallArgumentsDelta,
            global::G.ResponseMCPCallArgumentsDoneEvent? responseMcpCallArgumentsDone,
            global::G.ResponseMCPCallCompletedEvent? responseMcpCallCompleted,
            global::G.ResponseMCPCallFailedEvent? responseMcpCallFailed,
            global::G.ResponseMCPCallInProgressEvent? responseMcpCallInProgress,
            global::G.ResponseMCPListToolsCompletedEvent? responseMcpListToolsCompleted,
            global::G.ResponseMCPListToolsFailedEvent? responseMcpListToolsFailed,
            global::G.ResponseMCPListToolsInProgressEvent? responseMcpListToolsInProgress,
            global::G.ResponseOutputTextAnnotationAddedEvent? responseOutputTextAnnotationAdded,
            global::G.ResponseQueuedEvent? responseQueued,
            global::G.ResponseReasoningDeltaEvent? responseReasoningDelta,
            global::G.ResponseReasoningDoneEvent? responseReasoningDone,
            global::G.ResponseReasoningSummaryDeltaEvent? responseReasoningSummaryDelta,
            global::G.ResponseReasoningSummaryDoneEvent? responseReasoningSummaryDone
            )
        {
            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseCodeInterpreterCallCodeDelta = responseCodeInterpreterCallCodeDelta;
            ResponseCodeInterpreterCallCodeDone = responseCodeInterpreterCallCodeDone;
            ResponseCodeInterpreterCallCompleted = responseCodeInterpreterCallCompleted;
            ResponseCodeInterpreterCallInProgress = responseCodeInterpreterCallInProgress;
            ResponseCodeInterpreterCallInterpreting = responseCodeInterpreterCallInterpreting;
            ResponseCompleted = responseCompleted;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseCreated = responseCreated;
            Error = error;
            ResponseFileSearchCallCompleted = responseFileSearchCallCompleted;
            ResponseFileSearchCallInProgress = responseFileSearchCallInProgress;
            ResponseFileSearchCallSearching = responseFileSearchCallSearching;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseInProgress = responseInProgress;
            ResponseFailed = responseFailed;
            ResponseIncomplete = responseIncomplete;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseReasoningSummaryPartAdded = responseReasoningSummaryPartAdded;
            ResponseReasoningSummaryPartDone = responseReasoningSummaryPartDone;
            ResponseReasoningSummaryTextDelta = responseReasoningSummaryTextDelta;
            ResponseReasoningSummaryTextDone = responseReasoningSummaryTextDone;
            ResponseRefusalDelta = responseRefusalDelta;
            ResponseRefusalDone = responseRefusalDone;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            ResponseWebSearchCallCompleted = responseWebSearchCallCompleted;
            ResponseWebSearchCallInProgress = responseWebSearchCallInProgress;
            ResponseWebSearchCallSearching = responseWebSearchCallSearching;
            ResponseImageGenerationCallCompleted = responseImageGenerationCallCompleted;
            ResponseImageGenerationCallGenerating = responseImageGenerationCallGenerating;
            ResponseImageGenerationCallInProgress = responseImageGenerationCallInProgress;
            ResponseImageGenerationCallPartialImage = responseImageGenerationCallPartialImage;
            ResponseMcpCallArgumentsDelta = responseMcpCallArgumentsDelta;
            ResponseMcpCallArgumentsDone = responseMcpCallArgumentsDone;
            ResponseMcpCallCompleted = responseMcpCallCompleted;
            ResponseMcpCallFailed = responseMcpCallFailed;
            ResponseMcpCallInProgress = responseMcpCallInProgress;
            ResponseMcpListToolsCompleted = responseMcpListToolsCompleted;
            ResponseMcpListToolsFailed = responseMcpListToolsFailed;
            ResponseMcpListToolsInProgress = responseMcpListToolsInProgress;
            ResponseOutputTextAnnotationAdded = responseOutputTextAnnotationAdded;
            ResponseQueued = responseQueued;
            ResponseReasoningDelta = responseReasoningDelta;
            ResponseReasoningDone = responseReasoningDone;
            ResponseReasoningSummaryDelta = responseReasoningSummaryDelta;
            ResponseReasoningSummaryDone = responseReasoningSummaryDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseReasoningSummaryDone as object ??
            ResponseReasoningSummaryDelta as object ??
            ResponseReasoningDone as object ??
            ResponseReasoningDelta as object ??
            ResponseQueued as object ??
            ResponseOutputTextAnnotationAdded as object ??
            ResponseMcpListToolsInProgress as object ??
            ResponseMcpListToolsFailed as object ??
            ResponseMcpListToolsCompleted as object ??
            ResponseMcpCallInProgress as object ??
            ResponseMcpCallFailed as object ??
            ResponseMcpCallCompleted as object ??
            ResponseMcpCallArgumentsDone as object ??
            ResponseMcpCallArgumentsDelta as object ??
            ResponseImageGenerationCallPartialImage as object ??
            ResponseImageGenerationCallInProgress as object ??
            ResponseImageGenerationCallGenerating as object ??
            ResponseImageGenerationCallCompleted as object ??
            ResponseWebSearchCallSearching as object ??
            ResponseWebSearchCallInProgress as object ??
            ResponseWebSearchCallCompleted as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseRefusalDone as object ??
            ResponseRefusalDelta as object ??
            ResponseReasoningSummaryTextDone as object ??
            ResponseReasoningSummaryTextDelta as object ??
            ResponseReasoningSummaryPartDone as object ??
            ResponseReasoningSummaryPartAdded as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseIncomplete as object ??
            ResponseFailed as object ??
            ResponseInProgress as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseFileSearchCallSearching as object ??
            ResponseFileSearchCallInProgress as object ??
            ResponseFileSearchCallCompleted as object ??
            Error as object ??
            ResponseCreated as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseCompleted as object ??
            ResponseCodeInterpreterCallInterpreting as object ??
            ResponseCodeInterpreterCallInProgress as object ??
            ResponseCodeInterpreterCallCompleted as object ??
            ResponseCodeInterpreterCallCodeDone as object ??
            ResponseCodeInterpreterCallCodeDelta as object ??
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString() ??
            ResponseCodeInterpreterCallCodeDelta?.ToString() ??
            ResponseCodeInterpreterCallCodeDone?.ToString() ??
            ResponseCodeInterpreterCallCompleted?.ToString() ??
            ResponseCodeInterpreterCallInProgress?.ToString() ??
            ResponseCodeInterpreterCallInterpreting?.ToString() ??
            ResponseCompleted?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseCreated?.ToString() ??
            Error?.ToString() ??
            ResponseFileSearchCallCompleted?.ToString() ??
            ResponseFileSearchCallInProgress?.ToString() ??
            ResponseFileSearchCallSearching?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseInProgress?.ToString() ??
            ResponseFailed?.ToString() ??
            ResponseIncomplete?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseReasoningSummaryPartAdded?.ToString() ??
            ResponseReasoningSummaryPartDone?.ToString() ??
            ResponseReasoningSummaryTextDelta?.ToString() ??
            ResponseReasoningSummaryTextDone?.ToString() ??
            ResponseRefusalDelta?.ToString() ??
            ResponseRefusalDone?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            ResponseWebSearchCallCompleted?.ToString() ??
            ResponseWebSearchCallInProgress?.ToString() ??
            ResponseWebSearchCallSearching?.ToString() ??
            ResponseImageGenerationCallCompleted?.ToString() ??
            ResponseImageGenerationCallGenerating?.ToString() ??
            ResponseImageGenerationCallInProgress?.ToString() ??
            ResponseImageGenerationCallPartialImage?.ToString() ??
            ResponseMcpCallArgumentsDelta?.ToString() ??
            ResponseMcpCallArgumentsDone?.ToString() ??
            ResponseMcpCallCompleted?.ToString() ??
            ResponseMcpCallFailed?.ToString() ??
            ResponseMcpCallInProgress?.ToString() ??
            ResponseMcpListToolsCompleted?.ToString() ??
            ResponseMcpListToolsFailed?.ToString() ??
            ResponseMcpListToolsInProgress?.ToString() ??
            ResponseOutputTextAnnotationAdded?.ToString() ??
            ResponseQueued?.ToString() ??
            ResponseReasoningDelta?.ToString() ??
            ResponseReasoningDone?.ToString() ??
            ResponseReasoningSummaryDelta?.ToString() ??
            ResponseReasoningSummaryDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseAudioDelta || IsResponseAudioDone || IsResponseAudioTranscriptDelta || IsResponseAudioTranscriptDone || IsResponseCodeInterpreterCallCodeDelta || IsResponseCodeInterpreterCallCodeDone || IsResponseCodeInterpreterCallCompleted || IsResponseCodeInterpreterCallInProgress || IsResponseCodeInterpreterCallInterpreting || IsResponseCompleted || IsResponseContentPartAdded || IsResponseContentPartDone || IsResponseCreated || IsError || IsResponseFileSearchCallCompleted || IsResponseFileSearchCallInProgress || IsResponseFileSearchCallSearching || IsResponseFunctionCallArgumentsDelta || IsResponseFunctionCallArgumentsDone || IsResponseInProgress || IsResponseFailed || IsResponseIncomplete || IsResponseOutputItemAdded || IsResponseOutputItemDone || IsResponseReasoningSummaryPartAdded || IsResponseReasoningSummaryPartDone || IsResponseReasoningSummaryTextDelta || IsResponseReasoningSummaryTextDone || IsResponseRefusalDelta || IsResponseRefusalDone || IsResponseOutputTextDelta || IsResponseOutputTextDone || IsResponseWebSearchCallCompleted || IsResponseWebSearchCallInProgress || IsResponseWebSearchCallSearching || IsResponseImageGenerationCallCompleted || IsResponseImageGenerationCallGenerating || IsResponseImageGenerationCallInProgress || IsResponseImageGenerationCallPartialImage || IsResponseMcpCallArgumentsDelta || IsResponseMcpCallArgumentsDone || IsResponseMcpCallCompleted || IsResponseMcpCallFailed || IsResponseMcpCallInProgress || IsResponseMcpListToolsCompleted || IsResponseMcpListToolsFailed || IsResponseMcpListToolsInProgress || IsResponseOutputTextAnnotationAdded || IsResponseQueued || IsResponseReasoningDelta || IsResponseReasoningDone || IsResponseReasoningSummaryDelta || IsResponseReasoningSummaryDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseAudioDeltaEvent?, TResult>? responseAudioDelta = null,
            global::System.Func<global::G.ResponseAudioDoneEvent?, TResult>? responseAudioDone = null,
            global::System.Func<global::G.ResponseAudioTranscriptDeltaEvent?, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::G.ResponseAudioTranscriptDoneEvent?, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?, TResult>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallCodeDoneEvent?, TResult>? responseCodeInterpreterCallCodeDone = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallCompletedEvent?, TResult>? responseCodeInterpreterCallCompleted = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallInProgressEvent?, TResult>? responseCodeInterpreterCallInProgress = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallInterpretingEvent?, TResult>? responseCodeInterpreterCallInterpreting = null,
            global::System.Func<global::G.ResponseCompletedEvent?, TResult>? responseCompleted = null,
            global::System.Func<global::G.ResponseContentPartAddedEvent?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::G.ResponseContentPartDoneEvent?, TResult>? responseContentPartDone = null,
            global::System.Func<global::G.ResponseCreatedEvent?, TResult>? responseCreated = null,
            global::System.Func<global::G.ResponseErrorEvent?, TResult>? error = null,
            global::System.Func<global::G.ResponseFileSearchCallCompletedEvent?, TResult>? responseFileSearchCallCompleted = null,
            global::System.Func<global::G.ResponseFileSearchCallInProgressEvent?, TResult>? responseFileSearchCallInProgress = null,
            global::System.Func<global::G.ResponseFileSearchCallSearchingEvent?, TResult>? responseFileSearchCallSearching = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDeltaEvent?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDoneEvent?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::G.ResponseInProgressEvent?, TResult>? responseInProgress = null,
            global::System.Func<global::G.ResponseFailedEvent?, TResult>? responseFailed = null,
            global::System.Func<global::G.ResponseIncompleteEvent?, TResult>? responseIncomplete = null,
            global::System.Func<global::G.ResponseOutputItemAddedEvent?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::G.ResponseOutputItemDoneEvent?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::G.ResponseReasoningSummaryPartAddedEvent?, TResult>? responseReasoningSummaryPartAdded = null,
            global::System.Func<global::G.ResponseReasoningSummaryPartDoneEvent?, TResult>? responseReasoningSummaryPartDone = null,
            global::System.Func<global::G.ResponseReasoningSummaryTextDeltaEvent?, TResult>? responseReasoningSummaryTextDelta = null,
            global::System.Func<global::G.ResponseReasoningSummaryTextDoneEvent?, TResult>? responseReasoningSummaryTextDone = null,
            global::System.Func<global::G.ResponseRefusalDeltaEvent?, TResult>? responseRefusalDelta = null,
            global::System.Func<global::G.ResponseRefusalDoneEvent?, TResult>? responseRefusalDone = null,
            global::System.Func<global::G.ResponseTextDeltaEvent?, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::G.ResponseTextDoneEvent?, TResult>? responseOutputTextDone = null,
            global::System.Func<global::G.ResponseWebSearchCallCompletedEvent?, TResult>? responseWebSearchCallCompleted = null,
            global::System.Func<global::G.ResponseWebSearchCallInProgressEvent?, TResult>? responseWebSearchCallInProgress = null,
            global::System.Func<global::G.ResponseWebSearchCallSearchingEvent?, TResult>? responseWebSearchCallSearching = null,
            global::System.Func<global::G.ResponseImageGenCallCompletedEvent?, TResult>? responseImageGenerationCallCompleted = null,
            global::System.Func<global::G.ResponseImageGenCallGeneratingEvent?, TResult>? responseImageGenerationCallGenerating = null,
            global::System.Func<global::G.ResponseImageGenCallInProgressEvent?, TResult>? responseImageGenerationCallInProgress = null,
            global::System.Func<global::G.ResponseImageGenCallPartialImageEvent?, TResult>? responseImageGenerationCallPartialImage = null,
            global::System.Func<global::G.ResponseMCPCallArgumentsDeltaEvent?, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::G.ResponseMCPCallArgumentsDoneEvent?, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::G.ResponseMCPCallCompletedEvent?, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::G.ResponseMCPCallFailedEvent?, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::G.ResponseMCPCallInProgressEvent?, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::G.ResponseMCPListToolsCompletedEvent?, TResult>? responseMcpListToolsCompleted = null,
            global::System.Func<global::G.ResponseMCPListToolsFailedEvent?, TResult>? responseMcpListToolsFailed = null,
            global::System.Func<global::G.ResponseMCPListToolsInProgressEvent?, TResult>? responseMcpListToolsInProgress = null,
            global::System.Func<global::G.ResponseOutputTextAnnotationAddedEvent?, TResult>? responseOutputTextAnnotationAdded = null,
            global::System.Func<global::G.ResponseQueuedEvent?, TResult>? responseQueued = null,
            global::System.Func<global::G.ResponseReasoningDeltaEvent?, TResult>? responseReasoningDelta = null,
            global::System.Func<global::G.ResponseReasoningDoneEvent?, TResult>? responseReasoningDone = null,
            global::System.Func<global::G.ResponseReasoningSummaryDeltaEvent?, TResult>? responseReasoningSummaryDelta = null,
            global::System.Func<global::G.ResponseReasoningSummaryDoneEvent?, TResult>? responseReasoningSummaryDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta && responseAudioDelta != null)
            {
                return responseAudioDelta(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone && responseAudioDone != null)
            {
                return responseAudioDone(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta && responseCodeInterpreterCallCodeDelta != null)
            {
                return responseCodeInterpreterCallCodeDelta(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone && responseCodeInterpreterCallCodeDone != null)
            {
                return responseCodeInterpreterCallCodeDone(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted && responseCodeInterpreterCallCompleted != null)
            {
                return responseCodeInterpreterCallCompleted(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress && responseCodeInterpreterCallInProgress != null)
            {
                return responseCodeInterpreterCallInProgress(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting && responseCodeInterpreterCallInterpreting != null)
            {
                return responseCodeInterpreterCallInterpreting(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted && responseCompleted != null)
            {
                return responseCompleted(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded && responseContentPartAdded != null)
            {
                return responseContentPartAdded(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone && responseContentPartDone != null)
            {
                return responseContentPartDone(ResponseContentPartDone!);
            }
            else if (IsResponseCreated && responseCreated != null)
            {
                return responseCreated(ResponseCreated!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsResponseFileSearchCallCompleted && responseFileSearchCallCompleted != null)
            {
                return responseFileSearchCallCompleted(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress && responseFileSearchCallInProgress != null)
            {
                return responseFileSearchCallInProgress(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching && responseFileSearchCallSearching != null)
            {
                return responseFileSearchCallSearching(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress && responseInProgress != null)
            {
                return responseInProgress(ResponseInProgress!);
            }
            else if (IsResponseFailed && responseFailed != null)
            {
                return responseFailed(ResponseFailed!);
            }
            else if (IsResponseIncomplete && responseIncomplete != null)
            {
                return responseIncomplete(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseReasoningSummaryPartAdded && responseReasoningSummaryPartAdded != null)
            {
                return responseReasoningSummaryPartAdded(ResponseReasoningSummaryPartAdded!);
            }
            else if (IsResponseReasoningSummaryPartDone && responseReasoningSummaryPartDone != null)
            {
                return responseReasoningSummaryPartDone(ResponseReasoningSummaryPartDone!);
            }
            else if (IsResponseReasoningSummaryTextDelta && responseReasoningSummaryTextDelta != null)
            {
                return responseReasoningSummaryTextDelta(ResponseReasoningSummaryTextDelta!);
            }
            else if (IsResponseReasoningSummaryTextDone && responseReasoningSummaryTextDone != null)
            {
                return responseReasoningSummaryTextDone(ResponseReasoningSummaryTextDone!);
            }
            else if (IsResponseRefusalDelta && responseRefusalDelta != null)
            {
                return responseRefusalDelta(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone && responseRefusalDone != null)
            {
                return responseRefusalDone(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextDelta && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone && responseOutputTextDone != null)
            {
                return responseOutputTextDone(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted && responseWebSearchCallCompleted != null)
            {
                return responseWebSearchCallCompleted(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress && responseWebSearchCallInProgress != null)
            {
                return responseWebSearchCallInProgress(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching && responseWebSearchCallSearching != null)
            {
                return responseWebSearchCallSearching(ResponseWebSearchCallSearching!);
            }
            else if (IsResponseImageGenerationCallCompleted && responseImageGenerationCallCompleted != null)
            {
                return responseImageGenerationCallCompleted(ResponseImageGenerationCallCompleted!);
            }
            else if (IsResponseImageGenerationCallGenerating && responseImageGenerationCallGenerating != null)
            {
                return responseImageGenerationCallGenerating(ResponseImageGenerationCallGenerating!);
            }
            else if (IsResponseImageGenerationCallInProgress && responseImageGenerationCallInProgress != null)
            {
                return responseImageGenerationCallInProgress(ResponseImageGenerationCallInProgress!);
            }
            else if (IsResponseImageGenerationCallPartialImage && responseImageGenerationCallPartialImage != null)
            {
                return responseImageGenerationCallPartialImage(ResponseImageGenerationCallPartialImage!);
            }
            else if (IsResponseMcpCallArgumentsDelta && responseMcpCallArgumentsDelta != null)
            {
                return responseMcpCallArgumentsDelta(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone && responseMcpCallArgumentsDone != null)
            {
                return responseMcpCallArgumentsDone(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted && responseMcpCallCompleted != null)
            {
                return responseMcpCallCompleted(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed && responseMcpCallFailed != null)
            {
                return responseMcpCallFailed(ResponseMcpCallFailed!);
            }
            else if (IsResponseMcpCallInProgress && responseMcpCallInProgress != null)
            {
                return responseMcpCallInProgress(ResponseMcpCallInProgress!);
            }
            else if (IsResponseMcpListToolsCompleted && responseMcpListToolsCompleted != null)
            {
                return responseMcpListToolsCompleted(ResponseMcpListToolsCompleted!);
            }
            else if (IsResponseMcpListToolsFailed && responseMcpListToolsFailed != null)
            {
                return responseMcpListToolsFailed(ResponseMcpListToolsFailed!);
            }
            else if (IsResponseMcpListToolsInProgress && responseMcpListToolsInProgress != null)
            {
                return responseMcpListToolsInProgress(ResponseMcpListToolsInProgress!);
            }
            else if (IsResponseOutputTextAnnotationAdded && responseOutputTextAnnotationAdded != null)
            {
                return responseOutputTextAnnotationAdded(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseQueued && responseQueued != null)
            {
                return responseQueued(ResponseQueued!);
            }
            else if (IsResponseReasoningDelta && responseReasoningDelta != null)
            {
                return responseReasoningDelta(ResponseReasoningDelta!);
            }
            else if (IsResponseReasoningDone && responseReasoningDone != null)
            {
                return responseReasoningDone(ResponseReasoningDone!);
            }
            else if (IsResponseReasoningSummaryDelta && responseReasoningSummaryDelta != null)
            {
                return responseReasoningSummaryDelta(ResponseReasoningSummaryDelta!);
            }
            else if (IsResponseReasoningSummaryDone && responseReasoningSummaryDone != null)
            {
                return responseReasoningSummaryDone(ResponseReasoningSummaryDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseAudioDeltaEvent?>? responseAudioDelta = null,
            global::System.Action<global::G.ResponseAudioDoneEvent?>? responseAudioDone = null,
            global::System.Action<global::G.ResponseAudioTranscriptDeltaEvent?>? responseAudioTranscriptDelta = null,
            global::System.Action<global::G.ResponseAudioTranscriptDoneEvent?>? responseAudioTranscriptDone = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallCodeDoneEvent?>? responseCodeInterpreterCallCodeDone = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallCompletedEvent?>? responseCodeInterpreterCallCompleted = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallInProgressEvent?>? responseCodeInterpreterCallInProgress = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallInterpretingEvent?>? responseCodeInterpreterCallInterpreting = null,
            global::System.Action<global::G.ResponseCompletedEvent?>? responseCompleted = null,
            global::System.Action<global::G.ResponseContentPartAddedEvent?>? responseContentPartAdded = null,
            global::System.Action<global::G.ResponseContentPartDoneEvent?>? responseContentPartDone = null,
            global::System.Action<global::G.ResponseCreatedEvent?>? responseCreated = null,
            global::System.Action<global::G.ResponseErrorEvent?>? error = null,
            global::System.Action<global::G.ResponseFileSearchCallCompletedEvent?>? responseFileSearchCallCompleted = null,
            global::System.Action<global::G.ResponseFileSearchCallInProgressEvent?>? responseFileSearchCallInProgress = null,
            global::System.Action<global::G.ResponseFileSearchCallSearchingEvent?>? responseFileSearchCallSearching = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDeltaEvent?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDoneEvent?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::G.ResponseInProgressEvent?>? responseInProgress = null,
            global::System.Action<global::G.ResponseFailedEvent?>? responseFailed = null,
            global::System.Action<global::G.ResponseIncompleteEvent?>? responseIncomplete = null,
            global::System.Action<global::G.ResponseOutputItemAddedEvent?>? responseOutputItemAdded = null,
            global::System.Action<global::G.ResponseOutputItemDoneEvent?>? responseOutputItemDone = null,
            global::System.Action<global::G.ResponseReasoningSummaryPartAddedEvent?>? responseReasoningSummaryPartAdded = null,
            global::System.Action<global::G.ResponseReasoningSummaryPartDoneEvent?>? responseReasoningSummaryPartDone = null,
            global::System.Action<global::G.ResponseReasoningSummaryTextDeltaEvent?>? responseReasoningSummaryTextDelta = null,
            global::System.Action<global::G.ResponseReasoningSummaryTextDoneEvent?>? responseReasoningSummaryTextDone = null,
            global::System.Action<global::G.ResponseRefusalDeltaEvent?>? responseRefusalDelta = null,
            global::System.Action<global::G.ResponseRefusalDoneEvent?>? responseRefusalDone = null,
            global::System.Action<global::G.ResponseTextDeltaEvent?>? responseOutputTextDelta = null,
            global::System.Action<global::G.ResponseTextDoneEvent?>? responseOutputTextDone = null,
            global::System.Action<global::G.ResponseWebSearchCallCompletedEvent?>? responseWebSearchCallCompleted = null,
            global::System.Action<global::G.ResponseWebSearchCallInProgressEvent?>? responseWebSearchCallInProgress = null,
            global::System.Action<global::G.ResponseWebSearchCallSearchingEvent?>? responseWebSearchCallSearching = null,
            global::System.Action<global::G.ResponseImageGenCallCompletedEvent?>? responseImageGenerationCallCompleted = null,
            global::System.Action<global::G.ResponseImageGenCallGeneratingEvent?>? responseImageGenerationCallGenerating = null,
            global::System.Action<global::G.ResponseImageGenCallInProgressEvent?>? responseImageGenerationCallInProgress = null,
            global::System.Action<global::G.ResponseImageGenCallPartialImageEvent?>? responseImageGenerationCallPartialImage = null,
            global::System.Action<global::G.ResponseMCPCallArgumentsDeltaEvent?>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::G.ResponseMCPCallArgumentsDoneEvent?>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::G.ResponseMCPCallCompletedEvent?>? responseMcpCallCompleted = null,
            global::System.Action<global::G.ResponseMCPCallFailedEvent?>? responseMcpCallFailed = null,
            global::System.Action<global::G.ResponseMCPCallInProgressEvent?>? responseMcpCallInProgress = null,
            global::System.Action<global::G.ResponseMCPListToolsCompletedEvent?>? responseMcpListToolsCompleted = null,
            global::System.Action<global::G.ResponseMCPListToolsFailedEvent?>? responseMcpListToolsFailed = null,
            global::System.Action<global::G.ResponseMCPListToolsInProgressEvent?>? responseMcpListToolsInProgress = null,
            global::System.Action<global::G.ResponseOutputTextAnnotationAddedEvent?>? responseOutputTextAnnotationAdded = null,
            global::System.Action<global::G.ResponseQueuedEvent?>? responseQueued = null,
            global::System.Action<global::G.ResponseReasoningDeltaEvent?>? responseReasoningDelta = null,
            global::System.Action<global::G.ResponseReasoningDoneEvent?>? responseReasoningDone = null,
            global::System.Action<global::G.ResponseReasoningSummaryDeltaEvent?>? responseReasoningSummaryDelta = null,
            global::System.Action<global::G.ResponseReasoningSummaryDoneEvent?>? responseReasoningSummaryDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta)
            {
                responseAudioDelta?.Invoke(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone)
            {
                responseAudioDone?.Invoke(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta)
            {
                responseAudioTranscriptDelta?.Invoke(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone)
            {
                responseAudioTranscriptDone?.Invoke(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted)
            {
                responseCodeInterpreterCallCompleted?.Invoke(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress)
            {
                responseCodeInterpreterCallInProgress?.Invoke(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted)
            {
                responseCompleted?.Invoke(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded)
            {
                responseContentPartAdded?.Invoke(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone)
            {
                responseContentPartDone?.Invoke(ResponseContentPartDone!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsResponseFileSearchCallCompleted)
            {
                responseFileSearchCallCompleted?.Invoke(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress)
            {
                responseFileSearchCallInProgress?.Invoke(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching)
            {
                responseFileSearchCallSearching?.Invoke(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress)
            {
                responseInProgress?.Invoke(ResponseInProgress!);
            }
            else if (IsResponseFailed)
            {
                responseFailed?.Invoke(ResponseFailed!);
            }
            else if (IsResponseIncomplete)
            {
                responseIncomplete?.Invoke(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseReasoningSummaryPartAdded)
            {
                responseReasoningSummaryPartAdded?.Invoke(ResponseReasoningSummaryPartAdded!);
            }
            else if (IsResponseReasoningSummaryPartDone)
            {
                responseReasoningSummaryPartDone?.Invoke(ResponseReasoningSummaryPartDone!);
            }
            else if (IsResponseReasoningSummaryTextDelta)
            {
                responseReasoningSummaryTextDelta?.Invoke(ResponseReasoningSummaryTextDelta!);
            }
            else if (IsResponseReasoningSummaryTextDone)
            {
                responseReasoningSummaryTextDone?.Invoke(ResponseReasoningSummaryTextDone!);
            }
            else if (IsResponseRefusalDelta)
            {
                responseRefusalDelta?.Invoke(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone)
            {
                responseRefusalDone?.Invoke(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextDelta)
            {
                responseOutputTextDelta?.Invoke(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone)
            {
                responseOutputTextDone?.Invoke(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted)
            {
                responseWebSearchCallCompleted?.Invoke(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress)
            {
                responseWebSearchCallInProgress?.Invoke(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching)
            {
                responseWebSearchCallSearching?.Invoke(ResponseWebSearchCallSearching!);
            }
            else if (IsResponseImageGenerationCallCompleted)
            {
                responseImageGenerationCallCompleted?.Invoke(ResponseImageGenerationCallCompleted!);
            }
            else if (IsResponseImageGenerationCallGenerating)
            {
                responseImageGenerationCallGenerating?.Invoke(ResponseImageGenerationCallGenerating!);
            }
            else if (IsResponseImageGenerationCallInProgress)
            {
                responseImageGenerationCallInProgress?.Invoke(ResponseImageGenerationCallInProgress!);
            }
            else if (IsResponseImageGenerationCallPartialImage)
            {
                responseImageGenerationCallPartialImage?.Invoke(ResponseImageGenerationCallPartialImage!);
            }
            else if (IsResponseMcpCallArgumentsDelta)
            {
                responseMcpCallArgumentsDelta?.Invoke(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted)
            {
                responseMcpCallCompleted?.Invoke(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed)
            {
                responseMcpCallFailed?.Invoke(ResponseMcpCallFailed!);
            }
            else if (IsResponseMcpCallInProgress)
            {
                responseMcpCallInProgress?.Invoke(ResponseMcpCallInProgress!);
            }
            else if (IsResponseMcpListToolsCompleted)
            {
                responseMcpListToolsCompleted?.Invoke(ResponseMcpListToolsCompleted!);
            }
            else if (IsResponseMcpListToolsFailed)
            {
                responseMcpListToolsFailed?.Invoke(ResponseMcpListToolsFailed!);
            }
            else if (IsResponseMcpListToolsInProgress)
            {
                responseMcpListToolsInProgress?.Invoke(ResponseMcpListToolsInProgress!);
            }
            else if (IsResponseOutputTextAnnotationAdded)
            {
                responseOutputTextAnnotationAdded?.Invoke(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseQueued)
            {
                responseQueued?.Invoke(ResponseQueued!);
            }
            else if (IsResponseReasoningDelta)
            {
                responseReasoningDelta?.Invoke(ResponseReasoningDelta!);
            }
            else if (IsResponseReasoningDone)
            {
                responseReasoningDone?.Invoke(ResponseReasoningDone!);
            }
            else if (IsResponseReasoningSummaryDelta)
            {
                responseReasoningSummaryDelta?.Invoke(ResponseReasoningSummaryDelta!);
            }
            else if (IsResponseReasoningSummaryDone)
            {
                responseReasoningSummaryDone?.Invoke(ResponseReasoningSummaryDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseAudioDelta,
                typeof(global::G.ResponseAudioDeltaEvent),
                ResponseAudioDone,
                typeof(global::G.ResponseAudioDoneEvent),
                ResponseAudioTranscriptDelta,
                typeof(global::G.ResponseAudioTranscriptDeltaEvent),
                ResponseAudioTranscriptDone,
                typeof(global::G.ResponseAudioTranscriptDoneEvent),
                ResponseCodeInterpreterCallCodeDelta,
                typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent),
                ResponseCodeInterpreterCallCodeDone,
                typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent),
                ResponseCodeInterpreterCallCompleted,
                typeof(global::G.ResponseCodeInterpreterCallCompletedEvent),
                ResponseCodeInterpreterCallInProgress,
                typeof(global::G.ResponseCodeInterpreterCallInProgressEvent),
                ResponseCodeInterpreterCallInterpreting,
                typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent),
                ResponseCompleted,
                typeof(global::G.ResponseCompletedEvent),
                ResponseContentPartAdded,
                typeof(global::G.ResponseContentPartAddedEvent),
                ResponseContentPartDone,
                typeof(global::G.ResponseContentPartDoneEvent),
                ResponseCreated,
                typeof(global::G.ResponseCreatedEvent),
                Error,
                typeof(global::G.ResponseErrorEvent),
                ResponseFileSearchCallCompleted,
                typeof(global::G.ResponseFileSearchCallCompletedEvent),
                ResponseFileSearchCallInProgress,
                typeof(global::G.ResponseFileSearchCallInProgressEvent),
                ResponseFileSearchCallSearching,
                typeof(global::G.ResponseFileSearchCallSearchingEvent),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::G.ResponseFunctionCallArgumentsDoneEvent),
                ResponseInProgress,
                typeof(global::G.ResponseInProgressEvent),
                ResponseFailed,
                typeof(global::G.ResponseFailedEvent),
                ResponseIncomplete,
                typeof(global::G.ResponseIncompleteEvent),
                ResponseOutputItemAdded,
                typeof(global::G.ResponseOutputItemAddedEvent),
                ResponseOutputItemDone,
                typeof(global::G.ResponseOutputItemDoneEvent),
                ResponseReasoningSummaryPartAdded,
                typeof(global::G.ResponseReasoningSummaryPartAddedEvent),
                ResponseReasoningSummaryPartDone,
                typeof(global::G.ResponseReasoningSummaryPartDoneEvent),
                ResponseReasoningSummaryTextDelta,
                typeof(global::G.ResponseReasoningSummaryTextDeltaEvent),
                ResponseReasoningSummaryTextDone,
                typeof(global::G.ResponseReasoningSummaryTextDoneEvent),
                ResponseRefusalDelta,
                typeof(global::G.ResponseRefusalDeltaEvent),
                ResponseRefusalDone,
                typeof(global::G.ResponseRefusalDoneEvent),
                ResponseOutputTextDelta,
                typeof(global::G.ResponseTextDeltaEvent),
                ResponseOutputTextDone,
                typeof(global::G.ResponseTextDoneEvent),
                ResponseWebSearchCallCompleted,
                typeof(global::G.ResponseWebSearchCallCompletedEvent),
                ResponseWebSearchCallInProgress,
                typeof(global::G.ResponseWebSearchCallInProgressEvent),
                ResponseWebSearchCallSearching,
                typeof(global::G.ResponseWebSearchCallSearchingEvent),
                ResponseImageGenerationCallCompleted,
                typeof(global::G.ResponseImageGenCallCompletedEvent),
                ResponseImageGenerationCallGenerating,
                typeof(global::G.ResponseImageGenCallGeneratingEvent),
                ResponseImageGenerationCallInProgress,
                typeof(global::G.ResponseImageGenCallInProgressEvent),
                ResponseImageGenerationCallPartialImage,
                typeof(global::G.ResponseImageGenCallPartialImageEvent),
                ResponseMcpCallArgumentsDelta,
                typeof(global::G.ResponseMCPCallArgumentsDeltaEvent),
                ResponseMcpCallArgumentsDone,
                typeof(global::G.ResponseMCPCallArgumentsDoneEvent),
                ResponseMcpCallCompleted,
                typeof(global::G.ResponseMCPCallCompletedEvent),
                ResponseMcpCallFailed,
                typeof(global::G.ResponseMCPCallFailedEvent),
                ResponseMcpCallInProgress,
                typeof(global::G.ResponseMCPCallInProgressEvent),
                ResponseMcpListToolsCompleted,
                typeof(global::G.ResponseMCPListToolsCompletedEvent),
                ResponseMcpListToolsFailed,
                typeof(global::G.ResponseMCPListToolsFailedEvent),
                ResponseMcpListToolsInProgress,
                typeof(global::G.ResponseMCPListToolsInProgressEvent),
                ResponseOutputTextAnnotationAdded,
                typeof(global::G.ResponseOutputTextAnnotationAddedEvent),
                ResponseQueued,
                typeof(global::G.ResponseQueuedEvent),
                ResponseReasoningDelta,
                typeof(global::G.ResponseReasoningDeltaEvent),
                ResponseReasoningDone,
                typeof(global::G.ResponseReasoningDoneEvent),
                ResponseReasoningSummaryDelta,
                typeof(global::G.ResponseReasoningSummaryDeltaEvent),
                ResponseReasoningSummaryDone,
                typeof(global::G.ResponseReasoningSummaryDoneEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioDeltaEvent?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioDoneEvent?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioTranscriptDeltaEvent?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioTranscriptDoneEvent?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDelta, other.ResponseCodeInterpreterCallCodeDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallCodeDoneEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDone, other.ResponseCodeInterpreterCallCodeDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallCompletedEvent?>.Default.Equals(ResponseCodeInterpreterCallCompleted, other.ResponseCodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallInProgressEvent?>.Default.Equals(ResponseCodeInterpreterCallInProgress, other.ResponseCodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallInterpretingEvent?>.Default.Equals(ResponseCodeInterpreterCallInterpreting, other.ResponseCodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCompletedEvent?>.Default.Equals(ResponseCompleted, other.ResponseCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentPartAddedEvent?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentPartDoneEvent?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileSearchCallCompletedEvent?>.Default.Equals(ResponseFileSearchCallCompleted, other.ResponseFileSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileSearchCallInProgressEvent?>.Default.Equals(ResponseFileSearchCallInProgress, other.ResponseFileSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileSearchCallSearchingEvent?>.Default.Equals(ResponseFileSearchCallSearching, other.ResponseFileSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDeltaEvent?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseInProgressEvent?>.Default.Equals(ResponseInProgress, other.ResponseInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFailedEvent?>.Default.Equals(ResponseFailed, other.ResponseFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseIncompleteEvent?>.Default.Equals(ResponseIncomplete, other.ResponseIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemAddedEvent?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemDoneEvent?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryPartAddedEvent?>.Default.Equals(ResponseReasoningSummaryPartAdded, other.ResponseReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryPartDoneEvent?>.Default.Equals(ResponseReasoningSummaryPartDone, other.ResponseReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryTextDeltaEvent?>.Default.Equals(ResponseReasoningSummaryTextDelta, other.ResponseReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryTextDoneEvent?>.Default.Equals(ResponseReasoningSummaryTextDone, other.ResponseReasoningSummaryTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseRefusalDeltaEvent?>.Default.Equals(ResponseRefusalDelta, other.ResponseRefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseRefusalDoneEvent?>.Default.Equals(ResponseRefusalDone, other.ResponseRefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextDeltaEvent?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextDoneEvent?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseWebSearchCallCompletedEvent?>.Default.Equals(ResponseWebSearchCallCompleted, other.ResponseWebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseWebSearchCallInProgressEvent?>.Default.Equals(ResponseWebSearchCallInProgress, other.ResponseWebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseWebSearchCallSearchingEvent?>.Default.Equals(ResponseWebSearchCallSearching, other.ResponseWebSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallCompletedEvent?>.Default.Equals(ResponseImageGenerationCallCompleted, other.ResponseImageGenerationCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallGeneratingEvent?>.Default.Equals(ResponseImageGenerationCallGenerating, other.ResponseImageGenerationCallGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallInProgressEvent?>.Default.Equals(ResponseImageGenerationCallInProgress, other.ResponseImageGenerationCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallPartialImageEvent?>.Default.Equals(ResponseImageGenerationCallPartialImage, other.ResponseImageGenerationCallPartialImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallArgumentsDeltaEvent?>.Default.Equals(ResponseMcpCallArgumentsDelta, other.ResponseMcpCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallArgumentsDoneEvent?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallCompletedEvent?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallFailedEvent?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallInProgressEvent?>.Default.Equals(ResponseMcpCallInProgress, other.ResponseMcpCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPListToolsCompletedEvent?>.Default.Equals(ResponseMcpListToolsCompleted, other.ResponseMcpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPListToolsFailedEvent?>.Default.Equals(ResponseMcpListToolsFailed, other.ResponseMcpListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPListToolsInProgressEvent?>.Default.Equals(ResponseMcpListToolsInProgress, other.ResponseMcpListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputTextAnnotationAddedEvent?>.Default.Equals(ResponseOutputTextAnnotationAdded, other.ResponseOutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseQueuedEvent?>.Default.Equals(ResponseQueued, other.ResponseQueued) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningDeltaEvent?>.Default.Equals(ResponseReasoningDelta, other.ResponseReasoningDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningDoneEvent?>.Default.Equals(ResponseReasoningDone, other.ResponseReasoningDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryDeltaEvent?>.Default.Equals(ResponseReasoningSummaryDelta, other.ResponseReasoningSummaryDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryDoneEvent?>.Default.Equals(ResponseReasoningSummaryDone, other.ResponseReasoningSummaryDone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseStreamEvent o && Equals(o);
        }
    }
}
