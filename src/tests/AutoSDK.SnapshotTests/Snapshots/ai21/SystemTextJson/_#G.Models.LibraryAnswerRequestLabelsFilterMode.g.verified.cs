//HintName: G.Models.LibraryAnswerRequestLabelsFilterMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: AND
    /// </summary>
    public enum LibraryAnswerRequestLabelsFilterMode
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LibraryAnswerRequestLabelsFilterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LibraryAnswerRequestLabelsFilterMode value)
        {
            return value switch
            {
                LibraryAnswerRequestLabelsFilterMode.And => "AND",
                LibraryAnswerRequestLabelsFilterMode.Or => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LibraryAnswerRequestLabelsFilterMode? ToEnum(string value)
        {
            return value switch
            {
                "AND" => LibraryAnswerRequestLabelsFilterMode.And,
                "OR" => LibraryAnswerRequestLabelsFilterMode.Or,
                _ => null,
            };
        }
    }
}