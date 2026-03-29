//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chunk_search_result")]
        ChunkSearchResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search_result")]
        FileSearchResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query_regex")]
        QueryRegex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query_string")]
        QueryString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.ChunkSearchResult => "chunk_search_result",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.FileSearchResult => "file_search_result",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.QueryRegex => "query_regex",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.QueryString => "query_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk_search_result" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.ChunkSearchResult,
                "file_search_result" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.FileSearchResult,
                "query_regex" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.QueryRegex,
                "query_string" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorType.QueryString,
                _ => null,
            };
        }
    }
}