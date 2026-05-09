//HintName: G.JsonConverters.OutputItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItem>
    {
        /// <inheritdoc />
        public override global::G.OutputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OutputItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.OutputMessage? message = default;
            if (discriminator?.Type == "message")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OutputMessage)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FileSearchToolCall? fileSearchCall = default;
            if (discriminator?.Type == "file_search_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FileSearchToolCall)}");
                fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FunctionToolCall? functionCall = default;
            if (discriminator?.Type == "function_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FunctionToolCall)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSearchToolCall? webSearchCall = default;
            if (discriminator?.Type == "web_search_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSearchToolCall)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ComputerToolCall? computerCall = default;
            if (discriminator?.Type == "computer_call")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ComputerToolCall)}");
                computerCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ReasoningItem? reasoning = default;
            if (discriminator?.Type == "reasoning")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReasoningItem)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.OutputItem(
                discriminator?.Type,
                message,

                fileSearchCall,

                functionCall,

                webSearchCall,

                computerCall,

                reasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
        }
    }
}