//HintName: G.Models.AnswerLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum AnswerLength
    {
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Short,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerLength value)
        {
            return value switch
            {
                AnswerLength.Long => "long",
                AnswerLength.Medium => "medium",
                AnswerLength.Short => "short",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerLength? ToEnum(string value)
        {
            return value switch
            {
                "long" => AnswerLength.Long,
                "medium" => AnswerLength.Medium,
                "short" => AnswerLength.Short,
                _ => null,
            };
        }
    }
}