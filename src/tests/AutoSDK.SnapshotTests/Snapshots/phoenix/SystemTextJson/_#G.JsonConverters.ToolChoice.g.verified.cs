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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolsToolChoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolsToolChoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptToolsToolChoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PromptToolChoiceNone? none = default;
            if (discriminator?.Type == global::G.PromptToolsToolChoiceDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptToolChoiceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptToolChoiceZeroOrMore? zeroOrMore = default;
            if (discriminator?.Type == global::G.PromptToolsToolChoiceDiscriminatorType.ZeroOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceZeroOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceZeroOrMore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptToolChoiceZeroOrMore)}");
                zeroOrMore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptToolChoiceOneOrMore? oneOrMore = default;
            if (discriminator?.Type == global::G.PromptToolsToolChoiceDiscriminatorType.OneOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceOneOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceOneOrMore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptToolChoiceOneOrMore)}");
                oneOrMore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptToolChoiceSpecificFunctionTool? specificFunction = default;
            if (discriminator?.Type == global::G.PromptToolsToolChoiceDiscriminatorType.SpecificFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceSpecificFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceSpecificFunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptToolChoiceSpecificFunctionTool)}");
                specificFunction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ToolChoice(
                discriminator?.Type,
                none,

                zeroOrMore,

                oneOrMore,

                specificFunction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptToolChoiceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeInfo);
            }
            else if (value.IsZeroOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceZeroOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceZeroOrMore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptToolChoiceZeroOrMore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ZeroOrMore, typeInfo);
            }
            else if (value.IsOneOrMore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceOneOrMore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceOneOrMore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptToolChoiceOneOrMore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OneOrMore, typeInfo);
            }
            else if (value.IsSpecificFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptToolChoiceSpecificFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptToolChoiceSpecificFunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptToolChoiceSpecificFunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpecificFunction, typeInfo);
            }
        }
    }
}