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
        /// A delta event in a streaming conversation.
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
        /// A stop event in a streaming conversation.
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
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::G.MessageStreamEventDiscriminatorType? type,
            global::G.MessageStartEvent? start,
            global::G.MessageDeltaEvent? delta,
            global::G.MessageStopEvent? stop,
            global::G.ContentBlockStartEvent? contentBlockStart,
            global::G.ContentBlockDeltaEvent? contentBlockDelta,
            global::G.ContentBlockStopEvent? contentBlockStop,
            global::G.PingEvent? ping
            )
        {
            Type = type;

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
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageStartEvent?, TResult>? start = null,
            global::System.Func<global::G.MessageDeltaEvent?, TResult>? delta = null,
            global::System.Func<global::G.MessageStopEvent?, TResult>? stop = null,
            global::System.Func<global::G.ContentBlockStartEvent?, TResult>? contentBlockStart = null,
            global::System.Func<global::G.ContentBlockDeltaEvent?, TResult>? contentBlockDelta = null,
            global::System.Func<global::G.ContentBlockStopEvent?, TResult>? contentBlockStop = null,
            global::System.Func<global::G.PingEvent?, TResult>? ping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart && start != null)
            {
                return start(Start!);
            }
            else if (IsDelta && delta != null)
            {
                return delta(Delta!);
            }
            else if (IsStop && stop != null)
            {
                return stop(Stop!);
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageStartEvent?>? start = null,
            global::System.Action<global::G.MessageDeltaEvent?>? delta = null,
            global::System.Action<global::G.MessageStopEvent?>? stop = null,
            global::System.Action<global::G.ContentBlockStartEvent?>? contentBlockStart = null,
            global::System.Action<global::G.ContentBlockDeltaEvent?>? contentBlockDelta = null,
            global::System.Action<global::G.ContentBlockStopEvent?>? contentBlockStop = null,
            global::System.Action<global::G.PingEvent?>? ping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsDelta)
            {
                delta?.Invoke(Delta!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MessageStreamEvent? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MessageStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
