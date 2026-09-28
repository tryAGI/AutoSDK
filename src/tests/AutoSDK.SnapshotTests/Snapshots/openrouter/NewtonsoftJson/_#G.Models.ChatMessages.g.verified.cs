//HintName: G.Models.ChatMessages.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Chat completion message with role-based discrimination
    /// </summary>
    public readonly partial struct ChatMessages : global::System.IEquatable<ChatMessages>
    {
        /// <summary>
        /// System message for setting behavior
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatSystemMessage? ChatSystemMessage { get; init; }
#else
        public global::G.ChatSystemMessage? ChatSystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatSystemMessage))]
#endif
        public bool IsChatSystemMessage => ChatSystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatSystemMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatSystemMessage? value)
        {
            value = ChatSystemMessage;
            return IsChatSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatSystemMessage PickChatSystemMessage() => ChatSystemMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatSystemMessage' but the value was {ToString()}.");

        /// <summary>
        /// User message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatUserMessage? ChatUserMessage { get; init; }
#else
        public global::G.ChatUserMessage? ChatUserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatUserMessage))]
#endif
        public bool IsChatUserMessage => ChatUserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatUserMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatUserMessage? value)
        {
            value = ChatUserMessage;
            return IsChatUserMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatUserMessage PickChatUserMessage() => ChatUserMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatUserMessage' but the value was {ToString()}.");

        /// <summary>
        /// Developer message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatDeveloperMessage? ChatDeveloperMessage { get; init; }
#else
        public global::G.ChatDeveloperMessage? ChatDeveloperMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatDeveloperMessage))]
#endif
        public bool IsChatDeveloperMessage => ChatDeveloperMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatDeveloperMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatDeveloperMessage? value)
        {
            value = ChatDeveloperMessage;
            return IsChatDeveloperMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatDeveloperMessage PickChatDeveloperMessage() => ChatDeveloperMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatDeveloperMessage' but the value was {ToString()}.");

        /// <summary>
        /// Assistant message for requests and responses
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatAssistantMessage? ChatAssistantMessage { get; init; }
#else
        public global::G.ChatAssistantMessage? ChatAssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAssistantMessage))]
#endif
        public bool IsChatAssistantMessage => ChatAssistantMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatAssistantMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatAssistantMessage? value)
        {
            value = ChatAssistantMessage;
            return IsChatAssistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatAssistantMessage PickChatAssistantMessage() => ChatAssistantMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatAssistantMessage' but the value was {ToString()}.");

        /// <summary>
        /// Tool response message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolMessage? ChatToolMessage { get; init; }
#else
        public global::G.ChatToolMessage? ChatToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolMessage))]
