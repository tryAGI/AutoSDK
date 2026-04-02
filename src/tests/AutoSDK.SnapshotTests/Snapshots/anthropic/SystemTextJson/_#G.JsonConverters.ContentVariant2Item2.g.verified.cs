//HintName: G.JsonConverters.ContentVariant2Item2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentVariant2Item2>
    {
        /// <inheritdoc />
        public override global::G.ContentVariant2Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestToolResultBlockContentVariant2ItemDiscriminator>(ref readerCopy, options);

            global::G.RequestTextBlock? text = default;
            if (discriminator?.Type == global::G.RequestToolResultBlockContentVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestTextBlock>(ref reader, options);
            }
            global::G.RequestImageBlock? image = default;
            if (discriminator?.Type == global::G.RequestToolResultBlockContentVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RequestImageBlock>(ref reader, options);
            }

            var __value = new global::G.ContentVariant2Item2(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentVariant2Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.RequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.RequestImageBlock), options);
            }
        }
    }
}