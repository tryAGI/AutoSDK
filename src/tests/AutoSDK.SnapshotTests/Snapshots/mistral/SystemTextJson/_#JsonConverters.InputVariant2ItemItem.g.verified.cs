//HintName: JsonConverters.InputVariant2ItemItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant2ItemItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputVariant2ItemItem>
    {
        /// <inheritdoc />
        public override global::G.InputVariant2ItemItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatModerationRequestInputVariant2ItemItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatModerationRequestInputVariant2ItemItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatModerationRequestInputVariant2ItemItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SystemMessage? system = default;
            if (discriminator?.Role == global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserMessage? user = default;
            if (discriminator?.Role == global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolMessage? tool = default;
            if (discriminator?.Role == global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.InputVariant2ItemItem(
                discriminator?.Role,
                system,
                user,
                assistant,
                tool
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputVariant2ItemItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}