//HintName: G.JsonConverters.MessagesItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesItem>
    {
        /// <inheritdoc />
        public override global::G.MessagesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatPromptMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatPromptMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatPromptMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SystemMessage? system = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserMessage? user = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FunctionMessage? function = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FunctionMessage)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolMessage? tool = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PlaceholderMessage? placeholder = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Placeholder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlaceholderMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlaceholderMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PlaceholderMessage)}");
                placeholder = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeveloperMessage? developer = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Developer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeveloperMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeveloperMessage)}");
                developer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.MessagesItem(
                discriminator?.Role,
                system,

                user,

                assistant,

                function,

                tool,

                placeholder,

                developer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesItem value,
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
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsPlaceholder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlaceholderMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlaceholderMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PlaceholderMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Placeholder, typeInfo);
            }
            else if (value.IsDeveloper)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Developer, typeInfo);
            }
        }
    }
}