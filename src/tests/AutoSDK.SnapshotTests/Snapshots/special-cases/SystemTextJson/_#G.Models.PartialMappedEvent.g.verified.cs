//HintName: G.Models.PartialMappedEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PartialMappedEvent : global::System.IEquatable<PartialMappedEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MappedStartEvent? Start { get; init; }
#else
        public global::G.MappedStartEvent? Start { get; }
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
        public bool TryPickStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MappedStartEvent? value)
        {
            value = Start;
            return IsStart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MappedStartEvent PickStart() => Start is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Start' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MappedStopEvent? Stop { get; init; }
#else
        public global::G.MappedStopEvent? Stop { get; }
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
        public bool TryPickStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MappedStopEvent? value)
        {
            value = Stop;
            return IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MappedStopEvent PickStop() => Stop is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stop' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PartialMappedEvent(global::G.MappedStartEvent value) => new PartialMappedEvent((global::G.MappedStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MappedStartEvent?(PartialMappedEvent @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public PartialMappedEvent(global::G.MappedStartEvent? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PartialMappedEvent FromStart(global::G.MappedStartEvent? value) => new PartialMappedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PartialMappedEvent(global::G.MappedStopEvent value) => new PartialMappedEvent((global::G.MappedStopEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MappedStopEvent?(PartialMappedEvent @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public PartialMappedEvent(global::G.MappedStopEvent? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PartialMappedEvent FromStop(global::G.MappedStopEvent? value) => new PartialMappedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public PartialMappedEvent(
            global::G.MappedStartEvent? start,
            global::G.MappedStopEvent? stop
            )
        {
            Start = start;
            Stop = stop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Stop as object ??
            Start as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Start?.ToString() ??
            Stop?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsStop || !IsStart && IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MappedStartEvent, TResult>? start = null,
            global::System.Func<global::G.MappedStopEvent, TResult>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Start is { } __value0 && start != null)
            {
                return start(__value0);
            }
            else if (Stop is { } __value1 && stop != null)
            {
                return stop(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MappedStartEvent>? start = null,

            global::System.Action<global::G.MappedStopEvent>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Start is { } __value0)
            {
                start?.Invoke(__value0);
            }
            else if (Stop is { } __value1)
            {
                stop?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.MappedStartEvent>? start = null,
            global::System.Action<global::G.MappedStopEvent>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Start is { } __value0)
            {
                start?.Invoke(__value0);
            }
            else if (Stop is { } __value1)
            {
                stop?.Invoke(__value1);
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
                typeof(global::G.MappedStartEvent),
                Stop,
                typeof(global::G.MappedStopEvent),
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
        public bool Equals(PartialMappedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MappedStartEvent?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MappedStopEvent?>.Default.Equals(Stop, other.Stop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PartialMappedEvent obj1, PartialMappedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PartialMappedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PartialMappedEvent obj1, PartialMappedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PartialMappedEvent o && Equals(o);
        }
    }
}
