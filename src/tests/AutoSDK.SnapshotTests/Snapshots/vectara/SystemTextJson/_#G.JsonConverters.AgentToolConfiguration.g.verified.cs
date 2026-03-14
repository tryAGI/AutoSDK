//HintName: G.JsonConverters.AgentToolConfiguration.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentToolConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentToolConfiguration>
    {
        /// <inheritdoc />
        public override global::G.AgentToolConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentToolConfigurationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentToolConfigurationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AgentToolConfigurationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.InlineDynamicVectaraToolConfiguration? dynamicVectara = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.DynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineDynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineDynamicVectaraToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineDynamicVectaraToolConfiguration)}");
                dynamicVectara = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineMcpToolConfiguration? mcp = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineMcpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineMcpToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineMcpToolConfiguration)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineCorporaSearchToolConfiguration? corporaSearch = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.CorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineCorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineCorporaSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineCorporaSearchToolConfiguration)}");
                corporaSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineWebSearchToolConfiguration? webSearch = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineWebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineWebSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineWebSearchToolConfiguration)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineWebGetToolConfiguration? webGet = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.WebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineWebGetToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineWebGetToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineWebGetToolConfiguration)}");
                webGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineLambdaToolConfiguration? lambda = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineLambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineLambdaToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineLambdaToolConfiguration)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineStructuredIndexingToolConfiguration? structuredIndexing = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.StructuredIndexing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineStructuredIndexingToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineStructuredIndexingToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineStructuredIndexingToolConfiguration)}");
                structuredIndexing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineSubAgentToolConfiguration? subAgent = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineSubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineSubAgentToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineSubAgentToolConfiguration)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineArtifactReadToolConfiguration? artifactRead = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.ArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineArtifactReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineArtifactReadToolConfiguration)}");
                artifactRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineArtifactGrepToolConfiguration? artifactGrep = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.ArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineArtifactGrepToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineArtifactGrepToolConfiguration)}");
                artifactGrep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineImageReadToolConfiguration? imageRead = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineImageReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineImageReadToolConfiguration)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineDocumentConversionToolConfiguration? documentConversion = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.DocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineDocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineDocumentConversionToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineDocumentConversionToolConfiguration)}");
                documentConversion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.InlineGetDocumentTextToolConfiguration? getDocumentText = default;
            if (discriminator?.Type == global::G.AgentToolConfigurationDiscriminatorType.GetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineGetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineGetDocumentTextToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.InlineGetDocumentTextToolConfiguration)}");
                getDocumentText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.AgentToolConfiguration(
                discriminator?.Type,
                dynamicVectara,

                mcp,

                corporaSearch,

                webSearch,

                webGet,

                lambda,

                structuredIndexing,

                subAgent,

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
            global::G.AgentToolConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineDynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineDynamicVectaraToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineDynamicVectaraToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVectara, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineMcpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineMcpToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineMcpToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsCorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineCorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineCorporaSearchToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineCorporaSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CorporaSearch, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineWebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineWebSearchToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineWebSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
            else if (value.IsWebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineWebGetToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineWebGetToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineWebGetToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebGet, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineLambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineLambdaToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineLambdaToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda, typeInfo);
            }
            else if (value.IsStructuredIndexing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineStructuredIndexingToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineStructuredIndexingToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineStructuredIndexingToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredIndexing, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineSubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineSubAgentToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineSubAgentToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent, typeInfo);
            }
            else if (value.IsArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineArtifactReadToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineArtifactReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactRead, typeInfo);
            }
            else if (value.IsArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineArtifactGrepToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineArtifactGrepToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrep, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineImageReadToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineImageReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead, typeInfo);
            }
            else if (value.IsDocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineDocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineDocumentConversionToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineDocumentConversionToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentConversion, typeInfo);
            }
            else if (value.IsGetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InlineGetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InlineGetDocumentTextToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InlineGetDocumentTextToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetDocumentText, typeInfo);
            }
        }
    }
}