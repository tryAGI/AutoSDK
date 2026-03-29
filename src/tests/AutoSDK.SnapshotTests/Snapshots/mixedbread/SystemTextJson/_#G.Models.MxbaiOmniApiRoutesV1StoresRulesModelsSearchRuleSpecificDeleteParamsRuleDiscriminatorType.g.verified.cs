//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ChunkSearchResult,
        /// <summary>
        /// 
        /// </summary>
        FileSearchResult,
        /// <summary>
        /// 
        /// </summary>
        QueryRegex,
        /// <summary>
        /// 
        /// </summary>
        QueryString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.ChunkSearchResult => "chunk_search_result",
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.FileSearchResult => "file_search_result",
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryRegex => "query_regex",
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryString => "query_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk_search_result" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.ChunkSearchResult,
                "file_search_result" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.FileSearchResult,
                "query_regex" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryRegex,
                "query_string" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryString,
                _ => null,
            };
        }
    }
}