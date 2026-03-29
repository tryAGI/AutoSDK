//HintName: G.Models.InputFileType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_file`.
    /// </summary>
    public enum InputFileType
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFileType value)
        {
            return value switch
            {
                InputFileType.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFileType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => InputFileType.InputFile,
                _ => null,
            };
        }
    }
}