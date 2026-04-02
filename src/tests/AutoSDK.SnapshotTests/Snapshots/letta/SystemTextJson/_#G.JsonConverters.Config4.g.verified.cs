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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateMCPServerRequestConfigDiscriminator>(ref readerCopy, options);

            global::G.LettaSchemasMcpServerUpdateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                stdio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaSchemasMcpServerUpdateStdioMCPServer>(ref reader, options);
            }
            global::G.LettaSchemasMcpServerUpdateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                sse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaSchemasMcpServerUpdateSSEMCPServer>(ref reader, options);
            }
            global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer>(ref reader, options);
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

            if (value.IsStdio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio, typeof(global::G.LettaSchemasMcpServerUpdateStdioMCPServer), options);
            }
            else if (value.IsSse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse, typeof(global::G.LettaSchemasMcpServerUpdateSSEMCPServer), options);
            }
            else if (value.IsStreamableHttp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp, typeof(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer), options);
            }
        }
    }
}