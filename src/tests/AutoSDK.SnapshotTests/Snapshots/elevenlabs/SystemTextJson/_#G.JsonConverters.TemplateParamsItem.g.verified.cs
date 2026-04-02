//HintName: G.JsonConverters.TemplateParamsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TemplateParamsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TemplateParamsItem>
    {
        /// <inheritdoc />
        public override global::G.TemplateParamsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator>(ref readerCopy, options);

            global::G.WhatsAppTemplateHeaderComponentParams? header = default;
            if (discriminator?.Type == global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Header)
            {
                header = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateHeaderComponentParams>(ref reader, options);
            }
            global::G.WhatsAppTemplateBodyComponentParams? body = default;
            if (discriminator?.Type == global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Body)
            {
                body = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateBodyComponentParams>(ref reader, options);
            }
            global::G.WhatsAppTemplateButtonComponentParams? button = default;
            if (discriminator?.Type == global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Button)
            {
                button = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhatsAppTemplateButtonComponentParams>(ref reader, options);
            }

            var __value = new global::G.TemplateParamsItem(
                discriminator?.Type,
                header,

                body,

                button
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TemplateParamsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsHeader)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header, typeof(global::G.WhatsAppTemplateHeaderComponentParams), options);
            }
            else if (value.IsBody)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Body, typeof(global::G.WhatsAppTemplateBodyComponentParams), options);
            }
            else if (value.IsButton)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Button, typeof(global::G.WhatsAppTemplateButtonComponentParams), options);
            }
        }
    }
}