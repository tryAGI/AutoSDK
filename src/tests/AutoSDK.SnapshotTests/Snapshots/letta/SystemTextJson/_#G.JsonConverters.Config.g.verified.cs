//HintName: G.JsonConverters.Config.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Config>
    {
        /// <inheritdoc />
        public override global::G.Config Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMCPServerRequestConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMCPServerRequestConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMCPServerRequestConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateStdioMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateStdioMCPServer)}");
                stdio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSSEMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSSEMCPServer)}");
                sse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateStreamableHTTPMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateStreamableHTTPMCPServer)}");
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Config(
                discriminator?.McpServerType,
                stdio,

                sse,

                streamableHttp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Config value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateStdioMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateStdioMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio!, typeInfo);
            }
            else if (value.IsSse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSSEMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSSEMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse!, typeInfo);
            }
            else if (value.IsStreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateStreamableHTTPMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateStreamableHTTPMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp!, typeInfo);
            }
        }
    }
}