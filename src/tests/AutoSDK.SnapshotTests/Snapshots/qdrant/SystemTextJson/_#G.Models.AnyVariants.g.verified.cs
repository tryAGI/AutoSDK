//HintName: G.Models.AnyVariants.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnyVariants : global::System.IEquatable<AnyVariants>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? AnyVariantsVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? AnyVariantsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnyVariantsVariant1))]
#endif
        public bool IsAnyVariantsVariant1 => AnyVariantsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<long>? AnyVariantsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<long>? AnyVariantsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnyVariantsVariant2))]
#endif
        public bool IsAnyVariantsVariant2 => AnyVariantsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public AnyVariants(
            global::System.Collections.Generic.IList<string>? anyVariantsVariant1,
            global::System.Collections.Generic.IList<long>? anyVariantsVariant2
            )
        {
            AnyVariantsVariant1 = anyVariantsVariant1;
            AnyVariantsVariant2 = anyVariantsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnyVariantsVariant2 as object ??
            AnyVariantsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnyVariantsVariant1?.ToString() ??
            AnyVariantsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnyVariantsVariant1 || IsAnyVariantsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? anyVariantsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<long>?, TResult>? anyVariantsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnyVariantsVariant1 && anyVariantsVariant1 != null)
            {
                return anyVariantsVariant1(AnyVariantsVariant1!);
            }
            else if (IsAnyVariantsVariant2 && anyVariantsVariant2 != null)
            {
                return anyVariantsVariant2(AnyVariantsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<string>?>? anyVariantsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<long>?>? anyVariantsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnyVariantsVariant1)
            {
                anyVariantsVariant1?.Invoke(AnyVariantsVariant1!);
            }
            else if (IsAnyVariantsVariant2)
            {
                anyVariantsVariant2?.Invoke(AnyVariantsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnyVariantsVariant1,
                typeof(global::System.Collections.Generic.IList<string>),
                AnyVariantsVariant2,
                typeof(global::System.Collections.Generic.IList<long>),
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
        public bool Equals(AnyVariants other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(AnyVariantsVariant1, other.AnyVariantsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<long>?>.Default.Equals(AnyVariantsVariant2, other.AnyVariantsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnyVariants obj1, AnyVariants obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnyVariants>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnyVariants obj1, AnyVariants obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnyVariants o && Equals(o);
        }
    }
}
