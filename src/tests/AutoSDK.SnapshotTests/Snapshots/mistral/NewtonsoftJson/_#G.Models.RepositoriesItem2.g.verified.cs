//HintName: G.Models.RepositoriesItem2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RepositoriesItem2 : global::System.IEquatable<RepositoriesItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobInRepositorieDiscriminatorType? Type { get; }

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
        public static implicit operator RepositoriesItem2(global::G.GithubRepositoryIn value) => new RepositoriesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GithubRepositoryIn?(RepositoriesItem2 @this) => @this.Github;

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem2(global::G.GithubRepositoryIn? value)
        {
            Github = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem2(
            global::G.JobInRepositorieDiscriminatorType? type,
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
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RepositoriesItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GithubRepositoryIn?>.Default.Equals(Github, other.Github) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoriesItem2 obj1, RepositoriesItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoriesItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoriesItem2 obj1, RepositoriesItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoriesItem2 o && Equals(o);
        }
    }
}
