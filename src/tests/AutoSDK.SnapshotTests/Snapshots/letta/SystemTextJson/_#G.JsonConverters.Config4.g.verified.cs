//HintName: G.JsonConverters.Config4.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Config4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Config4>
    {
        /// <inheritdoc />
        public override global::G.Config4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateMCPServerRequestConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateMCPServerRequestConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateMCPServerRequestConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.LettaSchemasMcpServerUpdateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMcpServerUpdateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMcpServerUpdateStdioMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaSchemasMcpServerUpdateStdioMCPServer)}");
                stdio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaSchemasMcpServerUpdateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMcpServerUpdateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMcpServerUpdateSSEMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaSchemasMcpServerUpdateSSEMCPServer)}");
                sse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer)}");
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Config4(
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
            global::G.Config4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMcpServerUpdateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMcpServerUpdateStdioMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaSchemasMcpServerUpdateStdioMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio!, typeInfo);
            }
            else if (value.IsSse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMcpServerUpdateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMcpServerUpdateSSEMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaSchemasMcpServerUpdateSSEMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse!, typeInfo);
            }
            else if (value.IsStreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp!, typeInfo);
            }
        }
    }
}