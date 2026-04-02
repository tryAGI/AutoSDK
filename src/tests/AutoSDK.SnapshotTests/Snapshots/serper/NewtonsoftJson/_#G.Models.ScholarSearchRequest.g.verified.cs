//HintName: G.Models.ScholarSearchRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScholarSearchRequest : global::System.IEquatable<ScholarSearchRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseSearchRequest? Base { get; init; }
#else
        public global::G.BaseSearchRequest? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ScholarSearchRequestVariant2? ScholarSearchRequestVariant2 { get; init; }
#else
        public global::G.ScholarSearchRequestVariant2? ScholarSearchRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScholarSearchRequestVariant2))]
#endif
        public bool IsScholarSearchRequestVariant2 => ScholarSearchRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScholarSearchRequest(global::G.BaseSearchRequest value) => new ScholarSearchRequest((global::G.BaseSearchRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseSearchRequest?(ScholarSearchRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ScholarSearchRequest(global::G.BaseSearchRequest? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScholarSearchRequest(global::G.ScholarSearchRequestVariant2 value) => new ScholarSearchRequest((global::G.ScholarSearchRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ScholarSearchRequestVariant2?(ScholarSearchRequest @this) => @this.ScholarSearchRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ScholarSearchRequest(global::G.ScholarSearchRequestVariant2? value)
        {
            ScholarSearchRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScholarSearchRequest(
            global::G.BaseSearchRequest? @base,
            global::G.ScholarSearchRequestVariant2? scholarSearchRequestVariant2
            )
        {
            Base = @base;
            ScholarSearchRequestVariant2 = scholarSearchRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScholarSearchRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ScholarSearchRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsScholarSearchRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseSearchRequest?, TResult>? @base = null,
            global::System.Func<global::G.ScholarSearchRequestVariant2?, TResult>? scholarSearchRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsScholarSearchRequestVariant2 && scholarSearchRequestVariant2 != null)
            {
                return scholarSearchRequestVariant2(ScholarSearchRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseSearchRequest?>? @base = null,
            global::System.Action<global::G.ScholarSearchRequestVariant2?>? scholarSearchRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsScholarSearchRequestVariant2)
            {
                scholarSearchRequestVariant2?.Invoke(ScholarSearchRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.BaseSearchRequest),
                ScholarSearchRequestVariant2,
                typeof(global::G.ScholarSearchRequestVariant2),
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
        public bool Equals(ScholarSearchRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseSearchRequest?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ScholarSearchRequestVariant2?>.Default.Equals(ScholarSearchRequestVariant2, other.ScholarSearchRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScholarSearchRequest obj1, ScholarSearchRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScholarSearchRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScholarSearchRequest obj1, ScholarSearchRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScholarSearchRequest o && Equals(o);
        }
    }
}
