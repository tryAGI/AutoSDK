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
        public global::G.GithubRepositoryIn? GithubRepositoryIn { get; init; }
#else
        public global::G.GithubRepositoryIn? GithubRepositoryIn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GithubRepositoryIn))]
#endif
        public bool IsGithubRepositoryIn => GithubRepositoryIn != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoriesItem2(global::G.GithubRepositoryIn value) => new RepositoriesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GithubRepositoryIn?(RepositoriesItem2 @this) => @this.GithubRepositoryIn;

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem2(global::G.GithubRepositoryIn? value)
        {
            GithubRepositoryIn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem2(
            global::G.JobInRepositorieDiscriminatorType? type,
            global::G.GithubRepositoryIn? githubRepositoryIn
            )
        {
            Type = type;

            GithubRepositoryIn = githubRepositoryIn;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GithubRepositoryIn as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGithubRepositoryIn;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GithubRepositoryIn?, TResult>? githubRepositoryIn = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepositoryIn && githubRepositoryIn != null)
            {
                return githubRepositoryIn(GithubRepositoryIn!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GithubRepositoryIn?>? githubRepositoryIn = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepositoryIn)
            {
                githubRepositoryIn?.Invoke(GithubRepositoryIn!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GithubRepositoryIn,
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
                global::System.Collections.Generic.EqualityComparer<global::G.GithubRepositoryIn?>.Default.Equals(GithubRepositoryIn, other.GithubRepositoryIn) 
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoriesItem2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoriesItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
