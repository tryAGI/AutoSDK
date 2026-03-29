//HintName: G.Models.FailPageMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for representing the different available page error handling modes.
    /// </summary>
    public enum FailPageMode
    {
        /// <summary>
        /// 
        /// </summary>
        BlankPage,
        /// <summary>
        /// 
        /// </summary>
        ErrorMessage,
        /// <summary>
        /// 
        /// </summary>
        RawText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FailPageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FailPageMode value)
        {
            return value switch
            {
                FailPageMode.BlankPage => "blank_page",
                FailPageMode.ErrorMessage => "error_message",
                FailPageMode.RawText => "raw_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FailPageMode? ToEnum(string value)
        {
            return value switch
            {
                "blank_page" => FailPageMode.BlankPage,
                "error_message" => FailPageMode.ErrorMessage,
                "raw_text" => FailPageMode.RawText,
                _ => null,
            };
        }
    }
}