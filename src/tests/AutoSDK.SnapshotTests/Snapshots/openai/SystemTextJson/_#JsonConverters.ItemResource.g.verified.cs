//HintName: JsonConverters.ItemResource.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ItemResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ItemResource>
    {
        /// <inheritdoc />
        public override global::G.ItemResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.InputMessageResource? inputMessage = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageResource).Name}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.OutputMessage? outputMessage = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                outputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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
            global::G.ComputerToolCallOutputResource? computerToolCallOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCallOutputResource).Name}");
                computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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
            global::G.FunctionToolCallResource? functionToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCallResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCallResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCallResource).Name}");
                functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.FunctionToolCallOutputResource? functionToolCallOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCallOutputResource).Name}");
                functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ItemResource(
                inputMessage,
                outputMessage,
                fileSearchToolCall,
                computerToolCall,
                computerToolCallOutput,
                webSearchToolCall,
                functionToolCall,
                functionToolCallOutput
                );

            if (inputMessage != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageResource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputMessage != null)
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
            else if (computerToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (computerToolCallOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCallOutputResource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCallResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCallResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCallResource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionToolCallOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCallOutputResource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ItemResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage, typeInfo);
            }
            else if (value.IsOutputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessage, typeInfo);
            }
            else if (value.IsFileSearchToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchToolCall, typeInfo);
            }
            else if (value.IsComputerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCall, typeInfo);
            }
            else if (value.IsComputerToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerToolCallOutputResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutput, typeInfo);
            }
            else if (value.IsWebSearchToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolCall, typeInfo);
            }
            else if (value.IsFunctionToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCallResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCallResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCallResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall, typeInfo);
            }
            else if (value.IsFunctionToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionToolCallOutputResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionToolCallOutputResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionToolCallOutputResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutput, typeInfo);
            }
        }
    }
}