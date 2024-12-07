//HintName: G.Models.PromptCachingBetaMessageStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptCachingBetaMessageStreamEvent : global::System.IEquatable<PromptCachingBetaMessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptCachingBetaMessageStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptCachingBetaMessageStartEvent? MessageStart { get; init; }
#else
        public global::G.PromptCachingBetaMessageStartEvent? MessageStart { get; }
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
        public static implicit operator PromptCachingBetaMessageStreamEvent(global::G.PromptCachingBetaMessageStartEvent value) => new PromptCachingBetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCachingBetaMessageStartEvent?(PromptCachingBetaMessageStreamEvent @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(global::G.PromptCachingBetaMessageStartEvent? value)
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
        public static implicit operator PromptCachingBetaMessageStreamEvent(global::G.MessageDeltaEvent value) => new PromptCachingBetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaEvent?(PromptCachingBetaMessageStreamEvent @this) => @this.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(global::G.MessageDeltaEvent? value)
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
        public static implicit operator PromptCachingBetaMessageStreamEvent(global::G.MessageStopEvent value) => new PromptCachingBetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStopEvent?(PromptCachingBetaMessageStreamEvent @this) => @this.MessageStop;

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(global::G.MessageStopEvent? value)
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
        public static implicit operator PromptCachingBetaMessageStreamEvent(global::G.ContentBlockStartEvent value) => new PromptCachingBetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockStartEvent?(PromptCachingBetaMessageStreamEvent @this) => @this.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(global::G.ContentBlockStartEvent? value)
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
        public static implicit operator PromptCachingBetaMessageStreamEvent(global::G.ContentBlockDeltaEvent value) => new PromptCachingBetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockDeltaEvent?(PromptCachingBetaMessageStreamEvent @this) => @this.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(global::G.ContentBlockDeltaEvent? value)
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
        public static implicit operator PromptCachingBetaMessageStreamEvent(global::G.ContentBlockStopEvent value) => new PromptCachingBetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentBlockStopEvent?(PromptCachingBetaMessageStreamEvent @this) => @this.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(global::G.ContentBlockStopEvent? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptCachingBetaMessageStreamEvent(
            global::G.PromptCachingBetaMessageStreamEventDiscriminatorType? type,
            global::G.PromptCachingBetaMessageStartEvent? messageStart,
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
            global::System.Func<global::G.PromptCachingBetaMessageStartEvent?, TResult>? messageStart = null,
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
            global::System.Action<global::G.PromptCachingBetaMessageStartEvent?>? messageStart = null,
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
                typeof(global::G.PromptCachingBetaMessageStartEvent),
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
        public bool Equals(PromptCachingBetaMessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptCachingBetaMessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
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
        public static bool operator ==(PromptCachingBetaMessageStreamEvent obj1, PromptCachingBetaMessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptCachingBetaMessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptCachingBetaMessageStreamEvent obj1, PromptCachingBetaMessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptCachingBetaMessageStreamEvent o && Equals(o);
        }
    }
}
