//HintName: JsonConverters.Tool.g.cs
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

            var
            readerCopy = reader;
            global::G.FileSearchTool? fileSearch = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchTool).Name}");
                fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.FunctionTool? function = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ComputerTool? computer = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerTool).Name}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.WebSearchTool? webSearch = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchTool).Name}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Tool(
                fileSearch,
                function,
                computer,
                webSearch
                );

            if (fileSearch != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchTool).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (function != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (computer != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerTool).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearch != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchTool).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComputerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComputerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
        }
    }
}