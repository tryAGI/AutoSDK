//HintName: G.Models.AgentStreamedResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when the agent response is streamed.
    /// </summary>
    public readonly partial struct AgentStreamedResponse : global::System.IEquatable<AgentStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentStreamedResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// An input message event from a user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageEvent? InputMessage { get; init; }
#else
        public global::G.InputMessageEvent? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// A streaming chunk of agent output (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingAgentOutput? StreamingAgentOutput { get; init; }
#else
        public global::G.StreamingAgentOutput? StreamingAgentOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingAgentOutput))]
#endif
        public bool IsStreamingAgentOutput => StreamingAgentOutput != null;

        /// <summary>
        /// Signals the end of streaming agent output (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingAgentOutputEnd? StreamingAgentOutputEnd { get; init; }
#else
        public global::G.StreamingAgentOutputEnd? StreamingAgentOutputEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingAgentOutputEnd))]
#endif
        public bool IsStreamingAgentOutputEnd => StreamingAgentOutputEnd != null;

        /// <summary>
        /// A streaming chunk of agent thinking (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingThinking? StreamingThinking { get; init; }
#else
        public global::G.StreamingThinking? StreamingThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingThinking))]
#endif
        public bool IsStreamingThinking => StreamingThinking != null;

        /// <summary>
        /// Signals the end of streaming thinking (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamingThinkingEnd? StreamingThinkingEnd { get; init; }
#else
        public global::G.StreamingThinkingEnd? StreamingThinkingEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingThinkingEnd))]
#endif
        public bool IsStreamingThinkingEnd => StreamingThinkingEnd != null;

        /// <summary>
        /// An event representing input to a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolInputEvent? ToolInput { get; init; }
#else
        public global::G.ToolInputEvent? ToolInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolInput))]
#endif
        public bool IsToolInput => ToolInput != null;

        /// <summary>
        /// An event representing output from a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolOutputEvent? ToolOutput { get; init; }
#else
        public global::G.ToolOutputEvent? ToolOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolOutput))]
#endif
        public bool IsToolOutput => ToolOutput != null;

        /// <summary>
        /// An event representing a complete agent response with structured JSON content conforming to a schema.<br/>
        /// This event is published instead of AgentOutputEvent when the agent's output_parser is configured<br/>
        /// with type "structured". It contains the LLM's final response parsed as validated JSON that<br/>
        /// conforms to the schema specified in the StructuredOutputParser configuration.<br/>
        /// When streaming is enabled, this event appears as a single complete event (not streamed in chunks)<br/>
        /// after any tool interactions are complete. The content field contains the parsed JSON,<br/>
        /// and schema_name identifies which schema the content was validated against.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StructuredOutputEvent? StructuredOutput { get; init; }
#else
        public global::G.StructuredOutputEvent? StructuredOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredOutput))]
#endif
        public bool IsStructuredOutput => StructuredOutput != null;

        /// <summary>
        /// A transient event indicating the current request exceeded the LLM's context limit.<br/>
        /// This event is not persisted to the session history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContextLimitExceededEvent? ContextLimitExceeded { get; init; }
#else
        public global::G.ContextLimitExceededEvent? ContextLimitExceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextLimitExceeded))]
#endif
        public bool IsContextLimitExceeded => ContextLimitExceeded != null;

        /// <summary>
        /// A transient event indicating the agent exceeded the maximum number of step transitions,<br/>
        /// which may indicate an infinite loop between steps.<br/>
        /// This event is not persisted to the session history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StepTransitionLimitExceededEvent? StepTransitionLimitExceeded { get; init; }
#else
        public global::G.StepTransitionLimitExceededEvent? StepTransitionLimitExceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransitionLimitExceeded))]
#endif
        public bool IsStepTransitionLimitExceeded => StepTransitionLimitExceeded != null;

        /// <summary>
        /// A transient event indicating the agent session was interrupted by a user request.<br/>
        /// This event is not persisted to the session history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SessionInterruptedEvent? SessionInterrupted { get; init; }
#else
        public global::G.SessionInterruptedEvent? SessionInterrupted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInterrupted))]
#endif
        public bool IsSessionInterrupted => SessionInterrupted != null;

        /// <summary>
        /// An event representing an image being loaded into the conversation context for viewing and analysis.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageReadEvent? ImageRead { get; init; }
#else
        public global::G.ImageReadEvent? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// An event representing a transition between agent steps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StepTransitionEvent? StepTransition { get; init; }
