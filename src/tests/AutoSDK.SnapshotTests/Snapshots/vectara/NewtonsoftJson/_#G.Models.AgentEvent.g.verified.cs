//HintName: G.Models.AgentEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An event in an agent session conversation.
    /// </summary>
    public readonly partial struct AgentEvent : global::System.IEquatable<AgentEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentEventDiscriminatorType? Type { get; }

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
        /// An event representing the loading of a skill's content into the conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SkillLoadEvent? SkillLoad { get; init; }
#else
        public global::G.SkillLoadEvent? SkillLoad { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillLoad))]
#endif
        public bool IsSkillLoad => SkillLoad != null;

        /// <summary>
        /// Event representing files uploaded to the agent workspace as artifacts.<br/>
        /// This event is created when users upload one or more files to an agent session using multipart requests. The event becomes part of the session's conversation history and contains references to all artifacts that were uploaded in the request. Each uploaded file is assigned a unique artifact identifier and stored in the session's workspace.<br/>
        /// When an agent processes this event, it becomes aware that new files are available in the session and can use various tools to read, analyze, or transform these artifacts. For example, after receiving an artifact upload event with a PDF, the agent might use the document conversion tool to extract and analyze the document's contents.<br/>
        /// See the `ArtifactReference` schema for comprehensive details about what artifacts are, how they are stored, their lifecycle, and how agents interact with them.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ArtifactUploadEvent? ArtifactUpload { get; init; }
#else
        public global::G.ArtifactUploadEvent? ArtifactUpload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactUpload))]
#endif
        public bool IsArtifactUpload => ArtifactUpload != null;

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
        /// An event representing chain-of-thought thinking by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ThinkingEvent? Thinking { get; init; }
#else
        public global::G.ThinkingEvent? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// An event representing a complete agent response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentOutputEvent? AgentOutput { get; init; }
#else
        public global::G.AgentOutputEvent? AgentOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOutput))]
