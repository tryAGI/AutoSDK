//HintName: G.JsonConverters.SourcesItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourcesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SourcesItem2>
    {
        /// <inheritdoc />
        public override global::G.SourcesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.FileSourceRequest? file = default;
            if (discriminator?.Kind == global::G.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FileSourceRequest)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HttpSourceRequest? http = default;
            if (discriminator?.Kind == global::G.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.Http)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HttpSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HttpSourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HttpSourceRequest)}");
                http = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.S3SourceRequest? s3 = default;
            if (discriminator?.Kind == global::G.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3SourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3SourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.S3SourceRequest)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.SourcesItem2(
                discriminator?.Kind,
                file,

                http,

                s3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SourcesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSourceRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSourceRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HttpSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HttpSourceRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HttpSourceRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Http, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3SourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3SourceRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.S3SourceRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3, typeInfo);
            }
        }
    }
}