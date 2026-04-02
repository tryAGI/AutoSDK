//HintName: G.Models.ChatToolCallStartEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event delta which signifies a tool call has started streaming.
    /// </summary>
    public readonly partial struct ChatToolCallStartEvent : global::System.IEquatable<ChatToolCallStartEvent>
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
        public global::G.ChatToolCallStartEventLv559x? Lv559x { get; init; }
#else
        public global::G.ChatToolCallStartEventLv559x? Lv559x { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lv559x))]
#endif
        public bool IsLv559x => Lv559x != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallStartEvent(global::G.ChatStreamEventType value) => new ChatToolCallStartEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatToolCallStartEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallStartEvent(global::G.ChatToolCallStartEventLv559x value) => new ChatToolCallStartEvent((global::G.ChatToolCallStartEventLv559x?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallStartEventLv559x?(ChatToolCallStartEvent @this) => @this.Lv559x;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(global::G.ChatToolCallStartEventLv559x? value)
        {
            Lv559x = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatToolCallStartEventLv559x? lv559x
            )
        {
            StreamType = streamType;
            Lv559x = lv559x;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lv559x as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Lv559x?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsLv559x;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatToolCallStartEventLv559x?, TResult>? lv559x = null,
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
            else if (IsLv559x && lv559x != null)
            {
                return lv559x(Lv559x!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatToolCallStartEventLv559x?>? lv559x = null,
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
            else if (IsLv559x)
            {
                lv559x?.Invoke(Lv559x!);
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
                Lv559x,
                typeof(global::G.ChatToolCallStartEventLv559x),
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
        public bool Equals(ChatToolCallStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallStartEventLv559x?>.Default.Equals(Lv559x, other.Lv559x) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallStartEvent obj1, ChatToolCallStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallStartEvent obj1, ChatToolCallStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallStartEvent o && Equals(o);
        }
    }
}
