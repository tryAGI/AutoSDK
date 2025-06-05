//HintName: G.JsonConverters.ToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolChoice>
    {
        /// <inheritdoc />
        public override global::G.ToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolChoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::G.ToolChoiceDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceAuto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceAuto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolChoiceAuto)}");
                auto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolChoiceAny? any = default;
            if (discriminator?.Type == global::G.ToolChoiceDiscriminatorType.Any)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceAny> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolChoiceAny)}");
                any = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolChoiceTool? tool = default;
            if (discriminator?.Type == global::G.ToolChoiceDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolChoiceTool)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolChoice(
                discriminator?.Type,
                auto,
                any,
                tool
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceAuto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceAuto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolChoiceAuto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeInfo);
            }
            else if (value.IsAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolChoiceAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolChoiceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolChoiceTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolChoiceTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}