#endif
        public bool IsChatToolMessage => ChatToolMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatToolMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatToolMessage? value)
        {
            value = ChatToolMessage;
            return IsChatToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatToolMessage PickChatToolMessage() => ChatToolMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::G.ChatSystemMessage value) => new ChatMessages((global::G.ChatSystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSystemMessage?(ChatMessages @this) => @this.ChatSystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::G.ChatSystemMessage? value)
        {
            ChatSystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessages FromChatSystemMessage(global::G.ChatSystemMessage? value) => new ChatMessages(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::G.ChatUserMessage value) => new ChatMessages((global::G.ChatUserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatUserMessage?(ChatMessages @this) => @this.ChatUserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::G.ChatUserMessage? value)
        {
            ChatUserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessages FromChatUserMessage(global::G.ChatUserMessage? value) => new ChatMessages(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::G.ChatDeveloperMessage value) => new ChatMessages((global::G.ChatDeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatDeveloperMessage?(ChatMessages @this) => @this.ChatDeveloperMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::G.ChatDeveloperMessage? value)
        {
            ChatDeveloperMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessages FromChatDeveloperMessage(global::G.ChatDeveloperMessage? value) => new ChatMessages(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::G.ChatAssistantMessage value) => new ChatMessages((global::G.ChatAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatAssistantMessage?(ChatMessages @this) => @this.ChatAssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::G.ChatAssistantMessage? value)
        {
            ChatAssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessages FromChatAssistantMessage(global::G.ChatAssistantMessage? value) => new ChatMessages(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::G.ChatToolMessage value) => new ChatMessages((global::G.ChatToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolMessage?(ChatMessages @this) => @this.ChatToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::G.ChatToolMessage? value)
        {
            ChatToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessages FromChatToolMessage(global::G.ChatToolMessage? value) => new ChatMessages(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(
            global::G.ChatSystemMessage? chatSystemMessage,
            global::G.ChatUserMessage? chatUserMessage,
            global::G.ChatDeveloperMessage? chatDeveloperMessage,
            global::G.ChatAssistantMessage? chatAssistantMessage,
            global::G.ChatToolMessage? chatToolMessage
            )
        {
            ChatSystemMessage = chatSystemMessage;
            ChatUserMessage = chatUserMessage;
            ChatDeveloperMessage = chatDeveloperMessage;
            ChatAssistantMessage = chatAssistantMessage;
            ChatToolMessage = chatToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatToolMessage as object ??
            ChatAssistantMessage as object ??
            ChatDeveloperMessage as object ??
            ChatUserMessage as object ??
            ChatSystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatSystemMessage?.ToString() ??
            ChatUserMessage?.ToString() ??
            ChatDeveloperMessage?.ToString() ??
            ChatAssistantMessage?.ToString() ??
            ChatToolMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatSystemMessage && !IsChatUserMessage && !IsChatDeveloperMessage && !IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && IsChatUserMessage && !IsChatDeveloperMessage && !IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && !IsChatUserMessage && IsChatDeveloperMessage && !IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && !IsChatUserMessage && !IsChatDeveloperMessage && IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && !IsChatUserMessage && !IsChatDeveloperMessage && !IsChatAssistantMessage && IsChatToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatSystemMessage, TResult>? chatSystemMessage = null,
            global::System.Func<global::G.ChatUserMessage, TResult>? chatUserMessage = null,
            global::System.Func<global::G.ChatDeveloperMessage, TResult>? chatDeveloperMessage = null,
            global::System.Func<global::G.ChatAssistantMessage, TResult>? chatAssistantMessage = null,
            global::System.Func<global::G.ChatToolMessage, TResult>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatSystemMessage is { } __value0 && chatSystemMessage != null)
            {
                return chatSystemMessage(__value0);
            }
            else if (ChatUserMessage is { } __value1 && chatUserMessage != null)
            {
                return chatUserMessage(__value1);
            }
            else if (ChatDeveloperMessage is { } __value2 && chatDeveloperMessage != null)
            {
                return chatDeveloperMessage(__value2);
            }
            else if (ChatAssistantMessage is { } __value3 && chatAssistantMessage != null)
            {
                return chatAssistantMessage(__value3);
            }
            else if (ChatToolMessage is { } __value4 && chatToolMessage != null)
            {
                return chatToolMessage(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatSystemMessage>? chatSystemMessage = null,

            global::System.Action<global::G.ChatUserMessage>? chatUserMessage = null,

            global::System.Action<global::G.ChatDeveloperMessage>? chatDeveloperMessage = null,

            global::System.Action<global::G.ChatAssistantMessage>? chatAssistantMessage = null,

            global::System.Action<global::G.ChatToolMessage>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatSystemMessage is { } __value0)
            {
                chatSystemMessage?.Invoke(__value0);
            }
            else if (ChatUserMessage is { } __value1)
            {
                chatUserMessage?.Invoke(__value1);
            }
            else if (ChatDeveloperMessage is { } __value2)
            {
                chatDeveloperMessage?.Invoke(__value2);
            }
            else if (ChatAssistantMessage is { } __value3)
            {
                chatAssistantMessage?.Invoke(__value3);
            }
            else if (ChatToolMessage is { } __value4)
            {
                chatToolMessage?.Invoke(__value4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ChatSystemMessage>? chatSystemMessage = null,
            global::System.Action<global::G.ChatUserMessage>? chatUserMessage = null,
            global::System.Action<global::G.ChatDeveloperMessage>? chatDeveloperMessage = null,
            global::System.Action<global::G.ChatAssistantMessage>? chatAssistantMessage = null,
            global::System.Action<global::G.ChatToolMessage>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatSystemMessage is { } __value0)
            {
                chatSystemMessage?.Invoke(__value0);
            }
            else if (ChatUserMessage is { } __value1)
            {
                chatUserMessage?.Invoke(__value1);
            }
            else if (ChatDeveloperMessage is { } __value2)
            {
                chatDeveloperMessage?.Invoke(__value2);
            }
            else if (ChatAssistantMessage is { } __value3)
            {
                chatAssistantMessage?.Invoke(__value3);
            }
            else if (ChatToolMessage is { } __value4)
            {
                chatToolMessage?.Invoke(__value4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatSystemMessage,
                typeof(global::G.ChatSystemMessage),
                ChatUserMessage,
                typeof(global::G.ChatUserMessage),
                ChatDeveloperMessage,
                typeof(global::G.ChatDeveloperMessage),
                ChatAssistantMessage,
                typeof(global::G.ChatAssistantMessage),
                ChatToolMessage,
                typeof(global::G.ChatToolMessage),
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
        public bool Equals(ChatMessages other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSystemMessage?>.Default.Equals(ChatSystemMessage, other.ChatSystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatUserMessage?>.Default.Equals(ChatUserMessage, other.ChatUserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatDeveloperMessage?>.Default.Equals(ChatDeveloperMessage, other.ChatDeveloperMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatAssistantMessage?>.Default.Equals(ChatAssistantMessage, other.ChatAssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolMessage?>.Default.Equals(ChatToolMessage, other.ChatToolMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessages obj1, ChatMessages obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessages>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessages obj1, ChatMessages obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessages o && Equals(o);
        }
    }
}
