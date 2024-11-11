//HintName: G.Models.MessageStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A event in a streaming conversation.
    /// </summary>
    public readonly partial struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A start event in a streaming conversation.
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
        /// A delta event in a streaming conversation.
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
        /// A stop event in a streaming conversation.
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
        /// A start event in a streaming content block.
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
        /// A delta event in a streaming content block.
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
        /// A stop event in a streaming content block.
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
        /// A ping event in a streaming conversation.
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
        /// An error event in a streaming conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorEvent? Error { get; init; }
#else
        public global::G.ErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.ErrorEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorEvent?(MessageStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.ErrorEvent? value)
        {
            Error = value;
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
            global::G.ContentBlockStopEvent? contentBlockStop,
            global::G.PingEvent? ping,
            global::G.ErrorEvent? error
            )
        {
            Type = type;

            MessageStart = messageStart;
            MessageDelta = messageDelta;
            MessageStop = messageStop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
            Ping = ping;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Ping as object ??
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
            return IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && IsError;
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
            global::System.Func<global::G.PingEvent?, TResult>? ping = null,
            global::System.Func<global::G.ErrorEvent?, TResult>? error = null,
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
            else if (IsPing && ping != null)
            {
                return ping(Ping!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
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
            global::System.Action<global::G.PingEvent?>? ping = null,
            global::System.Action<global::G.ErrorEvent?>? error = null,
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
            else if (IsPing)
            {
                ping?.Invoke(Ping!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
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
                Ping,
                typeof(global::G.PingEvent),
                Error,
                typeof(global::G.ErrorEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaEvent?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStopEvent?>.Default.Equals(MessageStop, other.MessageStop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PingEvent?>.Default.Equals(Ping, other.Ping) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorEvent?>.Default.Equals(Error, other.Error) 
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
