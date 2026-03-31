//HintName: G.JsonConverters.Tool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Tool>
    {
        /// <inheritdoc />
        public override global::G.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.FunctionTool? function = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GraphTool? graph = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Graph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraphTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraphTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GraphTool)}");
                graph = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LlmTool? llm = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LlmTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LlmTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LlmTool)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TranslationTool? translation = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Translation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranslationTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranslationTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TranslationTool)}");
                translation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VisionTool? vision = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Vision)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VisionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VisionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VisionTool)}");
                vision = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSearchTool? webSearch = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSearchTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Tool(
                discriminator?.Type,
                function,

                graph,

                llm,

                translation,

                vision,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsGraph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GraphTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GraphTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GraphTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Graph!, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LlmTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LlmTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LlmTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsTranslation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranslationTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranslationTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranslationTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Translation!, typeInfo);
            }
            else if (value.IsVision)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VisionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VisionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VisionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vision!, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
        }
    }
}