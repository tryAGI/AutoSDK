//HintName: G.Models.MessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// 
        /// </summary>
        InputFile,
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageType value)
        {
            return value switch
            {
                MessageType.InputFile => "input_file",
                MessageType.InputImage => "input_image",
                MessageType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => MessageType.InputFile,
                "input_image" => MessageType.InputImage,
                "input_text" => MessageType.InputText,
                _ => null,
            };
        }
    }
}