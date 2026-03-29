//HintName: G.Models.ConfiguredRulesNumbersSpellingOutUnits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Spelling Out Units
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersSpellingOutUnits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="abbreviate_units_of_measure_when_used_with_numeral_but_spell_out_when_used_without_numeral")]
        AbbreviateUnitsOfMeasureWhenUsedWithNumeralButSpellOutWhenUsedWithoutNumeral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always_abbreviate_units_of_measure")]
        AlwaysAbbreviateUnitsOfMeasure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always_spell_out_units_of_measure")]
        AlwaysSpellOutUnitsOfMeasure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_units_in_korean")]
        SpellOutUnitsInKorean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_units_of_measure_when_used_with_spelled_out_numbers_but_abbreviate_when_used_with_numeral")]
        SpellOutUnitsOfMeasureWhenUsedWithSpelledOutNumbersButAbbreviateWhenUsedWithNumeral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_units_of_measure_with_katakana_or_katakana_and_kanji")]
        SpellOutUnitsOfMeasureWithKatakanaOrKatakanaAndKanji,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_si_symbols")]
        UseSiSymbols,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_unit_symbols")]
        UseUnitSymbols,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersSpellingOutUnitsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersSpellingOutUnits value)
        {
            return value switch
            {
                ConfiguredRulesNumbersSpellingOutUnits.AbbreviateUnitsOfMeasureWhenUsedWithNumeralButSpellOutWhenUsedWithoutNumeral => "abbreviate_units_of_measure_when_used_with_numeral_but_spell_out_when_used_without_numeral",
                ConfiguredRulesNumbersSpellingOutUnits.AlwaysAbbreviateUnitsOfMeasure => "always_abbreviate_units_of_measure",
                ConfiguredRulesNumbersSpellingOutUnits.AlwaysSpellOutUnitsOfMeasure => "always_spell_out_units_of_measure",
                ConfiguredRulesNumbersSpellingOutUnits.SpellOutUnitsInKorean => "spell_out_units_in_korean",
                ConfiguredRulesNumbersSpellingOutUnits.SpellOutUnitsOfMeasureWhenUsedWithSpelledOutNumbersButAbbreviateWhenUsedWithNumeral => "spell_out_units_of_measure_when_used_with_spelled_out_numbers_but_abbreviate_when_used_with_numeral",
                ConfiguredRulesNumbersSpellingOutUnits.SpellOutUnitsOfMeasureWithKatakanaOrKatakanaAndKanji => "spell_out_units_of_measure_with_katakana_or_katakana_and_kanji",
                ConfiguredRulesNumbersSpellingOutUnits.UseSiSymbols => "use_si_symbols",
                ConfiguredRulesNumbersSpellingOutUnits.UseUnitSymbols => "use_unit_symbols",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersSpellingOutUnits? ToEnum(string value)
        {
            return value switch
            {
                "abbreviate_units_of_measure_when_used_with_numeral_but_spell_out_when_used_without_numeral" => ConfiguredRulesNumbersSpellingOutUnits.AbbreviateUnitsOfMeasureWhenUsedWithNumeralButSpellOutWhenUsedWithoutNumeral,
                "always_abbreviate_units_of_measure" => ConfiguredRulesNumbersSpellingOutUnits.AlwaysAbbreviateUnitsOfMeasure,
                "always_spell_out_units_of_measure" => ConfiguredRulesNumbersSpellingOutUnits.AlwaysSpellOutUnitsOfMeasure,
                "spell_out_units_in_korean" => ConfiguredRulesNumbersSpellingOutUnits.SpellOutUnitsInKorean,
                "spell_out_units_of_measure_when_used_with_spelled_out_numbers_but_abbreviate_when_used_with_numeral" => ConfiguredRulesNumbersSpellingOutUnits.SpellOutUnitsOfMeasureWhenUsedWithSpelledOutNumbersButAbbreviateWhenUsedWithNumeral,
                "spell_out_units_of_measure_with_katakana_or_katakana_and_kanji" => ConfiguredRulesNumbersSpellingOutUnits.SpellOutUnitsOfMeasureWithKatakanaOrKatakanaAndKanji,
                "use_si_symbols" => ConfiguredRulesNumbersSpellingOutUnits.UseSiSymbols,
                "use_unit_symbols" => ConfiguredRulesNumbersSpellingOutUnits.UseUnitSymbols,
                _ => null,
            };
        }
    }
}