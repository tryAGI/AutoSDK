//HintName: G.JsonConverters.Rule2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Rule2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Rule2>
    {
        /// <inheritdoc />
        public override global::G.Rule2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.QueryStringSubstitutionRule? queryString = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryStringSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryStringSubstitutionRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.QueryStringSubstitutionRule)}");
                queryString = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.QueryRegexSubstitutionRule? queryRegex = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryRegexSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryRegexSubstitutionRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.QueryRegexSubstitutionRule)}");
                queryRegex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChunkSearchResultRule? chunkSearchResult = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.ChunkSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChunkSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChunkSearchResultRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChunkSearchResultRule)}");
                chunkSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FileSearchResultRule? fileSearchResult = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.FileSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchResultRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FileSearchResultRule)}");
                fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Rule2(
                discriminator?.Type,
                queryString,

                queryRegex,

                chunkSearchResult,

                fileSearchResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Rule2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsQueryString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryStringSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryStringSubstitutionRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.QueryStringSubstitutionRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryString!, typeInfo);
            }
            else if (value.IsQueryRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryRegexSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryRegexSubstitutionRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.QueryRegexSubstitutionRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryRegex!, typeInfo);
            }
            else if (value.IsChunkSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChunkSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChunkSearchResultRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChunkSearchResultRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChunkSearchResult!, typeInfo);
            }
            else if (value.IsFileSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchResultRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchResultRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchResult!, typeInfo);
            }
        }
    }
}