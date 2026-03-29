//HintName: G.Models.ConfigurationResponseParametersDiscriminatorProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfigurationResponseParametersDiscriminatorProductType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classify_v2")]
        ClassifyV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extract_v2")]
        ExtractV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_v2")]
        ParseV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="split_v1")]
        SplitV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigurationResponseParametersDiscriminatorProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurationResponseParametersDiscriminatorProductType value)
        {
            return value switch
            {
                ConfigurationResponseParametersDiscriminatorProductType.ClassifyV2 => "classify_v2",
                ConfigurationResponseParametersDiscriminatorProductType.ExtractV2 => "extract_v2",
                ConfigurationResponseParametersDiscriminatorProductType.ParseV2 => "parse_v2",
                ConfigurationResponseParametersDiscriminatorProductType.SplitV1 => "split_v1",
                ConfigurationResponseParametersDiscriminatorProductType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurationResponseParametersDiscriminatorProductType? ToEnum(string value)
        {
            return value switch
            {
                "classify_v2" => ConfigurationResponseParametersDiscriminatorProductType.ClassifyV2,
                "extract_v2" => ConfigurationResponseParametersDiscriminatorProductType.ExtractV2,
                "parse_v2" => ConfigurationResponseParametersDiscriminatorProductType.ParseV2,
                "split_v1" => ConfigurationResponseParametersDiscriminatorProductType.SplitV1,
                "unknown" => ConfigurationResponseParametersDiscriminatorProductType.Unknown,
                _ => null,
            };
        }
    }
}