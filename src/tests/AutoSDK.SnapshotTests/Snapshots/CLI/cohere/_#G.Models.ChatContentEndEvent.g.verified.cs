//HintName: G.Models.ChatContentEndEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed delta event which signifies that the content block has ended.
    /// </summary>
    public readonly partial struct ChatContentEndEvent : global::System.IEquatable<ChatContentEndEvent>
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
#if NET6_0_OR_GREATER
        public global::G.ChatContentEndEventMa278i? Ma278i { get; init; }
#else
        public global::G.ChatContentEndEventMa278i? Ma278i { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ma278i))]
#endif
        public bool IsMa278i => Ma278i != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentEndEvent(global::G.ChatStreamEventType value) => new ChatContentEndEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatContentEndEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentEndEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentEndEvent(global::G.ChatContentEndEventMa278i value) => new ChatContentEndEvent((global::G.ChatContentEndEventMa278i?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentEndEventMa278i?(ChatContentEndEvent @this) => @this.Ma278i;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentEndEvent(global::G.ChatContentEndEventMa278i? value)
        {
            Ma278i = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentEndEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatContentEndEventMa278i? ma278i
            )
        {
            StreamType = streamType;
            Ma278i = ma278i;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ma278i as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Ma278i?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsMa278i;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatContentEndEventMa278i?, TResult>? ma278i = null,
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
            else if (IsMa278i && ma278i != null)
            {
                return ma278i(Ma278i!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatContentEndEventMa278i?>? ma278i = null,
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
            else if (IsMa278i)
            {
                ma278i?.Invoke(Ma278i!);
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
                Ma278i,
                typeof(global::G.ChatContentEndEventMa278i),
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
        public bool Equals(ChatContentEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentEndEventMa278i?>.Default.Equals(Ma278i, other.Ma278i) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentEndEvent obj1, ChatContentEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentEndEvent obj1, ChatContentEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentEndEvent o && Equals(o);
        }
    }
}
