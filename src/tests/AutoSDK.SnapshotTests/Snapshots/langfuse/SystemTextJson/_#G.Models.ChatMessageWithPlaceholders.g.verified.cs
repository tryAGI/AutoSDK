//HintName: G.Models.ChatMessageWithPlaceholders.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatMessageWithPlaceholders : global::System.IEquatable<ChatMessageWithPlaceholders>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessage? ChatMessage { get; init; }
#else
        public global::G.ChatMessage? ChatMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessage))]
#endif
        public bool IsChatMessage => ChatMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PlaceholderMessage? PlaceholderMessage { get; init; }
#else
        public global::G.PlaceholderMessage? PlaceholderMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlaceholderMessage))]
#endif
        public bool IsPlaceholderMessage => PlaceholderMessage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageWithPlaceholders(global::G.ChatMessage value) => new ChatMessageWithPlaceholders((global::G.ChatMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessage?(ChatMessageWithPlaceholders @this) => @this.ChatMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageWithPlaceholders(global::G.ChatMessage? value)
        {
            ChatMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageWithPlaceholders(global::G.PlaceholderMessage value) => new ChatMessageWithPlaceholders((global::G.PlaceholderMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PlaceholderMessage?(ChatMessageWithPlaceholders @this) => @this.PlaceholderMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageWithPlaceholders(global::G.PlaceholderMessage? value)
        {
            PlaceholderMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageWithPlaceholders(
            global::G.ChatMessage? chatMessage,
            global::G.PlaceholderMessage? placeholderMessage
            )
        {
            ChatMessage = chatMessage;
            PlaceholderMessage = placeholderMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PlaceholderMessage as object ??
            ChatMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatMessage?.ToString() ??
            PlaceholderMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatMessage && !IsPlaceholderMessage || !IsChatMessage && IsPlaceholderMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatMessage?, TResult>? chatMessage = null,
            global::System.Func<global::G.PlaceholderMessage?, TResult>? placeholderMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessage && chatMessage != null)
            {
                return chatMessage(ChatMessage!);
            }
            else if (IsPlaceholderMessage && placeholderMessage != null)
            {
                return placeholderMessage(PlaceholderMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatMessage?>? chatMessage = null,
            global::System.Action<global::G.PlaceholderMessage?>? placeholderMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessage)
            {
                chatMessage?.Invoke(ChatMessage!);
            }
            else if (IsPlaceholderMessage)
            {
                placeholderMessage?.Invoke(PlaceholderMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatMessage,
                typeof(global::G.ChatMessage),
                PlaceholderMessage,
                typeof(global::G.PlaceholderMessage),
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
        public bool Equals(ChatMessageWithPlaceholders other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessage?>.Default.Equals(ChatMessage, other.ChatMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PlaceholderMessage?>.Default.Equals(PlaceholderMessage, other.PlaceholderMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageWithPlaceholders obj1, ChatMessageWithPlaceholders obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageWithPlaceholders>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageWithPlaceholders obj1, ChatMessageWithPlaceholders obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageWithPlaceholders o && Equals(o);
        }
    }
}
