//HintName: G.Models.RealtimeClientEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A realtime client event.
    /// </summary>
    public readonly partial struct RealtimeClientEvent : global::System.IEquatable<RealtimeClientEvent>
    {
        /// <summary>
        /// Add a new Item to the Conversation's context, including messages, function <br/>
        /// calls, and function call responses. This event can be used both to populate a <br/>
        /// "history" of the conversation and to add new items mid-stream, but has the <br/>
        /// current limitation that it cannot populate assistant audio messages.<br/>
        /// If successful, the server will respond with a `conversation.item.created` <br/>
        /// event, otherwise an `error` event will be sent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventConversationItemCreate? ConversationItemCreate { get; init; }
#else
        public global::G.RealtimeClientEventConversationItemCreate? ConversationItemCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemCreate))]
#endif
        public bool IsConversationItemCreate => ConversationItemCreate != null;

        /// <summary>
        /// Send this event when you want to remove any item from the conversation <br/>
        /// history. The server will respond with a `conversation.item.deleted` event, <br/>
        /// unless the item does not exist in the conversation history, in which case the <br/>
        /// server will respond with an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventConversationItemDelete? ConversationItemDelete { get; init; }
#else
        public global::G.RealtimeClientEventConversationItemDelete? ConversationItemDelete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDelete))]
#endif
        public bool IsConversationItemDelete => ConversationItemDelete != null;

        /// <summary>
        /// Send this event when you want to retrieve the server's representation of a specific item in the conversation history. This is useful, for example, to inspect user audio after noise cancellation and VAD.<br/>
        /// The server will respond with a `conversation.item.retrieved` event, <br/>
        /// unless the item does not exist in the conversation history, in which case the <br/>
        /// server will respond with an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventConversationItemRetrieve? ConversationItemRetrieve { get; init; }
#else
        public global::G.RealtimeClientEventConversationItemRetrieve? ConversationItemRetrieve { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemRetrieve))]
#endif
        public bool IsConversationItemRetrieve => ConversationItemRetrieve != null;

        /// <summary>
        /// Send this event to truncate a previous assistant message’s audio. The server <br/>
        /// will produce audio faster than realtime, so this event is useful when the user <br/>
        /// interrupts to truncate audio that has already been sent to the client but not <br/>
        /// yet played. This will synchronize the server's understanding of the audio with <br/>
        /// the client's playback.<br/>
        /// Truncating audio will delete the server-side text transcript to ensure there <br/>
        /// is not text in the context that hasn't been heard by the user.<br/>
        /// If successful, the server will respond with a `conversation.item.truncated` <br/>
        /// event. 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventConversationItemTruncate? ConversationItemTruncate { get; init; }
#else
        public global::G.RealtimeClientEventConversationItemTruncate? ConversationItemTruncate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncate))]
#endif
        public bool IsConversationItemTruncate => ConversationItemTruncate != null;

        /// <summary>
        /// Send this event to append audio bytes to the input audio buffer. The audio <br/>
        /// buffer is temporary storage you can write to and later commit. In Server VAD <br/>
        /// mode, the audio buffer is used to detect speech and the server will decide <br/>
        /// when to commit. When Server VAD is disabled, you must commit the audio buffer<br/>
        /// manually.<br/>
        /// The client may choose how much audio to place in each event up to a maximum <br/>
        /// of 15 MiB, for example streaming smaller chunks from the client may allow the <br/>
        /// VAD to be more responsive. Unlike made other client events, the server will <br/>
        /// not send a confirmation response to this event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventInputAudioBufferAppend? InputAudioBufferAppend { get; init; }
#else
        public global::G.RealtimeClientEventInputAudioBufferAppend? InputAudioBufferAppend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferAppend))]
#endif
        public bool IsInputAudioBufferAppend => InputAudioBufferAppend != null;

        /// <summary>
        /// Send this event to clear the audio bytes in the buffer. The server will <br/>
        /// respond with an `input_audio_buffer.cleared` event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventInputAudioBufferClear? InputAudioBufferClear { get; init; }
