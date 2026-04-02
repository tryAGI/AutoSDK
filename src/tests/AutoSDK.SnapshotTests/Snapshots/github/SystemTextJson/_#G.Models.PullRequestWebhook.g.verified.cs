//HintName: G.Models.PullRequestWebhook.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PullRequestWebhook : global::System.IEquatable<PullRequestWebhook>
    {
        /// <summary>
        /// Pull requests let you tell others about changes you've pushed to a repository on GitHub. Once a pull request is sent, interested parties can review the set of changes, discuss potential modifications, and even push follow-up commits if necessary.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PullRequest? PullRequest { get; init; }
#else
        public global::G.PullRequest? PullRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequest))]
#endif
        public bool IsPullRequest => PullRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PullRequestWebhookVariant2? PullRequestWebhookVariant2 { get; init; }
#else
        public global::G.PullRequestWebhookVariant2? PullRequestWebhookVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestWebhookVariant2))]
#endif
        public bool IsPullRequestWebhookVariant2 => PullRequestWebhookVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PullRequestWebhook(global::G.PullRequest value) => new PullRequestWebhook((global::G.PullRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PullRequest?(PullRequestWebhook @this) => @this.PullRequest;

        /// <summary>
        /// 
        /// </summary>
        public PullRequestWebhook(global::G.PullRequest? value)
        {
            PullRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PullRequestWebhook(global::G.PullRequestWebhookVariant2 value) => new PullRequestWebhook((global::G.PullRequestWebhookVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PullRequestWebhookVariant2?(PullRequestWebhook @this) => @this.PullRequestWebhookVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PullRequestWebhook(global::G.PullRequestWebhookVariant2? value)
        {
            PullRequestWebhookVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PullRequestWebhook(
            global::G.PullRequest? pullRequest,
            global::G.PullRequestWebhookVariant2? pullRequestWebhookVariant2
            )
        {
            PullRequest = pullRequest;
            PullRequestWebhookVariant2 = pullRequestWebhookVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PullRequestWebhookVariant2 as object ??
            PullRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PullRequest?.ToString() ??
            PullRequestWebhookVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPullRequest && IsPullRequestWebhookVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PullRequest?, TResult>? pullRequest = null,
            global::System.Func<global::G.PullRequestWebhookVariant2?, TResult>? pullRequestWebhookVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequest && pullRequest != null)
            {
                return pullRequest(PullRequest!);
            }
            else if (IsPullRequestWebhookVariant2 && pullRequestWebhookVariant2 != null)
            {
                return pullRequestWebhookVariant2(PullRequestWebhookVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PullRequest?>? pullRequest = null,
            global::System.Action<global::G.PullRequestWebhookVariant2?>? pullRequestWebhookVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsPullRequestWebhookVariant2)
            {
                pullRequestWebhookVariant2?.Invoke(PullRequestWebhookVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PullRequest,
                typeof(global::G.PullRequest),
                PullRequestWebhookVariant2,
                typeof(global::G.PullRequestWebhookVariant2),
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
        public bool Equals(PullRequestWebhook other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PullRequest?>.Default.Equals(PullRequest, other.PullRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PullRequestWebhookVariant2?>.Default.Equals(PullRequestWebhookVariant2, other.PullRequestWebhookVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PullRequestWebhook obj1, PullRequestWebhook obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PullRequestWebhook>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PullRequestWebhook obj1, PullRequestWebhook obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PullRequestWebhook o && Equals(o);
        }
    }
}
