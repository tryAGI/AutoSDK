//HintName: G.JsonConverters.InsightControllerUpdateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InsightControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::G.InsightControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InsightControllerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InsightControllerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InsightControllerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UpdateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateBarInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateBarInsightFromCallTableDTO)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Pie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdatePieInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdatePieInsightFromCallTableDTO)}");
                pie = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateLineInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateLineInsightFromCallTableDTO)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::G.InsightControllerUpdateRequestDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTextInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateTextInsightFromCallTableDTO)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.InsightControllerUpdateRequest(
                discriminator?.Type,
                bar,

                pie,

                line,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InsightControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateBarInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateBarInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar!, typeInfo);
            }
            else if (value.IsPie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdatePieInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdatePieInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie!, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateLineInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateLineInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTextInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateTextInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}