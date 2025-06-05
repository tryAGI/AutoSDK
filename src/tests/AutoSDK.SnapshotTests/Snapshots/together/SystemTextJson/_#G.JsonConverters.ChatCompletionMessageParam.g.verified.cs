//HintName: G.JsonConverters.ChatCompletionMessageParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionMessageParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionMessageParam>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionMessageParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionMessageParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionMessageParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionMessageParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ChatCompletionSystemMessageParam? system = default;
            if (discriminator?.Role == global::G.ChatCompletionMessageParamDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionSystemMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionSystemMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionSystemMessageParam)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatCompletionUserMessageParam? user = default;
            if (discriminator?.Role == global::G.ChatCompletionMessageParamDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionUserMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionUserMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionUserMessageParam)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatCompletionAssistantMessageParam? assistant = default;
            if (discriminator?.Role == global::G.ChatCompletionMessageParamDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionAssistantMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionAssistantMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionAssistantMessageParam)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatCompletionToolMessageParam? tool = default;
            if (discriminator?.Role == global::G.ChatCompletionMessageParamDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionToolMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionToolMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionToolMessageParam)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatCompletionFunctionMessageParam? function = default;
            if (discriminator?.Role == global::G.ChatCompletionMessageParamDiscriminatorRole.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionFunctionMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionFunctionMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionFunctionMessageParam)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ChatCompletionMessageParam(
                discriminator?.Role,
                system,
                user,
                assistant,
                tool,
                function
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionMessageParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionSystemMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionSystemMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionSystemMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionUserMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionUserMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionUserMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionAssistantMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionAssistantMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionAssistantMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionToolMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionToolMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionToolMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionFunctionMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionFunctionMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionFunctionMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
        }
    }
}