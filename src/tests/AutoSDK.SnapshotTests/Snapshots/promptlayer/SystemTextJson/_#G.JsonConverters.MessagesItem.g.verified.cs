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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatPromptMessageDiscriminator>(ref readerCopy, options);

            global::G.SystemMessage? system = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemMessage>(ref reader, options);
            }
            global::G.UserMessage? user = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.User)
            {
                user = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserMessage>(ref reader, options);
            }
            global::G.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Assistant)
            {
                assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantMessage>(ref reader, options);
            }
            global::G.FunctionMessage? function = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FunctionMessage>(ref reader, options);
            }
            global::G.ToolMessage? tool = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolMessage>(ref reader, options);
            }
            global::G.PlaceholderMessage? placeholder = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Placeholder)
            {
                placeholder = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PlaceholderMessage>(ref reader, options);
            }
            global::G.DeveloperMessage? developer = default;
            if (discriminator?.Role == global::G.ChatPromptMessageDiscriminatorRole.Developer)
            {
                developer = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeveloperMessage>(ref reader, options);
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

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::G.SystemMessage), options);
            }
            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::G.UserMessage), options);
            }
            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::G.AssistantMessage), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.FunctionMessage), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ToolMessage), options);
            }
            else if (value.IsPlaceholder)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Placeholder, typeof(global::G.PlaceholderMessage), options);
            }
            else if (value.IsDeveloper)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Developer, typeof(global::G.DeveloperMessage), options);
            }
        }
    }
}