//HintName: G.Models.ServerEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Session has been created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SessionCreatedEvent? SessionCreated { get; init; }
#else
        public global::G.SessionCreatedEvent? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// Session configuration has been updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SessionUpdatedEvent? SessionUpdated { get; init; }
#else
        public global::G.SessionUpdatedEvent? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// A new conversation has been created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationCreatedEvent? ConversationCreated { get; init; }
#else
        public global::G.ConversationCreatedEvent? ConversationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationCreated))]
#endif
        public bool IsConversationCreated => ConversationCreated != null;

        /// <summary>
        /// A conversation item has been added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationItemAddedEvent? ConversationItemAdded { get; init; }
#else
        public global::G.ConversationItemAddedEvent? ConversationItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemAdded))]
#endif
        public bool IsConversationItemAdded => ConversationItemAdded != null;

        /// <summary>
        /// Speech detected in audio input (VAD).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferSpeechStartedEvent? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::G.InputAudioBufferSpeechStartedEvent? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        /// Speech has stopped in audio input (VAD).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferSpeechStoppedEvent? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::G.InputAudioBufferSpeechStoppedEvent? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        /// Audio buffer has been committed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferCommittedEvent? InputAudioBufferCommitted { get; init; }
#else
        public global::G.InputAudioBufferCommittedEvent? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        /// Audio transcription has been completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioTranscriptionCompletedEvent? InputAudioTranscriptionCompleted { get; init; }
#else
        public global::G.InputAudioTranscriptionCompletedEvent? InputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioTranscriptionCompleted))]
#endif
        public bool IsInputAudioTranscriptionCompleted => InputAudioTranscriptionCompleted != null;

        /// <summary>
        /// A response has been created.
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
        /// A response has completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseDoneEvent? ResponseDone { get; init; }
#else
        public global::G.ResponseDoneEvent? ResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        /// An output item has been added to the response.
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
        /// Incremental audio transcript text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputAudioTranscriptDeltaEvent? ResponseOutputAudioTranscriptDelta { get; init; }
#else
        public global::G.ResponseOutputAudioTranscriptDeltaEvent? ResponseOutputAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDelta))]
#endif
        public bool IsResponseOutputAudioTranscriptDelta => ResponseOutputAudioTranscriptDelta != null;

        /// <summary>
        /// Audio transcript completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputAudioTranscriptDoneEvent? ResponseOutputAudioTranscriptDone { get; init; }
#else
        public global::G.ResponseOutputAudioTranscriptDoneEvent? ResponseOutputAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDone))]
#endif
        public bool IsResponseOutputAudioTranscriptDone => ResponseOutputAudioTranscriptDone != null;

        /// <summary>
        /// Incremental audio data (base64).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputAudioDeltaEvent? ResponseOutputAudioDelta { get; init; }
#else
        public global::G.ResponseOutputAudioDeltaEvent? ResponseOutputAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDelta))]
#endif
        public bool IsResponseOutputAudioDelta => ResponseOutputAudioDelta != null;

        /// <summary>
        /// Audio output completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputAudioDoneEvent? ResponseOutputAudioDone { get; init; }
#else
        public global::G.ResponseOutputAudioDoneEvent? ResponseOutputAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDone))]
#endif
        public bool IsResponseOutputAudioDone => ResponseOutputAudioDone != null;

        /// <summary>
        /// Function call arguments completed.
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
        /// MCP tool call arguments completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMcpCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::G.ResponseMcpCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDone))]
#endif
        public bool IsResponseMcpCallArgumentsDone => ResponseMcpCallArgumentsDone != null;

        /// <summary>
        /// MCP tool call completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMcpCallCompletedEvent? ResponseMcpCallCompleted { get; init; }
#else
        public global::G.ResponseMcpCallCompletedEvent? ResponseMcpCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallCompleted))]
#endif
        public bool IsResponseMcpCallCompleted => ResponseMcpCallCompleted != null;

        /// <summary>
        /// MCP tool call failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseMcpCallFailedEvent? ResponseMcpCallFailed { get; init; }
#else
        public global::G.ResponseMcpCallFailedEvent? ResponseMcpCallFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallFailed))]
#endif
        public bool IsResponseMcpCallFailed => ResponseMcpCallFailed != null;

        /// <summary>
        /// MCP tool list retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpListToolsCompletedEvent? McpListToolsCompleted { get; init; }
