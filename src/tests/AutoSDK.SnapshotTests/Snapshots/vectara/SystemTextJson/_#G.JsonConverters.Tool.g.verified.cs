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

            global::G.DynamicVectaraTool? dynamicVectara = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.DynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicVectaraTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicVectaraTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DynamicVectaraTool)}");
                dynamicVectara = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.McpTool? mcp = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.McpTool)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CorporaSearchTool? corporaSearch = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.CorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CorporaSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CorporaSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CorporaSearchTool)}");
                corporaSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSearchTool? webSearch = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSearchTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebGetTool? webGet = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.WebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebGetTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebGetTool)}");
                webGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LambdaTool? lambda = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LambdaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LambdaTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LambdaTool)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.StructuredIndexingTool? structuredIndexing = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.StructuredIndexing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredIndexingTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredIndexingTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.StructuredIndexingTool)}");
                structuredIndexing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SubAgentTool? subAgent = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SubAgentTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SubAgentTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SubAgentTool)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ArtifactCreateTool? artifactCreate = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.ArtifactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ArtifactCreateTool)}");
                artifactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ArtifactReadTool? artifactRead = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.ArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ArtifactReadTool)}");
                artifactRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ArtifactGrepTool? artifactGrep = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.ArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactGrepTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactGrepTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ArtifactGrepTool)}");
                artifactGrep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageReadTool? imageRead = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageReadTool)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DocumentConversionTool? documentConversion = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.DocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentConversionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentConversionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DocumentConversionTool)}");
                documentConversion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetDocumentTextTool? getDocumentText = default;
            if (discriminator?.Type == global::G.ToolDiscriminatorType.GetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetDocumentTextTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetDocumentTextTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetDocumentTextTool)}");
                getDocumentText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Tool(
                discriminator?.Type,
                dynamicVectara,

                mcp,

                corporaSearch,

                webSearch,

                webGet,

                lambda,

                structuredIndexing,

                subAgent,

                artifactCreate,

                artifactRead,

                artifactGrep,

                imageRead,

                documentConversion,

                getDocumentText
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

            if (value.IsDynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DynamicVectaraTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DynamicVectaraTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DynamicVectaraTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVectara, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsCorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CorporaSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CorporaSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CorporaSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CorporaSearch, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
            else if (value.IsWebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebGetTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebGetTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebGet, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LambdaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LambdaTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LambdaTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda, typeInfo);
            }
            else if (value.IsStructuredIndexing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StructuredIndexingTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StructuredIndexingTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StructuredIndexingTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredIndexing, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SubAgentTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SubAgentTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SubAgentTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent, typeInfo);
            }
            else if (value.IsArtifactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactCreateTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactCreate, typeInfo);
            }
            else if (value.IsArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactReadTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactRead, typeInfo);
            }
            else if (value.IsArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactGrepTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactGrepTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactGrepTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrep, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageReadTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead, typeInfo);
            }
            else if (value.IsDocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentConversionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentConversionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentConversionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentConversion, typeInfo);
            }
            else if (value.IsGetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetDocumentTextTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetDocumentTextTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetDocumentTextTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetDocumentText, typeInfo);
            }
        }
    }
}