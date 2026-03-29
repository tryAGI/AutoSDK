//HintName: G.JsonConverters.Asset1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Asset1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Asset1>
    {
        /// <inheritdoc />
        public override global::G.Asset1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssetAsset1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssetAsset1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssetAsset1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UploadedImage? uploadedImage = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.UploadedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UploadedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UploadedImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UploadedImage)}");
                uploadedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UploadedAudio? uploadedAudio = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.UploadedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UploadedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UploadedAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UploadedAudio)}");
                uploadedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UploadedVideo? uploadedVideo = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.UploadedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UploadedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UploadedVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UploadedVideo)}");
                uploadedVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GeneratedAudio? generatedAudio = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.GeneratedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GeneratedAudio)}");
                generatedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GeneratedImage? generatedImage = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.GeneratedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GeneratedImage)}");
                generatedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GeneratedVideo? generatedVideo = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.GeneratedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GeneratedVideo)}");
                generatedVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.Voice? voice = default;
            if (discriminator?.Type == global::G.AssetAsset1DiscriminatorType.Voice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Voice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Voice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.Voice)}");
                voice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Asset1(
                discriminator?.Type,
                uploadedImage,

                uploadedAudio,

                uploadedVideo,

                generatedAudio,

                generatedImage,

                generatedVideo,

                voice
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Asset1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUploadedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UploadedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UploadedImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UploadedImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadedImage, typeInfo);
            }
            else if (value.IsUploadedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UploadedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UploadedAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UploadedAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadedAudio, typeInfo);
            }
            else if (value.IsUploadedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UploadedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UploadedVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UploadedVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadedVideo, typeInfo);
            }
            else if (value.IsGeneratedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeneratedAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeneratedAudio, typeInfo);
            }
            else if (value.IsGeneratedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeneratedImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeneratedImage, typeInfo);
            }
            else if (value.IsGeneratedVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeneratedVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeneratedVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeneratedVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeneratedVideo, typeInfo);
            }
            else if (value.IsVoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Voice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Voice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Voice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voice, typeInfo);
            }
        }
    }
}