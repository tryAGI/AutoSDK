//HintName: G.Models.FineTuneEventLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneEventLevel
    {
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
        LegacyIerror,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneEventLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneEventLevel value)
        {
            return value switch
            {
                FineTuneEventLevel.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                FineTuneEventLevel.Info => "info",
                FineTuneEventLevel.Warning => "warning",
                FineTuneEventLevel.Error => "error",
                FineTuneEventLevel.LegacyInfo => "legacy_info",
                FineTuneEventLevel.LegacyIwarning => "legacy_iwarning",
                FineTuneEventLevel.LegacyIerror => "legacy_ierror",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneEventLevel? ToEnum(string value)
        {
            return value switch
            {
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => FineTuneEventLevel.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                "info" => FineTuneEventLevel.Info,
                "warning" => FineTuneEventLevel.Warning,
                "error" => FineTuneEventLevel.Error,
                "legacy_info" => FineTuneEventLevel.LegacyInfo,
                "legacy_iwarning" => FineTuneEventLevel.LegacyIwarning,
                "legacy_ierror" => FineTuneEventLevel.LegacyIerror,
                _ => null,
            };
        }
    }
}