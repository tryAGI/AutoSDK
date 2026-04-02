//HintName: G.Models.ChatToolPlanDeltaEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event which contains a delta of tool plan text.
    /// </summary>
    public readonly partial struct ChatToolPlanDeltaEvent : global::System.IEquatable<ChatToolPlanDeltaEvent>
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
        public global::G.ChatToolPlanDeltaEvent2obfex? Event2obfex { get; init; }
#else
        public global::G.ChatToolPlanDeltaEvent2obfex? Event2obfex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event2obfex))]
#endif
        public bool IsEvent2obfex => Event2obfex != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolPlanDeltaEvent(global::G.ChatStreamEventType value) => new ChatToolPlanDeltaEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatToolPlanDeltaEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolPlanDeltaEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolPlanDeltaEvent(global::G.ChatToolPlanDeltaEvent2obfex value) => new ChatToolPlanDeltaEvent((global::G.ChatToolPlanDeltaEvent2obfex?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolPlanDeltaEvent2obfex?(ChatToolPlanDeltaEvent @this) => @this.Event2obfex;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolPlanDeltaEvent(global::G.ChatToolPlanDeltaEvent2obfex? value)
        {
            Event2obfex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolPlanDeltaEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatToolPlanDeltaEvent2obfex? event2obfex
            )
        {
            StreamType = streamType;
            Event2obfex = event2obfex;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event2obfex as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Event2obfex?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsEvent2obfex;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatToolPlanDeltaEvent2obfex?, TResult>? event2obfex = null,
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
            else if (IsEvent2obfex && event2obfex != null)
            {
                return event2obfex(Event2obfex!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatToolPlanDeltaEvent2obfex?>? event2obfex = null,
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
            else if (IsEvent2obfex)
            {
                event2obfex?.Invoke(Event2obfex!);
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
                Event2obfex,
                typeof(global::G.ChatToolPlanDeltaEvent2obfex),
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
        public bool Equals(ChatToolPlanDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolPlanDeltaEvent2obfex?>.Default.Equals(Event2obfex, other.Event2obfex) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolPlanDeltaEvent obj1, ChatToolPlanDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolPlanDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolPlanDeltaEvent obj1, ChatToolPlanDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolPlanDeltaEvent o && Equals(o);
        }
    }
}
