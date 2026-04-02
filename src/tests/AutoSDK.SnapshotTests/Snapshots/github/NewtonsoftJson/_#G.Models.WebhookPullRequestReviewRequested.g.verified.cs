//HintName: G.Models.WebhookPullRequestReviewRequested.g.cs
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
        public global::G.WebhookPullRequestReviewRequestedVariant1? WebhookPullRequestReviewRequestedVariant1 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestedVariant1? WebhookPullRequestReviewRequestedVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookPullRequestReviewRequestedVariant1))]
#endif
        public bool IsWebhookPullRequestReviewRequestedVariant1 => WebhookPullRequestReviewRequestedVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestedVariant2? WebhookPullRequestReviewRequestedVariant2 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestedVariant2? WebhookPullRequestReviewRequestedVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookPullRequestReviewRequestedVariant2))]
#endif
        public bool IsWebhookPullRequestReviewRequestedVariant2 => WebhookPullRequestReviewRequestedVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant1 value) => new WebhookPullRequestReviewRequested((global::G.WebhookPullRequestReviewRequestedVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestedVariant1?(WebhookPullRequestReviewRequested @this) => @this.WebhookPullRequestReviewRequestedVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant1? value)
        {
            WebhookPullRequestReviewRequestedVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant2 value) => new WebhookPullRequestReviewRequested((global::G.WebhookPullRequestReviewRequestedVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestedVariant2?(WebhookPullRequestReviewRequested @this) => @this.WebhookPullRequestReviewRequestedVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequested(global::G.WebhookPullRequestReviewRequestedVariant2? value)
        {
            WebhookPullRequestReviewRequestedVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequested(
            global::G.WebhookPullRequestReviewRequestedVariant1? webhookPullRequestReviewRequestedVariant1,
            global::G.WebhookPullRequestReviewRequestedVariant2? webhookPullRequestReviewRequestedVariant2
            )
        {
            WebhookPullRequestReviewRequestedVariant1 = webhookPullRequestReviewRequestedVariant1;
            WebhookPullRequestReviewRequestedVariant2 = webhookPullRequestReviewRequestedVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebhookPullRequestReviewRequestedVariant2 as object ??
            WebhookPullRequestReviewRequestedVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebhookPullRequestReviewRequestedVariant1?.ToString() ??
            WebhookPullRequestReviewRequestedVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhookPullRequestReviewRequestedVariant1 && !IsWebhookPullRequestReviewRequestedVariant2 || !IsWebhookPullRequestReviewRequestedVariant1 && IsWebhookPullRequestReviewRequestedVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookPullRequestReviewRequestedVariant1?, TResult>? webhookPullRequestReviewRequestedVariant1 = null,
            global::System.Func<global::G.WebhookPullRequestReviewRequestedVariant2?, TResult>? webhookPullRequestReviewRequestedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestedVariant1 && webhookPullRequestReviewRequestedVariant1 != null)
            {
                return webhookPullRequestReviewRequestedVariant1(WebhookPullRequestReviewRequestedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestedVariant2 && webhookPullRequestReviewRequestedVariant2 != null)
            {
                return webhookPullRequestReviewRequestedVariant2(WebhookPullRequestReviewRequestedVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookPullRequestReviewRequestedVariant1?>? webhookPullRequestReviewRequestedVariant1 = null,
            global::System.Action<global::G.WebhookPullRequestReviewRequestedVariant2?>? webhookPullRequestReviewRequestedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestedVariant1)
            {
                webhookPullRequestReviewRequestedVariant1?.Invoke(WebhookPullRequestReviewRequestedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestedVariant2)
            {
                webhookPullRequestReviewRequestedVariant2?.Invoke(WebhookPullRequestReviewRequestedVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookPullRequestReviewRequestedVariant1,
                typeof(global::G.WebhookPullRequestReviewRequestedVariant1),
                WebhookPullRequestReviewRequestedVariant2,
                typeof(global::G.WebhookPullRequestReviewRequestedVariant2),
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
        public bool Equals(WebhookPullRequestReviewRequested other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestedVariant1?>.Default.Equals(WebhookPullRequestReviewRequestedVariant1, other.WebhookPullRequestReviewRequestedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestedVariant2?>.Default.Equals(WebhookPullRequestReviewRequestedVariant2, other.WebhookPullRequestReviewRequestedVariant2) 
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
