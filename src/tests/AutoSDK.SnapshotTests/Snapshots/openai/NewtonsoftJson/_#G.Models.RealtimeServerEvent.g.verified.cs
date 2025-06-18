//HintName: G.Models.RealtimeServerEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A realtime server event.
    /// </summary>
    public readonly partial struct RealtimeServerEvent : global::System.IEquatable<RealtimeServerEvent>
    {
        /// <summary>
        /// Returned when a conversation is created. Emitted right after session creation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationCreated? ConversationCreated { get; init; }
#else
        public global::G.RealtimeServerEventConversationCreated? ConversationCreated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationCreated value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationCreated?(RealtimeServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationCreated? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// Returned when a conversation item is created. There are several scenarios that produce this event:<br/>
        ///   - The server is generating a Response, which if successful will produce <br/>
        ///     either one or two Items, which will be of type `message` <br/>
        ///     (role `assistant`) or type `function_call`.<br/>
        ///   - The input audio buffer has been committed, either by the client or the <br/>
        ///     server (in `server_vad` mode). The server will take the content of the <br/>
        ///     input audio buffer and add it to a new user message Item.<br/>
        ///   - The client has sent a `conversation.item.create` event to add a new Item <br/>
        ///     to the Conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemCreated? ConversationItemCreated { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemCreated? ConversationItemCreated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemCreated value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemCreated?(RealtimeServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemCreated? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// Returned when an item in the conversation is deleted by the client with a <br/>
        /// `conversation.item.delete` event. This event is used to synchronize the <br/>
        /// server's understanding of the conversation history with the client's view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemDeleted? ConversationItemDeleted { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemDeleted? ConversationItemDeleted { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemDeleted value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemDeleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemDeleted?(RealtimeServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemDeleted? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// This event is the output of audio transcription for user audio written to the <br/>
        /// user audio buffer. Transcription begins when the input audio buffer is <br/>
        /// committed by the client or server (in `server_vad` mode). Transcription runs <br/>
        /// asynchronously with Response creation, so this event may come before or after <br/>
        /// the Response events.<br/>
        /// Realtime API models accept audio natively, and thus input transcription is a <br/>
        /// separate process run on a separate ASR (Automatic Speech Recognition) model, <br/>
        /// currently always `whisper-1`. Thus the transcript may diverge somewhat from <br/>
        /// the model's interpretation, and should be treated as a rough guide.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// Returned when the text value of an input audio transcription content part is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionDelta))]
#endif
        public bool IsConversationItemInputAudioTranscriptionDelta => ConversationItemInputAudioTranscriptionDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? value)
        {
            ConversationItemInputAudioTranscriptionDelta = value;
        }

        /// <summary>
        /// Returned when input audio transcription is configured, and a transcription <br/>
        /// request for a user message failed. These events are separate from other <br/>
        /// `error` events so that the client can identify the related Item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// Returned when a conversation item is retrieved with `conversation.item.retrieve`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemRetrieved? ConversationItemRetrieved { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemRetrieved? ConversationItemRetrieved { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemRetrieved))]
#endif
        public bool IsConversationItemRetrieved => ConversationItemRetrieved != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemRetrieved value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemRetrieved?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemRetrieved?(RealtimeServerEvent @this) => @this.ConversationItemRetrieved;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemRetrieved? value)
        {
            ConversationItemRetrieved = value;
        }

        /// <summary>
        /// Returned when an earlier assistant audio message item is truncated by the <br/>
        /// client with a `conversation.item.truncate` event. This event is used to <br/>
        /// synchronize the server's understanding of the audio with the client's playback.<br/>
        /// This action will truncate the audio and remove the server-side text transcript <br/>
        /// to ensure there is no text in the context that hasn't been heard by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventConversationItemTruncated? ConversationItemTruncated { get; init; }
