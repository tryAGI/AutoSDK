//HintName: G.JsonConverters.InsightControllerRemoveResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerRemoveResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InsightControllerRemoveResponse>
    {
        /// <inheritdoc />
        public override global::G.InsightControllerRemoveResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InsightControllerRemoveResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InsightControllerRemoveResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InsightControllerRemoveResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BarInsight? bar = default;
            if (discriminator?.Type == global::G.InsightControllerRemoveResponseDiscriminatorType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BarInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BarInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BarInsight)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PieInsight? pie = default;
            if (discriminator?.Type == global::G.InsightControllerRemoveResponseDiscriminatorType.Pie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PieInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PieInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PieInsight)}");
                pie = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LineInsight? line = default;
            if (discriminator?.Type == global::G.InsightControllerRemoveResponseDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LineInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LineInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LineInsight)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextInsight? text = default;
            if (discriminator?.Type == global::G.InsightControllerRemoveResponseDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextInsight)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.InsightControllerRemoveResponse(
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
            global::G.InsightControllerRemoveResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BarInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BarInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BarInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeInfo);
            }
            else if (value.IsPie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PieInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PieInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PieInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LineInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LineInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LineInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}