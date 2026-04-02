//HintName: G.JsonConverters.Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source>
    {
        /// <inheritdoc />
        public override global::G.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageContentSourceDiscriminator>(ref readerCopy, options);

            global::G.UrlImage? url = default;
            if (discriminator?.Type == global::G.ImageContentSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UrlImage>(ref reader, options);
            }
            global::G.Base64Image? base64 = default;
            if (discriminator?.Type == global::G.ImageContentSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Base64Image>(ref reader, options);
            }
            global::G.LettaImage? letta = default;
            if (discriminator?.Type == global::G.ImageContentSourceDiscriminatorType.Letta)
            {
                letta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaImage>(ref reader, options);
            }

            var __value = new global::G.Source(
                discriminator?.Type,
                url,

                base64,

                letta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::G.UrlImage), options);
            }
            else if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::G.Base64Image), options);
            }
            else if (value.IsLetta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Letta, typeof(global::G.LettaImage), options);
            }
        }
    }
}