//HintName: G.Models.RepositoriesVariant1Item.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RepositoriesVariant1Item : global::System.IEquatable<RepositoriesVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobInRepositoriesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GithubRepositoryIn? Github { get; init; }
#else
        public global::G.GithubRepositoryIn? Github { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Github))]
#endif
        public bool IsGithub => Github != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoriesVariant1Item(global::G.GithubRepositoryIn value) => new RepositoriesVariant1Item((global::G.GithubRepositoryIn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GithubRepositoryIn?(RepositoriesVariant1Item @this) => @this.Github;

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesVariant1Item(global::G.GithubRepositoryIn? value)
        {
            Github = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesVariant1Item(
            global::G.JobInRepositoriesVariant1ItemDiscriminatorType? type,
            global::G.GithubRepositoryIn? github
            )
        {
            Type = type;

            Github = github;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Github as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Github?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGithub;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GithubRepositoryIn?, TResult>? github = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithub && github != null)
            {
                return github(Github!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GithubRepositoryIn?>? github = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithub)
            {
                github?.Invoke(Github!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Github,
                typeof(global::G.GithubRepositoryIn),
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
        public bool Equals(RepositoriesVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GithubRepositoryIn?>.Default.Equals(Github, other.Github) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoriesVariant1Item obj1, RepositoriesVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoriesVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoriesVariant1Item obj1, RepositoriesVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoriesVariant1Item o && Equals(o);
        }
    }
}
