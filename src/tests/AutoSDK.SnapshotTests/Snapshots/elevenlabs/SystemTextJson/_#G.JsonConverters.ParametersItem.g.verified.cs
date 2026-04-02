//HintName: G.JsonConverters.ParametersItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ParametersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ParametersItem>
    {
        /// <inheritdoc />
        public override global::G.ParametersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator>(ref readerCopy, options);

            global::G.WhatsAppTemplateTextParam? text = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateTextParam>(ref reader, options);
            }
            global::G.WhatsAppTemplateImageParam? image = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateImageParam>(ref reader, options);
            }
            global::G.WhatsAppTemplateDocumentParam? document = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateDocumentParam>(ref reader, options);
            }
            global::G.WhatsAppTemplateLocationParam? location = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Location)
            {
                location = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateLocationParam>(ref reader, options);
            }

            var __value = new global::G.ParametersItem(
                discriminator?.Type,
                text,

                image,

                document,

                location
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ParametersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.WhatsAppTemplateTextParam), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.WhatsAppTemplateImageParam), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::G.WhatsAppTemplateDocumentParam), options);
            }
            else if (value.IsLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Location, typeof(global::G.WhatsAppTemplateLocationParam), options);
            }
        }
    }
}