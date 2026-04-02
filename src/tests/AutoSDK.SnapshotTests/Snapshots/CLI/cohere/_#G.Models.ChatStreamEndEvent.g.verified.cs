//HintName: G.Models.ChatStreamEndEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatStreamEndEvent : global::System.IEquatable<ChatStreamEndEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEvent? ChatStreamEvent { get; init; }
#else
        public global::G.ChatStreamEvent? ChatStreamEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatStreamEvent))]
#endif
        public bool IsChatStreamEvent => ChatStreamEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEndEventY8gq2x? Y8gq2x { get; init; }
#else
        public global::G.ChatStreamEndEventY8gq2x? Y8gq2x { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Y8gq2x))]
#endif
        public bool IsY8gq2x => Y8gq2x != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamEndEvent(global::G.ChatStreamEvent value) => new ChatStreamEndEvent((global::G.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatStreamEndEvent @this) => @this.ChatStreamEvent;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamEndEvent(global::G.ChatStreamEvent? value)
        {
            ChatStreamEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamEndEvent(global::G.ChatStreamEndEventY8gq2x value) => new ChatStreamEndEvent((global::G.ChatStreamEndEventY8gq2x?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEndEventY8gq2x?(ChatStreamEndEvent @this) => @this.Y8gq2x;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamEndEvent(global::G.ChatStreamEndEventY8gq2x? value)
        {
            Y8gq2x = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamEndEvent(
            global::G.ChatStreamEvent? chatStreamEvent,
            global::G.ChatStreamEndEventY8gq2x? y8gq2x
            )
        {
            ChatStreamEvent = chatStreamEvent;
            Y8gq2x = y8gq2x;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Y8gq2x as object ??
            ChatStreamEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatStreamEvent?.ToString() ??
            Y8gq2x?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatStreamEvent && IsY8gq2x;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? chatStreamEvent = null,
            global::System.Func<global::G.ChatStreamEndEventY8gq2x?, TResult>? y8gq2x = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamEvent && chatStreamEvent != null)
            {
                return chatStreamEvent(ChatStreamEvent!);
            }
            else if (IsY8gq2x && y8gq2x != null)
            {
                return y8gq2x(Y8gq2x!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEvent?>? chatStreamEvent = null,
            global::System.Action<global::G.ChatStreamEndEventY8gq2x?>? y8gq2x = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamEvent)
            {
                chatStreamEvent?.Invoke(ChatStreamEvent!);
            }
            else if (IsY8gq2x)
            {
                y8gq2x?.Invoke(Y8gq2x!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatStreamEvent,
                typeof(global::G.ChatStreamEvent),
                Y8gq2x,
                typeof(global::G.ChatStreamEndEventY8gq2x),
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
        public bool Equals(ChatStreamEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(ChatStreamEvent, other.ChatStreamEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEndEventY8gq2x?>.Default.Equals(Y8gq2x, other.Y8gq2x) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatStreamEndEvent obj1, ChatStreamEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatStreamEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatStreamEndEvent obj1, ChatStreamEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatStreamEndEvent o && Equals(o);
        }
    }
}
