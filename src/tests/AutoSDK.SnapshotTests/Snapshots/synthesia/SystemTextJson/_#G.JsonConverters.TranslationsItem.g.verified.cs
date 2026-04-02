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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetVideoTranslationsApiResponseTranslationDiscriminator>(ref readerCopy, options);

            global::G.TranslationStatusApiItemSuccess? complete = default;
            if (discriminator?.Status == global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Complete)
            {
                complete = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranslationStatusApiItemSuccess>(ref reader, options);
            }
            global::G.TranslationStatusApiItemError? error = default;
            if (discriminator?.Status == global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Error)
            {
                error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranslationStatusApiItemError>(ref reader, options);
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

            if (value.IsComplete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Complete, typeof(global::G.TranslationStatusApiItemSuccess), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::G.TranslationStatusApiItemError), options);
            }
        }
    }
}