#else
        public global::G.RealtimeClientEventInputAudioBufferClear? InputAudioBufferClear { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferClear))]
#endif
        public bool IsInputAudioBufferClear => InputAudioBufferClear != null;

        /// <summary>
        /// **WebRTC Only:** Emit to cut off the current audio response. This will trigger the server to<br/>
        /// stop generating audio and emit a `output_audio_buffer.cleared` event. This <br/>
        /// event should be preceded by a `response.cancel` client event to stop the <br/>
        /// generation of the current response.<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventOutputAudioBufferClear? OutputAudioBufferClear { get; init; }
#else
        public global::G.RealtimeClientEventOutputAudioBufferClear? OutputAudioBufferClear { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferClear))]
#endif
        public bool IsOutputAudioBufferClear => OutputAudioBufferClear != null;

        /// <summary>
        /// Send this event to commit the user input audio buffer, which will create a <br/>
        /// new user message item in the conversation. This event will produce an error <br/>
        /// if the input audio buffer is empty. When in Server VAD mode, the client does <br/>
        /// not need to send this event, the server will commit the audio buffer <br/>
        /// automatically.<br/>
        /// Committing the input audio buffer will trigger input audio transcription <br/>
        /// (if enabled in session configuration), but it will not create a response <br/>
        /// from the model. The server will respond with an `input_audio_buffer.committed` <br/>
        /// event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventInputAudioBufferCommit? InputAudioBufferCommit { get; init; }
#else
        public global::G.RealtimeClientEventInputAudioBufferCommit? InputAudioBufferCommit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommit))]
#endif
        public bool IsInputAudioBufferCommit => InputAudioBufferCommit != null;

        /// <summary>
        /// Send this event to cancel an in-progress response. The server will respond <br/>
        /// with a `response.cancelled` event or an error if there is no response to <br/>
        /// cancel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventResponseCancel? ResponseCancel { get; init; }
#else
        public global::G.RealtimeClientEventResponseCancel? ResponseCancel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCancel))]
#endif
        public bool IsResponseCancel => ResponseCancel != null;

        /// <summary>
        /// This event instructs the server to create a Response, which means triggering <br/>
        /// model inference. When in Server VAD mode, the server will create Responses <br/>
        /// automatically.<br/>
        /// A Response will include at least one Item, and may have two, in which case <br/>
        /// the second will be a function call. These Items will be appended to the <br/>
        /// conversation history.<br/>
        /// The server will respond with a `response.created` event, events for Items <br/>
        /// and content created, and finally a `response.done` event to indicate the <br/>
        /// Response is complete.<br/>
        /// The `response.create` event includes inference configuration like <br/>
        /// `instructions`, and `temperature`. These fields will override the Session's <br/>
        /// configuration for this Response only.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventResponseCreate? ResponseCreate { get; init; }
#else
        public global::G.RealtimeClientEventResponseCreate? ResponseCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreate))]
#endif
        public bool IsResponseCreate => ResponseCreate != null;

        /// <summary>
        /// Send this event to update the session’s default configuration.<br/>
        /// The client may send this event at any time to update any field,<br/>
        /// except for `voice`. However, note that once a session has been<br/>
        /// initialized with a particular `model`, it can’t be changed to<br/>
        /// another model using `session.update`.<br/>
        /// When the server receives a `session.update`, it will respond<br/>
        /// with a `session.updated` event showing the full, effective configuration.<br/>
        /// Only the fields that are present are updated. To clear a field like<br/>
        /// `instructions`, pass an empty string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventSessionUpdate? SessionUpdate { get; init; }
#else
        public global::G.RealtimeClientEventSessionUpdate? SessionUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdate))]
#endif
        public bool IsSessionUpdate => SessionUpdate != null;

        /// <summary>
        /// Send this event to update a transcription session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeClientEventTranscriptionSessionUpdate? TranscriptionSessionUpdate { get; init; }
