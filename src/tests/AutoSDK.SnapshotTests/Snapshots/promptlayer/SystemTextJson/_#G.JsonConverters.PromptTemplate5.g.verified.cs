//HintName: G.JsonConverters.PromptTemplate5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PromptTemplate5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PromptTemplate5>
    {
        /// <inheritdoc />
        public override global::G.PromptTemplate5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlueprintPromptTemplateDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlueprintPromptTemplateDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptBlueprintPromptTemplateDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CompletionPrompt? completion = default;
            if (discriminator?.Type == global::G.PromptBlueprintPromptTemplateDiscriminatorType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionPrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompletionPrompt)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatPrompt? chat = default;
            if (discriminator?.Type == global::G.PromptBlueprintPromptTemplateDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatPrompt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatPrompt)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.PromptTemplate5(
                discriminator?.Type,
                completion,

                chat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PromptTemplate5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompletionPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion!, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatPrompt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatPrompt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatPrompt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat!, typeInfo);
            }
        }
    }
}