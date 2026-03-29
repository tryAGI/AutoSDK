//HintName: G.Models.ConfigurationResponseProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Product type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfigurationResponseProductType
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
    public static class ConfigurationResponseProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurationResponseProductType value)
        {
            return value switch
            {
                ConfigurationResponseProductType.ClassifyV2 => "classify_v2",
                ConfigurationResponseProductType.ExtractV2 => "extract_v2",
                ConfigurationResponseProductType.ParseV2 => "parse_v2",
                ConfigurationResponseProductType.SplitV1 => "split_v1",
                ConfigurationResponseProductType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurationResponseProductType? ToEnum(string value)
        {
            return value switch
            {
                "classify_v2" => ConfigurationResponseProductType.ClassifyV2,
                "extract_v2" => ConfigurationResponseProductType.ExtractV2,
                "parse_v2" => ConfigurationResponseProductType.ParseV2,
                "split_v1" => ConfigurationResponseProductType.SplitV1,
                "unknown" => ConfigurationResponseProductType.Unknown,
                _ => null,
            };
        }
    }
}