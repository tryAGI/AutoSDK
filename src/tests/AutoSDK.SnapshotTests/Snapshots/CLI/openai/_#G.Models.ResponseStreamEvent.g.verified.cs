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
        public global::G.ResponseAudioDeltaEvent? AudioDelta { get; init; }
#else
        public global::G.ResponseAudioDeltaEvent? AudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDelta))]
#endif
        public bool IsAudioDelta => AudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioDeltaEvent?(ResponseStreamEvent @this) => @this.AudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioDeltaEvent? value)
        {
            AudioDelta = value;
        }

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioDoneEvent? AudioDone { get; init; }
#else
        public global::G.ResponseAudioDoneEvent? AudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDone))]
#endif
        public bool IsAudioDone => AudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioDoneEvent value) => new ResponseStreamEvent((global::G.ResponseAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioDoneEvent?(ResponseStreamEvent @this) => @this.AudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioDoneEvent? value)
        {
            AudioDone = value;
        }

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioTranscriptDeltaEvent? AudioTranscriptDelta { get; init; }
#else
        public global::G.ResponseAudioTranscriptDeltaEvent? AudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTranscriptDelta))]
#endif
        public bool IsAudioTranscriptDelta => AudioTranscriptDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioTranscriptDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseAudioTranscriptDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioTranscriptDeltaEvent?(ResponseStreamEvent @this) => @this.AudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioTranscriptDeltaEvent? value)
        {
            AudioTranscriptDelta = value;
        }

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioTranscriptDoneEvent? AudioTranscriptDone { get; init; }
#else
        public global::G.ResponseAudioTranscriptDoneEvent? AudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTranscriptDone))]
#endif
        public bool IsAudioTranscriptDone => AudioTranscriptDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseAudioTranscriptDoneEvent value) => new ResponseStreamEvent((global::G.ResponseAudioTranscriptDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioTranscriptDoneEvent?(ResponseStreamEvent @this) => @this.AudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseAudioTranscriptDoneEvent? value)
        {
            AudioTranscriptDone = value;
        }

        /// <summary>
        /// Emitted when a partial code snippet is added by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallCodeDeltaEvent? CodeInterpreterCallDelta { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallCodeDeltaEvent? CodeInterpreterCallDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallDelta))]
#endif
        public bool IsCodeInterpreterCallDelta => CodeInterpreterCallDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallCodeDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallCodeDeltaEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            CodeInterpreterCallDelta = value;
        }

        /// <summary>
        /// Emitted when code snippet output is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallCodeDoneEvent? CodeInterpreterCallDone { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallCodeDoneEvent? CodeInterpreterCallDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallDone))]
#endif
        public bool IsCodeInterpreterCallDone => CodeInterpreterCallDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDoneEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallCodeDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallCodeDoneEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            CodeInterpreterCallDone = value;
        }

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallCompletedEvent? CodeInterpreterCallCompleted { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallCompletedEvent? CodeInterpreterCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallCompleted))]
#endif
        public bool IsCodeInterpreterCallCompleted => CodeInterpreterCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallCompletedEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            CodeInterpreterCallCompleted = value;
        }

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallInProgressEvent? CodeInterpreterCallInProgress { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallInProgressEvent? CodeInterpreterCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallInProgress))]
#endif
        public bool IsCodeInterpreterCallInProgress => CodeInterpreterCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallInProgressEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            CodeInterpreterCallInProgress = value;
        }

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCodeInterpreterCallInterpretingEvent? CodeInterpreterCallInterpreting { get; init; }
#else
        public global::G.ResponseCodeInterpreterCallInterpretingEvent? CodeInterpreterCallInterpreting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallInterpreting))]
#endif
        public bool IsCodeInterpreterCallInterpreting => CodeInterpreterCallInterpreting != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInterpretingEvent value) => new ResponseStreamEvent((global::G.ResponseCodeInterpreterCallInterpretingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCodeInterpreterCallInterpretingEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallInterpreting;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            CodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCompletedEvent? Completed { get; init; }
#else
        public global::G.ResponseCompletedEvent? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCompletedEvent?(ResponseStreamEvent @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCompletedEvent? value)
        {
            Completed = value;
        }

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentPartAddedEvent? ContentPartAdded { get; init; }
#else
        public global::G.ResponseContentPartAddedEvent? ContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartAdded))]
#endif
        public bool IsContentPartAdded => ContentPartAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseContentPartAddedEvent value) => new ResponseStreamEvent((global::G.ResponseContentPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentPartAddedEvent?(ResponseStreamEvent @this) => @this.ContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseContentPartAddedEvent? value)
        {
            ContentPartAdded = value;
        }

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentPartDoneEvent? ContentPartDone { get; init; }
#else
        public global::G.ResponseContentPartDoneEvent? ContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartDone))]
#endif
        public bool IsContentPartDone => ContentPartDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseContentPartDoneEvent value) => new ResponseStreamEvent((global::G.ResponseContentPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentPartDoneEvent?(ResponseStreamEvent @this) => @this.ContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseContentPartDoneEvent? value)
        {
            ContentPartDone = value;
        }

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCreatedEvent? Created { get; init; }
#else
        public global::G.ResponseCreatedEvent? Created { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Created))]
#endif
        public bool IsCreated => Created != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseCreatedEvent value) => new ResponseStreamEvent((global::G.ResponseCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCreatedEvent?(ResponseStreamEvent @this) => @this.Created;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseCreatedEvent? value)
        {
            Created = value;
        }

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
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileSearchCallCompletedEvent? FileSearchCallCompleted { get; init; }
#else
        public global::G.ResponseFileSearchCallCompletedEvent? FileSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCallCompleted))]
#endif
        public bool IsFileSearchCallCompleted => FileSearchCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFileSearchCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseFileSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.FileSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFileSearchCallCompletedEvent? value)
        {
            FileSearchCallCompleted = value;
        }

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileSearchCallInProgressEvent? FileSearchCallInProgress { get; init; }
#else
        public global::G.ResponseFileSearchCallInProgressEvent? FileSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCallInProgress))]
#endif
        public bool IsFileSearchCallInProgress => FileSearchCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFileSearchCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseFileSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.FileSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFileSearchCallInProgressEvent? value)
        {
            FileSearchCallInProgress = value;
        }

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileSearchCallSearchingEvent? FileSearchCallSearching { get; init; }
#else
        public global::G.ResponseFileSearchCallSearchingEvent? FileSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCallSearching))]
#endif
        public bool IsFileSearchCallSearching => FileSearchCallSearching != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFileSearchCallSearchingEvent value) => new ResponseStreamEvent((global::G.ResponseFileSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.FileSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFileSearchCallSearchingEvent? value)
        {
            FileSearchCallSearching = value;
        }

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFunctionCallArgumentsDeltaEvent? FunctionCallArgumentsDelta { get; init; }
#else
        public global::G.ResponseFunctionCallArgumentsDeltaEvent? FunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallArgumentsDelta))]
#endif
        public bool IsFunctionCallArgumentsDelta => FunctionCallArgumentsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseFunctionCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.FunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            FunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFunctionCallArgumentsDoneEvent? FunctionCallArgumentsDone { get; init; }
#else
        public global::G.ResponseFunctionCallArgumentsDoneEvent? FunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallArgumentsDone))]
#endif
        public bool IsFunctionCallArgumentsDone => FunctionCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::G.ResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.FunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            FunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseInProgressEvent? InProgress { get; init; }
#else
        public global::G.ResponseInProgressEvent? InProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InProgress))]
#endif
        public bool IsInProgress => InProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseInProgressEvent?(ResponseStreamEvent @this) => @this.InProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseInProgressEvent? value)
        {
            InProgress = value;
        }

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFailedEvent? Failed { get; init; }
#else
        public global::G.ResponseFailedEvent? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseFailedEvent value) => new ResponseStreamEvent((global::G.ResponseFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFailedEvent?(ResponseStreamEvent @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseFailedEvent? value)
        {
            Failed = value;
        }

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseIncompleteEvent? Incomplete { get; init; }
#else
        public global::G.ResponseIncompleteEvent? Incomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Incomplete))]
#endif
        public bool IsIncomplete => Incomplete != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseIncompleteEvent value) => new ResponseStreamEvent((global::G.ResponseIncompleteEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseIncompleteEvent?(ResponseStreamEvent @this) => @this.Incomplete;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseIncompleteEvent? value)
        {
            Incomplete = value;
        }

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputItemAddedEvent? OutputItemAdded { get; init; }
#else
        public global::G.ResponseOutputItemAddedEvent? OutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemAdded))]
