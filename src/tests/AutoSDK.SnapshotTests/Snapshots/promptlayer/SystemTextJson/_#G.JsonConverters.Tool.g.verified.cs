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
            global::G.BuiltInTool? webSearch = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BuiltInTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BuiltInTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BuiltInTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Tool(
                discriminator?.Type,
                function,

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
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BuiltInTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BuiltInTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BuiltInTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
        }
    }
}