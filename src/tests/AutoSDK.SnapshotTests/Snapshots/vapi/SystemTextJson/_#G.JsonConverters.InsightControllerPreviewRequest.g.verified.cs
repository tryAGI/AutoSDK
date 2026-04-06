//HintName: G.JsonConverters.InsightControllerPreviewRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerPreviewRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InsightControllerPreviewRequest>
    {
        /// <inheritdoc />
        public override global::G.InsightControllerPreviewRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InsightControllerPreviewRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InsightControllerPreviewRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InsightControllerPreviewRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::G.InsightControllerPreviewRequestDiscriminatorType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateBarInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateBarInsightFromCallTableDTO)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::G.InsightControllerPreviewRequestDiscriminatorType.Pie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreatePieInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreatePieInsightFromCallTableDTO)}");
                pie = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::G.InsightControllerPreviewRequestDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLineInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateLineInsightFromCallTableDTO)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::G.InsightControllerPreviewRequestDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextInsightFromCallTableDTO)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.InsightControllerPreviewRequest(
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
            global::G.InsightControllerPreviewRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateBarInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateBarInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar!, typeInfo);
            }
            else if (value.IsPie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreatePieInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreatePieInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie!, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLineInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateLineInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}