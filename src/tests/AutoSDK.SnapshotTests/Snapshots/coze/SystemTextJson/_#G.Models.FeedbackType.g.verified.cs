//HintName: G.Models.FeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        Unlike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackType value)
        {
            return value switch
            {
                FeedbackType.Like => "like",
                FeedbackType.Unlike => "unlike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "like" => FeedbackType.Like,
                "unlike" => FeedbackType.Unlike,
                _ => null,
            };
        }
    }
}