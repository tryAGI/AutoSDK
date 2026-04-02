//HintName: G.Models.ExpressiveAvatarDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExpressiveAvatarDto : global::System.IEquatable<ExpressiveAvatarDto>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpressiveAvatarDtoVariant1? ExpressiveAvatarDtoVariant1 { get; init; }
#else
        public global::G.ExpressiveAvatarDtoVariant1? ExpressiveAvatarDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveAvatarDtoVariant1))]
#endif
        public bool IsExpressiveAvatarDtoVariant1 => ExpressiveAvatarDtoVariant1 != null;

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ExpressiveAvatarDtoVariant2 { get; init; }
#else
        public object? ExpressiveAvatarDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveAvatarDtoVariant2))]
#endif
        public bool IsExpressiveAvatarDtoVariant2 => ExpressiveAvatarDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExpressiveAvatarDto(global::G.ExpressiveAvatarDtoVariant1 value) => new ExpressiveAvatarDto((global::G.ExpressiveAvatarDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpressiveAvatarDtoVariant1?(ExpressiveAvatarDto @this) => @this.ExpressiveAvatarDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveAvatarDto(global::G.ExpressiveAvatarDtoVariant1? value)
        {
            ExpressiveAvatarDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveAvatarDto(
            global::G.ExpressiveAvatarDtoVariant1? expressiveAvatarDtoVariant1,
            object? expressiveAvatarDtoVariant2
            )
        {
            ExpressiveAvatarDtoVariant1 = expressiveAvatarDtoVariant1;
            ExpressiveAvatarDtoVariant2 = expressiveAvatarDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExpressiveAvatarDtoVariant2 as object ??
            ExpressiveAvatarDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExpressiveAvatarDtoVariant1?.ToString() ??
            ExpressiveAvatarDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExpressiveAvatarDtoVariant1 && IsExpressiveAvatarDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ExpressiveAvatarDtoVariant1?, TResult>? expressiveAvatarDtoVariant1 = null,
            global::System.Func<object?, TResult>? expressiveAvatarDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressiveAvatarDtoVariant1 && expressiveAvatarDtoVariant1 != null)
            {
                return expressiveAvatarDtoVariant1(ExpressiveAvatarDtoVariant1!);
            }
            else if (IsExpressiveAvatarDtoVariant2 && expressiveAvatarDtoVariant2 != null)
            {
                return expressiveAvatarDtoVariant2(ExpressiveAvatarDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ExpressiveAvatarDtoVariant1?>? expressiveAvatarDtoVariant1 = null,
            global::System.Action<object?>? expressiveAvatarDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressiveAvatarDtoVariant1)
            {
                expressiveAvatarDtoVariant1?.Invoke(ExpressiveAvatarDtoVariant1!);
            }
            else if (IsExpressiveAvatarDtoVariant2)
            {
                expressiveAvatarDtoVariant2?.Invoke(ExpressiveAvatarDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExpressiveAvatarDtoVariant1,
                typeof(global::G.ExpressiveAvatarDtoVariant1),
                ExpressiveAvatarDtoVariant2,
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
        public bool Equals(ExpressiveAvatarDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ExpressiveAvatarDtoVariant1?>.Default.Equals(ExpressiveAvatarDtoVariant1, other.ExpressiveAvatarDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ExpressiveAvatarDtoVariant2, other.ExpressiveAvatarDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExpressiveAvatarDto obj1, ExpressiveAvatarDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExpressiveAvatarDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExpressiveAvatarDto obj1, ExpressiveAvatarDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExpressiveAvatarDto o && Equals(o);
        }
    }
}