#else
        public global::G.McpListToolsCompletedEvent? McpListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListToolsCompleted))]
#endif
        public bool IsMcpListToolsCompleted => McpListToolsCompleted != null;

        /// <summary>
        /// An error occurred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorEvent? Error { get; init; }
#else
        public global::G.ErrorEvent? Error { get; }
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
        public static implicit operator ServerEvent(global::G.SessionCreatedEvent value) => new ServerEvent((global::G.SessionCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionCreatedEvent?(ServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.SessionCreatedEvent? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.SessionUpdatedEvent value) => new ServerEvent((global::G.SessionUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionUpdatedEvent?(ServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.SessionUpdatedEvent? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationCreatedEvent value) => new ServerEvent((global::G.ConversationCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationCreatedEvent?(ServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationCreatedEvent? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationItemAddedEvent value) => new ServerEvent((global::G.ConversationItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationItemAddedEvent?(ServerEvent @this) => @this.ConversationItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationItemAddedEvent? value)
        {
            ConversationItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferSpeechStartedEvent value) => new ServerEvent((global::G.InputAudioBufferSpeechStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferSpeechStartedEvent?(ServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferSpeechStartedEvent? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferSpeechStoppedEvent value) => new ServerEvent((global::G.InputAudioBufferSpeechStoppedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferSpeechStoppedEvent?(ServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferSpeechStoppedEvent? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferCommittedEvent value) => new ServerEvent((global::G.InputAudioBufferCommittedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferCommittedEvent?(ServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferCommittedEvent? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioTranscriptionCompletedEvent value) => new ServerEvent((global::G.InputAudioTranscriptionCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioTranscriptionCompletedEvent?(ServerEvent @this) => @this.InputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioTranscriptionCompletedEvent? value)
        {
            InputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseCreatedEvent value) => new ServerEvent((global::G.ResponseCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCreatedEvent?(ServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseDoneEvent value) => new ServerEvent((global::G.ResponseDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseDoneEvent?(ServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseDoneEvent? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputItemAddedEvent value) => new ServerEvent((global::G.ResponseOutputItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemAddedEvent?(ServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputItemAddedEvent? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputAudioTranscriptDeltaEvent value) => new ServerEvent((global::G.ResponseOutputAudioTranscriptDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputAudioTranscriptDeltaEvent?(ServerEvent @this) => @this.ResponseOutputAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputAudioTranscriptDeltaEvent? value)
        {
            ResponseOutputAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputAudioTranscriptDoneEvent value) => new ServerEvent((global::G.ResponseOutputAudioTranscriptDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputAudioTranscriptDoneEvent?(ServerEvent @this) => @this.ResponseOutputAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputAudioTranscriptDoneEvent? value)
        {
            ResponseOutputAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputAudioDeltaEvent value) => new ServerEvent((global::G.ResponseOutputAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputAudioDeltaEvent?(ServerEvent @this) => @this.ResponseOutputAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputAudioDeltaEvent? value)
        {
            ResponseOutputAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputAudioDoneEvent value) => new ServerEvent((global::G.ResponseOutputAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputAudioDoneEvent?(ServerEvent @this) => @this.ResponseOutputAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputAudioDoneEvent? value)
        {
            ResponseOutputAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseFunctionCallArgumentsDoneEvent value) => new ServerEvent((global::G.ResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDoneEvent?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseMcpCallArgumentsDoneEvent value) => new ServerEvent((global::G.ResponseMcpCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMcpCallArgumentsDoneEvent?(ServerEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseMcpCallArgumentsDoneEvent? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseMcpCallCompletedEvent value) => new ServerEvent((global::G.ResponseMcpCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMcpCallCompletedEvent?(ServerEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseMcpCallCompletedEvent? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseMcpCallFailedEvent value) => new ServerEvent((global::G.ResponseMcpCallFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseMcpCallFailedEvent?(ServerEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseMcpCallFailedEvent? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.McpListToolsCompletedEvent value) => new ServerEvent((global::G.McpListToolsCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpListToolsCompletedEvent?(ServerEvent @this) => @this.McpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.McpListToolsCompletedEvent? value)
        {
            McpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ErrorEvent value) => new ServerEvent((global::G.ErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorEvent?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::G.ServerEventDiscriminatorType? type,
            global::G.SessionCreatedEvent? sessionCreated,
            global::G.SessionUpdatedEvent? sessionUpdated,
            global::G.ConversationCreatedEvent? conversationCreated,
            global::G.ConversationItemAddedEvent? conversationItemAdded,
            global::G.InputAudioBufferSpeechStartedEvent? inputAudioBufferSpeechStarted,
            global::G.InputAudioBufferSpeechStoppedEvent? inputAudioBufferSpeechStopped,
            global::G.InputAudioBufferCommittedEvent? inputAudioBufferCommitted,
            global::G.InputAudioTranscriptionCompletedEvent? inputAudioTranscriptionCompleted,
            global::G.ResponseCreatedEvent? responseCreated,
            global::G.ResponseDoneEvent? responseDone,
            global::G.ResponseOutputItemAddedEvent? responseOutputItemAdded,
            global::G.ResponseOutputAudioTranscriptDeltaEvent? responseOutputAudioTranscriptDelta,
            global::G.ResponseOutputAudioTranscriptDoneEvent? responseOutputAudioTranscriptDone,
            global::G.ResponseOutputAudioDeltaEvent? responseOutputAudioDelta,
            global::G.ResponseOutputAudioDoneEvent? responseOutputAudioDone,
            global::G.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone,
            global::G.ResponseMcpCallArgumentsDoneEvent? responseMcpCallArgumentsDone,
            global::G.ResponseMcpCallCompletedEvent? responseMcpCallCompleted,
            global::G.ResponseMcpCallFailedEvent? responseMcpCallFailed,
            global::G.McpListToolsCompletedEvent? mcpListToolsCompleted,
            global::G.ErrorEvent? error
            )
        {
            Type = type;

            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            ConversationCreated = conversationCreated;
            ConversationItemAdded = conversationItemAdded;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioTranscriptionCompleted = inputAudioTranscriptionCompleted;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputAudioTranscriptDelta = responseOutputAudioTranscriptDelta;
            ResponseOutputAudioTranscriptDone = responseOutputAudioTranscriptDone;
            ResponseOutputAudioDelta = responseOutputAudioDelta;
            ResponseOutputAudioDone = responseOutputAudioDone;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseMcpCallArgumentsDone = responseMcpCallArgumentsDone;
            ResponseMcpCallCompleted = responseMcpCallCompleted;
            ResponseMcpCallFailed = responseMcpCallFailed;
            McpListToolsCompleted = mcpListToolsCompleted;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            McpListToolsCompleted as object ??
            ResponseMcpCallFailed as object ??
            ResponseMcpCallCompleted as object ??
            ResponseMcpCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseOutputAudioDone as object ??
            ResponseOutputAudioDelta as object ??
            ResponseOutputAudioTranscriptDone as object ??
            ResponseOutputAudioTranscriptDelta as object ??
            ResponseOutputItemAdded as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            InputAudioTranscriptionCompleted as object ??
            InputAudioBufferCommitted as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            ConversationItemAdded as object ??
            ConversationCreated as object ??
            SessionUpdated as object ??
            SessionCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            ConversationCreated?.ToString() ??
            ConversationItemAdded?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioTranscriptionCompleted?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputAudioTranscriptDelta?.ToString() ??
            ResponseOutputAudioTranscriptDone?.ToString() ??
            ResponseOutputAudioDelta?.ToString() ??
            ResponseOutputAudioDone?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseMcpCallArgumentsDone?.ToString() ??
            ResponseMcpCallCompleted?.ToString() ??
            ResponseMcpCallFailed?.ToString() ??
            McpListToolsCompleted?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && IsResponseMcpCallFailed && !IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && IsMcpListToolsCompleted && !IsError || !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemAdded && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioTranscriptionCompleted && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsMcpListToolsCompleted && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SessionCreatedEvent?, TResult>? sessionCreated = null,
            global::System.Func<global::G.SessionUpdatedEvent?, TResult>? sessionUpdated = null,
            global::System.Func<global::G.ConversationCreatedEvent?, TResult>? conversationCreated = null,
            global::System.Func<global::G.ConversationItemAddedEvent?, TResult>? conversationItemAdded = null,
            global::System.Func<global::G.InputAudioBufferSpeechStartedEvent?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::G.InputAudioBufferSpeechStoppedEvent?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::G.InputAudioBufferCommittedEvent?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::G.InputAudioTranscriptionCompletedEvent?, TResult>? inputAudioTranscriptionCompleted = null,
            global::System.Func<global::G.ResponseCreatedEvent?, TResult>? responseCreated = null,
            global::System.Func<global::G.ResponseDoneEvent?, TResult>? responseDone = null,
            global::System.Func<global::G.ResponseOutputItemAddedEvent?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::G.ResponseOutputAudioTranscriptDeltaEvent?, TResult>? responseOutputAudioTranscriptDelta = null,
            global::System.Func<global::G.ResponseOutputAudioTranscriptDoneEvent?, TResult>? responseOutputAudioTranscriptDone = null,
            global::System.Func<global::G.ResponseOutputAudioDeltaEvent?, TResult>? responseOutputAudioDelta = null,
            global::System.Func<global::G.ResponseOutputAudioDoneEvent?, TResult>? responseOutputAudioDone = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDoneEvent?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::G.ResponseMcpCallArgumentsDoneEvent?, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::G.ResponseMcpCallCompletedEvent?, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::G.ResponseMcpCallFailedEvent?, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::G.McpListToolsCompletedEvent?, TResult>? mcpListToolsCompleted = null,
            global::System.Func<global::G.ErrorEvent?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsConversationCreated && conversationCreated != null)
            {
                return conversationCreated(ConversationCreated!);
            }
            else if (IsConversationItemAdded && conversationItemAdded != null)
            {
                return conversationItemAdded(ConversationItemAdded!);
            }
            else if (IsInputAudioBufferSpeechStarted && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(InputAudioBufferSpeechStopped!);
            }
            else if (IsInputAudioBufferCommitted && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioTranscriptionCompleted && inputAudioTranscriptionCompleted != null)
            {
                return inputAudioTranscriptionCompleted(InputAudioTranscriptionCompleted!);
            }
            else if (IsResponseCreated && responseCreated != null)
            {
                return responseCreated(ResponseCreated!);
            }
            else if (IsResponseDone && responseDone != null)
            {
                return responseDone(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputAudioTranscriptDelta && responseOutputAudioTranscriptDelta != null)
            {
                return responseOutputAudioTranscriptDelta(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone && responseOutputAudioTranscriptDone != null)
            {
                return responseOutputAudioTranscriptDone(ResponseOutputAudioTranscriptDone!);
            }
            else if (IsResponseOutputAudioDelta && responseOutputAudioDelta != null)
            {
                return responseOutputAudioDelta(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone && responseOutputAudioDone != null)
            {
                return responseOutputAudioDone(ResponseOutputAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
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
            else if (IsMcpListToolsCompleted && mcpListToolsCompleted != null)
            {
                return mcpListToolsCompleted(McpListToolsCompleted!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SessionCreatedEvent?>? sessionCreated = null,
            global::System.Action<global::G.SessionUpdatedEvent?>? sessionUpdated = null,
            global::System.Action<global::G.ConversationCreatedEvent?>? conversationCreated = null,
            global::System.Action<global::G.ConversationItemAddedEvent?>? conversationItemAdded = null,
            global::System.Action<global::G.InputAudioBufferSpeechStartedEvent?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::G.InputAudioBufferSpeechStoppedEvent?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::G.InputAudioBufferCommittedEvent?>? inputAudioBufferCommitted = null,
            global::System.Action<global::G.InputAudioTranscriptionCompletedEvent?>? inputAudioTranscriptionCompleted = null,
            global::System.Action<global::G.ResponseCreatedEvent?>? responseCreated = null,
            global::System.Action<global::G.ResponseDoneEvent?>? responseDone = null,
            global::System.Action<global::G.ResponseOutputItemAddedEvent?>? responseOutputItemAdded = null,
            global::System.Action<global::G.ResponseOutputAudioTranscriptDeltaEvent?>? responseOutputAudioTranscriptDelta = null,
            global::System.Action<global::G.ResponseOutputAudioTranscriptDoneEvent?>? responseOutputAudioTranscriptDone = null,
            global::System.Action<global::G.ResponseOutputAudioDeltaEvent?>? responseOutputAudioDelta = null,
            global::System.Action<global::G.ResponseOutputAudioDoneEvent?>? responseOutputAudioDone = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDoneEvent?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::G.ResponseMcpCallArgumentsDoneEvent?>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::G.ResponseMcpCallCompletedEvent?>? responseMcpCallCompleted = null,
            global::System.Action<global::G.ResponseMcpCallFailedEvent?>? responseMcpCallFailed = null,
            global::System.Action<global::G.McpListToolsCompletedEvent?>? mcpListToolsCompleted = null,
            global::System.Action<global::G.ErrorEvent?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsConversationCreated)
            {
                conversationCreated?.Invoke(ConversationCreated!);
            }
            else if (IsConversationItemAdded)
            {
                conversationItemAdded?.Invoke(ConversationItemAdded!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioTranscriptionCompleted)
            {
                inputAudioTranscriptionCompleted?.Invoke(InputAudioTranscriptionCompleted!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsResponseDone)
            {
                responseDone?.Invoke(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputAudioTranscriptDelta)
            {
                responseOutputAudioTranscriptDelta?.Invoke(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone)
            {
                responseOutputAudioTranscriptDone?.Invoke(ResponseOutputAudioTranscriptDone!);
            }
            else if (IsResponseOutputAudioDelta)
            {
                responseOutputAudioDelta?.Invoke(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone)
            {
                responseOutputAudioDone?.Invoke(ResponseOutputAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
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
            else if (IsMcpListToolsCompleted)
            {
                mcpListToolsCompleted?.Invoke(McpListToolsCompleted!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionCreated,
                typeof(global::G.SessionCreatedEvent),
                SessionUpdated,
                typeof(global::G.SessionUpdatedEvent),
                ConversationCreated,
                typeof(global::G.ConversationCreatedEvent),
                ConversationItemAdded,
                typeof(global::G.ConversationItemAddedEvent),
                InputAudioBufferSpeechStarted,
                typeof(global::G.InputAudioBufferSpeechStartedEvent),
                InputAudioBufferSpeechStopped,
                typeof(global::G.InputAudioBufferSpeechStoppedEvent),
                InputAudioBufferCommitted,
                typeof(global::G.InputAudioBufferCommittedEvent),
                InputAudioTranscriptionCompleted,
                typeof(global::G.InputAudioTranscriptionCompletedEvent),
                ResponseCreated,
                typeof(global::G.ResponseCreatedEvent),
                ResponseDone,
                typeof(global::G.ResponseDoneEvent),
                ResponseOutputItemAdded,
                typeof(global::G.ResponseOutputItemAddedEvent),
                ResponseOutputAudioTranscriptDelta,
                typeof(global::G.ResponseOutputAudioTranscriptDeltaEvent),
                ResponseOutputAudioTranscriptDone,
                typeof(global::G.ResponseOutputAudioTranscriptDoneEvent),
                ResponseOutputAudioDelta,
                typeof(global::G.ResponseOutputAudioDeltaEvent),
                ResponseOutputAudioDone,
                typeof(global::G.ResponseOutputAudioDoneEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::G.ResponseFunctionCallArgumentsDoneEvent),
                ResponseMcpCallArgumentsDone,
                typeof(global::G.ResponseMcpCallArgumentsDoneEvent),
                ResponseMcpCallCompleted,
                typeof(global::G.ResponseMcpCallCompletedEvent),
                ResponseMcpCallFailed,
                typeof(global::G.ResponseMcpCallFailedEvent),
                McpListToolsCompleted,
                typeof(global::G.McpListToolsCompletedEvent),
                Error,
                typeof(global::G.ErrorEvent),
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
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SessionCreatedEvent?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SessionUpdatedEvent?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationCreatedEvent?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationItemAddedEvent?>.Default.Equals(ConversationItemAdded, other.ConversationItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferSpeechStartedEvent?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferSpeechStoppedEvent?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferCommittedEvent?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioTranscriptionCompletedEvent?>.Default.Equals(InputAudioTranscriptionCompleted, other.InputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseDoneEvent?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemAddedEvent?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputAudioTranscriptDeltaEvent?>.Default.Equals(ResponseOutputAudioTranscriptDelta, other.ResponseOutputAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputAudioTranscriptDoneEvent?>.Default.Equals(ResponseOutputAudioTranscriptDone, other.ResponseOutputAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputAudioDeltaEvent?>.Default.Equals(ResponseOutputAudioDelta, other.ResponseOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputAudioDoneEvent?>.Default.Equals(ResponseOutputAudioDone, other.ResponseOutputAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMcpCallArgumentsDoneEvent?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMcpCallCompletedEvent?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseMcpCallFailedEvent?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpListToolsCompletedEvent?>.Default.Equals(McpListToolsCompleted, other.McpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorEvent?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
