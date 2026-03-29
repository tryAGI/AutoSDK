//HintName: G.Models.BaseInputsOneOf1ItemsOneOf0Phase1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0Phase1
    {
        /// <summary>
        /// 
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0Phase1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0Phase1 value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0Phase1.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0Phase1? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => BaseInputsOneOf1ItemsOneOf0Phase1.FinalAnswer,
                _ => null,
            };
        }
    }
}