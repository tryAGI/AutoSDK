//HintName: G.Models.ChatContentDeltaEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed delta event which contains a delta of chat text content.
    /// </summary>
    public readonly partial struct ChatContentDeltaEvent : global::System.IEquatable<ChatContentDeltaEvent>
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
        public global::G.ChatContentDeltaEvent3m0vqs? Event3m0vqs { get; init; }
#else
        public global::G.ChatContentDeltaEvent3m0vqs? Event3m0vqs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event3m0vqs))]
#endif
        public bool IsEvent3m0vqs => Event3m0vqs != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentDeltaEvent(global::G.ChatStreamEventType value) => new ChatContentDeltaEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatContentDeltaEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentDeltaEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentDeltaEvent(global::G.ChatContentDeltaEvent3m0vqs value) => new ChatContentDeltaEvent((global::G.ChatContentDeltaEvent3m0vqs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatContentDeltaEvent3m0vqs?(ChatContentDeltaEvent @this) => @this.Event3m0vqs;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentDeltaEvent(global::G.ChatContentDeltaEvent3m0vqs? value)
        {
            Event3m0vqs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentDeltaEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatContentDeltaEvent3m0vqs? event3m0vqs
            )
        {
            StreamType = streamType;
            Event3m0vqs = event3m0vqs;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event3m0vqs as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Event3m0vqs?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsEvent3m0vqs;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatContentDeltaEvent3m0vqs?, TResult>? event3m0vqs = null,
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
            else if (IsEvent3m0vqs && event3m0vqs != null)
            {
                return event3m0vqs(Event3m0vqs!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatContentDeltaEvent3m0vqs?>? event3m0vqs = null,
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
            else if (IsEvent3m0vqs)
            {
                event3m0vqs?.Invoke(Event3m0vqs!);
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
                Event3m0vqs,
                typeof(global::G.ChatContentDeltaEvent3m0vqs),
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
        public bool Equals(ChatContentDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatContentDeltaEvent3m0vqs?>.Default.Equals(Event3m0vqs, other.Event3m0vqs) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentDeltaEvent obj1, ChatContentDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentDeltaEvent obj1, ChatContentDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentDeltaEvent o && Equals(o);
        }
    }
}
