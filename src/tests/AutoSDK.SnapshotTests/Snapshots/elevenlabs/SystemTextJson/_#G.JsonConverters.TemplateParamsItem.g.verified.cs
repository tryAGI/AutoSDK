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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WhatsAppTemplateHeaderComponentParams? header = default;
            if (discriminator?.Type == global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateHeaderComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateHeaderComponentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateHeaderComponentParams)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WhatsAppTemplateBodyComponentParams? body = default;
            if (discriminator?.Type == global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Body)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateBodyComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateBodyComponentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateBodyComponentParams)}");
                body = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WhatsAppTemplateButtonComponentParams? button = default;
            if (discriminator?.Type == global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Button)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateButtonComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateButtonComponentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateButtonComponentParams)}");
                button = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateHeaderComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateHeaderComponentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateHeaderComponentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateBodyComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateBodyComponentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateBodyComponentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Body!, typeInfo);
            }
            else if (value.IsButton)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateButtonComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateButtonComponentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateButtonComponentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Button!, typeInfo);
            }
        }
    }
}