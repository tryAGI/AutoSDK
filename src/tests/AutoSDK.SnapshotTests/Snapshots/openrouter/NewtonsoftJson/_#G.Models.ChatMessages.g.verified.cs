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
            global::System.Func<global::G.ChatSystemMessage?, TResult>? chatSystemMessage = null,
            global::System.Func<global::G.ChatUserMessage?, TResult>? chatUserMessage = null,
            global::System.Func<global::G.ChatDeveloperMessage?, TResult>? chatDeveloperMessage = null,
            global::System.Func<global::G.ChatAssistantMessage?, TResult>? chatAssistantMessage = null,
            global::System.Func<global::G.ChatToolMessage?, TResult>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatSystemMessage && chatSystemMessage != null)
            {
                return chatSystemMessage(ChatSystemMessage!);
            }
            else if (IsChatUserMessage && chatUserMessage != null)
            {
                return chatUserMessage(ChatUserMessage!);
            }
            else if (IsChatDeveloperMessage && chatDeveloperMessage != null)
            {
                return chatDeveloperMessage(ChatDeveloperMessage!);
            }
            else if (IsChatAssistantMessage && chatAssistantMessage != null)
            {
                return chatAssistantMessage(ChatAssistantMessage!);
            }
            else if (IsChatToolMessage && chatToolMessage != null)
            {
                return chatToolMessage(ChatToolMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatSystemMessage?>? chatSystemMessage = null,
            global::System.Action<global::G.ChatUserMessage?>? chatUserMessage = null,
            global::System.Action<global::G.ChatDeveloperMessage?>? chatDeveloperMessage = null,
            global::System.Action<global::G.ChatAssistantMessage?>? chatAssistantMessage = null,
            global::System.Action<global::G.ChatToolMessage?>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatSystemMessage)
            {
                chatSystemMessage?.Invoke(ChatSystemMessage!);
            }
            else if (IsChatUserMessage)
            {
                chatUserMessage?.Invoke(ChatUserMessage!);
            }
            else if (IsChatDeveloperMessage)
            {
                chatDeveloperMessage?.Invoke(ChatDeveloperMessage!);
            }
            else if (IsChatAssistantMessage)
            {
                chatAssistantMessage?.Invoke(ChatAssistantMessage!);
            }
            else if (IsChatToolMessage)
            {
                chatToolMessage?.Invoke(ChatToolMessage!);
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
