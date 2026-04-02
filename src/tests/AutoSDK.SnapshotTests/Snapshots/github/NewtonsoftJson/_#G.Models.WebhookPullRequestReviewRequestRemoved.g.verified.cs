//HintName: G.Models.WebhookPullRequestReviewRequestRemoved.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebhookPullRequestReviewRequestRemoved : global::System.IEquatable<WebhookPullRequestReviewRequestRemoved>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestRemovedVariant1? WebhookPullRequestReviewRequestRemovedVariant1 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestRemovedVariant1? WebhookPullRequestReviewRequestRemovedVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookPullRequestReviewRequestRemovedVariant1))]
#endif
        public bool IsWebhookPullRequestReviewRequestRemovedVariant1 => WebhookPullRequestReviewRequestRemovedVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestRemovedVariant2? WebhookPullRequestReviewRequestRemovedVariant2 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestRemovedVariant2? WebhookPullRequestReviewRequestRemovedVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookPullRequestReviewRequestRemovedVariant2))]
#endif
        public bool IsWebhookPullRequestReviewRequestRemovedVariant2 => WebhookPullRequestReviewRequestRemovedVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant1 value) => new WebhookPullRequestReviewRequestRemoved((global::G.WebhookPullRequestReviewRequestRemovedVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestRemovedVariant1?(WebhookPullRequestReviewRequestRemoved @this) => @this.WebhookPullRequestReviewRequestRemovedVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant1? value)
        {
            WebhookPullRequestReviewRequestRemovedVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant2 value) => new WebhookPullRequestReviewRequestRemoved((global::G.WebhookPullRequestReviewRequestRemovedVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestRemovedVariant2?(WebhookPullRequestReviewRequestRemoved @this) => @this.WebhookPullRequestReviewRequestRemovedVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant2? value)
        {
            WebhookPullRequestReviewRequestRemovedVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequestRemoved(
            global::G.WebhookPullRequestReviewRequestRemovedVariant1? webhookPullRequestReviewRequestRemovedVariant1,
            global::G.WebhookPullRequestReviewRequestRemovedVariant2? webhookPullRequestReviewRequestRemovedVariant2
            )
        {
            WebhookPullRequestReviewRequestRemovedVariant1 = webhookPullRequestReviewRequestRemovedVariant1;
            WebhookPullRequestReviewRequestRemovedVariant2 = webhookPullRequestReviewRequestRemovedVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebhookPullRequestReviewRequestRemovedVariant2 as object ??
            WebhookPullRequestReviewRequestRemovedVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebhookPullRequestReviewRequestRemovedVariant1?.ToString() ??
            WebhookPullRequestReviewRequestRemovedVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhookPullRequestReviewRequestRemovedVariant1 && !IsWebhookPullRequestReviewRequestRemovedVariant2 || !IsWebhookPullRequestReviewRequestRemovedVariant1 && IsWebhookPullRequestReviewRequestRemovedVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookPullRequestReviewRequestRemovedVariant1?, TResult>? webhookPullRequestReviewRequestRemovedVariant1 = null,
            global::System.Func<global::G.WebhookPullRequestReviewRequestRemovedVariant2?, TResult>? webhookPullRequestReviewRequestRemovedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestRemovedVariant1 && webhookPullRequestReviewRequestRemovedVariant1 != null)
            {
                return webhookPullRequestReviewRequestRemovedVariant1(WebhookPullRequestReviewRequestRemovedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestRemovedVariant2 && webhookPullRequestReviewRequestRemovedVariant2 != null)
            {
                return webhookPullRequestReviewRequestRemovedVariant2(WebhookPullRequestReviewRequestRemovedVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookPullRequestReviewRequestRemovedVariant1?>? webhookPullRequestReviewRequestRemovedVariant1 = null,
            global::System.Action<global::G.WebhookPullRequestReviewRequestRemovedVariant2?>? webhookPullRequestReviewRequestRemovedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestRemovedVariant1)
            {
                webhookPullRequestReviewRequestRemovedVariant1?.Invoke(WebhookPullRequestReviewRequestRemovedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestRemovedVariant2)
            {
                webhookPullRequestReviewRequestRemovedVariant2?.Invoke(WebhookPullRequestReviewRequestRemovedVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookPullRequestReviewRequestRemovedVariant1,
                typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1),
                WebhookPullRequestReviewRequestRemovedVariant2,
                typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2),
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
        public bool Equals(WebhookPullRequestReviewRequestRemoved other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestRemovedVariant1?>.Default.Equals(WebhookPullRequestReviewRequestRemovedVariant1, other.WebhookPullRequestReviewRequestRemovedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestRemovedVariant2?>.Default.Equals(WebhookPullRequestReviewRequestRemovedVariant2, other.WebhookPullRequestReviewRequestRemovedVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookPullRequestReviewRequestRemoved obj1, WebhookPullRequestReviewRequestRemoved obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookPullRequestReviewRequestRemoved>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookPullRequestReviewRequestRemoved obj1, WebhookPullRequestReviewRequestRemoved obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookPullRequestReviewRequestRemoved o && Equals(o);
        }
    }
}
