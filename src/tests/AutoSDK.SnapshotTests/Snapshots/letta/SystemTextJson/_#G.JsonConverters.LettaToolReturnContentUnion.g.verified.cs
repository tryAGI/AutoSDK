//HintName: G.JsonConverters.LettaToolReturnContentUnion.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LettaToolReturnContentUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LettaToolReturnContentUnion>
    {
        /// <inheritdoc />
        public override global::G.LettaToolReturnContentUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaToolReturnContentUnionDiscriminator>(ref readerCopy, options);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.LettaToolReturnContentUnionDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextContent>(ref reader, options);
            }
            global::G.ImageContent? image = default;
            if (discriminator?.Type == global::G.LettaToolReturnContentUnionDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageContent>(ref reader, options);
            }

            var __value = new global::G.LettaToolReturnContentUnion(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LettaToolReturnContentUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextContent), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.ImageContent), options);
            }
        }
    }
}