//HintName: G.JsonConverters.Source2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Source2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source2>
    {
        /// <inheritdoc />
        public override global::G.Source2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaRequestImageBlockSourceDiscriminator>(ref readerCopy, options);

            global::G.BetaBase64ImageSource? base64 = default;
            if (discriminator?.Type == global::G.BetaRequestImageBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaBase64ImageSource>(ref reader, options);
            }
            global::G.BetaURLImageSource? url = default;
            if (discriminator?.Type == global::G.BetaRequestImageBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BetaURLImageSource>(ref reader, options);
            }

            var __value = new global::G.Source2(
                discriminator?.Type,
                base64,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::G.BetaBase64ImageSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::G.BetaURLImageSource), options);
            }
        }
    }
}