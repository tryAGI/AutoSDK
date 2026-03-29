//HintName: G.Models.ConfiguredRulesNumbersEquationFormulaReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Equation Formula Reference
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersEquationFormulaReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always_use_arabic_numerals_to_number_equations_or_formulas_referenced_in_text")]
        AlwaysUseArabicNumeralsToNumberEquationsOrFormulasReferencedInText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersEquationFormulaReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersEquationFormulaReference value)
        {
            return value switch
            {
                ConfiguredRulesNumbersEquationFormulaReference.AlwaysUseArabicNumeralsToNumberEquationsOrFormulasReferencedInText => "always_use_arabic_numerals_to_number_equations_or_formulas_referenced_in_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersEquationFormulaReference? ToEnum(string value)
        {
            return value switch
            {
                "always_use_arabic_numerals_to_number_equations_or_formulas_referenced_in_text" => ConfiguredRulesNumbersEquationFormulaReference.AlwaysUseArabicNumeralsToNumberEquationsOrFormulasReferencedInText,
                _ => null,
            };
        }
    }
}