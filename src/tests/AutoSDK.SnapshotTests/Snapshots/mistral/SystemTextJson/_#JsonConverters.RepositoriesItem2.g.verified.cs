//HintName: JsonConverters.RepositoriesItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoriesItem2>
    {
        /// <inheritdoc />
        public override global::G.RepositoriesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobInRepositorieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobInRepositorieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobInRepositorieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GithubRepositoryIn? github = default;
            if (discriminator?.Type == global::G.JobInRepositorieDiscriminatorType.Github)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GithubRepositoryIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GithubRepositoryIn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GithubRepositoryIn)}");
                github = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RepositoriesItem2(
                discriminator?.Type,
                github
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoriesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGithub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GithubRepositoryIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GithubRepositoryIn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GithubRepositoryIn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Github, typeInfo);
            }
        }
    }
}