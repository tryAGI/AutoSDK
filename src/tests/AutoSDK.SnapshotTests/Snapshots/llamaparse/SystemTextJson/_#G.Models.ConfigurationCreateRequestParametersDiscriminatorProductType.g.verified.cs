//HintName: G.Models.ConfigurationCreateRequestParametersDiscriminatorProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConfigurationCreateRequestParametersDiscriminatorProductType
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
    public static class ConfigurationCreateRequestParametersDiscriminatorProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurationCreateRequestParametersDiscriminatorProductType value)
        {
            return value switch
            {
                ConfigurationCreateRequestParametersDiscriminatorProductType.ClassifyV2 => "classify_v2",
                ConfigurationCreateRequestParametersDiscriminatorProductType.ExtractV2 => "extract_v2",
                ConfigurationCreateRequestParametersDiscriminatorProductType.ParseV2 => "parse_v2",
                ConfigurationCreateRequestParametersDiscriminatorProductType.SplitV1 => "split_v1",
                ConfigurationCreateRequestParametersDiscriminatorProductType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurationCreateRequestParametersDiscriminatorProductType? ToEnum(string value)
        {
            return value switch
            {
                "classify_v2" => ConfigurationCreateRequestParametersDiscriminatorProductType.ClassifyV2,
                "extract_v2" => ConfigurationCreateRequestParametersDiscriminatorProductType.ExtractV2,
                "parse_v2" => ConfigurationCreateRequestParametersDiscriminatorProductType.ParseV2,
                "split_v1" => ConfigurationCreateRequestParametersDiscriminatorProductType.SplitV1,
                "unknown" => ConfigurationCreateRequestParametersDiscriminatorProductType.Unknown,
                _ => null,
            };
        }
    }
}