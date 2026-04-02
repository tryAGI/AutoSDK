//HintName: G.Models.ExpressiveAvatarExpressionDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExpressiveAvatarExpressionDto : global::System.IEquatable<ExpressiveAvatarExpressionDto>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpressiveAvatarExpressionDtoVariant1? ExpressiveAvatarExpressionDtoVariant1 { get; init; }
#else
        public global::G.ExpressiveAvatarExpressionDtoVariant1? ExpressiveAvatarExpressionDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveAvatarExpressionDtoVariant1))]
#endif
        public bool IsExpressiveAvatarExpressionDtoVariant1 => ExpressiveAvatarExpressionDtoVariant1 != null;

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ExpressiveAvatarExpressionDtoVariant2 { get; init; }
#else
        public object? ExpressiveAvatarExpressionDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveAvatarExpressionDtoVariant2))]
#endif
        public bool IsExpressiveAvatarExpressionDtoVariant2 => ExpressiveAvatarExpressionDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExpressiveAvatarExpressionDto(global::G.ExpressiveAvatarExpressionDtoVariant1 value) => new ExpressiveAvatarExpressionDto((global::G.ExpressiveAvatarExpressionDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpressiveAvatarExpressionDtoVariant1?(ExpressiveAvatarExpressionDto @this) => @this.ExpressiveAvatarExpressionDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveAvatarExpressionDto(global::G.ExpressiveAvatarExpressionDtoVariant1? value)
        {
            ExpressiveAvatarExpressionDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveAvatarExpressionDto(
            global::G.ExpressiveAvatarExpressionDtoVariant1? expressiveAvatarExpressionDtoVariant1,
            object? expressiveAvatarExpressionDtoVariant2
            )
        {
            ExpressiveAvatarExpressionDtoVariant1 = expressiveAvatarExpressionDtoVariant1;
            ExpressiveAvatarExpressionDtoVariant2 = expressiveAvatarExpressionDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExpressiveAvatarExpressionDtoVariant2 as object ??
            ExpressiveAvatarExpressionDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExpressiveAvatarExpressionDtoVariant1?.ToString() ??
            ExpressiveAvatarExpressionDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExpressiveAvatarExpressionDtoVariant1 && IsExpressiveAvatarExpressionDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ExpressiveAvatarExpressionDtoVariant1?, TResult>? expressiveAvatarExpressionDtoVariant1 = null,
            global::System.Func<object?, TResult>? expressiveAvatarExpressionDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressiveAvatarExpressionDtoVariant1 && expressiveAvatarExpressionDtoVariant1 != null)
            {
                return expressiveAvatarExpressionDtoVariant1(ExpressiveAvatarExpressionDtoVariant1!);
            }
            else if (IsExpressiveAvatarExpressionDtoVariant2 && expressiveAvatarExpressionDtoVariant2 != null)
            {
                return expressiveAvatarExpressionDtoVariant2(ExpressiveAvatarExpressionDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ExpressiveAvatarExpressionDtoVariant1?>? expressiveAvatarExpressionDtoVariant1 = null,
            global::System.Action<object?>? expressiveAvatarExpressionDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressiveAvatarExpressionDtoVariant1)
            {
                expressiveAvatarExpressionDtoVariant1?.Invoke(ExpressiveAvatarExpressionDtoVariant1!);
            }
            else if (IsExpressiveAvatarExpressionDtoVariant2)
            {
                expressiveAvatarExpressionDtoVariant2?.Invoke(ExpressiveAvatarExpressionDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExpressiveAvatarExpressionDtoVariant1,
                typeof(global::G.ExpressiveAvatarExpressionDtoVariant1),
                ExpressiveAvatarExpressionDtoVariant2,
                typeof(object),
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
        public bool Equals(ExpressiveAvatarExpressionDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ExpressiveAvatarExpressionDtoVariant1?>.Default.Equals(ExpressiveAvatarExpressionDtoVariant1, other.ExpressiveAvatarExpressionDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ExpressiveAvatarExpressionDtoVariant2, other.ExpressiveAvatarExpressionDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExpressiveAvatarExpressionDto obj1, ExpressiveAvatarExpressionDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExpressiveAvatarExpressionDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExpressiveAvatarExpressionDto obj1, ExpressiveAvatarExpressionDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExpressiveAvatarExpressionDto o && Equals(o);
        }
    }
}
