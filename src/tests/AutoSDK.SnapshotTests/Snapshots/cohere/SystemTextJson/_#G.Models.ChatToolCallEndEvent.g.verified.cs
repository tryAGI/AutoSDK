//HintName: G.Models.ChatToolCallEndEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event delta which signifies a tool call has finished streaming.
    /// </summary>
    public readonly partial struct ChatToolCallEndEvent : global::System.IEquatable<ChatToolCallEndEvent>
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
        public global::G.ChatToolCallEndEventT6ph9s? T6ph9s { get; init; }
#else
        public global::G.ChatToolCallEndEventT6ph9s? T6ph9s { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(T6ph9s))]
#endif
        public bool IsT6ph9s => T6ph9s != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallEndEvent(global::G.ChatStreamEventType value) => new ChatToolCallEndEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatToolCallEndEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallEndEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallEndEvent(global::G.ChatToolCallEndEventT6ph9s value) => new ChatToolCallEndEvent((global::G.ChatToolCallEndEventT6ph9s?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallEndEventT6ph9s?(ChatToolCallEndEvent @this) => @this.T6ph9s;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallEndEvent(global::G.ChatToolCallEndEventT6ph9s? value)
        {
            T6ph9s = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallEndEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatToolCallEndEventT6ph9s? t6ph9s
            )
        {
            StreamType = streamType;
            T6ph9s = t6ph9s;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            T6ph9s as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            T6ph9s?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsT6ph9s;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatToolCallEndEventT6ph9s?, TResult>? t6ph9s = null,
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
            else if (IsT6ph9s && t6ph9s != null)
            {
                return t6ph9s(T6ph9s!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatToolCallEndEventT6ph9s?>? t6ph9s = null,
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
            else if (IsT6ph9s)
            {
                t6ph9s?.Invoke(T6ph9s!);
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
                T6ph9s,
                typeof(global::G.ChatToolCallEndEventT6ph9s),
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
        public bool Equals(ChatToolCallEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallEndEventT6ph9s?>.Default.Equals(T6ph9s, other.T6ph9s) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallEndEvent obj1, ChatToolCallEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallEndEvent obj1, ChatToolCallEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallEndEvent o && Equals(o);
        }
    }
}
