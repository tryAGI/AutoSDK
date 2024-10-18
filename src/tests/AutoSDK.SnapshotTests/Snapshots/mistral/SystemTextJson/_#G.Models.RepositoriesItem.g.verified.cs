//HintName: G.Models.RepositoriesItem.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RepositoriesItem : global::System.IEquatable<RepositoriesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.DetailedJobOutRepositorieDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GithubRepositoryOut? GithubRepositoryOut { get; init; }
#else
        public global::G.GithubRepositoryOut? GithubRepositoryOut { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GithubRepositoryOut))]
#endif
        public bool IsGithubRepositoryOut => GithubRepositoryOut != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoriesItem(global::G.GithubRepositoryOut value) => new RepositoriesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GithubRepositoryOut?(RepositoriesItem @this) => @this.GithubRepositoryOut;

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem(global::G.GithubRepositoryOut? value)
        {
            GithubRepositoryOut = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem(
            global::G.DetailedJobOutRepositorieDiscriminatorType? type,
            global::G.GithubRepositoryOut? githubRepositoryOut
            )
        {
            Type = type;

            GithubRepositoryOut = githubRepositoryOut;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GithubRepositoryOut as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGithubRepositoryOut;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GithubRepositoryOut?, TResult>? githubRepositoryOut = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepositoryOut && githubRepositoryOut != null)
            {
                return githubRepositoryOut(GithubRepositoryOut!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GithubRepositoryOut?>? githubRepositoryOut = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepositoryOut)
            {
                githubRepositoryOut?.Invoke(GithubRepositoryOut!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GithubRepositoryOut,
                typeof(global::G.GithubRepositoryOut),
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
        public bool Equals(RepositoriesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GithubRepositoryOut?>.Default.Equals(GithubRepositoryOut, other.GithubRepositoryOut) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoriesItem obj1, RepositoriesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoriesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoriesItem obj1, RepositoriesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoriesItem o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.RepositoriesItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RepositoriesItem),
                jsonSerializerContext) as global::G.RepositoriesItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoriesItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoriesItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
