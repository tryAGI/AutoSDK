//HintName: G.Models.MessageStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A event in a streaming conversation.
    /// </summary>
    public readonly struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStartEvent? Start { get; init; }
#else
        public global::G.MessageStartEvent? Start { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Start))]
#endif
        public bool IsStart => Start != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStartEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStartEvent?(MessageStreamEvent @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStartEvent? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaEvent? Delta { get; init; }
#else
        public global::G.MessageDeltaEvent? Delta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Delta))]
#endif
        public bool IsDelta => Delta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageDeltaEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaEvent?(MessageStreamEvent @this) => @this.Delta;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageDeltaEvent? value)
        {
            Delta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStopEvent? Stop { get; init; }
#else
        public global::G.MessageStopEvent? Stop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stop))]
#endif
        public bool IsStop => Stop != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStopEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStopEvent?(MessageStreamEvent @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStopEvent? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentBlockStartEvent? ContentBlockStart { get; init; }
#else
        public global::G.ContentBlockStartEvent? ContentBlockStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStart))]
#endif
        public bool IsContentBlockStart => ContentBlockStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.ContentBlockStartEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockStartEvent?(MessageStreamEvent @this) => @this.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.ContentBlockStartEvent? value)
        {
            ContentBlockStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentBlockDeltaEvent? ContentBlockDelta { get; init; }
#else
        public global::G.ContentBlockDeltaEvent? ContentBlockDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockDelta))]
#endif
        public bool IsContentBlockDelta => ContentBlockDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.ContentBlockDeltaEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockDeltaEvent?(MessageStreamEvent @this) => @this.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.ContentBlockDeltaEvent? value)
        {
            ContentBlockDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentBlockStopEvent? ContentBlockStop { get; init; }
#else
        public global::G.ContentBlockStopEvent? ContentBlockStop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStop))]
#endif
        public bool IsContentBlockStop => ContentBlockStop != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.ContentBlockStopEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockStopEvent?(MessageStreamEvent @this) => @this.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.ContentBlockStopEvent? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PingEvent? Ping { get; init; }
#else
        public global::G.PingEvent? Ping { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ping))]
#endif
        public bool IsPing => Ping != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.PingEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PingEvent?(MessageStreamEvent @this) => @this.Ping;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.PingEvent? value)
        {
            Ping = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::G.MessageStartEvent? start,
            global::G.MessageDeltaEvent? delta,
            global::G.MessageStopEvent? stop,
            global::G.ContentBlockStartEvent? contentBlockStart,
            global::G.ContentBlockDeltaEvent? contentBlockDelta,
            global::G.ContentBlockStopEvent? contentBlockStop,
            global::G.PingEvent? ping
            )
        {
            Start = start;
            Delta = delta;
            Stop = stop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
            Ping = ping;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ping as object ??
            ContentBlockStop as object ??
            ContentBlockDelta as object ??
            ContentBlockStart as object ??
            Stop as object ??
            Delta as object ??
            Start as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsPing;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Start,
                typeof(global::G.MessageStartEvent),
                Delta,
                typeof(global::G.MessageDeltaEvent),
                Stop,
                typeof(global::G.MessageStopEvent),
                ContentBlockStart,
                typeof(global::G.ContentBlockStartEvent),
                ContentBlockDelta,
                typeof(global::G.ContentBlockDeltaEvent),
                ContentBlockStop,
                typeof(global::G.ContentBlockStopEvent),
                Ping,
                typeof(global::G.PingEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStartEvent?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaEvent?>.Default.Equals(Delta, other.Delta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStopEvent?>.Default.Equals(Stop, other.Stop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PingEvent?>.Default.Equals(Ping, other.Ping) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageStreamEvent o && Equals(o);
        }
    }
}
