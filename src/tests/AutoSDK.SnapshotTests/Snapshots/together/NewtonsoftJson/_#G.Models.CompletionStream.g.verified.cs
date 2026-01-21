//HintName: G.Models.CompletionStream.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompletionStream : global::System.IEquatable<CompletionStream>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompletionEvent? Event { get; init; }
#else
        public global::G.CompletionEvent? Event { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event))]
#endif
        public bool IsEvent => Event != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StreamSentinel? Sentinel { get; init; }
#else
        public global::G.StreamSentinel? Sentinel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sentinel))]
#endif
        public bool IsSentinel => Sentinel != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionStream(global::G.CompletionEvent value) => new CompletionStream((global::G.CompletionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompletionEvent?(CompletionStream @this) => @this.Event;

        /// <summary>
        /// 
        /// </summary>
        public CompletionStream(global::G.CompletionEvent? value)
        {
            Event = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionStream(global::G.StreamSentinel value) => new CompletionStream((global::G.StreamSentinel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StreamSentinel?(CompletionStream @this) => @this.Sentinel;

        /// <summary>
        /// 
        /// </summary>
        public CompletionStream(global::G.StreamSentinel? value)
        {
            Sentinel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompletionStream(
            global::G.CompletionEvent? @event,
            global::G.StreamSentinel? sentinel
            )
        {
            Event = @event;
            Sentinel = sentinel;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sentinel as object ??
            Event as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            Sentinel?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvent && !IsSentinel || !IsEvent && IsSentinel;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CompletionEvent?, TResult>? @event = null,
            global::System.Func<global::G.StreamSentinel?, TResult>? sentinel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent && @event != null)
            {
                return @event(Event!);
            }
            else if (IsSentinel && sentinel != null)
            {
                return sentinel(Sentinel!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CompletionEvent?>? @event = null,
            global::System.Action<global::G.StreamSentinel?>? sentinel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent)
            {
                @event?.Invoke(Event!);
            }
            else if (IsSentinel)
            {
                sentinel?.Invoke(Sentinel!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Event,
                typeof(global::G.CompletionEvent),
                Sentinel,
                typeof(global::G.StreamSentinel),
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
        public bool Equals(CompletionStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CompletionEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StreamSentinel?>.Default.Equals(Sentinel, other.Sentinel) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionStream obj1, CompletionStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionStream obj1, CompletionStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionStream o && Equals(o);
        }
    }
}
