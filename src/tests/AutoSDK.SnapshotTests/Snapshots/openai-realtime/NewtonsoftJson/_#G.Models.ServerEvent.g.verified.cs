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
        /// Returned when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorPayload? Error { get; init; }
#else
        public global::G.ErrorPayload? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// Returned when a session is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SessionCreatedPayload? SessionCreated { get; init; }
#else
        public global::G.SessionCreatedPayload? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// Returned when a session is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SessionUpdatedPayload? SessionUpdated { get; init; }
#else
        public global::G.SessionUpdatedPayload? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// Returned when a conversation is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationCreatedPayload? ConversationCreated { get; init; }
#else
        public global::G.ConversationCreatedPayload? ConversationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationCreated))]
#endif
        public bool IsConversationCreated => ConversationCreated != null;

        /// <summary>
        /// Returned when a conversation item is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationItemCreatedPayload? ConversationItemCreated { get; init; }
#else
        public global::G.ConversationItemCreatedPayload? ConversationItemCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemCreated))]
#endif
        public bool IsConversationItemCreated => ConversationItemCreated != null;

        /// <summary>
        /// Returned when input audio transcription succeeds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationItemInputAudioTranscriptionCompletedPayload? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::G.ConversationItemInputAudioTranscriptionCompletedPayload? ConversationItemInputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionCompleted))]
#endif
        public bool IsConversationItemInputAudioTranscriptionCompleted => ConversationItemInputAudioTranscriptionCompleted != null;

        /// <summary>
        /// Returned when input audio transcription fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationItemInputAudioTranscriptionFailedPayload? ConversationItemInputAudioTranscriptionFailed { get; init; }
#else
        public global::G.ConversationItemInputAudioTranscriptionFailedPayload? ConversationItemInputAudioTranscriptionFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionFailed))]
#endif
        public bool IsConversationItemInputAudioTranscriptionFailed => ConversationItemInputAudioTranscriptionFailed != null;

        /// <summary>
        /// Returned when an assistant audio message item is truncated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationItemTruncatedPayload? ConversationItemTruncated { get; init; }
#else
        public global::G.ConversationItemTruncatedPayload? ConversationItemTruncated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncated))]
#endif
        public bool IsConversationItemTruncated => ConversationItemTruncated != null;

        /// <summary>
        /// Returned when an item in the conversation is deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationItemDeletedPayload? ConversationItemDeleted { get; init; }
#else
        public global::G.ConversationItemDeletedPayload? ConversationItemDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDeleted))]
#endif
        public bool IsConversationItemDeleted => ConversationItemDeleted != null;

        /// <summary>
        /// Returned when an input audio buffer is committed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferCommittedPayload? InputAudioBufferCommitted { get; init; }
#else
        public global::G.InputAudioBufferCommittedPayload? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        /// Returned when the input audio buffer is cleared.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferClearedPayload? InputAudioBufferCleared { get; init; }
#else
        public global::G.InputAudioBufferClearedPayload? InputAudioBufferCleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCleared))]
#endif
        public bool IsInputAudioBufferCleared => InputAudioBufferCleared != null;

        /// <summary>
        /// Returned when speech is detected in server VAD mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferSpeechStartedPayload? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::G.InputAudioBufferSpeechStartedPayload? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        /// Returned when speech stops in server VAD mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudioBufferSpeechStoppedPayload? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::G.InputAudioBufferSpeechStoppedPayload? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        /// Returned when a new Response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseCreatedPayload? ResponseCreated { get; init; }
#else
        public global::G.ResponseCreatedPayload? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// Returned when a Response is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseDonePayload? ResponseDone { get; init; }
#else
        public global::G.ResponseDonePayload? ResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        /// Returned when a new Item is created during response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputItemAddedPayload? ResponseOutputItemAdded { get; init; }
#else
        public global::G.ResponseOutputItemAddedPayload? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// Returned when an Item is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputItemDonePayload? ResponseOutputItemDone { get; init; }
#else
        public global::G.ResponseOutputItemDonePayload? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        /// Returned when a new content part is added to an assistant message item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentPartAddedPayload? ResponseContentPartAdded { get; init; }
#else
        public global::G.ResponseContentPartAddedPayload? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        /// Returned when a content part is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseContentPartDonePayload? ResponseContentPartDone { get; init; }
#else
        public global::G.ResponseContentPartDonePayload? ResponseContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        /// Returned when the text value of a content part is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextDeltaPayload? ResponseTextDelta { get; init; }
