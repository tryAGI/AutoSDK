//HintName: G.JsonConverters.Target3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Target3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Target3>
    {
        /// <inheritdoc />
        public override global::G.Target3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.InBodyTarget? inbody = default;
            if (discriminator?.Kind == global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Inbody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InBodyTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InBodyTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InBodyTarget)}");
                inbody = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ZipTarget? zip = default;
            if (discriminator?.Kind == global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Zip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ZipTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ZipTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ZipTarget)}");
                zip = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.S3Target? s3 = default;
            if (discriminator?.Kind == global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3Target), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3Target> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.S3Target)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PutTarget? put = default;
            if (discriminator?.Kind == global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Put)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PutTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PutTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PutTarget)}");
                put = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Target3(
                discriminator?.Kind,
                inbody,

                zip,

                s3,

                put
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Target3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInbody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InBodyTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InBodyTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InBodyTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inbody!, typeInfo);
            }
            else if (value.IsZip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ZipTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ZipTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ZipTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zip!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.S3Target), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.S3Target?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.S3Target).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsPut)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PutTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PutTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PutTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Put!, typeInfo);
            }
        }
    }
}