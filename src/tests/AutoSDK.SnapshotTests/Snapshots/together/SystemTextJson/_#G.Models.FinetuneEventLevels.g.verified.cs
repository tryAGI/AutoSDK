//HintName: G.Models.FinetuneEventLevels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneEventLevels
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        LegacyIerror,
        /// <summary>
        /// 
        /// </summary>
        LegacyInfo,
        /// <summary>
        /// 
        /// </summary>
        LegacyIwarning,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneEventLevelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventLevels value)
        {
            return value switch
            {
                FinetuneEventLevels.Error => "error",
                FinetuneEventLevels.Info => "info",
                FinetuneEventLevels.LegacyIerror => "legacy_ierror",
                FinetuneEventLevels.LegacyInfo => "legacy_info",
                FinetuneEventLevels.LegacyIwarning => "legacy_iwarning",
                FinetuneEventLevels.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                FinetuneEventLevels.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventLevels? ToEnum(string value)
        {
            return value switch
            {
                "error" => FinetuneEventLevels.Error,
                "info" => FinetuneEventLevels.Info,
                "legacy_ierror" => FinetuneEventLevels.LegacyIerror,
                "legacy_info" => FinetuneEventLevels.LegacyInfo,
                "legacy_iwarning" => FinetuneEventLevels.LegacyIwarning,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => FinetuneEventLevels.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => FinetuneEventLevels.Warning,
                _ => null,
            };
        }
    }
}