#else
        public global::G.ResponseTextDeltaPayload? ResponseTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDelta))]
#endif
        public bool IsResponseTextDelta => ResponseTextDelta != null;

        /// <summary>
        /// Returned when the text value of a content part is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseTextDonePayload? ResponseTextDone { get; init; }
#else
        public global::G.ResponseTextDonePayload? ResponseTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDone))]
#endif
        public bool IsResponseTextDone => ResponseTextDone != null;

        /// <summary>
        /// Returned when the model-generated transcription of audio output is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioTranscriptDeltaPayload? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::G.ResponseAudioTranscriptDeltaPayload? ResponseAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDelta))]
#endif
        public bool IsResponseAudioTranscriptDelta => ResponseAudioTranscriptDelta != null;

        /// <summary>
        /// Returned when the model-generated transcription of audio output is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioTranscriptDonePayload? ResponseAudioTranscriptDone { get; init; }
#else
        public global::G.ResponseAudioTranscriptDonePayload? ResponseAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDone))]
#endif
        public bool IsResponseAudioTranscriptDone => ResponseAudioTranscriptDone != null;

        /// <summary>
        /// Returned when the model-generated audio is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioDeltaPayload? ResponseAudioDelta { get; init; }
#else
        public global::G.ResponseAudioDeltaPayload? ResponseAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDelta))]
#endif
        public bool IsResponseAudioDelta => ResponseAudioDelta != null;

        /// <summary>
        /// Returned when the model-generated audio is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseAudioDonePayload? ResponseAudioDone { get; init; }
#else
        public global::G.ResponseAudioDonePayload? ResponseAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDone))]
#endif
        public bool IsResponseAudioDone => ResponseAudioDone != null;

        /// <summary>
        /// Returned when the model-generated function call arguments are updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFunctionCallArgumentsDeltaPayload? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::G.ResponseFunctionCallArgumentsDeltaPayload? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        /// Returned when the model-generated function call arguments are done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFunctionCallArgumentsDonePayload? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::G.ResponseFunctionCallArgumentsDonePayload? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// Emitted after every response.done event to indicate updated rate limits.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RateLimitsUpdatedPayload? RateLimitsUpdated { get; init; }
#else
        public global::G.RateLimitsUpdatedPayload? RateLimitsUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitsUpdated))]
