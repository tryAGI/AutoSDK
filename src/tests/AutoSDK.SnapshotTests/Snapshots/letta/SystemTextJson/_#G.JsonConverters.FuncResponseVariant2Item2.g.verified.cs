//HintName: G.JsonConverters.FuncResponseVariant2Item2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FuncResponseVariant2Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FuncResponseVariant2Item2>
    {
        /// <inheritdoc />
        public override global::G.FuncResponseVariant2Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator>(ref readerCopy, options);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextContent>(ref reader, options);
            }
            global::G.ImageContent? image = default;
            if (discriminator?.Type == global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageContent>(ref reader, options);
            }

            var __value = new global::G.FuncResponseVariant2Item2(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FuncResponseVariant2Item2 value,
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