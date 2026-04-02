//HintName: G.Models.UsageLimitsPolicyResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UsageLimitsPolicyResponse : global::System.IEquatable<UsageLimitsPolicyResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageLimitsPolicy? UsageLimitsPolicy { get; init; }
#else
        public global::G.UsageLimitsPolicy? UsageLimitsPolicy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageLimitsPolicy))]
#endif
        public bool IsUsageLimitsPolicy => UsageLimitsPolicy != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UsageLimitsPolicyResponseVariant2? UsageLimitsPolicyResponseVariant2 { get; init; }
#else
        public global::G.UsageLimitsPolicyResponseVariant2? UsageLimitsPolicyResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageLimitsPolicyResponseVariant2))]
#endif
        public bool IsUsageLimitsPolicyResponseVariant2 => UsageLimitsPolicyResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsageLimitsPolicyResponse(global::G.UsageLimitsPolicy value) => new UsageLimitsPolicyResponse((global::G.UsageLimitsPolicy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageLimitsPolicy?(UsageLimitsPolicyResponse @this) => @this.UsageLimitsPolicy;

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsPolicyResponse(global::G.UsageLimitsPolicy? value)
        {
            UsageLimitsPolicy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsageLimitsPolicyResponse(global::G.UsageLimitsPolicyResponseVariant2 value) => new UsageLimitsPolicyResponse((global::G.UsageLimitsPolicyResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UsageLimitsPolicyResponseVariant2?(UsageLimitsPolicyResponse @this) => @this.UsageLimitsPolicyResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsPolicyResponse(global::G.UsageLimitsPolicyResponseVariant2? value)
        {
            UsageLimitsPolicyResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsPolicyResponse(
            global::G.UsageLimitsPolicy? usageLimitsPolicy,
            global::G.UsageLimitsPolicyResponseVariant2? usageLimitsPolicyResponseVariant2
            )
        {
            UsageLimitsPolicy = usageLimitsPolicy;
            UsageLimitsPolicyResponseVariant2 = usageLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UsageLimitsPolicyResponseVariant2 as object ??
            UsageLimitsPolicy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UsageLimitsPolicy?.ToString() ??
            UsageLimitsPolicyResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUsageLimitsPolicy && IsUsageLimitsPolicyResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UsageLimitsPolicy?, TResult>? usageLimitsPolicy = null,
            global::System.Func<global::G.UsageLimitsPolicyResponseVariant2?, TResult>? usageLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageLimitsPolicy && usageLimitsPolicy != null)
            {
                return usageLimitsPolicy(UsageLimitsPolicy!);
            }
            else if (IsUsageLimitsPolicyResponseVariant2 && usageLimitsPolicyResponseVariant2 != null)
            {
                return usageLimitsPolicyResponseVariant2(UsageLimitsPolicyResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UsageLimitsPolicy?>? usageLimitsPolicy = null,
            global::System.Action<global::G.UsageLimitsPolicyResponseVariant2?>? usageLimitsPolicyResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageLimitsPolicy)
            {
                usageLimitsPolicy?.Invoke(UsageLimitsPolicy!);
            }
            else if (IsUsageLimitsPolicyResponseVariant2)
            {
                usageLimitsPolicyResponseVariant2?.Invoke(UsageLimitsPolicyResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UsageLimitsPolicy,
                typeof(global::G.UsageLimitsPolicy),
                UsageLimitsPolicyResponseVariant2,
                typeof(global::G.UsageLimitsPolicyResponseVariant2),
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
        public bool Equals(UsageLimitsPolicyResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UsageLimitsPolicy?>.Default.Equals(UsageLimitsPolicy, other.UsageLimitsPolicy) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UsageLimitsPolicyResponseVariant2?>.Default.Equals(UsageLimitsPolicyResponseVariant2, other.UsageLimitsPolicyResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UsageLimitsPolicyResponse obj1, UsageLimitsPolicyResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsageLimitsPolicyResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UsageLimitsPolicyResponse obj1, UsageLimitsPolicyResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsageLimitsPolicyResponse o && Equals(o);
        }
    }
}
