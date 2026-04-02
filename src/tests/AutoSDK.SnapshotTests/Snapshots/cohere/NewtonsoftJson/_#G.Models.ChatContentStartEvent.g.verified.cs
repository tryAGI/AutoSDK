//HintName: G.Models.ChatContentStartEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed delta event which signifies that a new content block has started.
    /// </summary>
    public readonly partial struct ChatContentStartEvent : global::System.IEquatable<ChatContentStartEvent>
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
        public global::G.ChatContentStartEvent6xvlq1? Event6xvlq1 { get; init; }
#else
        public global::G.ChatContentStartEvent6xvlq1? Event6xvlq1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event6xvlq1))]
#endif
        public bool IsEvent6xvlq1 => Event6xvlq1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentStartEvent(global::G.ChatStreamEventType value) => new ChatContentStartEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatContentStartEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentStartEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentStartEvent(global::G.ChatContentStartEvent6xvlq1 value) => new ChatContentStartEvent((global::G.ChatContentStartEvent6xvlq1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentStartEvent6xvlq1?(ChatContentStartEvent @this) => @this.Event6xvlq1;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentStartEvent(global::G.ChatContentStartEvent6xvlq1? value)
        {
            Event6xvlq1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentStartEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatContentStartEvent6xvlq1? event6xvlq1
            )
        {
            StreamType = streamType;
            Event6xvlq1 = event6xvlq1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event6xvlq1 as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Event6xvlq1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsEvent6xvlq1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatContentStartEvent6xvlq1?, TResult>? event6xvlq1 = null,
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
            else if (IsEvent6xvlq1 && event6xvlq1 != null)
            {
                return event6xvlq1(Event6xvlq1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatContentStartEvent6xvlq1?>? event6xvlq1 = null,
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
            else if (IsEvent6xvlq1)
            {
                event6xvlq1?.Invoke(Event6xvlq1!);
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
                Event6xvlq1,
                typeof(global::G.ChatContentStartEvent6xvlq1),
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
        public bool Equals(ChatContentStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentStartEvent6xvlq1?>.Default.Equals(Event6xvlq1, other.Event6xvlq1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentStartEvent obj1, ChatContentStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentStartEvent obj1, ChatContentStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentStartEvent o && Equals(o);
        }
    }
}
