//HintName: G.Models.ConfiguredRulesStyleAndToneAddressingTheReader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Addressing The Reader
    /// </summary>
    public enum ConfiguredRulesStyleAndToneAddressingTheReader
    {
        /// <summary>
        /// 
        /// </summary>
        UseFormalFrenchWordVous,
        /// <summary>
        /// 
        /// </summary>
        UseFormalItalianWordLei,
        /// <summary>
        /// 
        /// </summary>
        UseInformalFrenchWordTu,
        /// <summary>
        /// 
        /// </summary>
        UseInformalItalianWordTu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneAddressingTheReaderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneAddressingTheReader value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneAddressingTheReader.UseFormalFrenchWordVous => "use_formal_french_word_vous",
                ConfiguredRulesStyleAndToneAddressingTheReader.UseFormalItalianWordLei => "use_formal_italian_word_lei",
                ConfiguredRulesStyleAndToneAddressingTheReader.UseInformalFrenchWordTu => "use_informal_french_word_tu",
                ConfiguredRulesStyleAndToneAddressingTheReader.UseInformalItalianWordTu => "use_informal_italian_word_tu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneAddressingTheReader? ToEnum(string value)
        {
            return value switch
            {
                "use_formal_french_word_vous" => ConfiguredRulesStyleAndToneAddressingTheReader.UseFormalFrenchWordVous,
                "use_formal_italian_word_lei" => ConfiguredRulesStyleAndToneAddressingTheReader.UseFormalItalianWordLei,
                "use_informal_french_word_tu" => ConfiguredRulesStyleAndToneAddressingTheReader.UseInformalFrenchWordTu,
                "use_informal_italian_word_tu" => ConfiguredRulesStyleAndToneAddressingTheReader.UseInformalItalianWordTu,
                _ => null,
            };
        }
    }
}