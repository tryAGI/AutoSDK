//HintName: G.Models.UsingVector.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UsingVector : global::System.IEquatable<UsingVector>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UsingVectorVariant1 { get; init; }
#else
        public string? UsingVectorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsingVectorVariant1))]
#endif
        public bool IsUsingVectorVariant1 => UsingVectorVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsingVector(string value) => new UsingVector((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(UsingVector @this) => @this.UsingVectorVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UsingVector(string? value)
        {
            UsingVectorVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UsingVectorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UsingVectorVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUsingVectorVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? usingVectorVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsingVectorVariant1 && usingVectorVariant1 != null)
            {
                return usingVectorVariant1(UsingVectorVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? usingVectorVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsingVectorVariant1)
            {
                usingVectorVariant1?.Invoke(UsingVectorVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UsingVectorVariant1,
                typeof(string),
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
        public bool Equals(UsingVector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UsingVectorVariant1, other.UsingVectorVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UsingVector obj1, UsingVector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsingVector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UsingVector obj1, UsingVector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsingVector o && Equals(o);
        }
    }
}
