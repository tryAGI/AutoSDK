//HintName: JsonConverters.OutputItem.g.cs
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

            var
            readerCopy = reader;
            global::G.OutputMessage? message = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.FileSearchToolCall? fileSearchToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchToolCall).Name}");
                fileSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.FunctionToolCall? functionToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCall).Name}");
                functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.WebSearchToolCall? webSearchToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                webSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ComputerToolCall? computerToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                computerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ReasoningItem? reasoning = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.OutputItem(
                message,
                fileSearchToolCall,
                functionToolCall,
                webSearchToolCall,
                computerToolCall,
                reasoning
                );

            if (message != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (computerToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoning != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeInfo);
            }
            else if (value.IsFileSearchToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchToolCall, typeInfo);
            }
            else if (value.IsFunctionToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall, typeInfo);
            }
            else if (value.IsWebSearchToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolCall, typeInfo);
            }
            else if (value.IsComputerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCall, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeInfo);
            }
        }
    }
}