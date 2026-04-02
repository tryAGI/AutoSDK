//HintName: G.Models.GenerateStreamError.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateStreamError : global::System.IEquatable<GenerateStreamError>
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
        public global::G.GenerateStreamError49d5xw? Error49d5xw { get; init; }
#else
        public global::G.GenerateStreamError49d5xw? Error49d5xw { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error49d5xw))]
#endif
        public bool IsError49d5xw => Error49d5xw != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamError(global::G.GenerateStreamEvent value) => new GenerateStreamError((global::G.GenerateStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamEvent?(GenerateStreamError @this) => @this.Event;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamError(global::G.GenerateStreamEvent? value)
        {
            Event = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamError(global::G.GenerateStreamError49d5xw value) => new GenerateStreamError((global::G.GenerateStreamError49d5xw?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamError49d5xw?(GenerateStreamError @this) => @this.Error49d5xw;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamError(global::G.GenerateStreamError49d5xw? value)
        {
            Error49d5xw = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamError(
            global::G.GenerateStreamEvent? @event,
            global::G.GenerateStreamError49d5xw? error49d5xw
            )
        {
            Event = @event;
            Error49d5xw = error49d5xw;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error49d5xw as object ??
            Event as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            Error49d5xw?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsError49d5xw;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerateStreamEvent?, TResult>? @event = null,
            global::System.Func<global::G.GenerateStreamError49d5xw?, TResult>? error49d5xw = null,
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
            else if (IsError49d5xw && error49d5xw != null)
            {
                return error49d5xw(Error49d5xw!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerateStreamEvent?>? @event = null,
            global::System.Action<global::G.GenerateStreamError49d5xw?>? error49d5xw = null,
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
            else if (IsError49d5xw)
            {
                error49d5xw?.Invoke(Error49d5xw!);
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
                Error49d5xw,
                typeof(global::G.GenerateStreamError49d5xw),
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
        public bool Equals(GenerateStreamError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamError49d5xw?>.Default.Equals(Error49d5xw, other.Error49d5xw) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateStreamError obj1, GenerateStreamError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateStreamError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateStreamError obj1, GenerateStreamError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateStreamError o && Equals(o);
        }
    }
}
