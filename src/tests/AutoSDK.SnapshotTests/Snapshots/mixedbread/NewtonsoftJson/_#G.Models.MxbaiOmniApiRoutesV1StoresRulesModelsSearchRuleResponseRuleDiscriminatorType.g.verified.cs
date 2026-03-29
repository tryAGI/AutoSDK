//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType
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
    public static class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.ChunkSearchResult => "chunk_search_result",
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.FileSearchResult => "file_search_result",
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.QueryRegex => "query_regex",
                MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.QueryString => "query_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chunk_search_result" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.ChunkSearchResult,
                "file_search_result" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.FileSearchResult,
                "query_regex" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.QueryRegex,
                "query_string" => MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorType.QueryString,
                _ => null,
            };
        }
    }
}