#else
        public global::G.RealtimeServerEventConversationItemTruncated? ConversationItemTruncated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventConversationItemTruncated value) => new RealtimeServerEvent((global::G.RealtimeServerEventConversationItemTruncated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventConversationItemTruncated?(RealtimeServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventConversationItemTruncated? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// Returned when an error occurs, which could be a client problem or a server <br/>
        /// problem. Most errors are recoverable and the session will stay open, we <br/>
        /// recommend to implementors to monitor and log error messages by default.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventError? Error { get; init; }
#else
        public global::G.RealtimeServerEventError? Error { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventError value) => new RealtimeServerEvent((global::G.RealtimeServerEventError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventError?(RealtimeServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventError? value)
        {
            Error = value;
        }

        /// <summary>
        /// Returned when the input audio buffer is cleared by the client with a <br/>
        /// `input_audio_buffer.clear` event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventInputAudioBufferCleared? InputAudioBufferCleared { get; init; }
#else
        public global::G.RealtimeServerEventInputAudioBufferCleared? InputAudioBufferCleared { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferCleared value) => new RealtimeServerEvent((global::G.RealtimeServerEventInputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventInputAudioBufferCleared?(RealtimeServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferCleared? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// Returned when an input audio buffer is committed, either by the client or <br/>
        /// automatically in server VAD mode. The `item_id` property is the ID of the user<br/>
        /// message item that will be created, thus a `conversation.item.created` event <br/>
        /// will also be sent to the client.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventInputAudioBufferCommitted? InputAudioBufferCommitted { get; init; }
#else
        public global::G.RealtimeServerEventInputAudioBufferCommitted? InputAudioBufferCommitted { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferCommitted value) => new RealtimeServerEvent((global::G.RealtimeServerEventInputAudioBufferCommitted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventInputAudioBufferCommitted?(RealtimeServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferCommitted? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// Sent by the server when in `server_vad` mode to indicate that speech has been <br/>
        /// detected in the audio buffer. This can happen any time audio is added to the <br/>
        /// buffer (unless speech is already detected). The client may want to use this <br/>
        /// event to interrupt audio playback or provide visual feedback to the user. <br/>
        /// The client should expect to receive a `input_audio_buffer.speech_stopped` event <br/>
        /// when speech stops. The `item_id` property is the ID of the user message item <br/>
        /// that will be created when speech stops and will also be included in the <br/>
        /// `input_audio_buffer.speech_stopped` event (unless the client manually commits <br/>
        /// the audio buffer during VAD activation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::G.RealtimeServerEventInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferSpeechStarted value) => new RealtimeServerEvent((global::G.RealtimeServerEventInputAudioBufferSpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventInputAudioBufferSpeechStarted?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferSpeechStarted? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// Returned in `server_vad` mode when the server detects the end of speech in <br/>
        /// the audio buffer. The server will also send an `conversation.item.created` <br/>
        /// event with the user message item that is created from the audio buffer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::G.RealtimeServerEventInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferSpeechStopped value) => new RealtimeServerEvent((global::G.RealtimeServerEventInputAudioBufferSpeechStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventInputAudioBufferSpeechStopped?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventInputAudioBufferSpeechStopped? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// Emitted at the beginning of a Response to indicate the updated rate limits. <br/>
        /// When a Response is created some tokens will be "reserved" for the output <br/>
        /// tokens, the rate limits shown here reflect that reservation, which is then <br/>
        /// adjusted accordingly once the Response is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventRateLimitsUpdated? RateLimitsUpdated { get; init; }
#else
        public global::G.RealtimeServerEventRateLimitsUpdated? RateLimitsUpdated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventRateLimitsUpdated value) => new RealtimeServerEvent((global::G.RealtimeServerEventRateLimitsUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventRateLimitsUpdated?(RealtimeServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventRateLimitsUpdated? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// Returned when the model-generated audio is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseAudioDelta? ResponseAudioDelta { get; init; }
#else
        public global::G.RealtimeServerEventResponseAudioDelta? ResponseAudioDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioDelta value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseAudioDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseAudioDelta?(RealtimeServerEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioDelta? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// Returned when the model-generated audio is done. Also emitted when a Response<br/>
        /// is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseAudioDone? ResponseAudioDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseAudioDone? ResponseAudioDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseAudioDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseAudioDone?(RealtimeServerEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioDone? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// Returned when the model-generated transcription of audio output is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseAudioTranscriptDelta? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::G.RealtimeServerEventResponseAudioTranscriptDelta? ResponseAudioTranscriptDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioTranscriptDelta value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseAudioTranscriptDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseAudioTranscriptDelta?(RealtimeServerEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioTranscriptDelta? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// Returned when the model-generated transcription of audio output is done<br/>
        /// streaming. Also emitted when a Response is interrupted, incomplete, or<br/>
        /// cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseAudioTranscriptDone? ResponseAudioTranscriptDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseAudioTranscriptDone? ResponseAudioTranscriptDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioTranscriptDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseAudioTranscriptDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseAudioTranscriptDone?(RealtimeServerEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseAudioTranscriptDone? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// Returned when a new content part is added to an assistant message item during<br/>
        /// response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseContentPartAdded? ResponseContentPartAdded { get; init; }
#else
        public global::G.RealtimeServerEventResponseContentPartAdded? ResponseContentPartAdded { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseContentPartAdded value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseContentPartAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseContentPartAdded?(RealtimeServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseContentPartAdded? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// Returned when a content part is done streaming in an assistant message item.<br/>
        /// Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseContentPartDone? ResponseContentPartDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseContentPartDone? ResponseContentPartDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseContentPartDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseContentPartDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseContentPartDone?(RealtimeServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseContentPartDone? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// Returned when a new Response is created. The first event of response creation,<br/>
        /// where the response is in an initial state of `in_progress`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseCreated? ResponseCreated { get; init; }
#else
        public global::G.RealtimeServerEventResponseCreated? ResponseCreated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseCreated value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseCreated?(RealtimeServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseCreated? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// Returned when a Response is done streaming. Always emitted, no matter the <br/>
        /// final state. The Response object included in the `response.done` event will <br/>
        /// include all output Items in the Response but will omit the raw audio data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseDone? ResponseDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseDone? ResponseDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseDone?(RealtimeServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseDone? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// Returned when the model-generated function call arguments are updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// Returned when the model-generated function call arguments are done streaming.<br/>
        /// Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// Returned when a new Item is created during Response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseOutputItemAdded? ResponseOutputItemAdded { get; init; }
#else
        public global::G.RealtimeServerEventResponseOutputItemAdded? ResponseOutputItemAdded { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseOutputItemAdded value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseOutputItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseOutputItemAdded?(RealtimeServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// Returned when an Item is done streaming. Also emitted when a Response is <br/>
        /// interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseOutputItemDone? ResponseOutputItemDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseOutputItemDone? ResponseOutputItemDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseOutputItemDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseOutputItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseOutputItemDone?(RealtimeServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// Returned when the text value of a "text" content part is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseTextDelta? ResponseTextDelta { get; init; }
#else
        public global::G.RealtimeServerEventResponseTextDelta? ResponseTextDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseTextDelta value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseTextDelta?(RealtimeServerEvent @this) => @this.ResponseTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseTextDelta? value)
        {
            ResponseTextDelta = value;
        }

        /// <summary>
        /// Returned when the text value of a "text" content part is done streaming. Also<br/>
        /// emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventResponseTextDone? ResponseTextDone { get; init; }
#else
        public global::G.RealtimeServerEventResponseTextDone? ResponseTextDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventResponseTextDone value) => new RealtimeServerEvent((global::G.RealtimeServerEventResponseTextDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventResponseTextDone?(RealtimeServerEvent @this) => @this.ResponseTextDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventResponseTextDone? value)
        {
            ResponseTextDone = value;
        }

        /// <summary>
        /// Returned when a Session is created. Emitted automatically when a new <br/>
        /// connection is established as the first server event. This event will contain <br/>
        /// the default Session configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventSessionCreated? SessionCreated { get; init; }
#else
        public global::G.RealtimeServerEventSessionCreated? SessionCreated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventSessionCreated value) => new RealtimeServerEvent((global::G.RealtimeServerEventSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventSessionCreated?(RealtimeServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// Returned when a session is updated with a `session.update` event, unless <br/>
        /// there is an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventSessionUpdated? SessionUpdated { get; init; }
#else
        public global::G.RealtimeServerEventSessionUpdated? SessionUpdated { get; }
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
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventSessionUpdated value) => new RealtimeServerEvent((global::G.RealtimeServerEventSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventSessionUpdated?(RealtimeServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// Returned when a transcription session is updated with a `transcription_session.update` event, unless <br/>
        /// there is an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventTranscriptionSessionUpdated? TranscriptionSessionUpdated { get; init; }
#else
        public global::G.RealtimeServerEventTranscriptionSessionUpdated? TranscriptionSessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionSessionUpdated))]
#endif
        public bool IsTranscriptionSessionUpdated => TranscriptionSessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventTranscriptionSessionUpdated value) => new RealtimeServerEvent((global::G.RealtimeServerEventTranscriptionSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventTranscriptionSessionUpdated?(RealtimeServerEvent @this) => @this.TranscriptionSessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventTranscriptionSessionUpdated? value)
        {
            TranscriptionSessionUpdated = value;
        }

        /// <summary>
        /// **WebRTC Only:** Emitted when the server begins streaming audio to the client. This event is<br/>
        /// emitted after an audio content part has been added (`response.content_part.added`)<br/>
        /// to the response.<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventOutputAudioBufferStarted? OutputAudioBufferStarted { get; init; }
#else
        public global::G.RealtimeServerEventOutputAudioBufferStarted? OutputAudioBufferStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferStarted))]
#endif
        public bool IsOutputAudioBufferStarted => OutputAudioBufferStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventOutputAudioBufferStarted value) => new RealtimeServerEvent((global::G.RealtimeServerEventOutputAudioBufferStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventOutputAudioBufferStarted?(RealtimeServerEvent @this) => @this.OutputAudioBufferStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventOutputAudioBufferStarted? value)
        {
            OutputAudioBufferStarted = value;
        }

        /// <summary>
        /// **WebRTC Only:** Emitted when the output audio buffer has been completely drained on the server,<br/>
        /// and no more audio is forthcoming. This event is emitted after the full response<br/>
        /// data has been sent to the client (`response.done`).<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventOutputAudioBufferStopped? OutputAudioBufferStopped { get; init; }
#else
        public global::G.RealtimeServerEventOutputAudioBufferStopped? OutputAudioBufferStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferStopped))]
#endif
        public bool IsOutputAudioBufferStopped => OutputAudioBufferStopped != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventOutputAudioBufferStopped value) => new RealtimeServerEvent((global::G.RealtimeServerEventOutputAudioBufferStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventOutputAudioBufferStopped?(RealtimeServerEvent @this) => @this.OutputAudioBufferStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventOutputAudioBufferStopped? value)
        {
            OutputAudioBufferStopped = value;
        }

        /// <summary>
        /// **WebRTC Only:** Emitted when the output audio buffer is cleared. This happens either in VAD<br/>
        /// mode when the user has interrupted (`input_audio_buffer.speech_started`),<br/>
        /// or when the client has emitted the `output_audio_buffer.clear` event to manually<br/>
        /// cut off the current audio response.<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeServerEventOutputAudioBufferCleared? OutputAudioBufferCleared { get; init; }
#else
        public global::G.RealtimeServerEventOutputAudioBufferCleared? OutputAudioBufferCleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferCleared))]
#endif
        public bool IsOutputAudioBufferCleared => OutputAudioBufferCleared != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::G.RealtimeServerEventOutputAudioBufferCleared value) => new RealtimeServerEvent((global::G.RealtimeServerEventOutputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeServerEventOutputAudioBufferCleared?(RealtimeServerEvent @this) => @this.OutputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::G.RealtimeServerEventOutputAudioBufferCleared? value)
        {
            OutputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(
            global::G.RealtimeServerEventConversationCreated? conversationCreated,
            global::G.RealtimeServerEventConversationItemCreated? conversationItemCreated,
            global::G.RealtimeServerEventConversationItemDeleted? conversationItemDeleted,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed,
            global::G.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved,
            global::G.RealtimeServerEventConversationItemTruncated? conversationItemTruncated,
            global::G.RealtimeServerEventError? error,
            global::G.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared,
            global::G.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted,
            global::G.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted,
            global::G.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped,
            global::G.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated,
            global::G.RealtimeServerEventResponseAudioDelta? responseAudioDelta,
            global::G.RealtimeServerEventResponseAudioDone? responseAudioDone,
            global::G.RealtimeServerEventResponseAudioTranscriptDelta? responseAudioTranscriptDelta,
            global::G.RealtimeServerEventResponseAudioTranscriptDone? responseAudioTranscriptDone,
            global::G.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded,
            global::G.RealtimeServerEventResponseContentPartDone? responseContentPartDone,
            global::G.RealtimeServerEventResponseCreated? responseCreated,
            global::G.RealtimeServerEventResponseDone? responseDone,
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta,
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone,
            global::G.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded,
            global::G.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone,
            global::G.RealtimeServerEventResponseTextDelta? responseTextDelta,
            global::G.RealtimeServerEventResponseTextDone? responseTextDone,
            global::G.RealtimeServerEventSessionCreated? sessionCreated,
            global::G.RealtimeServerEventSessionUpdated? sessionUpdated,
            global::G.RealtimeServerEventTranscriptionSessionUpdated? transcriptionSessionUpdated,
            global::G.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted,
            global::G.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped,
            global::G.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared
            )
        {
            ConversationCreated = conversationCreated;
            ConversationItemCreated = conversationItemCreated;
            ConversationItemDeleted = conversationItemDeleted;
            ConversationItemInputAudioTranscriptionCompleted = conversationItemInputAudioTranscriptionCompleted;
            ConversationItemInputAudioTranscriptionDelta = conversationItemInputAudioTranscriptionDelta;
            ConversationItemInputAudioTranscriptionFailed = conversationItemInputAudioTranscriptionFailed;
            ConversationItemRetrieved = conversationItemRetrieved;
            ConversationItemTruncated = conversationItemTruncated;
            Error = error;
            InputAudioBufferCleared = inputAudioBufferCleared;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            RateLimitsUpdated = rateLimitsUpdated;
            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseTextDelta = responseTextDelta;
            ResponseTextDone = responseTextDone;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            TranscriptionSessionUpdated = transcriptionSessionUpdated;
            OutputAudioBufferStarted = outputAudioBufferStarted;
            OutputAudioBufferStopped = outputAudioBufferStopped;
            OutputAudioBufferCleared = outputAudioBufferCleared;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputAudioBufferCleared as object ??
            OutputAudioBufferStopped as object ??
            OutputAudioBufferStarted as object ??
            TranscriptionSessionUpdated as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            ResponseTextDone as object ??
            ResponseTextDelta as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object ??
            RateLimitsUpdated as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            InputAudioBufferCommitted as object ??
            InputAudioBufferCleared as object ??
            Error as object ??
            ConversationItemTruncated as object ??
            ConversationItemRetrieved as object ??
            ConversationItemInputAudioTranscriptionFailed as object ??
            ConversationItemInputAudioTranscriptionDelta as object ??
            ConversationItemInputAudioTranscriptionCompleted as object ??
            ConversationItemDeleted as object ??
            ConversationItemCreated as object ??
            ConversationCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationCreated?.ToString() ??
            ConversationItemCreated?.ToString() ??
            ConversationItemDeleted?.ToString() ??
            ConversationItemInputAudioTranscriptionCompleted?.ToString() ??
            ConversationItemInputAudioTranscriptionDelta?.ToString() ??
            ConversationItemInputAudioTranscriptionFailed?.ToString() ??
            ConversationItemRetrieved?.ToString() ??
            ConversationItemTruncated?.ToString() ??
            Error?.ToString() ??
            InputAudioBufferCleared?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            RateLimitsUpdated?.ToString() ??
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseTextDelta?.ToString() ??
            ResponseTextDone?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            TranscriptionSessionUpdated?.ToString() ??
            OutputAudioBufferStarted?.ToString() ??
            OutputAudioBufferStopped?.ToString() ??
            OutputAudioBufferCleared?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationCreated || IsConversationItemCreated || IsConversationItemDeleted || IsConversationItemInputAudioTranscriptionCompleted || IsConversationItemInputAudioTranscriptionDelta || IsConversationItemInputAudioTranscriptionFailed || IsConversationItemRetrieved || IsConversationItemTruncated || IsError || IsInputAudioBufferCleared || IsInputAudioBufferCommitted || IsInputAudioBufferSpeechStarted || IsInputAudioBufferSpeechStopped || IsRateLimitsUpdated || IsResponseAudioDelta || IsResponseAudioDone || IsResponseAudioTranscriptDelta || IsResponseAudioTranscriptDone || IsResponseContentPartAdded || IsResponseContentPartDone || IsResponseCreated || IsResponseDone || IsResponseFunctionCallArgumentsDelta || IsResponseFunctionCallArgumentsDone || IsResponseOutputItemAdded || IsResponseOutputItemDone || IsResponseTextDelta || IsResponseTextDone || IsSessionCreated || IsSessionUpdated || IsTranscriptionSessionUpdated || IsOutputAudioBufferStarted || IsOutputAudioBufferStopped || IsOutputAudioBufferCleared;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RealtimeServerEventConversationCreated?, TResult>? conversationCreated = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemCreated?, TResult>? conversationItemCreated = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemDeleted?, TResult>? conversationItemDeleted = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?, TResult>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemRetrieved?, TResult>? conversationItemRetrieved = null,
            global::System.Func<global::G.RealtimeServerEventConversationItemTruncated?, TResult>? conversationItemTruncated = null,
            global::System.Func<global::G.RealtimeServerEventError?, TResult>? error = null,
            global::System.Func<global::G.RealtimeServerEventInputAudioBufferCleared?, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::G.RealtimeServerEventInputAudioBufferCommitted?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::G.RealtimeServerEventInputAudioBufferSpeechStarted?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::G.RealtimeServerEventInputAudioBufferSpeechStopped?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::G.RealtimeServerEventRateLimitsUpdated?, TResult>? rateLimitsUpdated = null,
            global::System.Func<global::G.RealtimeServerEventResponseAudioDelta?, TResult>? responseAudioDelta = null,
            global::System.Func<global::G.RealtimeServerEventResponseAudioDone?, TResult>? responseAudioDone = null,
            global::System.Func<global::G.RealtimeServerEventResponseAudioTranscriptDelta?, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::G.RealtimeServerEventResponseAudioTranscriptDone?, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::G.RealtimeServerEventResponseContentPartAdded?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::G.RealtimeServerEventResponseContentPartDone?, TResult>? responseContentPartDone = null,
            global::System.Func<global::G.RealtimeServerEventResponseCreated?, TResult>? responseCreated = null,
            global::System.Func<global::G.RealtimeServerEventResponseDone?, TResult>? responseDone = null,
            global::System.Func<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::G.RealtimeServerEventResponseOutputItemAdded?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::G.RealtimeServerEventResponseOutputItemDone?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::G.RealtimeServerEventResponseTextDelta?, TResult>? responseTextDelta = null,
            global::System.Func<global::G.RealtimeServerEventResponseTextDone?, TResult>? responseTextDone = null,
            global::System.Func<global::G.RealtimeServerEventSessionCreated?, TResult>? sessionCreated = null,
            global::System.Func<global::G.RealtimeServerEventSessionUpdated?, TResult>? sessionUpdated = null,
            global::System.Func<global::G.RealtimeServerEventTranscriptionSessionUpdated?, TResult>? transcriptionSessionUpdated = null,
            global::System.Func<global::G.RealtimeServerEventOutputAudioBufferStarted?, TResult>? outputAudioBufferStarted = null,
            global::System.Func<global::G.RealtimeServerEventOutputAudioBufferStopped?, TResult>? outputAudioBufferStopped = null,
            global::System.Func<global::G.RealtimeServerEventOutputAudioBufferCleared?, TResult>? outputAudioBufferCleared = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationCreated && conversationCreated != null)
            {
                return conversationCreated(ConversationCreated!);
            }
            else if (IsConversationItemCreated && conversationItemCreated != null)
            {
                return conversationItemCreated(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted && conversationItemDeleted != null)
            {
                return conversationItemDeleted(ConversationItemDeleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted && conversationItemInputAudioTranscriptionCompleted != null)
            {
                return conversationItemInputAudioTranscriptionCompleted(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionDelta && conversationItemInputAudioTranscriptionDelta != null)
            {
                return conversationItemInputAudioTranscriptionDelta(ConversationItemInputAudioTranscriptionDelta!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed && conversationItemInputAudioTranscriptionFailed != null)
            {
                return conversationItemInputAudioTranscriptionFailed(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemRetrieved && conversationItemRetrieved != null)
            {
                return conversationItemRetrieved(ConversationItemRetrieved!);
            }
            else if (IsConversationItemTruncated && conversationItemTruncated != null)
            {
                return conversationItemTruncated(ConversationItemTruncated!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsInputAudioBufferCleared && inputAudioBufferCleared != null)
            {
                return inputAudioBufferCleared(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferCommitted && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferSpeechStarted && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(InputAudioBufferSpeechStopped!);
            }
            else if (IsRateLimitsUpdated && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(RateLimitsUpdated!);
            }
            else if (IsResponseAudioDelta && responseAudioDelta != null)
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
            else if (IsResponseDone && responseDone != null)
            {
                return responseDone(ResponseDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseTextDelta && responseTextDelta != null)
            {
                return responseTextDelta(ResponseTextDelta!);
            }
            else if (IsResponseTextDone && responseTextDone != null)
            {
                return responseTextDone(ResponseTextDone!);
            }
            else if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsTranscriptionSessionUpdated && transcriptionSessionUpdated != null)
            {
                return transcriptionSessionUpdated(TranscriptionSessionUpdated!);
            }
            else if (IsOutputAudioBufferStarted && outputAudioBufferStarted != null)
            {
                return outputAudioBufferStarted(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped && outputAudioBufferStopped != null)
            {
                return outputAudioBufferStopped(OutputAudioBufferStopped!);
            }
            else if (IsOutputAudioBufferCleared && outputAudioBufferCleared != null)
            {
                return outputAudioBufferCleared(OutputAudioBufferCleared!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RealtimeServerEventConversationCreated?>? conversationCreated = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemCreated?>? conversationItemCreated = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemDeleted?>? conversationItemDeleted = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemRetrieved?>? conversationItemRetrieved = null,
            global::System.Action<global::G.RealtimeServerEventConversationItemTruncated?>? conversationItemTruncated = null,
            global::System.Action<global::G.RealtimeServerEventError?>? error = null,
            global::System.Action<global::G.RealtimeServerEventInputAudioBufferCleared?>? inputAudioBufferCleared = null,
            global::System.Action<global::G.RealtimeServerEventInputAudioBufferCommitted?>? inputAudioBufferCommitted = null,
            global::System.Action<global::G.RealtimeServerEventInputAudioBufferSpeechStarted?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::G.RealtimeServerEventInputAudioBufferSpeechStopped?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::G.RealtimeServerEventRateLimitsUpdated?>? rateLimitsUpdated = null,
            global::System.Action<global::G.RealtimeServerEventResponseAudioDelta?>? responseAudioDelta = null,
            global::System.Action<global::G.RealtimeServerEventResponseAudioDone?>? responseAudioDone = null,
            global::System.Action<global::G.RealtimeServerEventResponseAudioTranscriptDelta?>? responseAudioTranscriptDelta = null,
            global::System.Action<global::G.RealtimeServerEventResponseAudioTranscriptDone?>? responseAudioTranscriptDone = null,
            global::System.Action<global::G.RealtimeServerEventResponseContentPartAdded?>? responseContentPartAdded = null,
            global::System.Action<global::G.RealtimeServerEventResponseContentPartDone?>? responseContentPartDone = null,
            global::System.Action<global::G.RealtimeServerEventResponseCreated?>? responseCreated = null,
            global::System.Action<global::G.RealtimeServerEventResponseDone?>? responseDone = null,
            global::System.Action<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::G.RealtimeServerEventResponseOutputItemAdded?>? responseOutputItemAdded = null,
            global::System.Action<global::G.RealtimeServerEventResponseOutputItemDone?>? responseOutputItemDone = null,
            global::System.Action<global::G.RealtimeServerEventResponseTextDelta?>? responseTextDelta = null,
            global::System.Action<global::G.RealtimeServerEventResponseTextDone?>? responseTextDone = null,
            global::System.Action<global::G.RealtimeServerEventSessionCreated?>? sessionCreated = null,
            global::System.Action<global::G.RealtimeServerEventSessionUpdated?>? sessionUpdated = null,
            global::System.Action<global::G.RealtimeServerEventTranscriptionSessionUpdated?>? transcriptionSessionUpdated = null,
            global::System.Action<global::G.RealtimeServerEventOutputAudioBufferStarted?>? outputAudioBufferStarted = null,
            global::System.Action<global::G.RealtimeServerEventOutputAudioBufferStopped?>? outputAudioBufferStopped = null,
            global::System.Action<global::G.RealtimeServerEventOutputAudioBufferCleared?>? outputAudioBufferCleared = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationCreated)
            {
                conversationCreated?.Invoke(ConversationCreated!);
            }
            else if (IsConversationItemCreated)
            {
                conversationItemCreated?.Invoke(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted)
            {
                conversationItemDeleted?.Invoke(ConversationItemDeleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionDelta)
            {
                conversationItemInputAudioTranscriptionDelta?.Invoke(ConversationItemInputAudioTranscriptionDelta!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed)
            {
                conversationItemInputAudioTranscriptionFailed?.Invoke(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemRetrieved)
            {
                conversationItemRetrieved?.Invoke(ConversationItemRetrieved!);
            }
            else if (IsConversationItemTruncated)
            {
                conversationItemTruncated?.Invoke(ConversationItemTruncated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsInputAudioBufferCleared)
            {
                inputAudioBufferCleared?.Invoke(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
            }
            else if (IsRateLimitsUpdated)
            {
                rateLimitsUpdated?.Invoke(RateLimitsUpdated!);
            }
            else if (IsResponseAudioDelta)
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
            else if (IsResponseDone)
            {
                responseDone?.Invoke(ResponseDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseTextDelta)
            {
                responseTextDelta?.Invoke(ResponseTextDelta!);
            }
            else if (IsResponseTextDone)
            {
                responseTextDone?.Invoke(ResponseTextDone!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsTranscriptionSessionUpdated)
            {
                transcriptionSessionUpdated?.Invoke(TranscriptionSessionUpdated!);
            }
            else if (IsOutputAudioBufferStarted)
            {
                outputAudioBufferStarted?.Invoke(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped)
            {
                outputAudioBufferStopped?.Invoke(OutputAudioBufferStopped!);
            }
            else if (IsOutputAudioBufferCleared)
            {
                outputAudioBufferCleared?.Invoke(OutputAudioBufferCleared!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationCreated,
                typeof(global::G.RealtimeServerEventConversationCreated),
                ConversationItemCreated,
                typeof(global::G.RealtimeServerEventConversationItemCreated),
                ConversationItemDeleted,
                typeof(global::G.RealtimeServerEventConversationItemDeleted),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted),
                ConversationItemInputAudioTranscriptionDelta,
                typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed),
                ConversationItemRetrieved,
                typeof(global::G.RealtimeServerEventConversationItemRetrieved),
                ConversationItemTruncated,
                typeof(global::G.RealtimeServerEventConversationItemTruncated),
                Error,
                typeof(global::G.RealtimeServerEventError),
                InputAudioBufferCleared,
                typeof(global::G.RealtimeServerEventInputAudioBufferCleared),
                InputAudioBufferCommitted,
                typeof(global::G.RealtimeServerEventInputAudioBufferCommitted),
                InputAudioBufferSpeechStarted,
                typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted),
                InputAudioBufferSpeechStopped,
                typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped),
                RateLimitsUpdated,
                typeof(global::G.RealtimeServerEventRateLimitsUpdated),
                ResponseAudioDelta,
                typeof(global::G.RealtimeServerEventResponseAudioDelta),
                ResponseAudioDone,
                typeof(global::G.RealtimeServerEventResponseAudioDone),
                ResponseAudioTranscriptDelta,
                typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta),
                ResponseAudioTranscriptDone,
                typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone),
                ResponseContentPartAdded,
                typeof(global::G.RealtimeServerEventResponseContentPartAdded),
                ResponseContentPartDone,
                typeof(global::G.RealtimeServerEventResponseContentPartDone),
                ResponseCreated,
                typeof(global::G.RealtimeServerEventResponseCreated),
                ResponseDone,
                typeof(global::G.RealtimeServerEventResponseDone),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta),
                ResponseFunctionCallArgumentsDone,
                typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone),
                ResponseOutputItemAdded,
                typeof(global::G.RealtimeServerEventResponseOutputItemAdded),
                ResponseOutputItemDone,
                typeof(global::G.RealtimeServerEventResponseOutputItemDone),
                ResponseTextDelta,
                typeof(global::G.RealtimeServerEventResponseTextDelta),
                ResponseTextDone,
                typeof(global::G.RealtimeServerEventResponseTextDone),
                SessionCreated,
                typeof(global::G.RealtimeServerEventSessionCreated),
                SessionUpdated,
                typeof(global::G.RealtimeServerEventSessionUpdated),
                TranscriptionSessionUpdated,
                typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated),
                OutputAudioBufferStarted,
                typeof(global::G.RealtimeServerEventOutputAudioBufferStarted),
                OutputAudioBufferStopped,
                typeof(global::G.RealtimeServerEventOutputAudioBufferStopped),
                OutputAudioBufferCleared,
                typeof(global::G.RealtimeServerEventOutputAudioBufferCleared),
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
        public bool Equals(RealtimeServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationCreated?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemCreated?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemDeleted?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>.Default.Equals(ConversationItemInputAudioTranscriptionDelta, other.ConversationItemInputAudioTranscriptionDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemRetrieved?>.Default.Equals(ConversationItemRetrieved, other.ConversationItemRetrieved) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventConversationItemTruncated?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventInputAudioBufferCleared?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventInputAudioBufferCommitted?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventInputAudioBufferSpeechStarted?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventInputAudioBufferSpeechStopped?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventRateLimitsUpdated?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseAudioDelta?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseAudioDone?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseAudioTranscriptDelta?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseAudioTranscriptDone?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseContentPartAdded?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseContentPartDone?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseCreated?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseDone?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseTextDelta?>.Default.Equals(ResponseTextDelta, other.ResponseTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventResponseTextDone?>.Default.Equals(ResponseTextDone, other.ResponseTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventTranscriptionSessionUpdated?>.Default.Equals(TranscriptionSessionUpdated, other.TranscriptionSessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventOutputAudioBufferStarted?>.Default.Equals(OutputAudioBufferStarted, other.OutputAudioBufferStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventOutputAudioBufferStopped?>.Default.Equals(OutputAudioBufferStopped, other.OutputAudioBufferStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeServerEventOutputAudioBufferCleared?>.Default.Equals(OutputAudioBufferCleared, other.OutputAudioBufferCleared) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeServerEvent obj1, RealtimeServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeServerEvent obj1, RealtimeServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeServerEvent o && Equals(o);
        }
    }
}
