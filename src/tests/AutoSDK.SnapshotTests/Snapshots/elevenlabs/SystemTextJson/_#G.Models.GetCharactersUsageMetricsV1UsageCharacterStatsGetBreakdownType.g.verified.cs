//HintName: G.Models.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to break down the information. Cannot be "user" if include_workspace_metrics is False.<br/>
    /// Default Value: none
    /// </summary>
    public enum GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Voice,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        ApiKeys,
        /// <summary>
        /// 
        /// </summary>
        ProductType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType value)
        {
            return value switch
            {
                GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.None => "none",
                GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.Voice => "voice",
                GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.User => "user",
                GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.ApiKeys => "api_keys",
                GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.ProductType => "product_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? ToEnum(string value)
        {
            return value switch
            {
                "none" => GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.None,
                "voice" => GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.Voice,
                "user" => GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.User,
                "api_keys" => GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.ApiKeys,
                "product_type" => GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.ProductType,
                _ => null,
            };
        }
    }
}