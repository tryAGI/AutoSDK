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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateMCPServerRequestConfigDiscriminator>(ref readerCopy, options);

            global::G.CreateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                stdio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateStdioMCPServer>(ref reader, options);
            }
            global::G.CreateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                sse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSSEMCPServer>(ref reader, options);
            }
            global::G.CreateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateStreamableHTTPMCPServer>(ref reader, options);
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

            if (value.IsStdio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio, typeof(global::G.CreateStdioMCPServer), options);
            }
            else if (value.IsSse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse, typeof(global::G.CreateSSEMCPServer), options);
            }
            else if (value.IsStreamableHttp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp, typeof(global::G.CreateStreamableHTTPMCPServer), options);
            }
        }
    }
}