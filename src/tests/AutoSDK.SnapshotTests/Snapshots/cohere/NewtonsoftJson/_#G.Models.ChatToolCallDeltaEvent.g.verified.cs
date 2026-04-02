//HintName: G.Models.ChatToolCallDeltaEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event delta which signifies a delta in tool call arguments.
    /// </summary>
    public readonly partial struct ChatToolCallDeltaEvent : global::System.IEquatable<ChatToolCallDeltaEvent>
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
        public global::G.ChatToolCallDeltaEvent2bxzoc? Event2bxzoc { get; init; }
#else
        public global::G.ChatToolCallDeltaEvent2bxzoc? Event2bxzoc { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event2bxzoc))]
#endif
        public bool IsEvent2bxzoc => Event2bxzoc != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallDeltaEvent(global::G.ChatStreamEventType value) => new ChatToolCallDeltaEvent((global::G.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatToolCallDeltaEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallDeltaEvent(global::G.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallDeltaEvent(global::G.ChatToolCallDeltaEvent2bxzoc value) => new ChatToolCallDeltaEvent((global::G.ChatToolCallDeltaEvent2bxzoc?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallDeltaEvent2bxzoc?(ChatToolCallDeltaEvent @this) => @this.Event2bxzoc;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallDeltaEvent(global::G.ChatToolCallDeltaEvent2bxzoc? value)
        {
            Event2bxzoc = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallDeltaEvent(
            global::G.ChatStreamEventType? streamType,
            global::G.ChatToolCallDeltaEvent2bxzoc? event2bxzoc
            )
        {
            StreamType = streamType;
            Event2bxzoc = event2bxzoc;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event2bxzoc as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Event2bxzoc?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsEvent2bxzoc;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEventType?, TResult>? streamType = null,
            global::System.Func<global::G.ChatToolCallDeltaEvent2bxzoc?, TResult>? event2bxzoc = null,
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
            else if (IsEvent2bxzoc && event2bxzoc != null)
            {
                return event2bxzoc(Event2bxzoc!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatStreamEventType?>? streamType = null,
            global::System.Action<global::G.ChatToolCallDeltaEvent2bxzoc?>? event2bxzoc = null,
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
            else if (IsEvent2bxzoc)
            {
                event2bxzoc?.Invoke(Event2bxzoc!);
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
                Event2bxzoc,
                typeof(global::G.ChatToolCallDeltaEvent2bxzoc),
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
        public bool Equals(ChatToolCallDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallDeltaEvent2bxzoc?>.Default.Equals(Event2bxzoc, other.Event2bxzoc) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallDeltaEvent obj1, ChatToolCallDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallDeltaEvent obj1, ChatToolCallDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallDeltaEvent o && Equals(o);
        }
    }
}