#else
        public global::G.RealtimeClientEventTranscriptionSessionUpdate? TranscriptionSessionUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionSessionUpdate))]
#endif
        public bool IsTranscriptionSessionUpdate => TranscriptionSessionUpdate != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventConversationItemCreate value) => new RealtimeClientEvent((global::G.RealtimeClientEventConversationItemCreate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventConversationItemCreate?(RealtimeClientEvent @this) => @this.ConversationItemCreate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventConversationItemCreate? value)
        {
            ConversationItemCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventConversationItemDelete value) => new RealtimeClientEvent((global::G.RealtimeClientEventConversationItemDelete?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventConversationItemDelete?(RealtimeClientEvent @this) => @this.ConversationItemDelete;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventConversationItemDelete? value)
        {
            ConversationItemDelete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventConversationItemRetrieve value) => new RealtimeClientEvent((global::G.RealtimeClientEventConversationItemRetrieve?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventConversationItemRetrieve?(RealtimeClientEvent @this) => @this.ConversationItemRetrieve;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventConversationItemRetrieve? value)
        {
            ConversationItemRetrieve = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventConversationItemTruncate value) => new RealtimeClientEvent((global::G.RealtimeClientEventConversationItemTruncate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventConversationItemTruncate?(RealtimeClientEvent @this) => @this.ConversationItemTruncate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventConversationItemTruncate? value)
        {
            ConversationItemTruncate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventInputAudioBufferAppend value) => new RealtimeClientEvent((global::G.RealtimeClientEventInputAudioBufferAppend?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventInputAudioBufferAppend?(RealtimeClientEvent @this) => @this.InputAudioBufferAppend;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventInputAudioBufferAppend? value)
        {
            InputAudioBufferAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventInputAudioBufferClear value) => new RealtimeClientEvent((global::G.RealtimeClientEventInputAudioBufferClear?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventInputAudioBufferClear?(RealtimeClientEvent @this) => @this.InputAudioBufferClear;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventInputAudioBufferClear? value)
        {
            InputAudioBufferClear = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventOutputAudioBufferClear value) => new RealtimeClientEvent((global::G.RealtimeClientEventOutputAudioBufferClear?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventOutputAudioBufferClear?(RealtimeClientEvent @this) => @this.OutputAudioBufferClear;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventOutputAudioBufferClear? value)
        {
            OutputAudioBufferClear = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventInputAudioBufferCommit value) => new RealtimeClientEvent((global::G.RealtimeClientEventInputAudioBufferCommit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventInputAudioBufferCommit?(RealtimeClientEvent @this) => @this.InputAudioBufferCommit;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventInputAudioBufferCommit? value)
        {
            InputAudioBufferCommit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventResponseCancel value) => new RealtimeClientEvent((global::G.RealtimeClientEventResponseCancel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventResponseCancel?(RealtimeClientEvent @this) => @this.ResponseCancel;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventResponseCancel? value)
        {
            ResponseCancel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventResponseCreate value) => new RealtimeClientEvent((global::G.RealtimeClientEventResponseCreate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventResponseCreate?(RealtimeClientEvent @this) => @this.ResponseCreate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventResponseCreate? value)
        {
            ResponseCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventSessionUpdate value) => new RealtimeClientEvent((global::G.RealtimeClientEventSessionUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventSessionUpdate?(RealtimeClientEvent @this) => @this.SessionUpdate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventSessionUpdate? value)
        {
            SessionUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::G.RealtimeClientEventTranscriptionSessionUpdate value) => new RealtimeClientEvent((global::G.RealtimeClientEventTranscriptionSessionUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeClientEventTranscriptionSessionUpdate?(RealtimeClientEvent @this) => @this.TranscriptionSessionUpdate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::G.RealtimeClientEventTranscriptionSessionUpdate? value)
        {
            TranscriptionSessionUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(
            global::G.RealtimeClientEventConversationItemCreate? conversationItemCreate,
            global::G.RealtimeClientEventConversationItemDelete? conversationItemDelete,
            global::G.RealtimeClientEventConversationItemRetrieve? conversationItemRetrieve,
            global::G.RealtimeClientEventConversationItemTruncate? conversationItemTruncate,
            global::G.RealtimeClientEventInputAudioBufferAppend? inputAudioBufferAppend,
            global::G.RealtimeClientEventInputAudioBufferClear? inputAudioBufferClear,
            global::G.RealtimeClientEventOutputAudioBufferClear? outputAudioBufferClear,
            global::G.RealtimeClientEventInputAudioBufferCommit? inputAudioBufferCommit,
            global::G.RealtimeClientEventResponseCancel? responseCancel,
            global::G.RealtimeClientEventResponseCreate? responseCreate,
            global::G.RealtimeClientEventSessionUpdate? sessionUpdate,
            global::G.RealtimeClientEventTranscriptionSessionUpdate? transcriptionSessionUpdate
            )
        {
            ConversationItemCreate = conversationItemCreate;
            ConversationItemDelete = conversationItemDelete;
            ConversationItemRetrieve = conversationItemRetrieve;
            ConversationItemTruncate = conversationItemTruncate;
            InputAudioBufferAppend = inputAudioBufferAppend;
            InputAudioBufferClear = inputAudioBufferClear;
            OutputAudioBufferClear = outputAudioBufferClear;
            InputAudioBufferCommit = inputAudioBufferCommit;
            ResponseCancel = responseCancel;
            ResponseCreate = responseCreate;
            SessionUpdate = sessionUpdate;
            TranscriptionSessionUpdate = transcriptionSessionUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TranscriptionSessionUpdate as object ??
            SessionUpdate as object ??
            ResponseCreate as object ??
            ResponseCancel as object ??
            InputAudioBufferCommit as object ??
            OutputAudioBufferClear as object ??
            InputAudioBufferClear as object ??
            InputAudioBufferAppend as object ??
            ConversationItemTruncate as object ??
            ConversationItemRetrieve as object ??
            ConversationItemDelete as object ??
            ConversationItemCreate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationItemCreate?.ToString() ??
            ConversationItemDelete?.ToString() ??
            ConversationItemRetrieve?.ToString() ??
            ConversationItemTruncate?.ToString() ??
            InputAudioBufferAppend?.ToString() ??
            InputAudioBufferClear?.ToString() ??
            OutputAudioBufferClear?.ToString() ??
            InputAudioBufferCommit?.ToString() ??
            ResponseCancel?.ToString() ??
            ResponseCreate?.ToString() ??
            SessionUpdate?.ToString() ??
            TranscriptionSessionUpdate?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationItemCreate || IsConversationItemDelete || IsConversationItemRetrieve || IsConversationItemTruncate || IsInputAudioBufferAppend || IsInputAudioBufferClear || IsOutputAudioBufferClear || IsInputAudioBufferCommit || IsResponseCancel || IsResponseCreate || IsSessionUpdate || IsTranscriptionSessionUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RealtimeClientEventConversationItemCreate?, TResult>? conversationItemCreate = null,
            global::System.Func<global::G.RealtimeClientEventConversationItemDelete?, TResult>? conversationItemDelete = null,
            global::System.Func<global::G.RealtimeClientEventConversationItemRetrieve?, TResult>? conversationItemRetrieve = null,
            global::System.Func<global::G.RealtimeClientEventConversationItemTruncate?, TResult>? conversationItemTruncate = null,
            global::System.Func<global::G.RealtimeClientEventInputAudioBufferAppend?, TResult>? inputAudioBufferAppend = null,
            global::System.Func<global::G.RealtimeClientEventInputAudioBufferClear?, TResult>? inputAudioBufferClear = null,
            global::System.Func<global::G.RealtimeClientEventOutputAudioBufferClear?, TResult>? outputAudioBufferClear = null,
            global::System.Func<global::G.RealtimeClientEventInputAudioBufferCommit?, TResult>? inputAudioBufferCommit = null,
            global::System.Func<global::G.RealtimeClientEventResponseCancel?, TResult>? responseCancel = null,
            global::System.Func<global::G.RealtimeClientEventResponseCreate?, TResult>? responseCreate = null,
            global::System.Func<global::G.RealtimeClientEventSessionUpdate?, TResult>? sessionUpdate = null,
            global::System.Func<global::G.RealtimeClientEventTranscriptionSessionUpdate?, TResult>? transcriptionSessionUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationItemCreate && conversationItemCreate != null)
            {
                return conversationItemCreate(ConversationItemCreate!);
            }
            else if (IsConversationItemDelete && conversationItemDelete != null)
            {
                return conversationItemDelete(ConversationItemDelete!);
            }
            else if (IsConversationItemRetrieve && conversationItemRetrieve != null)
            {
                return conversationItemRetrieve(ConversationItemRetrieve!);
            }
            else if (IsConversationItemTruncate && conversationItemTruncate != null)
            {
                return conversationItemTruncate(ConversationItemTruncate!);
            }
            else if (IsInputAudioBufferAppend && inputAudioBufferAppend != null)
            {
                return inputAudioBufferAppend(InputAudioBufferAppend!);
            }
            else if (IsInputAudioBufferClear && inputAudioBufferClear != null)
            {
                return inputAudioBufferClear(InputAudioBufferClear!);
            }
            else if (IsOutputAudioBufferClear && outputAudioBufferClear != null)
            {
                return outputAudioBufferClear(OutputAudioBufferClear!);
            }
            else if (IsInputAudioBufferCommit && inputAudioBufferCommit != null)
            {
                return inputAudioBufferCommit(InputAudioBufferCommit!);
            }
            else if (IsResponseCancel && responseCancel != null)
            {
                return responseCancel(ResponseCancel!);
            }
            else if (IsResponseCreate && responseCreate != null)
            {
                return responseCreate(ResponseCreate!);
            }
            else if (IsSessionUpdate && sessionUpdate != null)
            {
                return sessionUpdate(SessionUpdate!);
            }
            else if (IsTranscriptionSessionUpdate && transcriptionSessionUpdate != null)
            {
                return transcriptionSessionUpdate(TranscriptionSessionUpdate!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RealtimeClientEventConversationItemCreate?>? conversationItemCreate = null,
            global::System.Action<global::G.RealtimeClientEventConversationItemDelete?>? conversationItemDelete = null,
            global::System.Action<global::G.RealtimeClientEventConversationItemRetrieve?>? conversationItemRetrieve = null,
            global::System.Action<global::G.RealtimeClientEventConversationItemTruncate?>? conversationItemTruncate = null,
            global::System.Action<global::G.RealtimeClientEventInputAudioBufferAppend?>? inputAudioBufferAppend = null,
            global::System.Action<global::G.RealtimeClientEventInputAudioBufferClear?>? inputAudioBufferClear = null,
            global::System.Action<global::G.RealtimeClientEventOutputAudioBufferClear?>? outputAudioBufferClear = null,
            global::System.Action<global::G.RealtimeClientEventInputAudioBufferCommit?>? inputAudioBufferCommit = null,
            global::System.Action<global::G.RealtimeClientEventResponseCancel?>? responseCancel = null,
            global::System.Action<global::G.RealtimeClientEventResponseCreate?>? responseCreate = null,
            global::System.Action<global::G.RealtimeClientEventSessionUpdate?>? sessionUpdate = null,
            global::System.Action<global::G.RealtimeClientEventTranscriptionSessionUpdate?>? transcriptionSessionUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationItemCreate)
            {
                conversationItemCreate?.Invoke(ConversationItemCreate!);
            }
            else if (IsConversationItemDelete)
            {
                conversationItemDelete?.Invoke(ConversationItemDelete!);
            }
            else if (IsConversationItemRetrieve)
            {
                conversationItemRetrieve?.Invoke(ConversationItemRetrieve!);
            }
            else if (IsConversationItemTruncate)
            {
                conversationItemTruncate?.Invoke(ConversationItemTruncate!);
            }
            else if (IsInputAudioBufferAppend)
            {
                inputAudioBufferAppend?.Invoke(InputAudioBufferAppend!);
            }
            else if (IsInputAudioBufferClear)
            {
                inputAudioBufferClear?.Invoke(InputAudioBufferClear!);
            }
            else if (IsOutputAudioBufferClear)
            {
                outputAudioBufferClear?.Invoke(OutputAudioBufferClear!);
            }
            else if (IsInputAudioBufferCommit)
            {
                inputAudioBufferCommit?.Invoke(InputAudioBufferCommit!);
            }
            else if (IsResponseCancel)
            {
                responseCancel?.Invoke(ResponseCancel!);
            }
            else if (IsResponseCreate)
            {
                responseCreate?.Invoke(ResponseCreate!);
            }
            else if (IsSessionUpdate)
            {
                sessionUpdate?.Invoke(SessionUpdate!);
            }
            else if (IsTranscriptionSessionUpdate)
            {
                transcriptionSessionUpdate?.Invoke(TranscriptionSessionUpdate!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationItemCreate,
                typeof(global::G.RealtimeClientEventConversationItemCreate),
                ConversationItemDelete,
                typeof(global::G.RealtimeClientEventConversationItemDelete),
                ConversationItemRetrieve,
                typeof(global::G.RealtimeClientEventConversationItemRetrieve),
                ConversationItemTruncate,
                typeof(global::G.RealtimeClientEventConversationItemTruncate),
                InputAudioBufferAppend,
                typeof(global::G.RealtimeClientEventInputAudioBufferAppend),
                InputAudioBufferClear,
                typeof(global::G.RealtimeClientEventInputAudioBufferClear),
                OutputAudioBufferClear,
                typeof(global::G.RealtimeClientEventOutputAudioBufferClear),
                InputAudioBufferCommit,
                typeof(global::G.RealtimeClientEventInputAudioBufferCommit),
                ResponseCancel,
                typeof(global::G.RealtimeClientEventResponseCancel),
                ResponseCreate,
                typeof(global::G.RealtimeClientEventResponseCreate),
                SessionUpdate,
                typeof(global::G.RealtimeClientEventSessionUpdate),
                TranscriptionSessionUpdate,
                typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate),
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
        public bool Equals(RealtimeClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventConversationItemCreate?>.Default.Equals(ConversationItemCreate, other.ConversationItemCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventConversationItemDelete?>.Default.Equals(ConversationItemDelete, other.ConversationItemDelete) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventConversationItemRetrieve?>.Default.Equals(ConversationItemRetrieve, other.ConversationItemRetrieve) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventConversationItemTruncate?>.Default.Equals(ConversationItemTruncate, other.ConversationItemTruncate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventInputAudioBufferAppend?>.Default.Equals(InputAudioBufferAppend, other.InputAudioBufferAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventInputAudioBufferClear?>.Default.Equals(InputAudioBufferClear, other.InputAudioBufferClear) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventOutputAudioBufferClear?>.Default.Equals(OutputAudioBufferClear, other.OutputAudioBufferClear) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventInputAudioBufferCommit?>.Default.Equals(InputAudioBufferCommit, other.InputAudioBufferCommit) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventResponseCancel?>.Default.Equals(ResponseCancel, other.ResponseCancel) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventResponseCreate?>.Default.Equals(ResponseCreate, other.ResponseCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventSessionUpdate?>.Default.Equals(SessionUpdate, other.SessionUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeClientEventTranscriptionSessionUpdate?>.Default.Equals(TranscriptionSessionUpdate, other.TranscriptionSessionUpdate) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeClientEvent obj1, RealtimeClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeClientEvent obj1, RealtimeClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeClientEvent o && Equals(o);
        }
    }
}
