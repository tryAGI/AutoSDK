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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WhatsAppTemplateTextParam? text = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateTextParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateTextParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateTextParam)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WhatsAppTemplateImageParam? image = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateImageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateImageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateImageParam)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WhatsAppTemplateDocumentParam? document = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Document)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateDocumentParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateDocumentParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateDocumentParam)}");
                document = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WhatsAppTemplateLocationParam? location = default;
            if (discriminator?.Type == global::G.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Location)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateLocationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WhatsAppTemplateLocationParam)}");
                location = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateTextParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateTextParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateTextParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateImageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateImageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateImageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateDocumentParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateDocumentParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateDocumentParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document!, typeInfo);
            }
            else if (value.IsLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WhatsAppTemplateLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WhatsAppTemplateLocationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WhatsAppTemplateLocationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Location!, typeInfo);
            }
        }
    }
}