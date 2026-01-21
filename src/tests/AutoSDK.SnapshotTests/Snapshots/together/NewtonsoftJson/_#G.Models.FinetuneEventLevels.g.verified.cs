//HintName: G.Models.FinetuneEventLevels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetuneEventLevels
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="info")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_ierror")]
        LegacyIerror,
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
                FinetuneEventLevels.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                FinetuneEventLevels.Info => "info",
                FinetuneEventLevels.Warning => "warning",
                FinetuneEventLevels.Error => "error",
                FinetuneEventLevels.LegacyInfo => "legacy_info",
                FinetuneEventLevels.LegacyIwarning => "legacy_iwarning",
                FinetuneEventLevels.LegacyIerror => "legacy_ierror",
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
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => FinetuneEventLevels.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                "info" => FinetuneEventLevels.Info,
                "warning" => FinetuneEventLevels.Warning,
                "error" => FinetuneEventLevels.Error,
                "legacy_info" => FinetuneEventLevels.LegacyInfo,
                "legacy_iwarning" => FinetuneEventLevels.LegacyIwarning,
                "legacy_ierror" => FinetuneEventLevels.LegacyIerror,
                _ => null,
            };
        }
    }
}