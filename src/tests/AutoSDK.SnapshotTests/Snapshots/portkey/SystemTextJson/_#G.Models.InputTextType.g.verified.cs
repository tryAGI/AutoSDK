//HintName: G.Models.InputTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_text`.
    /// </summary>
    public enum InputTextType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputTextType value)
        {
            return value switch
            {
                InputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => InputTextType.InputText,
                _ => null,
            };
        }
    }
}