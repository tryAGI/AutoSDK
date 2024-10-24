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
            global::G.ToolCustom? custom = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCustom).Name}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolComputerUse? computerUse = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolComputerUse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolComputerUse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolComputerUse).Name}");
                computerUse = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolTextEditor? textEditor = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolTextEditor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolTextEditor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolTextEditor).Name}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ToolBash? bash = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolBash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolBash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolBash).Name}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Tool(
                custom,
                computerUse,
                textEditor,
                bash
                );

            if (custom != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCustom).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (computerUse != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolComputerUse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolComputerUse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolComputerUse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textEditor != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolTextEditor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolTextEditor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolTextEditor).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (bash != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolBash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolBash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolBash).Name}");
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

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCustom?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCustom).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeInfo);
            }
            else if (value.IsComputerUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolComputerUse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolComputerUse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolComputerUse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUse, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolTextEditor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolTextEditor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolTextEditor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolBash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolBash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolBash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeInfo);
            }
        }
    }
}