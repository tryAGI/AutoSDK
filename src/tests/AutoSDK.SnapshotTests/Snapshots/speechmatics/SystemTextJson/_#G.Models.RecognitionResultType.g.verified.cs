//HintName: G.Models.RecognitionResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// New types of items may appear without being requested; unrecognized item types can be ignored.
    /// </summary>
    public enum RecognitionResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
        /// <summary>
        /// 
        /// </summary>
        Punctuation,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecognitionResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecognitionResultType value)
        {
            return value switch
            {
                RecognitionResultType.Entity => "entity",
                RecognitionResultType.Punctuation => "punctuation",
                RecognitionResultType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecognitionResultType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => RecognitionResultType.Entity,
                "punctuation" => RecognitionResultType.Punctuation,
                "word" => RecognitionResultType.Word,
                _ => null,
            };
        }
    }
}