﻿//HintName: G.JsonConverters.RepositoriesItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoriesItem>
    {
        /// <inheritdoc />
        public override global::G.RepositoriesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionDetailedJobOutRepositorieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionDetailedJobOutRepositorieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompletionDetailedJobOutRepositorieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GithubRepositoryOut? github = default;
            if (discriminator?.Type == global::G.CompletionDetailedJobOutRepositorieDiscriminatorType.Github)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GithubRepositoryOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GithubRepositoryOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GithubRepositoryOut)}");
                github = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RepositoriesItem(
                discriminator?.Type,
                github
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoriesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGithub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GithubRepositoryOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GithubRepositoryOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GithubRepositoryOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Github, typeInfo);
            }
        }
    }
}