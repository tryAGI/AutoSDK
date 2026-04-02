//HintName: G.Models.FacetValue.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FacetValue : global::System.IEquatable<FacetValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FacetValueVariant1 { get; init; }
#else
        public string? FacetValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetValueVariant1))]
#endif
        public bool IsFacetValueVariant1 => FacetValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public long? FacetValueVariant2 { get; init; }
#else
        public long? FacetValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetValueVariant2))]
#endif
        public bool IsFacetValueVariant2 => FacetValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? FacetValueVariant3 { get; init; }
#else
        public bool? FacetValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetValueVariant3))]
#endif
        public bool IsFacetValueVariant3 => FacetValueVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FacetValue(string value) => new FacetValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FacetValue @this) => @this.FacetValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FacetValue(string? value)
        {
            FacetValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FacetValue(long value) => new FacetValue((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(FacetValue @this) => @this.FacetValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FacetValue(long? value)
        {
            FacetValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FacetValue(bool value) => new FacetValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(FacetValue @this) => @this.FacetValueVariant3;

        /// <summary>
        /// 
        /// </summary>
        public FacetValue(bool? value)
        {
            FacetValueVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FacetValue(
            string? facetValueVariant1,
            long? facetValueVariant2,
            bool? facetValueVariant3
            )
        {
            FacetValueVariant1 = facetValueVariant1;
            FacetValueVariant2 = facetValueVariant2;
            FacetValueVariant3 = facetValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FacetValueVariant3 as object ??
            FacetValueVariant2 as object ??
            FacetValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FacetValueVariant1?.ToString() ??
            FacetValueVariant2?.ToString() ??
            FacetValueVariant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFacetValueVariant1 || IsFacetValueVariant2 || IsFacetValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? facetValueVariant1 = null,
            global::System.Func<long?, TResult>? facetValueVariant2 = null,
            global::System.Func<bool?, TResult>? facetValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFacetValueVariant1 && facetValueVariant1 != null)
            {
                return facetValueVariant1(FacetValueVariant1!);
            }
            else if (IsFacetValueVariant2 && facetValueVariant2 != null)
            {
                return facetValueVariant2(FacetValueVariant2!);
            }
            else if (IsFacetValueVariant3 && facetValueVariant3 != null)
            {
                return facetValueVariant3(FacetValueVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? facetValueVariant1 = null,
            global::System.Action<long?>? facetValueVariant2 = null,
            global::System.Action<bool?>? facetValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFacetValueVariant1)
            {
                facetValueVariant1?.Invoke(FacetValueVariant1!);
            }
            else if (IsFacetValueVariant2)
            {
                facetValueVariant2?.Invoke(FacetValueVariant2!);
            }
            else if (IsFacetValueVariant3)
            {
                facetValueVariant3?.Invoke(FacetValueVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FacetValueVariant1,
                typeof(string),
                FacetValueVariant2,
                typeof(long),
                FacetValueVariant3,
                typeof(bool),
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
        public bool Equals(FacetValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FacetValueVariant1, other.FacetValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(FacetValueVariant2, other.FacetValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(FacetValueVariant3, other.FacetValueVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FacetValue obj1, FacetValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FacetValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FacetValue obj1, FacetValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FacetValue o && Equals(o);
        }
    }
}
