//HintName: G.Models.FineTuneEventLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneEventLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="info")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_ierror")]
        LegacyIerror,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_info")]
        LegacyInfo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_iwarning")]
        LegacyIwarning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
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
                FineTuneEventLevel.Error => "error",
                FineTuneEventLevel.Info => "info",
                FineTuneEventLevel.LegacyIerror => "legacy_ierror",
                FineTuneEventLevel.LegacyInfo => "legacy_info",
                FineTuneEventLevel.LegacyIwarning => "legacy_iwarning",
                FineTuneEventLevel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                FineTuneEventLevel.Warning => "warning",
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
                "error" => FineTuneEventLevel.Error,
                "info" => FineTuneEventLevel.Info,
                "legacy_ierror" => FineTuneEventLevel.LegacyIerror,
                "legacy_info" => FineTuneEventLevel.LegacyInfo,
                "legacy_iwarning" => FineTuneEventLevel.LegacyIwarning,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => FineTuneEventLevel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => FineTuneEventLevel.Warning,
                _ => null,
            };
        }
    }
}