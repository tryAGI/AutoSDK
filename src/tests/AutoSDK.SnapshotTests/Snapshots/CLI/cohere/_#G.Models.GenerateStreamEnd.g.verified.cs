//HintName: G.Models.GenerateStreamEnd.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateStreamEnd : global::System.IEquatable<GenerateStreamEnd>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamEvent? Event { get; init; }
#else
        public global::G.GenerateStreamEvent? Event { get; }
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
        public global::G.GenerateStreamEndUbzr0t? Ubzr0t { get; init; }
#else
        public global::G.GenerateStreamEndUbzr0t? Ubzr0t { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ubzr0t))]
#endif
        public bool IsUbzr0t => Ubzr0t != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamEnd(global::G.GenerateStreamEvent value) => new GenerateStreamEnd((global::G.GenerateStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamEvent?(GenerateStreamEnd @this) => @this.Event;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamEnd(global::G.GenerateStreamEvent? value)
        {
            Event = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamEnd(global::G.GenerateStreamEndUbzr0t value) => new GenerateStreamEnd((global::G.GenerateStreamEndUbzr0t?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamEndUbzr0t?(GenerateStreamEnd @this) => @this.Ubzr0t;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamEnd(global::G.GenerateStreamEndUbzr0t? value)
        {
            Ubzr0t = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamEnd(
            global::G.GenerateStreamEvent? @event,
            global::G.GenerateStreamEndUbzr0t? ubzr0t
            )
        {
            Event = @event;
            Ubzr0t = ubzr0t;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ubzr0t as object ??
            Event as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            Ubzr0t?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsUbzr0t;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerateStreamEvent?, TResult>? @event = null,
            global::System.Func<global::G.GenerateStreamEndUbzr0t?, TResult>? ubzr0t = null,
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
            else if (IsUbzr0t && ubzr0t != null)
            {
                return ubzr0t(Ubzr0t!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerateStreamEvent?>? @event = null,
            global::System.Action<global::G.GenerateStreamEndUbzr0t?>? ubzr0t = null,
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
            else if (IsUbzr0t)
            {
                ubzr0t?.Invoke(Ubzr0t!);
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
                typeof(global::G.GenerateStreamEvent),
                Ubzr0t,
                typeof(global::G.GenerateStreamEndUbzr0t),
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
        public bool Equals(GenerateStreamEnd other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamEndUbzr0t?>.Default.Equals(Ubzr0t, other.Ubzr0t) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateStreamEnd obj1, GenerateStreamEnd obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateStreamEnd>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateStreamEnd obj1, GenerateStreamEnd obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateStreamEnd o && Equals(o);
        }
    }
}
