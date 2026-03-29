//HintName: G.JsonConverters.OpenAiGeneratedAssetOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OpenAiGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OpenAiGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::G.OpenAiGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OpenAiGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.OpenAiTextGeneratorOptions? textGenerator = default;
            if (discriminator?.Type == global::G.OpenAiGeneratedAssetOptionsDiscriminatorType.TextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiTextGeneratorOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OpenAiTextGeneratorOptions)}");
                textGenerator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.OpenAiGeneratedAssetOptions(
                discriminator?.Type,
                textGenerator
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OpenAiGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiTextGeneratorOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiTextGeneratorOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGenerator, typeInfo);
            }
        }
    }
}