//HintName: G.Models.MessageStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStartEvent? MessageStart { get; init; }
#else
        public global::G.MessageStartEvent? MessageStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStart))]
#endif
        public bool IsMessageStart => MessageStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStartEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStartEvent?(MessageStreamEvent @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaEvent? MessageDelta { get; init; }
#else
        public global::G.MessageDeltaEvent? MessageDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDelta))]
#endif
        public bool IsMessageDelta => MessageDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageDeltaEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaEvent?(MessageStreamEvent @this) => @this.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageDeltaEvent? value)
        {
            MessageDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStopEvent? MessageStop { get; init; }
#else
        public global::G.MessageStopEvent? MessageStop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStop))]
#endif
        public bool IsMessageStop => MessageStop != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStopEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStopEvent?(MessageStreamEvent @this) => @this.MessageStop;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStopEvent? value)
        {
            MessageStop = value;
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
        public MessageStreamEvent(
            global::G.MessageStreamEventDiscriminatorType? type,
            global::G.MessageStartEvent? messageStart,
            global::G.MessageDeltaEvent? messageDelta,
            global::G.MessageStopEvent? messageStop,
            global::G.ContentBlockStartEvent? contentBlockStart,
            global::G.ContentBlockDeltaEvent? contentBlockDelta,
            global::G.ContentBlockStopEvent? contentBlockStop
            )
        {
            Type = type;

            MessageStart = messageStart;
            MessageDelta = messageDelta;
            MessageStop = messageStop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentBlockStop as object ??
            ContentBlockDelta as object ??
            ContentBlockStart as object ??
            MessageStop as object ??
            MessageDelta as object ??
            MessageStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && !IsMessageStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageStartEvent?, TResult>? messageStart = null,
            global::System.Func<global::G.MessageDeltaEvent?, TResult>? messageDelta = null,
            global::System.Func<global::G.MessageStopEvent?, TResult>? messageStop = null,
            global::System.Func<global::G.ContentBlockStartEvent?, TResult>? contentBlockStart = null,
            global::System.Func<global::G.ContentBlockDeltaEvent?, TResult>? contentBlockDelta = null,
            global::System.Func<global::G.ContentBlockStopEvent?, TResult>? contentBlockStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart && messageStart != null)
            {
                return messageStart(MessageStart!);
            }
            else if (IsMessageDelta && messageDelta != null)
            {
                return messageDelta(MessageDelta!);
            }
            else if (IsMessageStop && messageStop != null)
            {
                return messageStop(MessageStop!);
            }
            else if (IsContentBlockStart && contentBlockStart != null)
            {
                return contentBlockStart(ContentBlockStart!);
            }
            else if (IsContentBlockDelta && contentBlockDelta != null)
            {
                return contentBlockDelta(ContentBlockDelta!);
            }
            else if (IsContentBlockStop && contentBlockStop != null)
            {
                return contentBlockStop(ContentBlockStop!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageStartEvent?>? messageStart = null,
            global::System.Action<global::G.MessageDeltaEvent?>? messageDelta = null,
            global::System.Action<global::G.MessageStopEvent?>? messageStop = null,
            global::System.Action<global::G.ContentBlockStartEvent?>? contentBlockStart = null,
            global::System.Action<global::G.ContentBlockDeltaEvent?>? contentBlockDelta = null,
            global::System.Action<global::G.ContentBlockStopEvent?>? contentBlockStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart)
            {
                messageStart?.Invoke(MessageStart!);
            }
            else if (IsMessageDelta)
            {
                messageDelta?.Invoke(MessageDelta!);
            }
            else if (IsMessageStop)
            {
                messageStop?.Invoke(MessageStop!);
            }
            else if (IsContentBlockStart)
            {
                contentBlockStart?.Invoke(ContentBlockStart!);
            }
            else if (IsContentBlockDelta)
            {
                contentBlockDelta?.Invoke(ContentBlockDelta!);
            }
            else if (IsContentBlockStop)
            {
                contentBlockStop?.Invoke(ContentBlockStop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStart,
                typeof(global::G.MessageStartEvent),
                MessageDelta,
                typeof(global::G.MessageDeltaEvent),
                MessageStop,
                typeof(global::G.MessageStopEvent),
                ContentBlockStart,
                typeof(global::G.ContentBlockStartEvent),
                ContentBlockDelta,
                typeof(global::G.ContentBlockDeltaEvent),
                ContentBlockStop,
                typeof(global::G.ContentBlockStopEvent),
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
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaEvent?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStopEvent?>.Default.Equals(MessageStop, other.MessageStop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) 
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
