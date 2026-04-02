//HintName: G.JsonConverters.ContentVariant2Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::G.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestToolResultBlockContentVariant2ItemDiscriminator>(ref readerCopy, options);

            global::G.BetaRequestTextBlock? text = default;
            if (discriminator?.Type == global::G.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestTextBlock>(ref reader, options);
            }
            global::G.BetaRequestImageBlock? image = default;
            if (discriminator?.Type == global::G.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestImageBlock>(ref reader, options);
            }

            var __value = new global::G.ContentVariant2Item(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.BetaRequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.BetaRequestImageBlock), options);
            }
        }
    }
}