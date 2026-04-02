//HintName: G.Models.ChatMessageStartEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event which signifies that a stream has started.
    /// </summary>
    public readonly partial struct ChatMessageStartEvent : global::System.IEquatable<ChatMessageStartEvent>
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
        public global::G.ChatMessageStartEventLsegeq? Lsegeq { get; init; }
#else
        public global::G.ChatMessageStartEventLsegeq? Lsegeq { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lsegeq))]
#endif
        public bool IsLsegeq => Lsegeq != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageStartEvent(global::G.ChatStreamEventType value) => new ChatMessageStartEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatMessageStartEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageStartEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageStartEvent(global::G.ChatMessageStartEventLsegeq value) => new ChatMessageStartEvent((global::G.ChatMessageStartEventLsegeq?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessageStartEventLsegeq?(ChatMessageStartEvent @this) => @this.Lsegeq;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageStartEvent(global::G.ChatMessageStartEventLsegeq? value)
        {
            Lsegeq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageStartEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatMessageStartEventLsegeq? lsegeq
            )
        {
            StreamType = streamType;
            Lsegeq = lsegeq;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lsegeq as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Lsegeq?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsLsegeq;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatMessageStartEventLsegeq?, TResult>? lsegeq = null,
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
            else if (IsLsegeq && lsegeq != null)
            {
                return lsegeq(Lsegeq!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatMessageStartEventLsegeq?>? lsegeq = null,
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
            else if (IsLsegeq)
            {
                lsegeq?.Invoke(Lsegeq!);
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
                Lsegeq,
                typeof(global::G.ChatMessageStartEventLsegeq),
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
        public bool Equals(ChatMessageStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessageStartEventLsegeq?>.Default.Equals(Lsegeq, other.Lsegeq) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageStartEvent obj1, ChatMessageStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageStartEvent obj1, ChatMessageStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageStartEvent o && Equals(o);
        }
    }
}
