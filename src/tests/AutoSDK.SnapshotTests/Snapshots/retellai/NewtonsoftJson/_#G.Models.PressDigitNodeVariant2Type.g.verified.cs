//HintName: G.Models.PressDigitNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PressDigitNodeVariant2Type
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
    public static class PressDigitNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PressDigitNodeVariant2Type value)
        {
            return value switch
            {
                PressDigitNodeVariant2Type.PressDigit => "press_digit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PressDigitNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "press_digit" => PressDigitNodeVariant2Type.PressDigit,
                _ => null,
            };
        }
    }
}