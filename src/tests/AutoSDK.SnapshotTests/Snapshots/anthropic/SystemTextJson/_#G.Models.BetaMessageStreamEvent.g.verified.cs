//HintName: G.Models.BetaMessageStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaMessageStreamEvent : global::System.IEquatable<BetaMessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaMessageStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaMessageStartEvent? MessageStart { get; init; }
#else
        public global::G.BetaMessageStartEvent? MessageStart { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaMessageDeltaEvent? MessageDelta { get; init; }
#else
        public global::G.BetaMessageDeltaEvent? MessageDelta { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaMessageStopEvent? MessageStop { get; init; }
#else
        public global::G.BetaMessageStopEvent? MessageStop { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaContentBlockStartEvent? ContentBlockStart { get; init; }
#else
        public global::G.BetaContentBlockStartEvent? ContentBlockStart { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaContentBlockDeltaEvent? ContentBlockDelta { get; init; }
#else
        public global::G.BetaContentBlockDeltaEvent? ContentBlockDelta { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaContentBlockStopEvent? ContentBlockStop { get; init; }
#else
        public global::G.BetaContentBlockStopEvent? ContentBlockStop { get; }
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
        public static implicit operator BetaMessageStreamEvent(global::G.BetaMessageStartEvent value) => new BetaMessageStreamEvent((global::G.BetaMessageStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaMessageStartEvent?(BetaMessageStreamEvent @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::G.BetaMessageStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::G.BetaMessageDeltaEvent value) => new BetaMessageStreamEvent((global::G.BetaMessageDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaMessageDeltaEvent?(BetaMessageStreamEvent @this) => @this.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::G.BetaMessageDeltaEvent? value)
        {
            MessageDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::G.BetaMessageStopEvent value) => new BetaMessageStreamEvent((global::G.BetaMessageStopEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaMessageStopEvent?(BetaMessageStreamEvent @this) => @this.MessageStop;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::G.BetaMessageStopEvent? value)
        {
            MessageStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::G.BetaContentBlockStartEvent value) => new BetaMessageStreamEvent((global::G.BetaContentBlockStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaContentBlockStartEvent?(BetaMessageStreamEvent @this) => @this.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::G.BetaContentBlockStartEvent? value)
        {
            ContentBlockStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::G.BetaContentBlockDeltaEvent value) => new BetaMessageStreamEvent((global::G.BetaContentBlockDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaContentBlockDeltaEvent?(BetaMessageStreamEvent @this) => @this.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::G.BetaContentBlockDeltaEvent? value)
        {
            ContentBlockDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::G.BetaContentBlockStopEvent value) => new BetaMessageStreamEvent((global::G.BetaContentBlockStopEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaContentBlockStopEvent?(BetaMessageStreamEvent @this) => @this.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::G.BetaContentBlockStopEvent? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(
            global::G.BetaMessageStreamEventDiscriminatorType? type,
            global::G.BetaMessageStartEvent? messageStart,
            global::G.BetaMessageDeltaEvent? messageDelta,
            global::G.BetaMessageStopEvent? messageStop,
            global::G.BetaContentBlockStartEvent? contentBlockStart,
            global::G.BetaContentBlockDeltaEvent? contentBlockDelta,
            global::G.BetaContentBlockStopEvent? contentBlockStop
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
        public override string? ToString() =>
            MessageStart?.ToString() ??
            MessageDelta?.ToString() ??
            MessageStop?.ToString() ??
            ContentBlockStart?.ToString() ??
            ContentBlockDelta?.ToString() ??
            ContentBlockStop?.ToString() 
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
            global::System.Func<global::G.BetaMessageStartEvent?, TResult>? messageStart = null,
            global::System.Func<global::G.BetaMessageDeltaEvent?, TResult>? messageDelta = null,
            global::System.Func<global::G.BetaMessageStopEvent?, TResult>? messageStop = null,
            global::System.Func<global::G.BetaContentBlockStartEvent?, TResult>? contentBlockStart = null,
            global::System.Func<global::G.BetaContentBlockDeltaEvent?, TResult>? contentBlockDelta = null,
            global::System.Func<global::G.BetaContentBlockStopEvent?, TResult>? contentBlockStop = null,
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
            global::System.Action<global::G.BetaMessageStartEvent?>? messageStart = null,
            global::System.Action<global::G.BetaMessageDeltaEvent?>? messageDelta = null,
            global::System.Action<global::G.BetaMessageStopEvent?>? messageStop = null,
            global::System.Action<global::G.BetaContentBlockStartEvent?>? contentBlockStart = null,
            global::System.Action<global::G.BetaContentBlockDeltaEvent?>? contentBlockDelta = null,
            global::System.Action<global::G.BetaContentBlockStopEvent?>? contentBlockStop = null,
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
                typeof(global::G.BetaMessageStartEvent),
                MessageDelta,
                typeof(global::G.BetaMessageDeltaEvent),
                MessageStop,
                typeof(global::G.BetaMessageStopEvent),
                ContentBlockStart,
                typeof(global::G.BetaContentBlockStartEvent),
                ContentBlockDelta,
                typeof(global::G.BetaContentBlockDeltaEvent),
                ContentBlockStop,
                typeof(global::G.BetaContentBlockStopEvent),
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
        public bool Equals(BetaMessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaMessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaMessageDeltaEvent?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaMessageStopEvent?>.Default.Equals(MessageStop, other.MessageStop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaMessageStreamEvent obj1, BetaMessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaMessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaMessageStreamEvent obj1, BetaMessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaMessageStreamEvent o && Equals(o);
        }
    }
}
