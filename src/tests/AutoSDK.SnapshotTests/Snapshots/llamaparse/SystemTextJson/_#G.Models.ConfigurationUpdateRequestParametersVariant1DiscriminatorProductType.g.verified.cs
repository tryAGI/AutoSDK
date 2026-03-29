//HintName: G.Models.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType
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
    public static class ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType value)
        {
            return value switch
            {
                ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ClassifyV2 => "classify_v2",
                ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ExtractV2 => "extract_v2",
                ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ParseV2 => "parse_v2",
                ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.SplitV1 => "split_v1",
                ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? ToEnum(string value)
        {
            return value switch
            {
                "classify_v2" => ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ClassifyV2,
                "extract_v2" => ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ExtractV2,
                "parse_v2" => ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.ParseV2,
                "split_v1" => ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.SplitV1,
                "unknown" => ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType.Unknown,
                _ => null,
            };
        }
    }
}