#endif
        public bool IsOutputItemAdded => OutputItemAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseOutputItemAddedEvent value) => new ResponseStreamEvent((global::G.ResponseOutputItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemAddedEvent?(ResponseStreamEvent @this) => @this.OutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseOutputItemAddedEvent? value)
        {
            OutputItemAdded = value;
        }

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputItemDoneEvent? OutputItemDone { get; init; }
#else
        public global::G.ResponseOutputItemDoneEvent? OutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemDone))]
#endif
        public bool IsOutputItemDone => OutputItemDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseOutputItemDoneEvent value) => new ResponseStreamEvent((global::G.ResponseOutputItemDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemDoneEvent?(ResponseStreamEvent @this) => @this.OutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseOutputItemDoneEvent? value)
        {
            OutputItemDone = value;
        }

        /// <summary>
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryPartAddedEvent? ReasoningSummaryPartAdded { get; init; }
#else
        public global::G.ResponseReasoningSummaryPartAddedEvent? ReasoningSummaryPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryPartAdded))]
#endif
        public bool IsReasoningSummaryPartAdded => ReasoningSummaryPartAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryPartAddedEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryPartAddedEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryPartAddedEvent? value)
        {
            ReasoningSummaryPartAdded = value;
        }

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryPartDoneEvent? ReasoningSummaryPartDone { get; init; }
#else
        public global::G.ResponseReasoningSummaryPartDoneEvent? ReasoningSummaryPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryPartDone))]
#endif
        public bool IsReasoningSummaryPartDone => ReasoningSummaryPartDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryPartDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryPartDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryPartDoneEvent? value)
        {
            ReasoningSummaryPartDone = value;
        }

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryTextDeltaEvent? ReasoningSummaryTextDelta { get; init; }
#else
        public global::G.ResponseReasoningSummaryTextDeltaEvent? ReasoningSummaryTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryTextDelta))]
#endif
        public bool IsReasoningSummaryTextDelta => ReasoningSummaryTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryTextDeltaEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDeltaEvent? value)
        {
            ReasoningSummaryTextDelta = value;
        }

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryTextDoneEvent? ReasoningSummaryTextDone { get; init; }
#else
        public global::G.ResponseReasoningSummaryTextDoneEvent? ReasoningSummaryTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryTextDone))]
#endif
        public bool IsReasoningSummaryTextDone => ReasoningSummaryTextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryTextDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryTextDoneEvent? value)
        {
            ReasoningSummaryTextDone = value;
        }

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseRefusalDeltaEvent? RefusalDelta { get; init; }
#else
        public global::G.ResponseRefusalDeltaEvent? RefusalDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalDelta))]
#endif
        public bool IsRefusalDelta => RefusalDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseRefusalDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseRefusalDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseRefusalDeltaEvent?(ResponseStreamEvent @this) => @this.RefusalDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseRefusalDeltaEvent? value)
        {
            RefusalDelta = value;
        }

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseRefusalDoneEvent? RefusalDone { get; init; }
#else
        public global::G.ResponseRefusalDoneEvent? RefusalDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalDone))]
#endif
        public bool IsRefusalDone => RefusalDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseRefusalDoneEvent value) => new ResponseStreamEvent((global::G.ResponseRefusalDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseRefusalDoneEvent?(ResponseStreamEvent @this) => @this.RefusalDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseRefusalDoneEvent? value)
        {
            RefusalDone = value;
        }

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextDeltaEvent? TextDelta { get; init; }
#else
        public global::G.ResponseTextDeltaEvent? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseTextDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextDeltaEvent?(ResponseStreamEvent @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseTextDeltaEvent? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextDoneEvent? TextDone { get; init; }
#else
        public global::G.ResponseTextDoneEvent? TextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDone))]
#endif
        public bool IsTextDone => TextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseTextDoneEvent value) => new ResponseStreamEvent((global::G.ResponseTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextDoneEvent?(ResponseStreamEvent @this) => @this.TextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseTextDoneEvent? value)
        {
            TextDone = value;
        }

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseWebSearchCallCompletedEvent? WebSearchCallCompleted { get; init; }
#else
        public global::G.ResponseWebSearchCallCompletedEvent? WebSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallCompleted))]
#endif
        public bool IsWebSearchCallCompleted => WebSearchCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseWebSearchCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseWebSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseWebSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.WebSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseWebSearchCallCompletedEvent? value)
        {
            WebSearchCallCompleted = value;
        }

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseWebSearchCallInProgressEvent? WebSearchCallInProgress { get; init; }
#else
        public global::G.ResponseWebSearchCallInProgressEvent? WebSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallInProgress))]
#endif
        public bool IsWebSearchCallInProgress => WebSearchCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseWebSearchCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseWebSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseWebSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.WebSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseWebSearchCallInProgressEvent? value)
        {
            WebSearchCallInProgress = value;
        }

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseWebSearchCallSearchingEvent? WebSearchCallSearching { get; init; }
#else
        public global::G.ResponseWebSearchCallSearchingEvent? WebSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallSearching))]
#endif
        public bool IsWebSearchCallSearching => WebSearchCallSearching != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseWebSearchCallSearchingEvent value) => new ResponseStreamEvent((global::G.ResponseWebSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseWebSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.WebSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseWebSearchCallSearchingEvent? value)
        {
            WebSearchCallSearching = value;
        }

        /// <summary>
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallCompletedEvent? ImageGenCallCompleted { get; init; }
#else
        public global::G.ResponseImageGenCallCompletedEvent? ImageGenCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallCompleted))]
#endif
        public bool IsImageGenCallCompleted => ImageGenCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallCompletedEvent?(ResponseStreamEvent @this) => @this.ImageGenCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallCompletedEvent? value)
        {
            ImageGenCallCompleted = value;
        }

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallGeneratingEvent? ImageGenCallGenerating { get; init; }
#else
        public global::G.ResponseImageGenCallGeneratingEvent? ImageGenCallGenerating { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallGenerating))]
#endif
        public bool IsImageGenCallGenerating => ImageGenCallGenerating != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallGeneratingEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallGeneratingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallGeneratingEvent?(ResponseStreamEvent @this) => @this.ImageGenCallGenerating;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallGeneratingEvent? value)
        {
            ImageGenCallGenerating = value;
        }

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallInProgressEvent? ImageGenCallInProgress { get; init; }
#else
        public global::G.ResponseImageGenCallInProgressEvent? ImageGenCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallInProgress))]
#endif
        public bool IsImageGenCallInProgress => ImageGenCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallInProgressEvent?(ResponseStreamEvent @this) => @this.ImageGenCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallInProgressEvent? value)
        {
            ImageGenCallInProgress = value;
        }

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseImageGenCallPartialImageEvent? ImageGenCallPartial { get; init; }
#else
        public global::G.ResponseImageGenCallPartialImageEvent? ImageGenCallPartial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallPartial))]
#endif
        public bool IsImageGenCallPartial => ImageGenCallPartial != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseImageGenCallPartialImageEvent value) => new ResponseStreamEvent((global::G.ResponseImageGenCallPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseImageGenCallPartialImageEvent?(ResponseStreamEvent @this) => @this.ImageGenCallPartial;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseImageGenCallPartialImageEvent? value)
        {
            ImageGenCallPartial = value;
        }

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallArgumentsDeltaEvent? MCPCallArgumentsDelta { get; init; }
#else
        public global::G.ResponseMCPCallArgumentsDeltaEvent? MCPCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallArgumentsDelta))]
#endif
        public bool IsMCPCallArgumentsDelta => MCPCallArgumentsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.MCPCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDeltaEvent? value)
        {
            MCPCallArgumentsDelta = value;
        }

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallArgumentsDoneEvent? MCPCallArgumentsDone { get; init; }
#else
        public global::G.ResponseMCPCallArgumentsDoneEvent? MCPCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallArgumentsDone))]
#endif
        public bool IsMCPCallArgumentsDone => MCPCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.MCPCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallArgumentsDoneEvent? value)
        {
            MCPCallArgumentsDone = value;
        }

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallCompletedEvent? MCPCallCompleted { get; init; }
#else
        public global::G.ResponseMCPCallCompletedEvent? MCPCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallCompleted))]
#endif
        public bool IsMCPCallCompleted => MCPCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallCompletedEvent?(ResponseStreamEvent @this) => @this.MCPCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallCompletedEvent? value)
        {
            MCPCallCompleted = value;
        }

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallFailedEvent? MCPCallFailed { get; init; }
#else
        public global::G.ResponseMCPCallFailedEvent? MCPCallFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallFailed))]
#endif
        public bool IsMCPCallFailed => MCPCallFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallFailedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallFailedEvent?(ResponseStreamEvent @this) => @this.MCPCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallFailedEvent? value)
        {
            MCPCallFailed = value;
        }

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPCallInProgressEvent? MCPCallInProgress { get; init; }
#else
        public global::G.ResponseMCPCallInProgressEvent? MCPCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallInProgress))]
