//HintName: G.Models.WebhookPullRequestReviewRequested.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebhookPullRequestReviewRequested : global::System.IEquatable<WebhookPullRequestReviewRequested>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestedVariant1? Value1 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestedVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant1 value) => new WebhookPullRequestReviewRequested(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestedVariant1?(WebhookPullRequestReviewRequested @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestedVariant2? Value2 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestedVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant2 value) => new WebhookPullRequestReviewRequested(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestedVariant2?(WebhookPullRequestReviewRequested @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequested(
            global::G.WebhookPullRequestReviewRequestedVariant1? value1,
            global::G.WebhookPullRequestReviewRequestedVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookPullRequestReviewRequestedVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.WebhookPullRequestReviewRequestedVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookPullRequestReviewRequestedVariant1?>? value1 = null,
            global::System.Action<global::G.WebhookPullRequestReviewRequestedVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.WebhookPullRequestReviewRequestedVariant1),
                Value2,
                typeof(global::G.WebhookPullRequestReviewRequestedVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(WebhookPullRequestReviewRequested other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestedVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestedVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookPullRequestReviewRequested obj1, WebhookPullRequestReviewRequested obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookPullRequestReviewRequested>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookPullRequestReviewRequested obj1, WebhookPullRequestReviewRequested obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookPullRequestReviewRequested o && Equals(o);
        }
    }
}
