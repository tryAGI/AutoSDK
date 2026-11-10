//HintName: G.Models.Match.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Match : global::System.IEquatable<Match>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchEqual? Equal { get; init; }
#else
        public global::G.MatchEqual? Equal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Equal))]
#endif
        public bool IsEqual => Equal != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEqual(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MatchEqual? value)
        {
            value = Equal;
            return IsEqual;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MatchEqual PickEqual() => Equal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Equal' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchRange? Range { get; init; }
#else
        public global::G.MatchRange? Range { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Range))]
#endif
        public bool IsRange => Range != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MatchRange? value)
        {
            value = Range;
            return IsRange;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MatchRange PickRange() => Range is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Range' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Match(global::G.MatchEqual value) => new Match((global::G.MatchEqual?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchEqual?(Match @this) => @this.Equal;

        /// <summary>
        /// 
        /// </summary>
        public Match(global::G.MatchEqual? value)
        {
            Equal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Match FromEqual(global::G.MatchEqual? value) => new Match(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Match(global::G.MatchRange value) => new Match((global::G.MatchRange?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchRange?(Match @this) => @this.Range;

        /// <summary>
        /// 
        /// </summary>
        public Match(global::G.MatchRange? value)
        {
            Range = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Match FromRange(global::G.MatchRange? value) => new Match(value);

        /// <summary>
        /// 
        /// </summary>
        public Match(
            global::G.MatchEqual? equal,
            global::G.MatchRange? range
            )
        {
            Equal = equal;
            Range = range;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Range as object ??
            Equal as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Equal?.ToString() ??
            Range?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEqual && !IsRange || !IsEqual && IsRange;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? MatchValue<TResult>(
            global::System.Func<global::G.MatchEqual, TResult>? equal = null,
            global::System.Func<global::G.MatchRange, TResult>? range = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Equal is { } __value0 && equal != null)
            {
                return equal(__value0);
            }
            else if (Range is { } __value1 && range != null)
            {
                return range(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void MatchValue(
            global::System.Action<global::G.MatchEqual>? equal = null,

            global::System.Action<global::G.MatchRange>? range = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Equal is { } __value0)
            {
                equal?.Invoke(__value0);
            }
            else if (Range is { } __value1)
            {
                range?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.MatchEqual>? equal = null,
            global::System.Action<global::G.MatchRange>? range = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Equal is { } __value0)
            {
                equal?.Invoke(__value0);
            }
            else if (Range is { } __value1)
            {
                range?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Equal,
                typeof(global::G.MatchEqual),
                Range,
                typeof(global::G.MatchRange),
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
        public bool Equals(Match other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MatchEqual?>.Default.Equals(Equal, other.Equal) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchRange?>.Default.Equals(Range, other.Range) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Match obj1, Match obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Match>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Match obj1, Match obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Match o && Equals(o);
        }
    }
}
