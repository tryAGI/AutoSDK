//HintName: G.JsonConverters.Template2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Template2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Template2>
    {
        /// <inheritdoc />
        public override global::G.Template2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptVersionDataTemplateDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptVersionDataTemplateDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptVersionDataTemplateDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PromptChatTemplate? chat = default;
            if (discriminator?.Type == global::G.PromptVersionDataTemplateDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptChatTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptChatTemplate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptChatTemplate)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptStringTemplate? @string = default;
            if (discriminator?.Type == global::G.PromptVersionDataTemplateDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptStringTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptStringTemplate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptStringTemplate)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Template2(
                discriminator?.Type,
                chat,

                @string
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Template2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptChatTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptChatTemplate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptChatTemplate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptStringTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptStringTemplate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptStringTemplate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeInfo);
            }
        }
    }
}