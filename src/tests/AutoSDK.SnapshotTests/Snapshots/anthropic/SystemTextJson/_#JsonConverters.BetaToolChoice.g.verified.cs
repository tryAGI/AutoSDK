//HintName: JsonConverters.BetaToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BetaToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaToolChoice>
    {
        /// <inheritdoc />
        public override global::G.BetaToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaToolChoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::G.BetaToolChoiceDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceAuto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceAuto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaToolChoiceAuto)}");
                auto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaToolChoiceAny? any = default;
            if (discriminator?.Type == global::G.BetaToolChoiceDiscriminatorType.Any)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceAny> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaToolChoiceAny)}");
                any = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaToolChoiceTool? tool = default;
            if (discriminator?.Type == global::G.BetaToolChoiceDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaToolChoiceTool)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.BetaToolChoice(
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
            global::G.BetaToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceAuto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceAuto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaToolChoiceAuto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeInfo);
            }
            else if (value.IsAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaToolChoiceAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaToolChoiceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaToolChoiceTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaToolChoiceTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}