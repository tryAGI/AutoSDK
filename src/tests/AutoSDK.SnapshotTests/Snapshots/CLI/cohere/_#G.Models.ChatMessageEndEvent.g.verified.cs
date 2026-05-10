//HintName: G.Models.ChatMessageEndEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event which signifies that the chat message has ended.
    /// </summary>
    public readonly partial struct ChatMessageEndEvent : global::System.IEquatable<ChatMessageEndEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEventType? StreamType { get; init; }
#else
        public global::G.ChatStreamEventType? StreamType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamType))]
#endif
        public bool IsStreamType => StreamType != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamType(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatStreamEventType? value)
        {
            value = StreamType;
            return IsStreamType;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessageEndEventU3fzny? U3fzny { get; init; }
#else
        public global::G.ChatMessageEndEventU3fzny? U3fzny { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(U3fzny))]
#endif
        public bool IsU3fzny => U3fzny != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickU3fzny(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ChatMessageEndEventU3fzny? value)
        {
            value = U3fzny;
            return IsU3fzny;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageEndEvent(global::G.ChatStreamEventType value) => new ChatMessageEndEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatMessageEndEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageEndEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessageEndEvent FromStreamType(global::G.ChatStreamEventType? value) => new ChatMessageEndEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageEndEvent(global::G.ChatMessageEndEventU3fzny value) => new ChatMessageEndEvent((global::G.ChatMessageEndEventU3fzny?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageEndEventU3fzny?(ChatMessageEndEvent @this) => @this.U3fzny;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageEndEvent(global::G.ChatMessageEndEventU3fzny? value)
        {
            U3fzny = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessageEndEvent FromU3fzny(global::G.ChatMessageEndEventU3fzny? value) => new ChatMessageEndEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageEndEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatMessageEndEventU3fzny? u3fzny
            )
        {
            StreamType = streamType;
            U3fzny = u3fzny;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            U3fzny as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            U3fzny?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsU3fzny;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType, TResult>? streamType = null,
            global::System.Func<global::G.ChatMessageEndEventU3fzny, TResult>? u3fzny = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamType && streamType != null)
            {
                return streamType(StreamType!);
            }
            else if (IsU3fzny && u3fzny != null)
            {
                return u3fzny(U3fzny!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType>? streamType = null,

            global::System.Action<global::G.ChatMessageEndEventU3fzny>? u3fzny = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamType)
            {
                streamType?.Invoke(StreamType!);
            }
            else if (IsU3fzny)
            {
                u3fzny?.Invoke(U3fzny!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ChatStreamEventType>? streamType = null,
            global::System.Action<global::G.ChatMessageEndEventU3fzny>? u3fzny = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamType)
            {
                streamType?.Invoke(StreamType!);
            }
            else if (IsU3fzny)
            {
                u3fzny?.Invoke(U3fzny!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamType,
                typeof(global::G.ChatStreamEventType),
                U3fzny,
                typeof(global::G.ChatMessageEndEventU3fzny),
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
        public bool Equals(ChatMessageEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessageEndEventU3fzny?>.Default.Equals(U3fzny, other.U3fzny) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageEndEvent obj1, ChatMessageEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageEndEvent obj1, ChatMessageEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageEndEvent o && Equals(o);
        }
    }
}
