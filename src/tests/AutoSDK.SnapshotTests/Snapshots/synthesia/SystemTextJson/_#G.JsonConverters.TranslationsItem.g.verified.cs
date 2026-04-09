//HintName: G.JsonConverters.TranslationsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TranslationsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TranslationsItem>
    {
        /// <inheritdoc />
        public override global::G.TranslationsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetVideoTranslationsApiResponseTranslationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetVideoTranslationsApiResponseTranslationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetVideoTranslationsApiResponseTranslationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TranslationStatusApiItemSuccess? complete = default;
            if (discriminator?.Status == global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Complete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranslationStatusApiItemSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranslationStatusApiItemSuccess> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranslationStatusApiItemSuccess)}");
                complete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TranslationStatusApiItemError? error = default;
            if (discriminator?.Status == global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranslationStatusApiItemError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranslationStatusApiItemError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranslationStatusApiItemError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.TranslationsItem(
                discriminator?.Status,
                complete,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TranslationsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsComplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranslationStatusApiItemSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranslationStatusApiItemSuccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranslationStatusApiItemSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Complete!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranslationStatusApiItemError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranslationStatusApiItemError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranslationStatusApiItemError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}