#endif
        public bool IsAgentOutput => AgentOutput != null;

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
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.InputMessageEvent value) => new AgentEvent((global::G.InputMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageEvent?(AgentEvent @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.InputMessageEvent? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.SkillLoadEvent value) => new AgentEvent((global::G.SkillLoadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SkillLoadEvent?(AgentEvent @this) => @this.SkillLoad;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.SkillLoadEvent? value)
        {
            SkillLoad = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.ArtifactUploadEvent value) => new AgentEvent((global::G.ArtifactUploadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ArtifactUploadEvent?(AgentEvent @this) => @this.ArtifactUpload;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.ArtifactUploadEvent? value)
        {
            ArtifactUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.ToolInputEvent value) => new AgentEvent((global::G.ToolInputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolInputEvent?(AgentEvent @this) => @this.ToolInput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.ToolInputEvent? value)
        {
            ToolInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.ToolOutputEvent value) => new AgentEvent((global::G.ToolOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolOutputEvent?(AgentEvent @this) => @this.ToolOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.ToolOutputEvent? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.ThinkingEvent value) => new AgentEvent((global::G.ThinkingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThinkingEvent?(AgentEvent @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.ThinkingEvent? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.AgentOutputEvent value) => new AgentEvent((global::G.AgentOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentOutputEvent?(AgentEvent @this) => @this.AgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.AgentOutputEvent? value)
        {
            AgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.StructuredOutputEvent value) => new AgentEvent((global::G.StructuredOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StructuredOutputEvent?(AgentEvent @this) => @this.StructuredOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.StructuredOutputEvent? value)
        {
            StructuredOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.ContextLimitExceededEvent value) => new AgentEvent((global::G.ContextLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContextLimitExceededEvent?(AgentEvent @this) => @this.ContextLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.ContextLimitExceededEvent? value)
        {
            ContextLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.StepTransitionLimitExceededEvent value) => new AgentEvent((global::G.StepTransitionLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StepTransitionLimitExceededEvent?(AgentEvent @this) => @this.StepTransitionLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.StepTransitionLimitExceededEvent? value)
        {
            StepTransitionLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.SessionInterruptedEvent value) => new AgentEvent((global::G.SessionInterruptedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionInterruptedEvent?(AgentEvent @this) => @this.SessionInterrupted;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.SessionInterruptedEvent? value)
        {
            SessionInterrupted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.ImageReadEvent value) => new AgentEvent((global::G.ImageReadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageReadEvent?(AgentEvent @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.ImageReadEvent? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.StepTransitionEvent value) => new AgentEvent((global::G.StepTransitionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StepTransitionEvent?(AgentEvent @this) => @this.StepTransition;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.StepTransitionEvent? value)
        {
            StepTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::G.CompactionEvent value) => new AgentEvent((global::G.CompactionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompactionEvent?(AgentEvent @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::G.CompactionEvent? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(
            global::G.AgentEventDiscriminatorType? type,
            global::G.InputMessageEvent? inputMessage,
            global::G.SkillLoadEvent? skillLoad,
            global::G.ArtifactUploadEvent? artifactUpload,
            global::G.ToolInputEvent? toolInput,
            global::G.ToolOutputEvent? toolOutput,
            global::G.ThinkingEvent? thinking,
            global::G.AgentOutputEvent? agentOutput,
            global::G.StructuredOutputEvent? structuredOutput,
            global::G.ContextLimitExceededEvent? contextLimitExceeded,
            global::G.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded,
            global::G.SessionInterruptedEvent? sessionInterrupted,
            global::G.ImageReadEvent? imageRead,
            global::G.StepTransitionEvent? stepTransition,
            global::G.CompactionEvent? compaction
            )
        {
            Type = type;

            InputMessage = inputMessage;
            SkillLoad = skillLoad;
            ArtifactUpload = artifactUpload;
            ToolInput = toolInput;
            ToolOutput = toolOutput;
            Thinking = thinking;
            AgentOutput = agentOutput;
            StructuredOutput = structuredOutput;
            ContextLimitExceeded = contextLimitExceeded;
            StepTransitionLimitExceeded = stepTransitionLimitExceeded;
            SessionInterrupted = sessionInterrupted;
            ImageRead = imageRead;
            StepTransition = stepTransition;
            Compaction = compaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compaction as object ??
            StepTransition as object ??
            ImageRead as object ??
            SessionInterrupted as object ??
            StepTransitionLimitExceeded as object ??
            ContextLimitExceeded as object ??
            StructuredOutput as object ??
            AgentOutput as object ??
            Thinking as object ??
            ToolOutput as object ??
            ToolInput as object ??
            ArtifactUpload as object ??
            SkillLoad as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            SkillLoad?.ToString() ??
            ArtifactUpload?.ToString() ??
            ToolInput?.ToString() ??
            ToolOutput?.ToString() ??
            Thinking?.ToString() ??
            AgentOutput?.ToString() ??
            StructuredOutput?.ToString() ??
            ContextLimitExceeded?.ToString() ??
            StepTransitionLimitExceeded?.ToString() ??
            SessionInterrupted?.ToString() ??
            ImageRead?.ToString() ??
            StepTransition?.ToString() ??
            Compaction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::G.SkillLoadEvent?, TResult>? skillLoad = null,
            global::System.Func<global::G.ArtifactUploadEvent?, TResult>? artifactUpload = null,
            global::System.Func<global::G.ToolInputEvent?, TResult>? toolInput = null,
            global::System.Func<global::G.ToolOutputEvent?, TResult>? toolOutput = null,
            global::System.Func<global::G.ThinkingEvent?, TResult>? thinking = null,
            global::System.Func<global::G.AgentOutputEvent?, TResult>? agentOutput = null,
            global::System.Func<global::G.StructuredOutputEvent?, TResult>? structuredOutput = null,
            global::System.Func<global::G.ContextLimitExceededEvent?, TResult>? contextLimitExceeded = null,
            global::System.Func<global::G.StepTransitionLimitExceededEvent?, TResult>? stepTransitionLimitExceeded = null,
            global::System.Func<global::G.SessionInterruptedEvent?, TResult>? sessionInterrupted = null,
            global::System.Func<global::G.ImageReadEvent?, TResult>? imageRead = null,
            global::System.Func<global::G.StepTransitionEvent?, TResult>? stepTransition = null,
            global::System.Func<global::G.CompactionEvent?, TResult>? compaction = null,
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
            else if (IsSkillLoad && skillLoad != null)
            {
                return skillLoad(SkillLoad!);
            }
            else if (IsArtifactUpload && artifactUpload != null)
            {
                return artifactUpload(ArtifactUpload!);
            }
            else if (IsToolInput && toolInput != null)
            {
                return toolInput(ToolInput!);
            }
            else if (IsToolOutput && toolOutput != null)
            {
                return toolOutput(ToolOutput!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsAgentOutput && agentOutput != null)
            {
                return agentOutput(AgentOutput!);
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
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputMessageEvent?>? inputMessage = null,
            global::System.Action<global::G.SkillLoadEvent?>? skillLoad = null,
            global::System.Action<global::G.ArtifactUploadEvent?>? artifactUpload = null,
            global::System.Action<global::G.ToolInputEvent?>? toolInput = null,
            global::System.Action<global::G.ToolOutputEvent?>? toolOutput = null,
            global::System.Action<global::G.ThinkingEvent?>? thinking = null,
            global::System.Action<global::G.AgentOutputEvent?>? agentOutput = null,
            global::System.Action<global::G.StructuredOutputEvent?>? structuredOutput = null,
            global::System.Action<global::G.ContextLimitExceededEvent?>? contextLimitExceeded = null,
            global::System.Action<global::G.StepTransitionLimitExceededEvent?>? stepTransitionLimitExceeded = null,
            global::System.Action<global::G.SessionInterruptedEvent?>? sessionInterrupted = null,
            global::System.Action<global::G.ImageReadEvent?>? imageRead = null,
            global::System.Action<global::G.StepTransitionEvent?>? stepTransition = null,
            global::System.Action<global::G.CompactionEvent?>? compaction = null,
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
            else if (IsSkillLoad)
            {
                skillLoad?.Invoke(SkillLoad!);
            }
            else if (IsArtifactUpload)
            {
                artifactUpload?.Invoke(ArtifactUpload!);
            }
            else if (IsToolInput)
            {
                toolInput?.Invoke(ToolInput!);
            }
            else if (IsToolOutput)
            {
                toolOutput?.Invoke(ToolOutput!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsAgentOutput)
            {
                agentOutput?.Invoke(AgentOutput!);
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
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
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
                SkillLoad,
                typeof(global::G.SkillLoadEvent),
                ArtifactUpload,
                typeof(global::G.ArtifactUploadEvent),
                ToolInput,
                typeof(global::G.ToolInputEvent),
                ToolOutput,
                typeof(global::G.ToolOutputEvent),
                Thinking,
                typeof(global::G.ThinkingEvent),
                AgentOutput,
                typeof(global::G.AgentOutputEvent),
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
                Compaction,
                typeof(global::G.CompactionEvent),
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
        public bool Equals(AgentEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageEvent?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SkillLoadEvent?>.Default.Equals(SkillLoad, other.SkillLoad) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ArtifactUploadEvent?>.Default.Equals(ArtifactUpload, other.ArtifactUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolInputEvent?>.Default.Equals(ToolInput, other.ToolInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolOutputEvent?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ThinkingEvent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentOutputEvent?>.Default.Equals(AgentOutput, other.AgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StructuredOutputEvent?>.Default.Equals(StructuredOutput, other.StructuredOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContextLimitExceededEvent?>.Default.Equals(ContextLimitExceeded, other.ContextLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StepTransitionLimitExceededEvent?>.Default.Equals(StepTransitionLimitExceeded, other.StepTransitionLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SessionInterruptedEvent?>.Default.Equals(SessionInterrupted, other.SessionInterrupted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageReadEvent?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StepTransitionEvent?>.Default.Equals(StepTransition, other.StepTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CompactionEvent?>.Default.Equals(Compaction, other.Compaction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentEvent obj1, AgentEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentEvent obj1, AgentEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentEvent o && Equals(o);
        }
    }
}
