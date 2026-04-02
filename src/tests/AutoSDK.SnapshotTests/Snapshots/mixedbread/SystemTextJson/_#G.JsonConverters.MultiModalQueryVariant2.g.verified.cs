//HintName: G.JsonConverters.MultiModalQueryVariant2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MultiModalQueryVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MultiModalQueryVariant2>
    {
        /// <inheritdoc />
        public override global::G.MultiModalQueryVariant2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MultiModalQueryVariant2Discriminator>(ref readerCopy, options);

            global::G.ImageUrlInput2? imageUrl = default;
            if (discriminator?.Type == global::G.MultiModalQueryVariant2DiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageUrlInput2>(ref reader, options);
            }
            global::G.TextInput? text = default;
            if (discriminator?.Type == global::G.MultiModalQueryVariant2DiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextInput>(ref reader, options);
            }

            var __value = new global::G.MultiModalQueryVariant2(
                discriminator?.Type,
                imageUrl,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MultiModalQueryVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::G.ImageUrlInput2), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextInput), options);
            }
        }
    }
}