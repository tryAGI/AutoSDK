//HintName: G.Models.ScrapeOptionsActionWriteTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Write text into an input field, text area, or contenteditable element. Note: You must first focus the element using a 'click' action before writing. The text will be typed character by character to simulate keyboard input.
    /// </summary>
    public enum ScrapeOptionsActionWriteTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionWriteTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionWriteTextType value)
        {
            return value switch
            {
                ScrapeOptionsActionWriteTextType.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionWriteTextType? ToEnum(string value)
        {
            return value switch
            {
                "write" => ScrapeOptionsActionWriteTextType.Write,
                _ => null,
            };
        }
    }
}