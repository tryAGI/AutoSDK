//HintName: G.Models.ConfigurationResponseProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Product type.
    /// </summary>
    public enum ConfigurationResponseProductType
    {
        /// <summary>
        /// 
        /// </summary>
        ClassifyV2,
        /// <summary>
        /// 
        /// </summary>
        ExtractV2,
        /// <summary>
        /// 
        /// </summary>
        ParseV2,
        /// <summary>
        /// 
        /// </summary>
        SplitV1,
        /// <summary>
        /// 
        /// </summary>
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