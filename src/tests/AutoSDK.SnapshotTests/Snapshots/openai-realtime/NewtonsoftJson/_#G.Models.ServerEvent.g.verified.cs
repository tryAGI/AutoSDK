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
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ErrorPayload? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ErrorPayload PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SessionCreatedPayload? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SessionCreatedPayload PickSessionCreated() => SessionCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SessionUpdatedPayload? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SessionUpdatedPayload PickSessionUpdated() => SessionUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationCreatedPayload? value)
        {
            value = ConversationCreated;
            return IsConversationCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationCreatedPayload PickConversationCreated() => ConversationCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationItemCreatedPayload? value)
        {
            value = ConversationItemCreated;
            return IsConversationItemCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationItemCreatedPayload PickConversationItemCreated() => ConversationItemCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationItemInputAudioTranscriptionCompletedPayload? value)
        {
            value = ConversationItemInputAudioTranscriptionCompleted;
            return IsConversationItemInputAudioTranscriptionCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationItemInputAudioTranscriptionCompletedPayload PickConversationItemInputAudioTranscriptionCompleted() => ConversationItemInputAudioTranscriptionCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionCompleted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationItemInputAudioTranscriptionFailedPayload? value)
        {
            value = ConversationItemInputAudioTranscriptionFailed;
            return IsConversationItemInputAudioTranscriptionFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationItemInputAudioTranscriptionFailedPayload PickConversationItemInputAudioTranscriptionFailed() => ConversationItemInputAudioTranscriptionFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionFailed' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemTruncated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationItemTruncatedPayload? value)
        {
            value = ConversationItemTruncated;
            return IsConversationItemTruncated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationItemTruncatedPayload PickConversationItemTruncated() => ConversationItemTruncated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemTruncated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationItemDeletedPayload? value)
        {
            value = ConversationItemDeleted;
            return IsConversationItemDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationItemDeletedPayload PickConversationItemDeleted() => ConversationItemDeleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemDeleted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferCommitted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputAudioBufferCommittedPayload? value)
        {
            value = InputAudioBufferCommitted;
            return IsInputAudioBufferCommitted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudioBufferCommittedPayload PickInputAudioBufferCommitted() => InputAudioBufferCommitted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCommitted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferCleared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputAudioBufferClearedPayload? value)
        {
            value = InputAudioBufferCleared;
            return IsInputAudioBufferCleared;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudioBufferClearedPayload PickInputAudioBufferCleared() => InputAudioBufferCleared is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCleared' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputAudioBufferSpeechStartedPayload? value)
        {
            value = InputAudioBufferSpeechStarted;
            return IsInputAudioBufferSpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudioBufferSpeechStartedPayload PickInputAudioBufferSpeechStarted() => InputAudioBufferSpeechStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStarted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputAudioBufferSpeechStoppedPayload? value)
        {
            value = InputAudioBufferSpeechStopped;
            return IsInputAudioBufferSpeechStopped;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudioBufferSpeechStoppedPayload PickInputAudioBufferSpeechStopped() => InputAudioBufferSpeechStopped is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStopped' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseCreatedPayload? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCreatedPayload PickResponseCreated() => ResponseCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseDonePayload? value)
        {
            value = ResponseDone;
            return IsResponseDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseDonePayload PickResponseDone() => ResponseDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseOutputItemAddedPayload? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputItemAddedPayload PickResponseOutputItemAdded() => ResponseOutputItemAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseOutputItemDonePayload? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputItemDonePayload PickResponseOutputItemDone() => ResponseOutputItemDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseContentPartAddedPayload? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentPartAddedPayload PickResponseContentPartAdded() => ResponseContentPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseContentPartDonePayload? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentPartDonePayload PickResponseContentPartDone() => ResponseContentPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseTextDeltaPayload? value)
        {
            value = ResponseTextDelta;
            return IsResponseTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextDeltaPayload PickResponseTextDelta() => ResponseTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseTextDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseTextDonePayload? value)
        {
            value = ResponseTextDone;
            return IsResponseTextDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextDonePayload PickResponseTextDone() => ResponseTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseTextDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseAudioTranscriptDeltaPayload? value)
        {
            value = ResponseAudioTranscriptDelta;
            return IsResponseAudioTranscriptDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioTranscriptDeltaPayload PickResponseAudioTranscriptDelta() => ResponseAudioTranscriptDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseAudioTranscriptDonePayload? value)
        {
            value = ResponseAudioTranscriptDone;
            return IsResponseAudioTranscriptDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioTranscriptDonePayload PickResponseAudioTranscriptDone() => ResponseAudioTranscriptDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseAudioDeltaPayload? value)
        {
            value = ResponseAudioDelta;
            return IsResponseAudioDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioDeltaPayload PickResponseAudioDelta() => ResponseAudioDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseAudioDonePayload? value)
        {
            value = ResponseAudioDone;
            return IsResponseAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioDonePayload PickResponseAudioDone() => ResponseAudioDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseFunctionCallArgumentsDeltaPayload? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFunctionCallArgumentsDeltaPayload PickResponseFunctionCallArgumentsDelta() => ResponseFunctionCallArgumentsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResponseFunctionCallArgumentsDonePayload? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFunctionCallArgumentsDonePayload PickResponseFunctionCallArgumentsDone() => ResponseFunctionCallArgumentsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

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
        public bool TryPickRateLimitsUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RateLimitsUpdatedPayload? value)
        {
            value = RateLimitsUpdated;
            return IsRateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsUpdatedPayload PickRateLimitsUpdated() => RateLimitsUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RateLimitsUpdated' but the value was {ToString()}.");
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
        public static ServerEvent FromError(global::G.ErrorPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromSessionCreated(global::G.SessionCreatedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromSessionUpdated(global::G.SessionUpdatedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromConversationCreated(global::G.ConversationCreatedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromConversationItemCreated(global::G.ConversationItemCreatedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromConversationItemInputAudioTranscriptionCompleted(global::G.ConversationItemInputAudioTranscriptionCompletedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromConversationItemInputAudioTranscriptionFailed(global::G.ConversationItemInputAudioTranscriptionFailedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromConversationItemTruncated(global::G.ConversationItemTruncatedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromConversationItemDeleted(global::G.ConversationItemDeletedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromInputAudioBufferCommitted(global::G.InputAudioBufferCommittedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromInputAudioBufferCleared(global::G.InputAudioBufferClearedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromInputAudioBufferSpeechStarted(global::G.InputAudioBufferSpeechStartedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromInputAudioBufferSpeechStopped(global::G.InputAudioBufferSpeechStoppedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseCreated(global::G.ResponseCreatedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseDone(global::G.ResponseDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseOutputItemAdded(global::G.ResponseOutputItemAddedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseOutputItemDone(global::G.ResponseOutputItemDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseContentPartAdded(global::G.ResponseContentPartAddedPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseContentPartDone(global::G.ResponseContentPartDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseTextDelta(global::G.ResponseTextDeltaPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseTextDone(global::G.ResponseTextDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseAudioTranscriptDelta(global::G.ResponseAudioTranscriptDeltaPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseAudioTranscriptDone(global::G.ResponseAudioTranscriptDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseAudioDelta(global::G.ResponseAudioDeltaPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseAudioDone(global::G.ResponseAudioDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseFunctionCallArgumentsDelta(global::G.ResponseFunctionCallArgumentsDeltaPayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromResponseFunctionCallArgumentsDone(global::G.ResponseFunctionCallArgumentsDonePayload? value) => new ServerEvent(value);

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
        public static ServerEvent FromRateLimitsUpdated(global::G.RateLimitsUpdatedPayload? value) => new ServerEvent(value);

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
            global::System.Func<global::G.ErrorPayload, TResult>? error = null,
            global::System.Func<global::G.SessionCreatedPayload, TResult>? sessionCreated = null,
            global::System.Func<global::G.SessionUpdatedPayload, TResult>? sessionUpdated = null,
            global::System.Func<global::G.ConversationCreatedPayload, TResult>? conversationCreated = null,
            global::System.Func<global::G.ConversationItemCreatedPayload, TResult>? conversationItemCreated = null,
            global::System.Func<global::G.ConversationItemInputAudioTranscriptionCompletedPayload, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::G.ConversationItemInputAudioTranscriptionFailedPayload, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::G.ConversationItemTruncatedPayload, TResult>? conversationItemTruncated = null,
            global::System.Func<global::G.ConversationItemDeletedPayload, TResult>? conversationItemDeleted = null,
            global::System.Func<global::G.InputAudioBufferCommittedPayload, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::G.InputAudioBufferClearedPayload, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::G.InputAudioBufferSpeechStartedPayload, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::G.InputAudioBufferSpeechStoppedPayload, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::G.ResponseCreatedPayload, TResult>? responseCreated = null,
            global::System.Func<global::G.ResponseDonePayload, TResult>? responseDone = null,
            global::System.Func<global::G.ResponseOutputItemAddedPayload, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::G.ResponseOutputItemDonePayload, TResult>? responseOutputItemDone = null,
            global::System.Func<global::G.ResponseContentPartAddedPayload, TResult>? responseContentPartAdded = null,
            global::System.Func<global::G.ResponseContentPartDonePayload, TResult>? responseContentPartDone = null,
            global::System.Func<global::G.ResponseTextDeltaPayload, TResult>? responseTextDelta = null,
            global::System.Func<global::G.ResponseTextDonePayload, TResult>? responseTextDone = null,
            global::System.Func<global::G.ResponseAudioTranscriptDeltaPayload, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::G.ResponseAudioTranscriptDonePayload, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::G.ResponseAudioDeltaPayload, TResult>? responseAudioDelta = null,
            global::System.Func<global::G.ResponseAudioDonePayload, TResult>? responseAudioDone = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDeltaPayload, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::G.ResponseFunctionCallArgumentsDonePayload, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::G.RateLimitsUpdatedPayload, TResult>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0 && error != null)
            {
                return error(__value0);
            }
            else if (SessionCreated is { } __value1 && sessionCreated != null)
            {
                return sessionCreated(__value1);
            }
            else if (SessionUpdated is { } __value2 && sessionUpdated != null)
            {
                return sessionUpdated(__value2);
            }
            else if (ConversationCreated is { } __value3 && conversationCreated != null)
            {
                return conversationCreated(__value3);
            }
            else if (ConversationItemCreated is { } __value4 && conversationItemCreated != null)
            {
                return conversationItemCreated(__value4);
            }
            else if (ConversationItemInputAudioTranscriptionCompleted is { } __value5 && conversationItemInputAudioTranscriptionCompleted != null)
            {
                return conversationItemInputAudioTranscriptionCompleted(__value5);
            }
            else if (ConversationItemInputAudioTranscriptionFailed is { } __value6 && conversationItemInputAudioTranscriptionFailed != null)
            {
                return conversationItemInputAudioTranscriptionFailed(__value6);
            }
            else if (ConversationItemTruncated is { } __value7 && conversationItemTruncated != null)
            {
                return conversationItemTruncated(__value7);
            }
            else if (ConversationItemDeleted is { } __value8 && conversationItemDeleted != null)
            {
                return conversationItemDeleted(__value8);
            }
            else if (InputAudioBufferCommitted is { } __value9 && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(__value9);
            }
            else if (InputAudioBufferCleared is { } __value10 && inputAudioBufferCleared != null)
            {
                return inputAudioBufferCleared(__value10);
            }
            else if (InputAudioBufferSpeechStarted is { } __value11 && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(__value11);
            }
            else if (InputAudioBufferSpeechStopped is { } __value12 && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(__value12);
            }
            else if (ResponseCreated is { } __value13 && responseCreated != null)
            {
                return responseCreated(__value13);
            }
            else if (ResponseDone is { } __value14 && responseDone != null)
            {
                return responseDone(__value14);
            }
            else if (ResponseOutputItemAdded is { } __value15 && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(__value15);
            }
            else if (ResponseOutputItemDone is { } __value16 && responseOutputItemDone != null)
            {
                return responseOutputItemDone(__value16);
            }
            else if (ResponseContentPartAdded is { } __value17 && responseContentPartAdded != null)
            {
                return responseContentPartAdded(__value17);
            }
            else if (ResponseContentPartDone is { } __value18 && responseContentPartDone != null)
            {
                return responseContentPartDone(__value18);
            }
            else if (ResponseTextDelta is { } __value19 && responseTextDelta != null)
            {
                return responseTextDelta(__value19);
            }
            else if (ResponseTextDone is { } __value20 && responseTextDone != null)
            {
                return responseTextDone(__value20);
            }
            else if (ResponseAudioTranscriptDelta is { } __value21 && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(__value21);
            }
            else if (ResponseAudioTranscriptDone is { } __value22 && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(__value22);
            }
            else if (ResponseAudioDelta is { } __value23 && responseAudioDelta != null)
            {
                return responseAudioDelta(__value23);
            }
            else if (ResponseAudioDone is { } __value24 && responseAudioDone != null)
            {
                return responseAudioDone(__value24);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value25 && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(__value25);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value26 && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(__value26);
            }
            else if (RateLimitsUpdated is { } __value27 && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(__value27);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ErrorPayload>? error = null,

            global::System.Action<global::G.SessionCreatedPayload>? sessionCreated = null,

            global::System.Action<global::G.SessionUpdatedPayload>? sessionUpdated = null,

            global::System.Action<global::G.ConversationCreatedPayload>? conversationCreated = null,

            global::System.Action<global::G.ConversationItemCreatedPayload>? conversationItemCreated = null,

            global::System.Action<global::G.ConversationItemInputAudioTranscriptionCompletedPayload>? conversationItemInputAudioTranscriptionCompleted = null,

            global::System.Action<global::G.ConversationItemInputAudioTranscriptionFailedPayload>? conversationItemInputAudioTranscriptionFailed = null,

            global::System.Action<global::G.ConversationItemTruncatedPayload>? conversationItemTruncated = null,

            global::System.Action<global::G.ConversationItemDeletedPayload>? conversationItemDeleted = null,

            global::System.Action<global::G.InputAudioBufferCommittedPayload>? inputAudioBufferCommitted = null,

            global::System.Action<global::G.InputAudioBufferClearedPayload>? inputAudioBufferCleared = null,

            global::System.Action<global::G.InputAudioBufferSpeechStartedPayload>? inputAudioBufferSpeechStarted = null,

            global::System.Action<global::G.InputAudioBufferSpeechStoppedPayload>? inputAudioBufferSpeechStopped = null,

            global::System.Action<global::G.ResponseCreatedPayload>? responseCreated = null,

            global::System.Action<global::G.ResponseDonePayload>? responseDone = null,

            global::System.Action<global::G.ResponseOutputItemAddedPayload>? responseOutputItemAdded = null,

            global::System.Action<global::G.ResponseOutputItemDonePayload>? responseOutputItemDone = null,

            global::System.Action<global::G.ResponseContentPartAddedPayload>? responseContentPartAdded = null,

            global::System.Action<global::G.ResponseContentPartDonePayload>? responseContentPartDone = null,

            global::System.Action<global::G.ResponseTextDeltaPayload>? responseTextDelta = null,

            global::System.Action<global::G.ResponseTextDonePayload>? responseTextDone = null,

            global::System.Action<global::G.ResponseAudioTranscriptDeltaPayload>? responseAudioTranscriptDelta = null,

            global::System.Action<global::G.ResponseAudioTranscriptDonePayload>? responseAudioTranscriptDone = null,

            global::System.Action<global::G.ResponseAudioDeltaPayload>? responseAudioDelta = null,

            global::System.Action<global::G.ResponseAudioDonePayload>? responseAudioDone = null,

            global::System.Action<global::G.ResponseFunctionCallArgumentsDeltaPayload>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::G.ResponseFunctionCallArgumentsDonePayload>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::G.RateLimitsUpdatedPayload>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0)
            {
                error?.Invoke(__value0);
            }
            else if (SessionCreated is { } __value1)
            {
                sessionCreated?.Invoke(__value1);
            }
            else if (SessionUpdated is { } __value2)
            {
                sessionUpdated?.Invoke(__value2);
            }
            else if (ConversationCreated is { } __value3)
            {
                conversationCreated?.Invoke(__value3);
            }
            else if (ConversationItemCreated is { } __value4)
            {
                conversationItemCreated?.Invoke(__value4);
            }
            else if (ConversationItemInputAudioTranscriptionCompleted is { } __value5)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(__value5);
            }
            else if (ConversationItemInputAudioTranscriptionFailed is { } __value6)
            {
                conversationItemInputAudioTranscriptionFailed?.Invoke(__value6);
            }
            else if (ConversationItemTruncated is { } __value7)
            {
                conversationItemTruncated?.Invoke(__value7);
            }
            else if (ConversationItemDeleted is { } __value8)
            {
                conversationItemDeleted?.Invoke(__value8);
            }
            else if (InputAudioBufferCommitted is { } __value9)
            {
                inputAudioBufferCommitted?.Invoke(__value9);
            }
            else if (InputAudioBufferCleared is { } __value10)
            {
                inputAudioBufferCleared?.Invoke(__value10);
            }
            else if (InputAudioBufferSpeechStarted is { } __value11)
            {
                inputAudioBufferSpeechStarted?.Invoke(__value11);
            }
            else if (InputAudioBufferSpeechStopped is { } __value12)
            {
                inputAudioBufferSpeechStopped?.Invoke(__value12);
            }
            else if (ResponseCreated is { } __value13)
            {
                responseCreated?.Invoke(__value13);
            }
            else if (ResponseDone is { } __value14)
            {
                responseDone?.Invoke(__value14);
            }
            else if (ResponseOutputItemAdded is { } __value15)
            {
                responseOutputItemAdded?.Invoke(__value15);
            }
            else if (ResponseOutputItemDone is { } __value16)
            {
                responseOutputItemDone?.Invoke(__value16);
            }
            else if (ResponseContentPartAdded is { } __value17)
            {
                responseContentPartAdded?.Invoke(__value17);
            }
            else if (ResponseContentPartDone is { } __value18)
            {
                responseContentPartDone?.Invoke(__value18);
            }
            else if (ResponseTextDelta is { } __value19)
            {
                responseTextDelta?.Invoke(__value19);
            }
            else if (ResponseTextDone is { } __value20)
            {
                responseTextDone?.Invoke(__value20);
            }
            else if (ResponseAudioTranscriptDelta is { } __value21)
            {
                responseAudioTranscriptDelta?.Invoke(__value21);
            }
            else if (ResponseAudioTranscriptDone is { } __value22)
            {
                responseAudioTranscriptDone?.Invoke(__value22);
            }
            else if (ResponseAudioDelta is { } __value23)
            {
                responseAudioDelta?.Invoke(__value23);
            }
            else if (ResponseAudioDone is { } __value24)
            {
                responseAudioDone?.Invoke(__value24);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value25)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value25);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value26)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value26);
            }
            else if (RateLimitsUpdated is { } __value27)
            {
                rateLimitsUpdated?.Invoke(__value27);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ErrorPayload>? error = null,
            global::System.Action<global::G.SessionCreatedPayload>? sessionCreated = null,
            global::System.Action<global::G.SessionUpdatedPayload>? sessionUpdated = null,
            global::System.Action<global::G.ConversationCreatedPayload>? conversationCreated = null,
            global::System.Action<global::G.ConversationItemCreatedPayload>? conversationItemCreated = null,
            global::System.Action<global::G.ConversationItemInputAudioTranscriptionCompletedPayload>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::G.ConversationItemInputAudioTranscriptionFailedPayload>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::G.ConversationItemTruncatedPayload>? conversationItemTruncated = null,
            global::System.Action<global::G.ConversationItemDeletedPayload>? conversationItemDeleted = null,
            global::System.Action<global::G.InputAudioBufferCommittedPayload>? inputAudioBufferCommitted = null,
            global::System.Action<global::G.InputAudioBufferClearedPayload>? inputAudioBufferCleared = null,
            global::System.Action<global::G.InputAudioBufferSpeechStartedPayload>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::G.InputAudioBufferSpeechStoppedPayload>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::G.ResponseCreatedPayload>? responseCreated = null,
            global::System.Action<global::G.ResponseDonePayload>? responseDone = null,
            global::System.Action<global::G.ResponseOutputItemAddedPayload>? responseOutputItemAdded = null,
            global::System.Action<global::G.ResponseOutputItemDonePayload>? responseOutputItemDone = null,
            global::System.Action<global::G.ResponseContentPartAddedPayload>? responseContentPartAdded = null,
            global::System.Action<global::G.ResponseContentPartDonePayload>? responseContentPartDone = null,
            global::System.Action<global::G.ResponseTextDeltaPayload>? responseTextDelta = null,
            global::System.Action<global::G.ResponseTextDonePayload>? responseTextDone = null,
            global::System.Action<global::G.ResponseAudioTranscriptDeltaPayload>? responseAudioTranscriptDelta = null,
            global::System.Action<global::G.ResponseAudioTranscriptDonePayload>? responseAudioTranscriptDone = null,
            global::System.Action<global::G.ResponseAudioDeltaPayload>? responseAudioDelta = null,
            global::System.Action<global::G.ResponseAudioDonePayload>? responseAudioDone = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDeltaPayload>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::G.ResponseFunctionCallArgumentsDonePayload>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::G.RateLimitsUpdatedPayload>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0)
            {
                error?.Invoke(__value0);
            }
            else if (SessionCreated is { } __value1)
            {
                sessionCreated?.Invoke(__value1);
            }
            else if (SessionUpdated is { } __value2)
            {
                sessionUpdated?.Invoke(__value2);
            }
            else if (ConversationCreated is { } __value3)
            {
                conversationCreated?.Invoke(__value3);
            }
            else if (ConversationItemCreated is { } __value4)
            {
                conversationItemCreated?.Invoke(__value4);
            }
            else if (ConversationItemInputAudioTranscriptionCompleted is { } __value5)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(__value5);
            }
            else if (ConversationItemInputAudioTranscriptionFailed is { } __value6)
            {
                conversationItemInputAudioTranscriptionFailed?.Invoke(__value6);
            }
            else if (ConversationItemTruncated is { } __value7)
            {
                conversationItemTruncated?.Invoke(__value7);
            }
            else if (ConversationItemDeleted is { } __value8)
            {
                conversationItemDeleted?.Invoke(__value8);
            }
            else if (InputAudioBufferCommitted is { } __value9)
            {
                inputAudioBufferCommitted?.Invoke(__value9);
            }
            else if (InputAudioBufferCleared is { } __value10)
            {
                inputAudioBufferCleared?.Invoke(__value10);
            }
            else if (InputAudioBufferSpeechStarted is { } __value11)
            {
                inputAudioBufferSpeechStarted?.Invoke(__value11);
            }
            else if (InputAudioBufferSpeechStopped is { } __value12)
            {
                inputAudioBufferSpeechStopped?.Invoke(__value12);
            }
            else if (ResponseCreated is { } __value13)
            {
                responseCreated?.Invoke(__value13);
            }
            else if (ResponseDone is { } __value14)
            {
                responseDone?.Invoke(__value14);
            }
            else if (ResponseOutputItemAdded is { } __value15)
            {
                responseOutputItemAdded?.Invoke(__value15);
            }
            else if (ResponseOutputItemDone is { } __value16)
            {
                responseOutputItemDone?.Invoke(__value16);
            }
            else if (ResponseContentPartAdded is { } __value17)
            {
                responseContentPartAdded?.Invoke(__value17);
            }
            else if (ResponseContentPartDone is { } __value18)
            {
                responseContentPartDone?.Invoke(__value18);
            }
            else if (ResponseTextDelta is { } __value19)
            {
                responseTextDelta?.Invoke(__value19);
            }
            else if (ResponseTextDone is { } __value20)
            {
                responseTextDone?.Invoke(__value20);
            }
            else if (ResponseAudioTranscriptDelta is { } __value21)
            {
                responseAudioTranscriptDelta?.Invoke(__value21);
            }
            else if (ResponseAudioTranscriptDone is { } __value22)
            {
                responseAudioTranscriptDone?.Invoke(__value22);
            }
            else if (ResponseAudioDelta is { } __value23)
            {
                responseAudioDelta?.Invoke(__value23);
            }
            else if (ResponseAudioDone is { } __value24)
            {
                responseAudioDone?.Invoke(__value24);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value25)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value25);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value26)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value26);
            }
            else if (RateLimitsUpdated is { } __value27)
            {
                rateLimitsUpdated?.Invoke(__value27);
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
