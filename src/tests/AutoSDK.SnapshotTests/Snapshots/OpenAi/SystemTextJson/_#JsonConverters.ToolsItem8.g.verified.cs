﻿//HintName: JsonConverters.ToolsItem8.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem8JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsItem8>
    {
        /// <inheritdoc />
        public override global::G.ToolsItem8 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMessageRequestAttachmentToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMessageRequestAttachmentToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMessageRequestAttachmentToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AssistantToolsCode? assistantCode = default;
            if (discriminator?.Type == global::G.CreateMessageRequestAttachmentToolDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantToolsCode)}");
                assistantCode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantToolsFileSearchTypeOnly? assistantFileSearchTypeOnly = default;
            if (discriminator?.Type == global::G.CreateMessageRequestAttachmentToolDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsFileSearchTypeOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsFileSearchTypeOnly> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantToolsFileSearchTypeOnly)}");
                assistantFileSearchTypeOnly = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolsItem8(
                discriminator?.Type,
                assistantCode,
                assistantFileSearchTypeOnly
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsItem8 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAssistantCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsCode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantToolsCode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantCode, typeInfo);
            }
            else if (value.IsAssistantFileSearchTypeOnly)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsFileSearchTypeOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsFileSearchTypeOnly?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantToolsFileSearchTypeOnly).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantFileSearchTypeOnly, typeInfo);
            }
        }
    }
}