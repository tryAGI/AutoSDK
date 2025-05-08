//HintName: G.Models.InputFileContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_file`.<br/>
    /// Default Value: input_file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputFileContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_file")]
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFileContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFileContentType value)
        {
            return value switch
            {
                InputFileContentType.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFileContentType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => InputFileContentType.InputFile,
                _ => null,
            };
        }
    }
}