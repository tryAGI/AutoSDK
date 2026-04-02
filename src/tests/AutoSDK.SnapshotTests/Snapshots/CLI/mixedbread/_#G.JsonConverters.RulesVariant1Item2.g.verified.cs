//HintName: G.JsonConverters.RulesVariant1Item2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RulesVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RulesVariant1Item2>
    {
        /// <inheritdoc />
        public override global::G.RulesVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminator>(ref readerCopy, options);

            global::G.QueryStringSubstitutionRule? queryString = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.QueryString)
            {
                queryString = global::System.Text.Json.JsonSerializer.Deserialize<global::G.QueryStringSubstitutionRule>(ref reader, options);
            }
            global::G.QueryRegexSubstitutionRule? queryRegex = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.QueryRegex)
            {
                queryRegex = global::System.Text.Json.JsonSerializer.Deserialize<global::G.QueryRegexSubstitutionRule>(ref reader, options);
            }
            global::G.ChunkSearchResultRule? chunkSearchResult = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.ChunkSearchResult)
            {
                chunkSearchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChunkSearchResultRule>(ref reader, options);
            }
            global::G.FileSearchResultRule? fileSearchResult = default;
            if (discriminator?.Type == global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.FileSearchResult)
            {
                fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileSearchResultRule>(ref reader, options);
            }

            var __value = new global::G.RulesVariant1Item2(
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
            global::G.RulesVariant1Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsQueryString)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryString, typeof(global::G.QueryStringSubstitutionRule), options);
            }
            else if (value.IsQueryRegex)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryRegex, typeof(global::G.QueryRegexSubstitutionRule), options);
            }
            else if (value.IsChunkSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChunkSearchResult, typeof(global::G.ChunkSearchResultRule), options);
            }
            else if (value.IsFileSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchResult, typeof(global::G.FileSearchResultRule), options);
            }
        }
    }
}