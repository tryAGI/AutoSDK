//HintName: G.JsonConverters.ShotstackGeneratedAssetOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ShotstackGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ShotstackGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::G.ShotstackGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShotstackGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ShotstackTextToSpeechOptions? textToSpeech = default;
            if (discriminator?.Type == global::G.ShotstackGeneratedAssetOptionsDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackTextToSpeechOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShotstackTextToSpeechOptions)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ShotstackTextToImageOptions? textToImage = default;
            if (discriminator?.Type == global::G.ShotstackGeneratedAssetOptionsDiscriminatorType.TextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackTextToImageOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackTextToImageOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShotstackTextToImageOptions)}");
                textToImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ShotstackTextGeneratorOptions? textGenerator = default;
            if (discriminator?.Type == global::G.ShotstackGeneratedAssetOptionsDiscriminatorType.TextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackTextGeneratorOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShotstackTextGeneratorOptions)}");
                textGenerator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ShotstackImageToVideoOptions? imageToVideo = default;
            if (discriminator?.Type == global::G.ShotstackGeneratedAssetOptionsDiscriminatorType.ImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackImageToVideoOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackImageToVideoOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShotstackImageToVideoOptions)}");
                imageToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ShotstackGeneratedAssetOptions(
                discriminator?.Type,
                textToSpeech,

                textToImage,

                textGenerator,

                imageToVideo
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ShotstackGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackTextToSpeechOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackTextToSpeechOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech, typeInfo);
            }
            else if (value.IsTextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackTextToImageOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackTextToImageOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackTextToImageOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToImage, typeInfo);
            }
            else if (value.IsTextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackTextGeneratorOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackTextGeneratorOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGenerator, typeInfo);
            }
            else if (value.IsImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackImageToVideoOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackImageToVideoOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackImageToVideoOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageToVideo, typeInfo);
            }
        }
    }
}