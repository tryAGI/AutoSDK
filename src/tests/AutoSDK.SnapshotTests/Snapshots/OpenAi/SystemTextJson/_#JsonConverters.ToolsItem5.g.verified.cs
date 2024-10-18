//HintName: JsonConverters.ToolsItem5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsItem5>
    {
        /// <inheritdoc />
        public override global::G.ToolsItem5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRunRequestToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRunRequestToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateRunRequestToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AssistantToolsCode? assistantCode = default;
            if (discriminator?.Type == global::G.CreateRunRequestToolDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsCode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsCode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantToolsCode)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantToolsFileSearch? assistantFileSearch = default;
            if (discriminator?.Type == global::G.CreateRunRequestToolDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsFileSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsFileSearch> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantToolsFileSearch)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantToolsFunction? assistantFunction = default;
            if (discriminator?.Type == global::G.CreateRunRequestToolDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsFunction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantToolsFunction)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolsItem5(
                discriminator?.Type,
                assistantCode,
                assistantFileSearch,
                assistantFunction
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsItem5 value,
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
            else if (value.IsAssistantFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsFileSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsFileSearch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantToolsFileSearch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantFileSearch, typeInfo);
            }
            else if (value.IsAssistantFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantToolsFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantToolsFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantToolsFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantFunction, typeInfo);
            }
        }
    }
}