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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageContent? image = default;
            if (discriminator?.Type == global::G.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageContent)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}