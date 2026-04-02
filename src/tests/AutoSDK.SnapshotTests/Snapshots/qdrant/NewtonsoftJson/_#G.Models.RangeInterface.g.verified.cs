//HintName: G.Models.RangeInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RangeInterface : global::System.IEquatable<RangeInterface>
    {
        /// <summary>
        /// Range filter request
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Range? Range { get; init; }
#else
        public global::G.Range? Range { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Range))]
#endif
        public bool IsRange => Range != null;

        /// <summary>
        /// Range filter request
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DatetimeRange? Datetime { get; init; }
#else
        public global::G.DatetimeRange? Datetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Datetime))]
#endif
        public bool IsDatetime => Datetime != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RangeInterface(global::G.Range value) => new RangeInterface((global::G.Range?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Range?(RangeInterface @this) => @this.Range;

        /// <summary>
        /// 
        /// </summary>
        public RangeInterface(global::G.Range? value)
        {
            Range = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RangeInterface(global::G.DatetimeRange value) => new RangeInterface((global::G.DatetimeRange?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DatetimeRange?(RangeInterface @this) => @this.Datetime;

        /// <summary>
        /// 
        /// </summary>
        public RangeInterface(global::G.DatetimeRange? value)
        {
            Datetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RangeInterface(
            global::G.Range? range,
            global::G.DatetimeRange? datetime
            )
        {
            Range = range;
            Datetime = datetime;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Datetime as object ??
            Range as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Range?.ToString() ??
            Datetime?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRange || IsDatetime;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Range?, TResult>? range = null,
            global::System.Func<global::G.DatetimeRange?, TResult>? datetime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRange && range != null)
            {
                return range(Range!);
            }
            else if (IsDatetime && datetime != null)
            {
                return datetime(Datetime!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Range?>? range = null,
            global::System.Action<global::G.DatetimeRange?>? datetime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRange)
            {
                range?.Invoke(Range!);
            }
            else if (IsDatetime)
            {
                datetime?.Invoke(Datetime!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Range,
                typeof(global::G.Range),
                Datetime,
                typeof(global::G.DatetimeRange),
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
        public bool Equals(RangeInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Range?>.Default.Equals(Range, other.Range) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DatetimeRange?>.Default.Equals(Datetime, other.Datetime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RangeInterface obj1, RangeInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RangeInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RangeInterface obj1, RangeInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RangeInterface o && Equals(o);
        }
    }
}