#endif
        public bool IsRateLimitsUpdated => RateLimitsUpdated != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ErrorPayload value) => new ServerEvent((global::G.ErrorPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorPayload?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ErrorPayload? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.SessionCreatedPayload value) => new ServerEvent((global::G.SessionCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionCreatedPayload?(ServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.SessionCreatedPayload? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.SessionUpdatedPayload value) => new ServerEvent((global::G.SessionUpdatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionUpdatedPayload?(ServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.SessionUpdatedPayload? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationCreatedPayload value) => new ServerEvent((global::G.ConversationCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationCreatedPayload?(ServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationCreatedPayload? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationItemCreatedPayload value) => new ServerEvent((global::G.ConversationItemCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationItemCreatedPayload?(ServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationItemCreatedPayload? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationItemInputAudioTranscriptionCompletedPayload value) => new ServerEvent((global::G.ConversationItemInputAudioTranscriptionCompletedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationItemInputAudioTranscriptionCompletedPayload?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationItemInputAudioTranscriptionCompletedPayload? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationItemInputAudioTranscriptionFailedPayload value) => new ServerEvent((global::G.ConversationItemInputAudioTranscriptionFailedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationItemInputAudioTranscriptionFailedPayload?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationItemInputAudioTranscriptionFailedPayload? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationItemTruncatedPayload value) => new ServerEvent((global::G.ConversationItemTruncatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationItemTruncatedPayload?(ServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationItemTruncatedPayload? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ConversationItemDeletedPayload value) => new ServerEvent((global::G.ConversationItemDeletedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationItemDeletedPayload?(ServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ConversationItemDeletedPayload? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferCommittedPayload value) => new ServerEvent((global::G.InputAudioBufferCommittedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferCommittedPayload?(ServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferCommittedPayload? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferClearedPayload value) => new ServerEvent((global::G.InputAudioBufferClearedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferClearedPayload?(ServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferClearedPayload? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferSpeechStartedPayload value) => new ServerEvent((global::G.InputAudioBufferSpeechStartedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferSpeechStartedPayload?(ServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferSpeechStartedPayload? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.InputAudioBufferSpeechStoppedPayload value) => new ServerEvent((global::G.InputAudioBufferSpeechStoppedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudioBufferSpeechStoppedPayload?(ServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.InputAudioBufferSpeechStoppedPayload? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseCreatedPayload value) => new ServerEvent((global::G.ResponseCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseCreatedPayload?(ServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseCreatedPayload? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseDonePayload value) => new ServerEvent((global::G.ResponseDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseDonePayload?(ServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseDonePayload? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputItemAddedPayload value) => new ServerEvent((global::G.ResponseOutputItemAddedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemAddedPayload?(ServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputItemAddedPayload? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseOutputItemDonePayload value) => new ServerEvent((global::G.ResponseOutputItemDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputItemDonePayload?(ServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseOutputItemDonePayload? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseContentPartAddedPayload value) => new ServerEvent((global::G.ResponseContentPartAddedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentPartAddedPayload?(ServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseContentPartAddedPayload? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseContentPartDonePayload value) => new ServerEvent((global::G.ResponseContentPartDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseContentPartDonePayload?(ServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseContentPartDonePayload? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseTextDeltaPayload value) => new ServerEvent((global::G.ResponseTextDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextDeltaPayload?(ServerEvent @this) => @this.ResponseTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseTextDeltaPayload? value)
        {
            ResponseTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseTextDonePayload value) => new ServerEvent((global::G.ResponseTextDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseTextDonePayload?(ServerEvent @this) => @this.ResponseTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseTextDonePayload? value)
        {
            ResponseTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseAudioTranscriptDeltaPayload value) => new ServerEvent((global::G.ResponseAudioTranscriptDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioTranscriptDeltaPayload?(ServerEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseAudioTranscriptDeltaPayload? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseAudioTranscriptDonePayload value) => new ServerEvent((global::G.ResponseAudioTranscriptDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioTranscriptDonePayload?(ServerEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseAudioTranscriptDonePayload? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseAudioDeltaPayload value) => new ServerEvent((global::G.ResponseAudioDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioDeltaPayload?(ServerEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseAudioDeltaPayload? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseAudioDonePayload value) => new ServerEvent((global::G.ResponseAudioDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseAudioDonePayload?(ServerEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseAudioDonePayload? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseFunctionCallArgumentsDeltaPayload value) => new ServerEvent((global::G.ResponseFunctionCallArgumentsDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDeltaPayload?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseFunctionCallArgumentsDeltaPayload? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ResponseFunctionCallArgumentsDonePayload value) => new ServerEvent((global::G.ResponseFunctionCallArgumentsDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFunctionCallArgumentsDonePayload?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ResponseFunctionCallArgumentsDonePayload? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.RateLimitsUpdatedPayload value) => new ServerEvent((global::G.RateLimitsUpdatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RateLimitsUpdatedPayload?(ServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.RateLimitsUpdatedPayload? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::G.ServerEventDiscriminatorType? type,
            global::G.ErrorPayload? error,
            global::G.SessionCreatedPayload? sessionCreated,
            global::G.SessionUpdatedPayload? sessionUpdated,
            global::G.ConversationCreatedPayload? conversationCreated,
            global::G.ConversationItemCreatedPayload? conversationItemCreated,
            global::G.ConversationItemInputAudioTranscriptionCompletedPayload? conversationItemInputAudioTranscriptionCompleted,
            global::G.ConversationItemInputAudioTranscriptionFailedPayload? conversationItemInputAudioTranscriptionFailed,
            global::G.ConversationItemTruncatedPayload? conversationItemTruncated,
            global::G.ConversationItemDeletedPayload? conversationItemDeleted,
            global::G.InputAudioBufferCommittedPayload? inputAudioBufferCommitted,
            global::G.InputAudioBufferClearedPayload? inputAudioBufferCleared,
            global::G.InputAudioBufferSpeechStartedPayload? inputAudioBufferSpeechStarted,
            global::G.InputAudioBufferSpeechStoppedPayload? inputAudioBufferSpeechStopped,
            global::G.ResponseCreatedPayload? responseCreated,
            global::G.ResponseDonePayload? responseDone,
            global::G.ResponseOutputItemAddedPayload? responseOutputItemAdded,
            global::G.ResponseOutputItemDonePayload? responseOutputItemDone,
            global::G.ResponseContentPartAddedPayload? responseContentPartAdded,
            global::G.ResponseContentPartDonePayload? responseContentPartDone,
            global::G.ResponseTextDeltaPayload? responseTextDelta,
            global::G.ResponseTextDonePayload? responseTextDone,
            global::G.ResponseAudioTranscriptDeltaPayload? responseAudioTranscriptDelta,
            global::G.ResponseAudioTranscriptDonePayload? responseAudioTranscriptDone,
            global::G.ResponseAudioDeltaPayload? responseAudioDelta,
            global::G.ResponseAudioDonePayload? responseAudioDone,
            global::G.ResponseFunctionCallArgumentsDeltaPayload? responseFunctionCallArgumentsDelta,
            global::G.ResponseFunctionCallArgumentsDonePayload? responseFunctionCallArgumentsDone,
            global::G.RateLimitsUpdatedPayload? rateLimitsUpdated
            )
        {
            Type = type;

            Error = error;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            ConversationCreated = conversationCreated;
            ConversationItemCreated = conversationItemCreated;
            ConversationItemInputAudioTranscriptionCompleted = conversationItemInputAudioTranscriptionCompleted;
            ConversationItemInputAudioTranscriptionFailed = conversationItemInputAudioTranscriptionFailed;
            ConversationItemTruncated = conversationItemTruncated;
            ConversationItemDeleted = conversationItemDeleted;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioBufferCleared = inputAudioBufferCleared;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseTextDelta = responseTextDelta;
            ResponseTextDone = responseTextDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            RateLimitsUpdated = rateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RateLimitsUpdated as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object ??
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseTextDone as object ??
            ResponseTextDelta as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            InputAudioBufferCleared as object ??
            InputAudioBufferCommitted as object ??
            ConversationItemDeleted as object ??
            ConversationItemTruncated as object ??
            ConversationItemInputAudioTranscriptionFailed as object ??
            ConversationItemInputAudioTranscriptionCompleted as object ??
            ConversationItemCreated as object ??
            ConversationCreated as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            Error as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            ConversationCreated?.ToString() ??
            ConversationItemCreated?.ToString() ??
            ConversationItemInputAudioTranscriptionCompleted?.ToString() ??
            ConversationItemInputAudioTranscriptionFailed?.ToString() ??
            ConversationItemTruncated?.ToString() ??
            ConversationItemDeleted?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioBufferCleared?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseTextDelta?.ToString() ??
            ResponseTextDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString() ??
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            RateLimitsUpdated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && IsRateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ErrorPayload?, TResult>? error = null,
            global::System.Func<global::G.SessionCreatedPayload?, TResult>? sessionCreated = null,
            global::System.Func<global::G.SessionUpdatedPayload?, TResult>? sessionUpdated = null,
            global::System.Func<global::G.ConversationCreatedPayload?, TResult>? conversationCreated = null,
            global::System.Func<global::G.ConversationItemCreatedPayload?, TResult>? conversationItemCreated = null,
            global::System.Func<global::G.ConversationItemInputAudioTranscriptionCompletedPayload?, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::G.ConversationItemInputAudioTranscriptionFailedPayload?, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::G.ConversationItemTruncatedPayload?, TResult>? conversationItemTruncated = null,
            global::System.Func<global::G.ConversationItemDeletedPayload?, TResult>? conversationItemDeleted = null,
            global::System.Func<global::G.InputAudioBufferCommittedPayload?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::G.InputAudioBufferClearedPayload?, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::G.InputAudioBufferSpeechStartedPayload?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::G.InputAudioBufferSpeechStoppedPayload?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::G.ResponseCreatedPayload?, TResult>? responseCreated = null,
            global::System.Func<global::G.ResponseDonePayload?, TResult>? responseDone = null,
            global::System.Func<global::G.ResponseOutputItemAddedPayload?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::G.ResponseOutputItemDonePayload?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::G.ResponseContentPartAddedPayload?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::G.ResponseContentPartDonePayload?, TResult>? responseContentPartDone = null,
            global::System.Func<global::G.ResponseTextDeltaPayload?, TResult>? responseTextDelta = null,
            global::System.Func<global::G.ResponseTextDonePayload?, TResult>? responseTextDone = null,
            global::System.Func<global::G.ResponseAudioTranscriptDeltaPayload?, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::G.ResponseAudioTranscriptDonePayload?, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::G.ResponseAudioDeltaPayload?, TResult>? responseAudioDelta = null,
            global::System.Func<global::G.ResponseAudioDonePayload?, TResult>? responseAudioDone = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDeltaPayload?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDonePayload?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::G.RateLimitsUpdatedPayload?, TResult>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsSessionCreated && sessionCreated != null)
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
            else if (IsConversationItemCreated && conversationItemCreated != null)
            {
                return conversationItemCreated(ConversationItemCreated!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted && conversationItemInputAudioTranscriptionCompleted != null)
            {
                return conversationItemInputAudioTranscriptionCompleted(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed && conversationItemInputAudioTranscriptionFailed != null)
            {
                return conversationItemInputAudioTranscriptionFailed(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemTruncated && conversationItemTruncated != null)
            {
                return conversationItemTruncated(ConversationItemTruncated!);
            }
            else if (IsConversationItemDeleted && conversationItemDeleted != null)
            {
                return conversationItemDeleted(ConversationItemDeleted!);
            }
            else if (IsInputAudioBufferCommitted && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferCleared && inputAudioBufferCleared != null)
            {
                return inputAudioBufferCleared(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferSpeechStarted && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(InputAudioBufferSpeechStopped!);
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
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseContentPartAdded && responseContentPartAdded != null)
            {
                return responseContentPartAdded(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone && responseContentPartDone != null)
            {
                return responseContentPartDone(ResponseContentPartDone!);
            }
            else if (IsResponseTextDelta && responseTextDelta != null)
            {
                return responseTextDelta(ResponseTextDelta!);
            }
            else if (IsResponseTextDone && responseTextDone != null)
            {
                return responseTextDone(ResponseTextDone!);
            }
            else if (IsResponseAudioTranscriptDelta && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseAudioDelta && responseAudioDelta != null)
            {
                return responseAudioDelta(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone && responseAudioDone != null)
            {
                return responseAudioDone(ResponseAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsRateLimitsUpdated && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(RateLimitsUpdated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ErrorPayload?>? error = null,
            global::System.Action<global::G.SessionCreatedPayload?>? sessionCreated = null,
            global::System.Action<global::G.SessionUpdatedPayload?>? sessionUpdated = null,
            global::System.Action<global::G.ConversationCreatedPayload?>? conversationCreated = null,
            global::System.Action<global::G.ConversationItemCreatedPayload?>? conversationItemCreated = null,
            global::System.Action<global::G.ConversationItemInputAudioTranscriptionCompletedPayload?>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::G.ConversationItemInputAudioTranscriptionFailedPayload?>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::G.ConversationItemTruncatedPayload?>? conversationItemTruncated = null,
            global::System.Action<global::G.ConversationItemDeletedPayload?>? conversationItemDeleted = null,
            global::System.Action<global::G.InputAudioBufferCommittedPayload?>? inputAudioBufferCommitted = null,
            global::System.Action<global::G.InputAudioBufferClearedPayload?>? inputAudioBufferCleared = null,
            global::System.Action<global::G.InputAudioBufferSpeechStartedPayload?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::G.InputAudioBufferSpeechStoppedPayload?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::G.ResponseCreatedPayload?>? responseCreated = null,
            global::System.Action<global::G.ResponseDonePayload?>? responseDone = null,
            global::System.Action<global::G.ResponseOutputItemAddedPayload?>? responseOutputItemAdded = null,
            global::System.Action<global::G.ResponseOutputItemDonePayload?>? responseOutputItemDone = null,
            global::System.Action<global::G.ResponseContentPartAddedPayload?>? responseContentPartAdded = null,
            global::System.Action<global::G.ResponseContentPartDonePayload?>? responseContentPartDone = null,
            global::System.Action<global::G.ResponseTextDeltaPayload?>? responseTextDelta = null,
            global::System.Action<global::G.ResponseTextDonePayload?>? responseTextDone = null,
            global::System.Action<global::G.ResponseAudioTranscriptDeltaPayload?>? responseAudioTranscriptDelta = null,
            global::System.Action<global::G.ResponseAudioTranscriptDonePayload?>? responseAudioTranscriptDone = null,
            global::System.Action<global::G.ResponseAudioDeltaPayload?>? responseAudioDelta = null,
            global::System.Action<global::G.ResponseAudioDonePayload?>? responseAudioDone = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDeltaPayload?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDonePayload?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::G.RateLimitsUpdatedPayload?>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsSessionCreated)
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
            else if (IsConversationItemCreated)
            {
                conversationItemCreated?.Invoke(ConversationItemCreated!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed)
            {
                conversationItemInputAudioTranscriptionFailed?.Invoke(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemTruncated)
            {
                conversationItemTruncated?.Invoke(ConversationItemTruncated!);
            }
            else if (IsConversationItemDeleted)
            {
                conversationItemDeleted?.Invoke(ConversationItemDeleted!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferCleared)
            {
                inputAudioBufferCleared?.Invoke(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
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
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseContentPartAdded)
            {
                responseContentPartAdded?.Invoke(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone)
            {
                responseContentPartDone?.Invoke(ResponseContentPartDone!);
            }
            else if (IsResponseTextDelta)
            {
                responseTextDelta?.Invoke(ResponseTextDelta!);
            }
            else if (IsResponseTextDone)
            {
                responseTextDone?.Invoke(ResponseTextDone!);
            }
            else if (IsResponseAudioTranscriptDelta)
            {
                responseAudioTranscriptDelta?.Invoke(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone)
            {
                responseAudioTranscriptDone?.Invoke(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseAudioDelta)
            {
                responseAudioDelta?.Invoke(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone)
            {
                responseAudioDone?.Invoke(ResponseAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsRateLimitsUpdated)
            {
                rateLimitsUpdated?.Invoke(RateLimitsUpdated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Error,
                typeof(global::G.ErrorPayload),
                SessionCreated,
                typeof(global::G.SessionCreatedPayload),
                SessionUpdated,
                typeof(global::G.SessionUpdatedPayload),
                ConversationCreated,
                typeof(global::G.ConversationCreatedPayload),
                ConversationItemCreated,
                typeof(global::G.ConversationItemCreatedPayload),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::G.ConversationItemInputAudioTranscriptionCompletedPayload),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::G.ConversationItemInputAudioTranscriptionFailedPayload),
                ConversationItemTruncated,
                typeof(global::G.ConversationItemTruncatedPayload),
                ConversationItemDeleted,
                typeof(global::G.ConversationItemDeletedPayload),
                InputAudioBufferCommitted,
                typeof(global::G.InputAudioBufferCommittedPayload),
                InputAudioBufferCleared,
                typeof(global::G.InputAudioBufferClearedPayload),
                InputAudioBufferSpeechStarted,
                typeof(global::G.InputAudioBufferSpeechStartedPayload),
                InputAudioBufferSpeechStopped,
                typeof(global::G.InputAudioBufferSpeechStoppedPayload),
                ResponseCreated,
                typeof(global::G.ResponseCreatedPayload),
                ResponseDone,
                typeof(global::G.ResponseDonePayload),
                ResponseOutputItemAdded,
                typeof(global::G.ResponseOutputItemAddedPayload),
                ResponseOutputItemDone,
                typeof(global::G.ResponseOutputItemDonePayload),
                ResponseContentPartAdded,
                typeof(global::G.ResponseContentPartAddedPayload),
                ResponseContentPartDone,
                typeof(global::G.ResponseContentPartDonePayload),
                ResponseTextDelta,
                typeof(global::G.ResponseTextDeltaPayload),
                ResponseTextDone,
                typeof(global::G.ResponseTextDonePayload),
                ResponseAudioTranscriptDelta,
                typeof(global::G.ResponseAudioTranscriptDeltaPayload),
                ResponseAudioTranscriptDone,
                typeof(global::G.ResponseAudioTranscriptDonePayload),
                ResponseAudioDelta,
                typeof(global::G.ResponseAudioDeltaPayload),
                ResponseAudioDone,
                typeof(global::G.ResponseAudioDonePayload),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::G.ResponseFunctionCallArgumentsDeltaPayload),
                ResponseFunctionCallArgumentsDone,
                typeof(global::G.ResponseFunctionCallArgumentsDonePayload),
                RateLimitsUpdated,
                typeof(global::G.RateLimitsUpdatedPayload),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorPayload?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SessionCreatedPayload?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SessionUpdatedPayload?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationCreatedPayload?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationItemCreatedPayload?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationItemInputAudioTranscriptionCompletedPayload?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationItemInputAudioTranscriptionFailedPayload?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationItemTruncatedPayload?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationItemDeletedPayload?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferCommittedPayload?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferClearedPayload?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferSpeechStartedPayload?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudioBufferSpeechStoppedPayload?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseCreatedPayload?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseDonePayload?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemAddedPayload?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputItemDonePayload?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentPartAddedPayload?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseContentPartDonePayload?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextDeltaPayload?>.Default.Equals(ResponseTextDelta, other.ResponseTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseTextDonePayload?>.Default.Equals(ResponseTextDone, other.ResponseTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioTranscriptDeltaPayload?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioTranscriptDonePayload?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioDeltaPayload?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseAudioDonePayload?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDeltaPayload?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFunctionCallArgumentsDonePayload?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RateLimitsUpdatedPayload?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) 
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
