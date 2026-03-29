//HintName: G.Models.InputImageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_image`.
    /// </summary>
    public enum InputImageType
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageType value)
        {
            return value switch
            {
                InputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputImageType.InputImage,
                _ => null,
            };
        }
    }
}