//HintName: G.Models.ExpressiveVideoBackground.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExpressiveVideoBackground : global::System.IEquatable<ExpressiveVideoBackground>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpressiveVideoBackgroundVariant1? ExpressiveVideoBackgroundVariant1 { get; init; }
#else
        public global::G.ExpressiveVideoBackgroundVariant1? ExpressiveVideoBackgroundVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveVideoBackgroundVariant1))]
#endif
        public bool IsExpressiveVideoBackgroundVariant1 => ExpressiveVideoBackgroundVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpressiveVideoBackgroundVariant2? ExpressiveVideoBackgroundVariant2 { get; init; }
#else
        public global::G.ExpressiveVideoBackgroundVariant2? ExpressiveVideoBackgroundVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveVideoBackgroundVariant2))]
#endif
        public bool IsExpressiveVideoBackgroundVariant2 => ExpressiveVideoBackgroundVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExpressiveVideoBackground(global::G.ExpressiveVideoBackgroundVariant1 value) => new ExpressiveVideoBackground((global::G.ExpressiveVideoBackgroundVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpressiveVideoBackgroundVariant1?(ExpressiveVideoBackground @this) => @this.ExpressiveVideoBackgroundVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveVideoBackground(global::G.ExpressiveVideoBackgroundVariant1? value)
        {
            ExpressiveVideoBackgroundVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExpressiveVideoBackground(global::G.ExpressiveVideoBackgroundVariant2 value) => new ExpressiveVideoBackground((global::G.ExpressiveVideoBackgroundVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpressiveVideoBackgroundVariant2?(ExpressiveVideoBackground @this) => @this.ExpressiveVideoBackgroundVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveVideoBackground(global::G.ExpressiveVideoBackgroundVariant2? value)
        {
            ExpressiveVideoBackgroundVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExpressiveVideoBackground(
            global::G.ExpressiveVideoBackgroundVariant1? expressiveVideoBackgroundVariant1,
            global::G.ExpressiveVideoBackgroundVariant2? expressiveVideoBackgroundVariant2
            )
        {
            ExpressiveVideoBackgroundVariant1 = expressiveVideoBackgroundVariant1;
            ExpressiveVideoBackgroundVariant2 = expressiveVideoBackgroundVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExpressiveVideoBackgroundVariant2 as object ??
            ExpressiveVideoBackgroundVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExpressiveVideoBackgroundVariant1?.ToString() ??
            ExpressiveVideoBackgroundVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExpressiveVideoBackgroundVariant1 || IsExpressiveVideoBackgroundVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ExpressiveVideoBackgroundVariant1?, TResult>? expressiveVideoBackgroundVariant1 = null,
            global::System.Func<global::G.ExpressiveVideoBackgroundVariant2?, TResult>? expressiveVideoBackgroundVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressiveVideoBackgroundVariant1 && expressiveVideoBackgroundVariant1 != null)
            {
                return expressiveVideoBackgroundVariant1(ExpressiveVideoBackgroundVariant1!);
            }
            else if (IsExpressiveVideoBackgroundVariant2 && expressiveVideoBackgroundVariant2 != null)
            {
                return expressiveVideoBackgroundVariant2(ExpressiveVideoBackgroundVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ExpressiveVideoBackgroundVariant1?>? expressiveVideoBackgroundVariant1 = null,
            global::System.Action<global::G.ExpressiveVideoBackgroundVariant2?>? expressiveVideoBackgroundVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressiveVideoBackgroundVariant1)
            {
                expressiveVideoBackgroundVariant1?.Invoke(ExpressiveVideoBackgroundVariant1!);
            }
            else if (IsExpressiveVideoBackgroundVariant2)
            {
                expressiveVideoBackgroundVariant2?.Invoke(ExpressiveVideoBackgroundVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExpressiveVideoBackgroundVariant1,
                typeof(global::G.ExpressiveVideoBackgroundVariant1),
                ExpressiveVideoBackgroundVariant2,
                typeof(global::G.ExpressiveVideoBackgroundVariant2),
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
        public bool Equals(ExpressiveVideoBackground other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ExpressiveVideoBackgroundVariant1?>.Default.Equals(ExpressiveVideoBackgroundVariant1, other.ExpressiveVideoBackgroundVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExpressiveVideoBackgroundVariant2?>.Default.Equals(ExpressiveVideoBackgroundVariant2, other.ExpressiveVideoBackgroundVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExpressiveVideoBackground obj1, ExpressiveVideoBackground obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExpressiveVideoBackground>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExpressiveVideoBackground obj1, ExpressiveVideoBackground obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExpressiveVideoBackground o && Equals(o);
        }
    }
}
