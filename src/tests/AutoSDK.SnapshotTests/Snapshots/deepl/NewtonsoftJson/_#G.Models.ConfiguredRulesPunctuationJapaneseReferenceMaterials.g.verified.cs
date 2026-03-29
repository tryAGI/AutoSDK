//HintName: G.Models.ConfiguredRulesPunctuationJapaneseReferenceMaterials.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Japanese Reference Materials
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationJapaneseReferenceMaterials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_corner_brackets")]
        UseDoubleCornerBrackets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationJapaneseReferenceMaterialsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationJapaneseReferenceMaterials value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationJapaneseReferenceMaterials.UseDoubleCornerBrackets => "use_double_corner_brackets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationJapaneseReferenceMaterials? ToEnum(string value)
        {
            return value switch
            {
                "use_double_corner_brackets" => ConfiguredRulesPunctuationJapaneseReferenceMaterials.UseDoubleCornerBrackets,
                _ => null,
            };
        }
    }
}