#endif
        public bool IsMCPCallInProgress => MCPCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPCallInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseMCPCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPCallInProgressEvent?(ResponseStreamEvent @this) => @this.MCPCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPCallInProgressEvent? value)
        {
            MCPCallInProgress = value;
        }

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPListToolsCompletedEvent? MCPListToolsCompleted { get; init; }
#else
        public global::G.ResponseMCPListToolsCompletedEvent? MCPListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListToolsCompleted))]
#endif
        public bool IsMCPListToolsCompleted => MCPListToolsCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPListToolsCompletedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPListToolsCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPListToolsCompletedEvent?(ResponseStreamEvent @this) => @this.MCPListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPListToolsCompletedEvent? value)
        {
            MCPListToolsCompleted = value;
        }

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPListToolsFailedEvent? MCPListToolsFailed { get; init; }
#else
        public global::G.ResponseMCPListToolsFailedEvent? MCPListToolsFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListToolsFailed))]
#endif
        public bool IsMCPListToolsFailed => MCPListToolsFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPListToolsFailedEvent value) => new ResponseStreamEvent((global::G.ResponseMCPListToolsFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPListToolsFailedEvent?(ResponseStreamEvent @this) => @this.MCPListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPListToolsFailedEvent? value)
        {
            MCPListToolsFailed = value;
        }

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMCPListToolsInProgressEvent? MCPListToolsInProgress { get; init; }
#else
        public global::G.ResponseMCPListToolsInProgressEvent? MCPListToolsInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListToolsInProgress))]
#endif
        public bool IsMCPListToolsInProgress => MCPListToolsInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseMCPListToolsInProgressEvent value) => new ResponseStreamEvent((global::G.ResponseMCPListToolsInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMCPListToolsInProgressEvent?(ResponseStreamEvent @this) => @this.MCPListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseMCPListToolsInProgressEvent? value)
        {
            MCPListToolsInProgress = value;
        }

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputTextAnnotationAddedEvent? OutputTextAnnotationAdded { get; init; }
#else
        public global::G.ResponseOutputTextAnnotationAddedEvent? OutputTextAnnotationAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputTextAnnotationAdded))]
#endif
        public bool IsOutputTextAnnotationAdded => OutputTextAnnotationAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseOutputTextAnnotationAddedEvent value) => new ResponseStreamEvent((global::G.ResponseOutputTextAnnotationAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputTextAnnotationAddedEvent?(ResponseStreamEvent @this) => @this.OutputTextAnnotationAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseOutputTextAnnotationAddedEvent? value)
        {
            OutputTextAnnotationAdded = value;
        }

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseQueuedEvent? Queued { get; init; }
#else
        public global::G.ResponseQueuedEvent? Queued { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Queued))]
#endif
        public bool IsQueued => Queued != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseQueuedEvent value) => new ResponseStreamEvent((global::G.ResponseQueuedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseQueuedEvent?(ResponseStreamEvent @this) => @this.Queued;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseQueuedEvent? value)
        {
            Queued = value;
        }

        /// <summary>
        /// Emitted when there is a delta (partial update) to the reasoning content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningDeltaEvent? ReasoningDelta { get; init; }
#else
        public global::G.ResponseReasoningDeltaEvent? ReasoningDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDelta))]
#endif
        public bool IsReasoningDelta => ReasoningDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningDeltaEvent?(ResponseStreamEvent @this) => @this.ReasoningDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningDeltaEvent? value)
        {
            ReasoningDelta = value;
        }

        /// <summary>
        /// Emitted when the reasoning content is finalized for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningDoneEvent? ReasoningDone { get; init; }
#else
        public global::G.ResponseReasoningDoneEvent? ReasoningDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDone))]
#endif
        public bool IsReasoningDone => ReasoningDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningDoneEvent? value)
        {
            ReasoningDone = value;
        }

        /// <summary>
        /// Emitted when there is a delta (partial update) to the reasoning summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryDeltaEvent? ReasoningSummaryDelta { get; init; }
#else
        public global::G.ResponseReasoningSummaryDeltaEvent? ReasoningSummaryDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryDelta))]
#endif
        public bool IsReasoningSummaryDelta => ReasoningSummaryDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryDeltaEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryDeltaEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryDeltaEvent? value)
        {
            ReasoningSummaryDelta = value;
        }

        /// <summary>
        /// Emitted when the reasoning summary content is finalized for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseReasoningSummaryDoneEvent? ReasoningSummaryDone { get; init; }
#else
        public global::G.ResponseReasoningSummaryDoneEvent? ReasoningSummaryDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryDone))]
