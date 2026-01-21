//HintName: G.JsonConverters.RepositoriesVariant1Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoriesVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.RepositoriesVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JobInRepositoriesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JobInRepositoriesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.JobInRepositoriesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GithubRepositoryIn? github = default;
            if (discriminator?.Type == global::G.JobInRepositoriesVariant1ItemDiscriminatorType.Github)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GithubRepositoryIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GithubRepositoryIn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GithubRepositoryIn)}");
                github = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RepositoriesVariant1Item(
                discriminator?.Type,
                github
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoriesVariant1Item value,
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