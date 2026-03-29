//HintName: G.Models.ShoppingSearchRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ShoppingSearchRequest : global::System.IEquatable<ShoppingSearchRequest>
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
        public static implicit operator ShoppingSearchRequest(global::G.BaseSearchRequest value) => new ShoppingSearchRequest((global::G.BaseSearchRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseSearchRequest?(ShoppingSearchRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ShoppingSearchRequest(global::G.BaseSearchRequest? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseSearchRequest?, TResult>? @base = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseSearchRequest?>? @base = null,
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
        public bool Equals(ShoppingSearchRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseSearchRequest?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShoppingSearchRequest obj1, ShoppingSearchRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShoppingSearchRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShoppingSearchRequest obj1, ShoppingSearchRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShoppingSearchRequest o && Equals(o);
        }
    }
}