#endif
        public bool IsReasoningSummaryDone => ReasoningSummaryDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::G.ResponseReasoningSummaryDoneEvent value) => new ResponseStreamEvent((global::G.ResponseReasoningSummaryDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseReasoningSummaryDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::G.ResponseReasoningSummaryDoneEvent? value)
        {
            ReasoningSummaryDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(
            global::G.ResponseAudioDeltaEvent? audioDelta,
            global::G.ResponseAudioDoneEvent? audioDone,
            global::G.ResponseAudioTranscriptDeltaEvent? audioTranscriptDelta,
            global::G.ResponseAudioTranscriptDoneEvent? audioTranscriptDone,
            global::G.ResponseCodeInterpreterCallCodeDeltaEvent? codeInterpreterCallDelta,
            global::G.ResponseCodeInterpreterCallCodeDoneEvent? codeInterpreterCallDone,
            global::G.ResponseCodeInterpreterCallCompletedEvent? codeInterpreterCallCompleted,
            global::G.ResponseCodeInterpreterCallInProgressEvent? codeInterpreterCallInProgress,
            global::G.ResponseCodeInterpreterCallInterpretingEvent? codeInterpreterCallInterpreting,
            global::G.ResponseCompletedEvent? completed,
            global::G.ResponseContentPartAddedEvent? contentPartAdded,
            global::G.ResponseContentPartDoneEvent? contentPartDone,
            global::G.ResponseCreatedEvent? created,
            global::G.ResponseErrorEvent? error,
            global::G.ResponseFileSearchCallCompletedEvent? fileSearchCallCompleted,
            global::G.ResponseFileSearchCallInProgressEvent? fileSearchCallInProgress,
            global::G.ResponseFileSearchCallSearchingEvent? fileSearchCallSearching,
            global::G.ResponseFunctionCallArgumentsDeltaEvent? functionCallArgumentsDelta,
            global::G.ResponseFunctionCallArgumentsDoneEvent? functionCallArgumentsDone,
            global::G.ResponseInProgressEvent? inProgress,
            global::G.ResponseFailedEvent? failed,
            global::G.ResponseIncompleteEvent? incomplete,
            global::G.ResponseOutputItemAddedEvent? outputItemAdded,
            global::G.ResponseOutputItemDoneEvent? outputItemDone,
            global::G.ResponseReasoningSummaryPartAddedEvent? reasoningSummaryPartAdded,
            global::G.ResponseReasoningSummaryPartDoneEvent? reasoningSummaryPartDone,
            global::G.ResponseReasoningSummaryTextDeltaEvent? reasoningSummaryTextDelta,
            global::G.ResponseReasoningSummaryTextDoneEvent? reasoningSummaryTextDone,
            global::G.ResponseRefusalDeltaEvent? refusalDelta,
            global::G.ResponseRefusalDoneEvent? refusalDone,
            global::G.ResponseTextDeltaEvent? textDelta,
            global::G.ResponseTextDoneEvent? textDone,
            global::G.ResponseWebSearchCallCompletedEvent? webSearchCallCompleted,
            global::G.ResponseWebSearchCallInProgressEvent? webSearchCallInProgress,
            global::G.ResponseWebSearchCallSearchingEvent? webSearchCallSearching,
            global::G.ResponseImageGenCallCompletedEvent? imageGenCallCompleted,
            global::G.ResponseImageGenCallGeneratingEvent? imageGenCallGenerating,
            global::G.ResponseImageGenCallInProgressEvent? imageGenCallInProgress,
            global::G.ResponseImageGenCallPartialImageEvent? imageGenCallPartial,
            global::G.ResponseMCPCallArgumentsDeltaEvent? mCPCallArgumentsDelta,
            global::G.ResponseMCPCallArgumentsDoneEvent? mCPCallArgumentsDone,
            global::G.ResponseMCPCallCompletedEvent? mCPCallCompleted,
            global::G.ResponseMCPCallFailedEvent? mCPCallFailed,
            global::G.ResponseMCPCallInProgressEvent? mCPCallInProgress,
            global::G.ResponseMCPListToolsCompletedEvent? mCPListToolsCompleted,
            global::G.ResponseMCPListToolsFailedEvent? mCPListToolsFailed,
            global::G.ResponseMCPListToolsInProgressEvent? mCPListToolsInProgress,
            global::G.ResponseOutputTextAnnotationAddedEvent? outputTextAnnotationAdded,
            global::G.ResponseQueuedEvent? queued,
            global::G.ResponseReasoningDeltaEvent? reasoningDelta,
            global::G.ResponseReasoningDoneEvent? reasoningDone,
            global::G.ResponseReasoningSummaryDeltaEvent? reasoningSummaryDelta,
            global::G.ResponseReasoningSummaryDoneEvent? reasoningSummaryDone
            )
        {
            AudioDelta = audioDelta;
            AudioDone = audioDone;
            AudioTranscriptDelta = audioTranscriptDelta;
            AudioTranscriptDone = audioTranscriptDone;
            CodeInterpreterCallDelta = codeInterpreterCallDelta;
            CodeInterpreterCallDone = codeInterpreterCallDone;
            CodeInterpreterCallCompleted = codeInterpreterCallCompleted;
            CodeInterpreterCallInProgress = codeInterpreterCallInProgress;
            CodeInterpreterCallInterpreting = codeInterpreterCallInterpreting;
            Completed = completed;
            ContentPartAdded = contentPartAdded;
            ContentPartDone = contentPartDone;
            Created = created;
            Error = error;
            FileSearchCallCompleted = fileSearchCallCompleted;
            FileSearchCallInProgress = fileSearchCallInProgress;
            FileSearchCallSearching = fileSearchCallSearching;
            FunctionCallArgumentsDelta = functionCallArgumentsDelta;
            FunctionCallArgumentsDone = functionCallArgumentsDone;
            InProgress = inProgress;
            Failed = failed;
            Incomplete = incomplete;
            OutputItemAdded = outputItemAdded;
            OutputItemDone = outputItemDone;
            ReasoningSummaryPartAdded = reasoningSummaryPartAdded;
            ReasoningSummaryPartDone = reasoningSummaryPartDone;
            ReasoningSummaryTextDelta = reasoningSummaryTextDelta;
            ReasoningSummaryTextDone = reasoningSummaryTextDone;
            RefusalDelta = refusalDelta;
            RefusalDone = refusalDone;
            TextDelta = textDelta;
            TextDone = textDone;
            WebSearchCallCompleted = webSearchCallCompleted;
            WebSearchCallInProgress = webSearchCallInProgress;
            WebSearchCallSearching = webSearchCallSearching;
            ImageGenCallCompleted = imageGenCallCompleted;
            ImageGenCallGenerating = imageGenCallGenerating;
            ImageGenCallInProgress = imageGenCallInProgress;
            ImageGenCallPartial = imageGenCallPartial;
            MCPCallArgumentsDelta = mCPCallArgumentsDelta;
            MCPCallArgumentsDone = mCPCallArgumentsDone;
            MCPCallCompleted = mCPCallCompleted;
            MCPCallFailed = mCPCallFailed;
            MCPCallInProgress = mCPCallInProgress;
            MCPListToolsCompleted = mCPListToolsCompleted;
            MCPListToolsFailed = mCPListToolsFailed;
            MCPListToolsInProgress = mCPListToolsInProgress;
            OutputTextAnnotationAdded = outputTextAnnotationAdded;
            Queued = queued;
            ReasoningDelta = reasoningDelta;
            ReasoningDone = reasoningDone;
            ReasoningSummaryDelta = reasoningSummaryDelta;
            ReasoningSummaryDone = reasoningSummaryDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningSummaryDone as object ??
            ReasoningSummaryDelta as object ??
            ReasoningDone as object ??
            ReasoningDelta as object ??
            Queued as object ??
            OutputTextAnnotationAdded as object ??
            MCPListToolsInProgress as object ??
            MCPListToolsFailed as object ??
            MCPListToolsCompleted as object ??
            MCPCallInProgress as object ??
            MCPCallFailed as object ??
            MCPCallCompleted as object ??
            MCPCallArgumentsDone as object ??
            MCPCallArgumentsDelta as object ??
            ImageGenCallPartial as object ??
            ImageGenCallInProgress as object ??
            ImageGenCallGenerating as object ??
            ImageGenCallCompleted as object ??
            WebSearchCallSearching as object ??
            WebSearchCallInProgress as object ??
            WebSearchCallCompleted as object ??
            TextDone as object ??
            TextDelta as object ??
            RefusalDone as object ??
            RefusalDelta as object ??
            ReasoningSummaryTextDone as object ??
            ReasoningSummaryTextDelta as object ??
            ReasoningSummaryPartDone as object ??
            ReasoningSummaryPartAdded as object ??
            OutputItemDone as object ??
            OutputItemAdded as object ??
            Incomplete as object ??
            Failed as object ??
            InProgress as object ??
            FunctionCallArgumentsDone as object ??
            FunctionCallArgumentsDelta as object ??
            FileSearchCallSearching as object ??
            FileSearchCallInProgress as object ??
            FileSearchCallCompleted as object ??
            Error as object ??
            Created as object ??
            ContentPartDone as object ??
            ContentPartAdded as object ??
            Completed as object ??
            CodeInterpreterCallInterpreting as object ??
            CodeInterpreterCallInProgress as object ??
            CodeInterpreterCallCompleted as object ??
            CodeInterpreterCallDone as object ??
            CodeInterpreterCallDelta as object ??
            AudioTranscriptDone as object ??
            AudioTranscriptDelta as object ??
            AudioDone as object ??
            AudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioDelta?.ToString() ??
            AudioDone?.ToString() ??
            AudioTranscriptDelta?.ToString() ??
            AudioTranscriptDone?.ToString() ??
            CodeInterpreterCallDelta?.ToString() ??
            CodeInterpreterCallDone?.ToString() ??
            CodeInterpreterCallCompleted?.ToString() ??
            CodeInterpreterCallInProgress?.ToString() ??
            CodeInterpreterCallInterpreting?.ToString() ??
            Completed?.ToString() ??
            ContentPartAdded?.ToString() ??
            ContentPartDone?.ToString() ??
            Created?.ToString() ??
            Error?.ToString() ??
            FileSearchCallCompleted?.ToString() ??
            FileSearchCallInProgress?.ToString() ??
            FileSearchCallSearching?.ToString() ??
            FunctionCallArgumentsDelta?.ToString() ??
            FunctionCallArgumentsDone?.ToString() ??
            InProgress?.ToString() ??
            Failed?.ToString() ??
            Incomplete?.ToString() ??
            OutputItemAdded?.ToString() ??
            OutputItemDone?.ToString() ??
            ReasoningSummaryPartAdded?.ToString() ??
            ReasoningSummaryPartDone?.ToString() ??
            ReasoningSummaryTextDelta?.ToString() ??
            ReasoningSummaryTextDone?.ToString() ??
            RefusalDelta?.ToString() ??
            RefusalDone?.ToString() ??
            TextDelta?.ToString() ??
            TextDone?.ToString() ??
            WebSearchCallCompleted?.ToString() ??
            WebSearchCallInProgress?.ToString() ??
            WebSearchCallSearching?.ToString() ??
            ImageGenCallCompleted?.ToString() ??
            ImageGenCallGenerating?.ToString() ??
            ImageGenCallInProgress?.ToString() ??
            ImageGenCallPartial?.ToString() ??
            MCPCallArgumentsDelta?.ToString() ??
            MCPCallArgumentsDone?.ToString() ??
            MCPCallCompleted?.ToString() ??
            MCPCallFailed?.ToString() ??
            MCPCallInProgress?.ToString() ??
            MCPListToolsCompleted?.ToString() ??
            MCPListToolsFailed?.ToString() ??
            MCPListToolsInProgress?.ToString() ??
            OutputTextAnnotationAdded?.ToString() ??
            Queued?.ToString() ??
            ReasoningDelta?.ToString() ??
            ReasoningDone?.ToString() ??
            ReasoningSummaryDelta?.ToString() ??
            ReasoningSummaryDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioDelta || IsAudioDone || IsAudioTranscriptDelta || IsAudioTranscriptDone || IsCodeInterpreterCallDelta || IsCodeInterpreterCallDone || IsCodeInterpreterCallCompleted || IsCodeInterpreterCallInProgress || IsCodeInterpreterCallInterpreting || IsCompleted || IsContentPartAdded || IsContentPartDone || IsCreated || IsError || IsFileSearchCallCompleted || IsFileSearchCallInProgress || IsFileSearchCallSearching || IsFunctionCallArgumentsDelta || IsFunctionCallArgumentsDone || IsInProgress || IsFailed || IsIncomplete || IsOutputItemAdded || IsOutputItemDone || IsReasoningSummaryPartAdded || IsReasoningSummaryPartDone || IsReasoningSummaryTextDelta || IsReasoningSummaryTextDone || IsRefusalDelta || IsRefusalDone || IsTextDelta || IsTextDone || IsWebSearchCallCompleted || IsWebSearchCallInProgress || IsWebSearchCallSearching || IsImageGenCallCompleted || IsImageGenCallGenerating || IsImageGenCallInProgress || IsImageGenCallPartial || IsMCPCallArgumentsDelta || IsMCPCallArgumentsDone || IsMCPCallCompleted || IsMCPCallFailed || IsMCPCallInProgress || IsMCPListToolsCompleted || IsMCPListToolsFailed || IsMCPListToolsInProgress || IsOutputTextAnnotationAdded || IsQueued || IsReasoningDelta || IsReasoningDone || IsReasoningSummaryDelta || IsReasoningSummaryDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseAudioDeltaEvent?, TResult>? audioDelta = null,
            global::System.Func<global::G.ResponseAudioDoneEvent?, TResult>? audioDone = null,
            global::System.Func<global::G.ResponseAudioTranscriptDeltaEvent?, TResult>? audioTranscriptDelta = null,
            global::System.Func<global::G.ResponseAudioTranscriptDoneEvent?, TResult>? audioTranscriptDone = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?, TResult>? codeInterpreterCallDelta = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallCodeDoneEvent?, TResult>? codeInterpreterCallDone = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallCompletedEvent?, TResult>? codeInterpreterCallCompleted = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallInProgressEvent?, TResult>? codeInterpreterCallInProgress = null,
            global::System.Func<global::G.ResponseCodeInterpreterCallInterpretingEvent?, TResult>? codeInterpreterCallInterpreting = null,
            global::System.Func<global::G.ResponseCompletedEvent?, TResult>? completed = null,
            global::System.Func<global::G.ResponseContentPartAddedEvent?, TResult>? contentPartAdded = null,
            global::System.Func<global::G.ResponseContentPartDoneEvent?, TResult>? contentPartDone = null,
            global::System.Func<global::G.ResponseCreatedEvent?, TResult>? created = null,
            global::System.Func<global::G.ResponseErrorEvent?, TResult>? error = null,
            global::System.Func<global::G.ResponseFileSearchCallCompletedEvent?, TResult>? fileSearchCallCompleted = null,
            global::System.Func<global::G.ResponseFileSearchCallInProgressEvent?, TResult>? fileSearchCallInProgress = null,
            global::System.Func<global::G.ResponseFileSearchCallSearchingEvent?, TResult>? fileSearchCallSearching = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDeltaEvent?, TResult>? functionCallArgumentsDelta = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDoneEvent?, TResult>? functionCallArgumentsDone = null,
            global::System.Func<global::G.ResponseInProgressEvent?, TResult>? inProgress = null,
            global::System.Func<global::G.ResponseFailedEvent?, TResult>? failed = null,
            global::System.Func<global::G.ResponseIncompleteEvent?, TResult>? incomplete = null,
            global::System.Func<global::G.ResponseOutputItemAddedEvent?, TResult>? outputItemAdded = null,
            global::System.Func<global::G.ResponseOutputItemDoneEvent?, TResult>? outputItemDone = null,
            global::System.Func<global::G.ResponseReasoningSummaryPartAddedEvent?, TResult>? reasoningSummaryPartAdded = null,
            global::System.Func<global::G.ResponseReasoningSummaryPartDoneEvent?, TResult>? reasoningSummaryPartDone = null,
            global::System.Func<global::G.ResponseReasoningSummaryTextDeltaEvent?, TResult>? reasoningSummaryTextDelta = null,
            global::System.Func<global::G.ResponseReasoningSummaryTextDoneEvent?, TResult>? reasoningSummaryTextDone = null,
            global::System.Func<global::G.ResponseRefusalDeltaEvent?, TResult>? refusalDelta = null,
            global::System.Func<global::G.ResponseRefusalDoneEvent?, TResult>? refusalDone = null,
            global::System.Func<global::G.ResponseTextDeltaEvent?, TResult>? textDelta = null,
            global::System.Func<global::G.ResponseTextDoneEvent?, TResult>? textDone = null,
            global::System.Func<global::G.ResponseWebSearchCallCompletedEvent?, TResult>? webSearchCallCompleted = null,
            global::System.Func<global::G.ResponseWebSearchCallInProgressEvent?, TResult>? webSearchCallInProgress = null,
            global::System.Func<global::G.ResponseWebSearchCallSearchingEvent?, TResult>? webSearchCallSearching = null,
            global::System.Func<global::G.ResponseImageGenCallCompletedEvent?, TResult>? imageGenCallCompleted = null,
            global::System.Func<global::G.ResponseImageGenCallGeneratingEvent?, TResult>? imageGenCallGenerating = null,
            global::System.Func<global::G.ResponseImageGenCallInProgressEvent?, TResult>? imageGenCallInProgress = null,
            global::System.Func<global::G.ResponseImageGenCallPartialImageEvent?, TResult>? imageGenCallPartial = null,
            global::System.Func<global::G.ResponseMCPCallArgumentsDeltaEvent?, TResult>? mCPCallArgumentsDelta = null,
            global::System.Func<global::G.ResponseMCPCallArgumentsDoneEvent?, TResult>? mCPCallArgumentsDone = null,
            global::System.Func<global::G.ResponseMCPCallCompletedEvent?, TResult>? mCPCallCompleted = null,
            global::System.Func<global::G.ResponseMCPCallFailedEvent?, TResult>? mCPCallFailed = null,
            global::System.Func<global::G.ResponseMCPCallInProgressEvent?, TResult>? mCPCallInProgress = null,
            global::System.Func<global::G.ResponseMCPListToolsCompletedEvent?, TResult>? mCPListToolsCompleted = null,
            global::System.Func<global::G.ResponseMCPListToolsFailedEvent?, TResult>? mCPListToolsFailed = null,
            global::System.Func<global::G.ResponseMCPListToolsInProgressEvent?, TResult>? mCPListToolsInProgress = null,
            global::System.Func<global::G.ResponseOutputTextAnnotationAddedEvent?, TResult>? outputTextAnnotationAdded = null,
            global::System.Func<global::G.ResponseQueuedEvent?, TResult>? queued = null,
            global::System.Func<global::G.ResponseReasoningDeltaEvent?, TResult>? reasoningDelta = null,
            global::System.Func<global::G.ResponseReasoningDoneEvent?, TResult>? reasoningDone = null,
            global::System.Func<global::G.ResponseReasoningSummaryDeltaEvent?, TResult>? reasoningSummaryDelta = null,
            global::System.Func<global::G.ResponseReasoningSummaryDoneEvent?, TResult>? reasoningSummaryDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta && audioDelta != null)
            {
                return audioDelta(AudioDelta!);
            }
            else if (IsAudioDone && audioDone != null)
            {
                return audioDone(AudioDone!);
            }
            else if (IsAudioTranscriptDelta && audioTranscriptDelta != null)
            {
                return audioTranscriptDelta(AudioTranscriptDelta!);
            }
            else if (IsAudioTranscriptDone && audioTranscriptDone != null)
            {
                return audioTranscriptDone(AudioTranscriptDone!);
            }
            else if (IsCodeInterpreterCallDelta && codeInterpreterCallDelta != null)
            {
                return codeInterpreterCallDelta(CodeInterpreterCallDelta!);
            }
            else if (IsCodeInterpreterCallDone && codeInterpreterCallDone != null)
            {
                return codeInterpreterCallDone(CodeInterpreterCallDone!);
            }
            else if (IsCodeInterpreterCallCompleted && codeInterpreterCallCompleted != null)
            {
                return codeInterpreterCallCompleted(CodeInterpreterCallCompleted!);
            }
            else if (IsCodeInterpreterCallInProgress && codeInterpreterCallInProgress != null)
            {
                return codeInterpreterCallInProgress(CodeInterpreterCallInProgress!);
            }
            else if (IsCodeInterpreterCallInterpreting && codeInterpreterCallInterpreting != null)
            {
                return codeInterpreterCallInterpreting(CodeInterpreterCallInterpreting!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsContentPartAdded && contentPartAdded != null)
            {
                return contentPartAdded(ContentPartAdded!);
            }
            else if (IsContentPartDone && contentPartDone != null)
            {
                return contentPartDone(ContentPartDone!);
            }
            else if (IsCreated && created != null)
            {
                return created(Created!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsFileSearchCallCompleted && fileSearchCallCompleted != null)
            {
                return fileSearchCallCompleted(FileSearchCallCompleted!);
            }
            else if (IsFileSearchCallInProgress && fileSearchCallInProgress != null)
            {
                return fileSearchCallInProgress(FileSearchCallInProgress!);
            }
            else if (IsFileSearchCallSearching && fileSearchCallSearching != null)
            {
                return fileSearchCallSearching(FileSearchCallSearching!);
            }
            else if (IsFunctionCallArgumentsDelta && functionCallArgumentsDelta != null)
            {
                return functionCallArgumentsDelta(FunctionCallArgumentsDelta!);
            }
            else if (IsFunctionCallArgumentsDone && functionCallArgumentsDone != null)
            {
                return functionCallArgumentsDone(FunctionCallArgumentsDone!);
            }
            else if (IsInProgress && inProgress != null)
            {
                return inProgress(InProgress!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }
            else if (IsIncomplete && incomplete != null)
            {
                return incomplete(Incomplete!);
            }
            else if (IsOutputItemAdded && outputItemAdded != null)
            {
                return outputItemAdded(OutputItemAdded!);
            }
            else if (IsOutputItemDone && outputItemDone != null)
            {
                return outputItemDone(OutputItemDone!);
            }
            else if (IsReasoningSummaryPartAdded && reasoningSummaryPartAdded != null)
            {
                return reasoningSummaryPartAdded(ReasoningSummaryPartAdded!);
            }
            else if (IsReasoningSummaryPartDone && reasoningSummaryPartDone != null)
            {
                return reasoningSummaryPartDone(ReasoningSummaryPartDone!);
            }
            else if (IsReasoningSummaryTextDelta && reasoningSummaryTextDelta != null)
            {
                return reasoningSummaryTextDelta(ReasoningSummaryTextDelta!);
            }
            else if (IsReasoningSummaryTextDone && reasoningSummaryTextDone != null)
            {
                return reasoningSummaryTextDone(ReasoningSummaryTextDone!);
            }
            else if (IsRefusalDelta && refusalDelta != null)
            {
                return refusalDelta(RefusalDelta!);
            }
            else if (IsRefusalDone && refusalDone != null)
            {
                return refusalDone(RefusalDone!);
            }
            else if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsTextDone && textDone != null)
            {
                return textDone(TextDone!);
            }
            else if (IsWebSearchCallCompleted && webSearchCallCompleted != null)
            {
                return webSearchCallCompleted(WebSearchCallCompleted!);
            }
            else if (IsWebSearchCallInProgress && webSearchCallInProgress != null)
            {
                return webSearchCallInProgress(WebSearchCallInProgress!);
            }
            else if (IsWebSearchCallSearching && webSearchCallSearching != null)
            {
                return webSearchCallSearching(WebSearchCallSearching!);
            }
            else if (IsImageGenCallCompleted && imageGenCallCompleted != null)
            {
                return imageGenCallCompleted(ImageGenCallCompleted!);
            }
            else if (IsImageGenCallGenerating && imageGenCallGenerating != null)
            {
                return imageGenCallGenerating(ImageGenCallGenerating!);
            }
            else if (IsImageGenCallInProgress && imageGenCallInProgress != null)
            {
                return imageGenCallInProgress(ImageGenCallInProgress!);
            }
            else if (IsImageGenCallPartial && imageGenCallPartial != null)
            {
                return imageGenCallPartial(ImageGenCallPartial!);
            }
            else if (IsMCPCallArgumentsDelta && mCPCallArgumentsDelta != null)
            {
                return mCPCallArgumentsDelta(MCPCallArgumentsDelta!);
            }
            else if (IsMCPCallArgumentsDone && mCPCallArgumentsDone != null)
            {
                return mCPCallArgumentsDone(MCPCallArgumentsDone!);
            }
            else if (IsMCPCallCompleted && mCPCallCompleted != null)
            {
                return mCPCallCompleted(MCPCallCompleted!);
            }
            else if (IsMCPCallFailed && mCPCallFailed != null)
            {
                return mCPCallFailed(MCPCallFailed!);
            }
            else if (IsMCPCallInProgress && mCPCallInProgress != null)
            {
                return mCPCallInProgress(MCPCallInProgress!);
            }
            else if (IsMCPListToolsCompleted && mCPListToolsCompleted != null)
            {
                return mCPListToolsCompleted(MCPListToolsCompleted!);
            }
            else if (IsMCPListToolsFailed && mCPListToolsFailed != null)
            {
                return mCPListToolsFailed(MCPListToolsFailed!);
            }
            else if (IsMCPListToolsInProgress && mCPListToolsInProgress != null)
            {
                return mCPListToolsInProgress(MCPListToolsInProgress!);
            }
            else if (IsOutputTextAnnotationAdded && outputTextAnnotationAdded != null)
            {
                return outputTextAnnotationAdded(OutputTextAnnotationAdded!);
            }
            else if (IsQueued && queued != null)
            {
                return queued(Queued!);
            }
            else if (IsReasoningDelta && reasoningDelta != null)
            {
                return reasoningDelta(ReasoningDelta!);
            }
            else if (IsReasoningDone && reasoningDone != null)
            {
                return reasoningDone(ReasoningDone!);
            }
            else if (IsReasoningSummaryDelta && reasoningSummaryDelta != null)
            {
                return reasoningSummaryDelta(ReasoningSummaryDelta!);
            }
            else if (IsReasoningSummaryDone && reasoningSummaryDone != null)
            {
                return reasoningSummaryDone(ReasoningSummaryDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseAudioDeltaEvent?>? audioDelta = null,
            global::System.Action<global::G.ResponseAudioDoneEvent?>? audioDone = null,
            global::System.Action<global::G.ResponseAudioTranscriptDeltaEvent?>? audioTranscriptDelta = null,
            global::System.Action<global::G.ResponseAudioTranscriptDoneEvent?>? audioTranscriptDone = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?>? codeInterpreterCallDelta = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallCodeDoneEvent?>? codeInterpreterCallDone = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallCompletedEvent?>? codeInterpreterCallCompleted = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallInProgressEvent?>? codeInterpreterCallInProgress = null,
            global::System.Action<global::G.ResponseCodeInterpreterCallInterpretingEvent?>? codeInterpreterCallInterpreting = null,
            global::System.Action<global::G.ResponseCompletedEvent?>? completed = null,
            global::System.Action<global::G.ResponseContentPartAddedEvent?>? contentPartAdded = null,
            global::System.Action<global::G.ResponseContentPartDoneEvent?>? contentPartDone = null,
            global::System.Action<global::G.ResponseCreatedEvent?>? created = null,
            global::System.Action<global::G.ResponseErrorEvent?>? error = null,
            global::System.Action<global::G.ResponseFileSearchCallCompletedEvent?>? fileSearchCallCompleted = null,
            global::System.Action<global::G.ResponseFileSearchCallInProgressEvent?>? fileSearchCallInProgress = null,
            global::System.Action<global::G.ResponseFileSearchCallSearchingEvent?>? fileSearchCallSearching = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDeltaEvent?>? functionCallArgumentsDelta = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDoneEvent?>? functionCallArgumentsDone = null,
            global::System.Action<global::G.ResponseInProgressEvent?>? inProgress = null,
            global::System.Action<global::G.ResponseFailedEvent?>? failed = null,
            global::System.Action<global::G.ResponseIncompleteEvent?>? incomplete = null,
            global::System.Action<global::G.ResponseOutputItemAddedEvent?>? outputItemAdded = null,
            global::System.Action<global::G.ResponseOutputItemDoneEvent?>? outputItemDone = null,
            global::System.Action<global::G.ResponseReasoningSummaryPartAddedEvent?>? reasoningSummaryPartAdded = null,
            global::System.Action<global::G.ResponseReasoningSummaryPartDoneEvent?>? reasoningSummaryPartDone = null,
            global::System.Action<global::G.ResponseReasoningSummaryTextDeltaEvent?>? reasoningSummaryTextDelta = null,
            global::System.Action<global::G.ResponseReasoningSummaryTextDoneEvent?>? reasoningSummaryTextDone = null,
            global::System.Action<global::G.ResponseRefusalDeltaEvent?>? refusalDelta = null,
            global::System.Action<global::G.ResponseRefusalDoneEvent?>? refusalDone = null,
            global::System.Action<global::G.ResponseTextDeltaEvent?>? textDelta = null,
            global::System.Action<global::G.ResponseTextDoneEvent?>? textDone = null,
            global::System.Action<global::G.ResponseWebSearchCallCompletedEvent?>? webSearchCallCompleted = null,
            global::System.Action<global::G.ResponseWebSearchCallInProgressEvent?>? webSearchCallInProgress = null,
            global::System.Action<global::G.ResponseWebSearchCallSearchingEvent?>? webSearchCallSearching = null,
            global::System.Action<global::G.ResponseImageGenCallCompletedEvent?>? imageGenCallCompleted = null,
            global::System.Action<global::G.ResponseImageGenCallGeneratingEvent?>? imageGenCallGenerating = null,
            global::System.Action<global::G.ResponseImageGenCallInProgressEvent?>? imageGenCallInProgress = null,
            global::System.Action<global::G.ResponseImageGenCallPartialImageEvent?>? imageGenCallPartial = null,
            global::System.Action<global::G.ResponseMCPCallArgumentsDeltaEvent?>? mCPCallArgumentsDelta = null,
            global::System.Action<global::G.ResponseMCPCallArgumentsDoneEvent?>? mCPCallArgumentsDone = null,
            global::System.Action<global::G.ResponseMCPCallCompletedEvent?>? mCPCallCompleted = null,
            global::System.Action<global::G.ResponseMCPCallFailedEvent?>? mCPCallFailed = null,
            global::System.Action<global::G.ResponseMCPCallInProgressEvent?>? mCPCallInProgress = null,
            global::System.Action<global::G.ResponseMCPListToolsCompletedEvent?>? mCPListToolsCompleted = null,
            global::System.Action<global::G.ResponseMCPListToolsFailedEvent?>? mCPListToolsFailed = null,
            global::System.Action<global::G.ResponseMCPListToolsInProgressEvent?>? mCPListToolsInProgress = null,
            global::System.Action<global::G.ResponseOutputTextAnnotationAddedEvent?>? outputTextAnnotationAdded = null,
            global::System.Action<global::G.ResponseQueuedEvent?>? queued = null,
            global::System.Action<global::G.ResponseReasoningDeltaEvent?>? reasoningDelta = null,
            global::System.Action<global::G.ResponseReasoningDoneEvent?>? reasoningDone = null,
            global::System.Action<global::G.ResponseReasoningSummaryDeltaEvent?>? reasoningSummaryDelta = null,
            global::System.Action<global::G.ResponseReasoningSummaryDoneEvent?>? reasoningSummaryDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta)
            {
                audioDelta?.Invoke(AudioDelta!);
            }
            else if (IsAudioDone)
            {
                audioDone?.Invoke(AudioDone!);
            }
            else if (IsAudioTranscriptDelta)
            {
                audioTranscriptDelta?.Invoke(AudioTranscriptDelta!);
            }
            else if (IsAudioTranscriptDone)
            {
                audioTranscriptDone?.Invoke(AudioTranscriptDone!);
            }
            else if (IsCodeInterpreterCallDelta)
            {
                codeInterpreterCallDelta?.Invoke(CodeInterpreterCallDelta!);
            }
            else if (IsCodeInterpreterCallDone)
            {
                codeInterpreterCallDone?.Invoke(CodeInterpreterCallDone!);
            }
            else if (IsCodeInterpreterCallCompleted)
            {
                codeInterpreterCallCompleted?.Invoke(CodeInterpreterCallCompleted!);
            }
            else if (IsCodeInterpreterCallInProgress)
            {
                codeInterpreterCallInProgress?.Invoke(CodeInterpreterCallInProgress!);
            }
            else if (IsCodeInterpreterCallInterpreting)
            {
                codeInterpreterCallInterpreting?.Invoke(CodeInterpreterCallInterpreting!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsContentPartAdded)
            {
                contentPartAdded?.Invoke(ContentPartAdded!);
            }
            else if (IsContentPartDone)
            {
                contentPartDone?.Invoke(ContentPartDone!);
            }
            else if (IsCreated)
            {
                created?.Invoke(Created!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsFileSearchCallCompleted)
            {
                fileSearchCallCompleted?.Invoke(FileSearchCallCompleted!);
            }
            else if (IsFileSearchCallInProgress)
            {
                fileSearchCallInProgress?.Invoke(FileSearchCallInProgress!);
            }
            else if (IsFileSearchCallSearching)
            {
                fileSearchCallSearching?.Invoke(FileSearchCallSearching!);
            }
            else if (IsFunctionCallArgumentsDelta)
            {
                functionCallArgumentsDelta?.Invoke(FunctionCallArgumentsDelta!);
            }
            else if (IsFunctionCallArgumentsDone)
            {
                functionCallArgumentsDone?.Invoke(FunctionCallArgumentsDone!);
            }
            else if (IsInProgress)
            {
                inProgress?.Invoke(InProgress!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsIncomplete)
            {
                incomplete?.Invoke(Incomplete!);
            }
            else if (IsOutputItemAdded)
            {
                outputItemAdded?.Invoke(OutputItemAdded!);
            }
            else if (IsOutputItemDone)
            {
                outputItemDone?.Invoke(OutputItemDone!);
            }
            else if (IsReasoningSummaryPartAdded)
            {
                reasoningSummaryPartAdded?.Invoke(ReasoningSummaryPartAdded!);
            }
            else if (IsReasoningSummaryPartDone)
            {
                reasoningSummaryPartDone?.Invoke(ReasoningSummaryPartDone!);
            }
            else if (IsReasoningSummaryTextDelta)
            {
                reasoningSummaryTextDelta?.Invoke(ReasoningSummaryTextDelta!);
            }
            else if (IsReasoningSummaryTextDone)
            {
                reasoningSummaryTextDone?.Invoke(ReasoningSummaryTextDone!);
            }
            else if (IsRefusalDelta)
            {
                refusalDelta?.Invoke(RefusalDelta!);
            }
            else if (IsRefusalDone)
            {
                refusalDone?.Invoke(RefusalDone!);
            }
            else if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsTextDone)
            {
                textDone?.Invoke(TextDone!);
            }
            else if (IsWebSearchCallCompleted)
            {
                webSearchCallCompleted?.Invoke(WebSearchCallCompleted!);
            }
            else if (IsWebSearchCallInProgress)
            {
                webSearchCallInProgress?.Invoke(WebSearchCallInProgress!);
            }
            else if (IsWebSearchCallSearching)
            {
                webSearchCallSearching?.Invoke(WebSearchCallSearching!);
            }
            else if (IsImageGenCallCompleted)
            {
                imageGenCallCompleted?.Invoke(ImageGenCallCompleted!);
            }
            else if (IsImageGenCallGenerating)
            {
                imageGenCallGenerating?.Invoke(ImageGenCallGenerating!);
            }
            else if (IsImageGenCallInProgress)
            {
                imageGenCallInProgress?.Invoke(ImageGenCallInProgress!);
            }
            else if (IsImageGenCallPartial)
            {
                imageGenCallPartial?.Invoke(ImageGenCallPartial!);
            }
            else if (IsMCPCallArgumentsDelta)
            {
                mCPCallArgumentsDelta?.Invoke(MCPCallArgumentsDelta!);
            }
            else if (IsMCPCallArgumentsDone)
            {
                mCPCallArgumentsDone?.Invoke(MCPCallArgumentsDone!);
            }
            else if (IsMCPCallCompleted)
            {
                mCPCallCompleted?.Invoke(MCPCallCompleted!);
            }
            else if (IsMCPCallFailed)
            {
                mCPCallFailed?.Invoke(MCPCallFailed!);
            }
            else if (IsMCPCallInProgress)
            {
                mCPCallInProgress?.Invoke(MCPCallInProgress!);
            }
            else if (IsMCPListToolsCompleted)
            {
                mCPListToolsCompleted?.Invoke(MCPListToolsCompleted!);
            }
            else if (IsMCPListToolsFailed)
            {
                mCPListToolsFailed?.Invoke(MCPListToolsFailed!);
            }
            else if (IsMCPListToolsInProgress)
            {
                mCPListToolsInProgress?.Invoke(MCPListToolsInProgress!);
            }
            else if (IsOutputTextAnnotationAdded)
            {
                outputTextAnnotationAdded?.Invoke(OutputTextAnnotationAdded!);
            }
            else if (IsQueued)
            {
                queued?.Invoke(Queued!);
            }
            else if (IsReasoningDelta)
            {
                reasoningDelta?.Invoke(ReasoningDelta!);
            }
            else if (IsReasoningDone)
            {
                reasoningDone?.Invoke(ReasoningDone!);
            }
            else if (IsReasoningSummaryDelta)
            {
                reasoningSummaryDelta?.Invoke(ReasoningSummaryDelta!);
            }
            else if (IsReasoningSummaryDone)
            {
                reasoningSummaryDone?.Invoke(ReasoningSummaryDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioDelta,
                typeof(global::G.ResponseAudioDeltaEvent),
                AudioDone,
                typeof(global::G.ResponseAudioDoneEvent),
                AudioTranscriptDelta,
                typeof(global::G.ResponseAudioTranscriptDeltaEvent),
                AudioTranscriptDone,
                typeof(global::G.ResponseAudioTranscriptDoneEvent),
                CodeInterpreterCallDelta,
                typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent),
                CodeInterpreterCallDone,
                typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent),
                CodeInterpreterCallCompleted,
                typeof(global::G.ResponseCodeInterpreterCallCompletedEvent),
                CodeInterpreterCallInProgress,
                typeof(global::G.ResponseCodeInterpreterCallInProgressEvent),
                CodeInterpreterCallInterpreting,
                typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent),
                Completed,
                typeof(global::G.ResponseCompletedEvent),
                ContentPartAdded,
                typeof(global::G.ResponseContentPartAddedEvent),
                ContentPartDone,
                typeof(global::G.ResponseContentPartDoneEvent),
                Created,
                typeof(global::G.ResponseCreatedEvent),
                Error,
                typeof(global::G.ResponseErrorEvent),
                FileSearchCallCompleted,
                typeof(global::G.ResponseFileSearchCallCompletedEvent),
                FileSearchCallInProgress,
                typeof(global::G.ResponseFileSearchCallInProgressEvent),
                FileSearchCallSearching,
                typeof(global::G.ResponseFileSearchCallSearchingEvent),
                FunctionCallArgumentsDelta,
                typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent),
                FunctionCallArgumentsDone,
                typeof(global::G.ResponseFunctionCallArgumentsDoneEvent),
                InProgress,
                typeof(global::G.ResponseInProgressEvent),
                Failed,
                typeof(global::G.ResponseFailedEvent),
                Incomplete,
                typeof(global::G.ResponseIncompleteEvent),
                OutputItemAdded,
                typeof(global::G.ResponseOutputItemAddedEvent),
                OutputItemDone,
                typeof(global::G.ResponseOutputItemDoneEvent),
                ReasoningSummaryPartAdded,
                typeof(global::G.ResponseReasoningSummaryPartAddedEvent),
                ReasoningSummaryPartDone,
                typeof(global::G.ResponseReasoningSummaryPartDoneEvent),
                ReasoningSummaryTextDelta,
                typeof(global::G.ResponseReasoningSummaryTextDeltaEvent),
                ReasoningSummaryTextDone,
                typeof(global::G.ResponseReasoningSummaryTextDoneEvent),
                RefusalDelta,
                typeof(global::G.ResponseRefusalDeltaEvent),
                RefusalDone,
                typeof(global::G.ResponseRefusalDoneEvent),
                TextDelta,
                typeof(global::G.ResponseTextDeltaEvent),
                TextDone,
                typeof(global::G.ResponseTextDoneEvent),
                WebSearchCallCompleted,
                typeof(global::G.ResponseWebSearchCallCompletedEvent),
                WebSearchCallInProgress,
                typeof(global::G.ResponseWebSearchCallInProgressEvent),
                WebSearchCallSearching,
                typeof(global::G.ResponseWebSearchCallSearchingEvent),
                ImageGenCallCompleted,
                typeof(global::G.ResponseImageGenCallCompletedEvent),
                ImageGenCallGenerating,
                typeof(global::G.ResponseImageGenCallGeneratingEvent),
                ImageGenCallInProgress,
                typeof(global::G.ResponseImageGenCallInProgressEvent),
                ImageGenCallPartial,
                typeof(global::G.ResponseImageGenCallPartialImageEvent),
                MCPCallArgumentsDelta,
                typeof(global::G.ResponseMCPCallArgumentsDeltaEvent),
                MCPCallArgumentsDone,
                typeof(global::G.ResponseMCPCallArgumentsDoneEvent),
                MCPCallCompleted,
                typeof(global::G.ResponseMCPCallCompletedEvent),
                MCPCallFailed,
                typeof(global::G.ResponseMCPCallFailedEvent),
                MCPCallInProgress,
                typeof(global::G.ResponseMCPCallInProgressEvent),
                MCPListToolsCompleted,
                typeof(global::G.ResponseMCPListToolsCompletedEvent),
                MCPListToolsFailed,
                typeof(global::G.ResponseMCPListToolsFailedEvent),
                MCPListToolsInProgress,
                typeof(global::G.ResponseMCPListToolsInProgressEvent),
                OutputTextAnnotationAdded,
                typeof(global::G.ResponseOutputTextAnnotationAddedEvent),
                Queued,
                typeof(global::G.ResponseQueuedEvent),
                ReasoningDelta,
                typeof(global::G.ResponseReasoningDeltaEvent),
                ReasoningDone,
                typeof(global::G.ResponseReasoningDoneEvent),
                ReasoningSummaryDelta,
                typeof(global::G.ResponseReasoningSummaryDeltaEvent),
                ReasoningSummaryDone,
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
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioDeltaEvent?>.Default.Equals(AudioDelta, other.AudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioDoneEvent?>.Default.Equals(AudioDone, other.AudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioTranscriptDeltaEvent?>.Default.Equals(AudioTranscriptDelta, other.AudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioTranscriptDoneEvent?>.Default.Equals(AudioTranscriptDone, other.AudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?>.Default.Equals(CodeInterpreterCallDelta, other.CodeInterpreterCallDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallCodeDoneEvent?>.Default.Equals(CodeInterpreterCallDone, other.CodeInterpreterCallDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallCompletedEvent?>.Default.Equals(CodeInterpreterCallCompleted, other.CodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallInProgressEvent?>.Default.Equals(CodeInterpreterCallInProgress, other.CodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCodeInterpreterCallInterpretingEvent?>.Default.Equals(CodeInterpreterCallInterpreting, other.CodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCompletedEvent?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentPartAddedEvent?>.Default.Equals(ContentPartAdded, other.ContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentPartDoneEvent?>.Default.Equals(ContentPartDone, other.ContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCreatedEvent?>.Default.Equals(Created, other.Created) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileSearchCallCompletedEvent?>.Default.Equals(FileSearchCallCompleted, other.FileSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileSearchCallInProgressEvent?>.Default.Equals(FileSearchCallInProgress, other.FileSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileSearchCallSearchingEvent?>.Default.Equals(FileSearchCallSearching, other.FileSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDeltaEvent?>.Default.Equals(FunctionCallArgumentsDelta, other.FunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(FunctionCallArgumentsDone, other.FunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseInProgressEvent?>.Default.Equals(InProgress, other.InProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFailedEvent?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseIncompleteEvent?>.Default.Equals(Incomplete, other.Incomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemAddedEvent?>.Default.Equals(OutputItemAdded, other.OutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemDoneEvent?>.Default.Equals(OutputItemDone, other.OutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryPartAddedEvent?>.Default.Equals(ReasoningSummaryPartAdded, other.ReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryPartDoneEvent?>.Default.Equals(ReasoningSummaryPartDone, other.ReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryTextDeltaEvent?>.Default.Equals(ReasoningSummaryTextDelta, other.ReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryTextDoneEvent?>.Default.Equals(ReasoningSummaryTextDone, other.ReasoningSummaryTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseRefusalDeltaEvent?>.Default.Equals(RefusalDelta, other.RefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseRefusalDoneEvent?>.Default.Equals(RefusalDone, other.RefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextDeltaEvent?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextDoneEvent?>.Default.Equals(TextDone, other.TextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseWebSearchCallCompletedEvent?>.Default.Equals(WebSearchCallCompleted, other.WebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseWebSearchCallInProgressEvent?>.Default.Equals(WebSearchCallInProgress, other.WebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseWebSearchCallSearchingEvent?>.Default.Equals(WebSearchCallSearching, other.WebSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallCompletedEvent?>.Default.Equals(ImageGenCallCompleted, other.ImageGenCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallGeneratingEvent?>.Default.Equals(ImageGenCallGenerating, other.ImageGenCallGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallInProgressEvent?>.Default.Equals(ImageGenCallInProgress, other.ImageGenCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseImageGenCallPartialImageEvent?>.Default.Equals(ImageGenCallPartial, other.ImageGenCallPartial) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallArgumentsDeltaEvent?>.Default.Equals(MCPCallArgumentsDelta, other.MCPCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallArgumentsDoneEvent?>.Default.Equals(MCPCallArgumentsDone, other.MCPCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallCompletedEvent?>.Default.Equals(MCPCallCompleted, other.MCPCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallFailedEvent?>.Default.Equals(MCPCallFailed, other.MCPCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPCallInProgressEvent?>.Default.Equals(MCPCallInProgress, other.MCPCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPListToolsCompletedEvent?>.Default.Equals(MCPListToolsCompleted, other.MCPListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPListToolsFailedEvent?>.Default.Equals(MCPListToolsFailed, other.MCPListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMCPListToolsInProgressEvent?>.Default.Equals(MCPListToolsInProgress, other.MCPListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputTextAnnotationAddedEvent?>.Default.Equals(OutputTextAnnotationAdded, other.OutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseQueuedEvent?>.Default.Equals(Queued, other.Queued) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningDeltaEvent?>.Default.Equals(ReasoningDelta, other.ReasoningDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningDoneEvent?>.Default.Equals(ReasoningDone, other.ReasoningDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryDeltaEvent?>.Default.Equals(ReasoningSummaryDelta, other.ReasoningSummaryDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseReasoningSummaryDoneEvent?>.Default.Equals(ReasoningSummaryDone, other.ReasoningSummaryDone) 
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