#else
        public global::G.StepTransitionEvent? StepTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransition))]
#endif
        public bool IsStepTransition => StepTransition != null;

        /// <summary>
        /// Token usage event reporting context window consumption.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContextConsumedEvent? ContextConsumed { get; init; }
#else
        public global::G.ContextConsumedEvent? ContextConsumed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextConsumed))]
#endif
        public bool IsContextConsumed => ContextConsumed != null;

        /// <summary>
        /// An event indicating that context compaction has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompactionStartedEvent? CompactionStarted { get; init; }
#else
        public global::G.CompactionStartedEvent? CompactionStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionStarted))]
#endif
        public bool IsCompactionStarted => CompactionStarted != null;

        /// <summary>
        /// An event indicating that context compaction has completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompactionEvent? Compaction { get; init; }
#else
        public global::G.CompactionEvent? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamError? Error { get; init; }
#else
        public global::G.StreamError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamResponseEnd? End { get; init; }
#else
        public global::G.StreamResponseEnd? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.InputMessageEvent value) => new AgentStreamedResponse((global::G.InputMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageEvent?(AgentStreamedResponse @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.InputMessageEvent? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StreamingAgentOutput value) => new AgentStreamedResponse((global::G.StreamingAgentOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingAgentOutput?(AgentStreamedResponse @this) => @this.StreamingAgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StreamingAgentOutput? value)
        {
            StreamingAgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StreamingAgentOutputEnd value) => new AgentStreamedResponse((global::G.StreamingAgentOutputEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingAgentOutputEnd?(AgentStreamedResponse @this) => @this.StreamingAgentOutputEnd;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StreamingAgentOutputEnd? value)
        {
            StreamingAgentOutputEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StreamingThinking value) => new AgentStreamedResponse((global::G.StreamingThinking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingThinking?(AgentStreamedResponse @this) => @this.StreamingThinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StreamingThinking? value)
        {
            StreamingThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StreamingThinkingEnd value) => new AgentStreamedResponse((global::G.StreamingThinkingEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamingThinkingEnd?(AgentStreamedResponse @this) => @this.StreamingThinkingEnd;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StreamingThinkingEnd? value)
        {
            StreamingThinkingEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.ToolInputEvent value) => new AgentStreamedResponse((global::G.ToolInputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolInputEvent?(AgentStreamedResponse @this) => @this.ToolInput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.ToolInputEvent? value)
        {
            ToolInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.ToolOutputEvent value) => new AgentStreamedResponse((global::G.ToolOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolOutputEvent?(AgentStreamedResponse @this) => @this.ToolOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.ToolOutputEvent? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StructuredOutputEvent value) => new AgentStreamedResponse((global::G.StructuredOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StructuredOutputEvent?(AgentStreamedResponse @this) => @this.StructuredOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StructuredOutputEvent? value)
        {
            StructuredOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.ContextLimitExceededEvent value) => new AgentStreamedResponse((global::G.ContextLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContextLimitExceededEvent?(AgentStreamedResponse @this) => @this.ContextLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.ContextLimitExceededEvent? value)
        {
            ContextLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StepTransitionLimitExceededEvent value) => new AgentStreamedResponse((global::G.StepTransitionLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StepTransitionLimitExceededEvent?(AgentStreamedResponse @this) => @this.StepTransitionLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StepTransitionLimitExceededEvent? value)
        {
            StepTransitionLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.SessionInterruptedEvent value) => new AgentStreamedResponse((global::G.SessionInterruptedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionInterruptedEvent?(AgentStreamedResponse @this) => @this.SessionInterrupted;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.SessionInterruptedEvent? value)
        {
            SessionInterrupted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.ImageReadEvent value) => new AgentStreamedResponse((global::G.ImageReadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageReadEvent?(AgentStreamedResponse @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.ImageReadEvent? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StepTransitionEvent value) => new AgentStreamedResponse((global::G.StepTransitionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StepTransitionEvent?(AgentStreamedResponse @this) => @this.StepTransition;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StepTransitionEvent? value)
        {
            StepTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.ContextConsumedEvent value) => new AgentStreamedResponse((global::G.ContextConsumedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContextConsumedEvent?(AgentStreamedResponse @this) => @this.ContextConsumed;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.ContextConsumedEvent? value)
        {
            ContextConsumed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.CompactionStartedEvent value) => new AgentStreamedResponse((global::G.CompactionStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompactionStartedEvent?(AgentStreamedResponse @this) => @this.CompactionStarted;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.CompactionStartedEvent? value)
        {
            CompactionStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.CompactionEvent value) => new AgentStreamedResponse((global::G.CompactionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompactionEvent?(AgentStreamedResponse @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.CompactionEvent? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StreamError value) => new AgentStreamedResponse((global::G.StreamError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamError?(AgentStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StreamError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::G.StreamResponseEnd value) => new AgentStreamedResponse((global::G.StreamResponseEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamResponseEnd?(AgentStreamedResponse @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::G.StreamResponseEnd? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(
            global::G.AgentStreamedResponseDiscriminatorType? type,
            global::G.InputMessageEvent? inputMessage,
            global::G.StreamingAgentOutput? streamingAgentOutput,
            global::G.StreamingAgentOutputEnd? streamingAgentOutputEnd,
            global::G.StreamingThinking? streamingThinking,
            global::G.StreamingThinkingEnd? streamingThinkingEnd,
            global::G.ToolInputEvent? toolInput,
            global::G.ToolOutputEvent? toolOutput,
            global::G.StructuredOutputEvent? structuredOutput,
            global::G.ContextLimitExceededEvent? contextLimitExceeded,
            global::G.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded,
            global::G.SessionInterruptedEvent? sessionInterrupted,
            global::G.ImageReadEvent? imageRead,
            global::G.StepTransitionEvent? stepTransition,
            global::G.ContextConsumedEvent? contextConsumed,
            global::G.CompactionStartedEvent? compactionStarted,
            global::G.CompactionEvent? compaction,
            global::G.StreamError? error,
            global::G.StreamResponseEnd? end
            )
        {
            Type = type;

            InputMessage = inputMessage;
            StreamingAgentOutput = streamingAgentOutput;
            StreamingAgentOutputEnd = streamingAgentOutputEnd;
            StreamingThinking = streamingThinking;
            StreamingThinkingEnd = streamingThinkingEnd;
            ToolInput = toolInput;
            ToolOutput = toolOutput;
            StructuredOutput = structuredOutput;
            ContextLimitExceeded = contextLimitExceeded;
            StepTransitionLimitExceeded = stepTransitionLimitExceeded;
            SessionInterrupted = sessionInterrupted;
            ImageRead = imageRead;
            StepTransition = stepTransition;
            ContextConsumed = contextConsumed;
            CompactionStarted = compactionStarted;
            Compaction = compaction;
            Error = error;
            End = end;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            End as object ??
            Error as object ??
            Compaction as object ??
            CompactionStarted as object ??
            ContextConsumed as object ??
            StepTransition as object ??
            ImageRead as object ??
            SessionInterrupted as object ??
            StepTransitionLimitExceeded as object ??
            ContextLimitExceeded as object ??
            StructuredOutput as object ??
            ToolOutput as object ??
            ToolInput as object ??
            StreamingThinkingEnd as object ??
            StreamingThinking as object ??
            StreamingAgentOutputEnd as object ??
            StreamingAgentOutput as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            StreamingAgentOutput?.ToString() ??
            StreamingAgentOutputEnd?.ToString() ??
            StreamingThinking?.ToString() ??
            StreamingThinkingEnd?.ToString() ??
            ToolInput?.ToString() ??
            ToolOutput?.ToString() ??
            StructuredOutput?.ToString() ??
            ContextLimitExceeded?.ToString() ??
            StepTransitionLimitExceeded?.ToString() ??
            SessionInterrupted?.ToString() ??
            ImageRead?.ToString() ??
            StepTransition?.ToString() ??
            ContextConsumed?.ToString() ??
            CompactionStarted?.ToString() ??
            Compaction?.ToString() ??
            Error?.ToString() ??
            End?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && IsEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::G.StreamingAgentOutput?, TResult>? streamingAgentOutput = null,
            global::System.Func<global::G.StreamingAgentOutputEnd?, TResult>? streamingAgentOutputEnd = null,
            global::System.Func<global::G.StreamingThinking?, TResult>? streamingThinking = null,
            global::System.Func<global::G.StreamingThinkingEnd?, TResult>? streamingThinkingEnd = null,
            global::System.Func<global::G.ToolInputEvent?, TResult>? toolInput = null,
            global::System.Func<global::G.ToolOutputEvent?, TResult>? toolOutput = null,
            global::System.Func<global::G.StructuredOutputEvent?, TResult>? structuredOutput = null,
            global::System.Func<global::G.ContextLimitExceededEvent?, TResult>? contextLimitExceeded = null,
            global::System.Func<global::G.StepTransitionLimitExceededEvent?, TResult>? stepTransitionLimitExceeded = null,
            global::System.Func<global::G.SessionInterruptedEvent?, TResult>? sessionInterrupted = null,
            global::System.Func<global::G.ImageReadEvent?, TResult>? imageRead = null,
            global::System.Func<global::G.StepTransitionEvent?, TResult>? stepTransition = null,
            global::System.Func<global::G.ContextConsumedEvent?, TResult>? contextConsumed = null,
            global::System.Func<global::G.CompactionStartedEvent?, TResult>? compactionStarted = null,
            global::System.Func<global::G.CompactionEvent?, TResult>? compaction = null,
            global::System.Func<global::G.StreamError?, TResult>? error = null,
            global::System.Func<global::G.StreamResponseEnd?, TResult>? end = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsStreamingAgentOutput && streamingAgentOutput != null)
            {
                return streamingAgentOutput(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd && streamingAgentOutputEnd != null)
            {
                return streamingAgentOutputEnd(StreamingAgentOutputEnd!);
            }
            else if (IsStreamingThinking && streamingThinking != null)
            {
                return streamingThinking(StreamingThinking!);
            }
            else if (IsStreamingThinkingEnd && streamingThinkingEnd != null)
            {
                return streamingThinkingEnd(StreamingThinkingEnd!);
            }
            else if (IsToolInput && toolInput != null)
            {
                return toolInput(ToolInput!);
            }
            else if (IsToolOutput && toolOutput != null)
            {
                return toolOutput(ToolOutput!);
            }
            else if (IsStructuredOutput && structuredOutput != null)
            {
                return structuredOutput(StructuredOutput!);
            }
            else if (IsContextLimitExceeded && contextLimitExceeded != null)
            {
                return contextLimitExceeded(ContextLimitExceeded!);
            }
            else if (IsStepTransitionLimitExceeded && stepTransitionLimitExceeded != null)
            {
                return stepTransitionLimitExceeded(StepTransitionLimitExceeded!);
            }
            else if (IsSessionInterrupted && sessionInterrupted != null)
            {
                return sessionInterrupted(SessionInterrupted!);
            }
            else if (IsImageRead && imageRead != null)
            {
                return imageRead(ImageRead!);
            }
            else if (IsStepTransition && stepTransition != null)
            {
                return stepTransition(StepTransition!);
            }
            else if (IsContextConsumed && contextConsumed != null)
            {
                return contextConsumed(ContextConsumed!);
            }
            else if (IsCompactionStarted && compactionStarted != null)
            {
                return compactionStarted(CompactionStarted!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputMessageEvent?>? inputMessage = null,
            global::System.Action<global::G.StreamingAgentOutput?>? streamingAgentOutput = null,
            global::System.Action<global::G.StreamingAgentOutputEnd?>? streamingAgentOutputEnd = null,
            global::System.Action<global::G.StreamingThinking?>? streamingThinking = null,
            global::System.Action<global::G.StreamingThinkingEnd?>? streamingThinkingEnd = null,
            global::System.Action<global::G.ToolInputEvent?>? toolInput = null,
            global::System.Action<global::G.ToolOutputEvent?>? toolOutput = null,
            global::System.Action<global::G.StructuredOutputEvent?>? structuredOutput = null,
            global::System.Action<global::G.ContextLimitExceededEvent?>? contextLimitExceeded = null,
            global::System.Action<global::G.StepTransitionLimitExceededEvent?>? stepTransitionLimitExceeded = null,
            global::System.Action<global::G.SessionInterruptedEvent?>? sessionInterrupted = null,
            global::System.Action<global::G.ImageReadEvent?>? imageRead = null,
            global::System.Action<global::G.StepTransitionEvent?>? stepTransition = null,
            global::System.Action<global::G.ContextConsumedEvent?>? contextConsumed = null,
            global::System.Action<global::G.CompactionStartedEvent?>? compactionStarted = null,
            global::System.Action<global::G.CompactionEvent?>? compaction = null,
            global::System.Action<global::G.StreamError?>? error = null,
            global::System.Action<global::G.StreamResponseEnd?>? end = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsStreamingAgentOutput)
            {
                streamingAgentOutput?.Invoke(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd)
            {
                streamingAgentOutputEnd?.Invoke(StreamingAgentOutputEnd!);
            }
            else if (IsStreamingThinking)
            {
                streamingThinking?.Invoke(StreamingThinking!);
            }
            else if (IsStreamingThinkingEnd)
            {
                streamingThinkingEnd?.Invoke(StreamingThinkingEnd!);
            }
            else if (IsToolInput)
            {
                toolInput?.Invoke(ToolInput!);
            }
            else if (IsToolOutput)
            {
                toolOutput?.Invoke(ToolOutput!);
            }
            else if (IsStructuredOutput)
            {
                structuredOutput?.Invoke(StructuredOutput!);
            }
            else if (IsContextLimitExceeded)
            {
                contextLimitExceeded?.Invoke(ContextLimitExceeded!);
            }
            else if (IsStepTransitionLimitExceeded)
            {
                stepTransitionLimitExceeded?.Invoke(StepTransitionLimitExceeded!);
            }
            else if (IsSessionInterrupted)
            {
                sessionInterrupted?.Invoke(SessionInterrupted!);
            }
            else if (IsImageRead)
            {
                imageRead?.Invoke(ImageRead!);
            }
            else if (IsStepTransition)
            {
                stepTransition?.Invoke(StepTransition!);
            }
            else if (IsContextConsumed)
            {
                contextConsumed?.Invoke(ContextConsumed!);
            }
            else if (IsCompactionStarted)
            {
                compactionStarted?.Invoke(CompactionStarted!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::G.InputMessageEvent),
                StreamingAgentOutput,
                typeof(global::G.StreamingAgentOutput),
                StreamingAgentOutputEnd,
                typeof(global::G.StreamingAgentOutputEnd),
                StreamingThinking,
                typeof(global::G.StreamingThinking),
                StreamingThinkingEnd,
                typeof(global::G.StreamingThinkingEnd),
                ToolInput,
                typeof(global::G.ToolInputEvent),
                ToolOutput,
                typeof(global::G.ToolOutputEvent),
                StructuredOutput,
                typeof(global::G.StructuredOutputEvent),
                ContextLimitExceeded,
                typeof(global::G.ContextLimitExceededEvent),
                StepTransitionLimitExceeded,
                typeof(global::G.StepTransitionLimitExceededEvent),
                SessionInterrupted,
                typeof(global::G.SessionInterruptedEvent),
                ImageRead,
                typeof(global::G.ImageReadEvent),
                StepTransition,
                typeof(global::G.StepTransitionEvent),
                ContextConsumed,
                typeof(global::G.ContextConsumedEvent),
                CompactionStarted,
                typeof(global::G.CompactionStartedEvent),
                Compaction,
                typeof(global::G.CompactionEvent),
                Error,
                typeof(global::G.StreamError),
                End,
                typeof(global::G.StreamResponseEnd),
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
        public bool Equals(AgentStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageEvent?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingAgentOutput?>.Default.Equals(StreamingAgentOutput, other.StreamingAgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingAgentOutputEnd?>.Default.Equals(StreamingAgentOutputEnd, other.StreamingAgentOutputEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingThinking?>.Default.Equals(StreamingThinking, other.StreamingThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamingThinkingEnd?>.Default.Equals(StreamingThinkingEnd, other.StreamingThinkingEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolInputEvent?>.Default.Equals(ToolInput, other.ToolInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolOutputEvent?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StructuredOutputEvent?>.Default.Equals(StructuredOutput, other.StructuredOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContextLimitExceededEvent?>.Default.Equals(ContextLimitExceeded, other.ContextLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StepTransitionLimitExceededEvent?>.Default.Equals(StepTransitionLimitExceeded, other.StepTransitionLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SessionInterruptedEvent?>.Default.Equals(SessionInterrupted, other.SessionInterrupted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageReadEvent?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StepTransitionEvent?>.Default.Equals(StepTransition, other.StepTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContextConsumedEvent?>.Default.Equals(ContextConsumed, other.ContextConsumed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CompactionStartedEvent?>.Default.Equals(CompactionStarted, other.CompactionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CompactionEvent?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamResponseEnd?>.Default.Equals(End, other.End) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentStreamedResponse obj1, AgentStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentStreamedResponse obj1, AgentStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentStreamedResponse o && Equals(o);
        }
    }
}
