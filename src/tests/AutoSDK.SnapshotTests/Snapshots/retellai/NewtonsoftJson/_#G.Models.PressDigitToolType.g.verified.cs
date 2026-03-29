//HintName: G.Models.PressDigitToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PressDigitToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="press_digit")]
        PressDigit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PressDigitToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PressDigitToolType value)
        {
            return value switch
            {
                PressDigitToolType.PressDigit => "press_digit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PressDigitToolType? ToEnum(string value)
        {
            return value switch
            {
                "press_digit" => PressDigitToolType.PressDigit,
                _ => null,
            };
        }
    }
}