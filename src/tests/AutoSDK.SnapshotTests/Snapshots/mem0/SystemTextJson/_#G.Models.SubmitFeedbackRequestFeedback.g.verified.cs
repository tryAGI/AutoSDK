//HintName: G.Models.SubmitFeedbackRequestFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of feedback
    /// </summary>
    public enum SubmitFeedbackRequestFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Positive,
        /// <summary>
        /// 
        /// </summary>
        VeryNegative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitFeedbackRequestFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitFeedbackRequestFeedback value)
        {
            return value switch
            {
                SubmitFeedbackRequestFeedback.Negative => "NEGATIVE",
                SubmitFeedbackRequestFeedback.Positive => "POSITIVE",
                SubmitFeedbackRequestFeedback.VeryNegative => "VERY_NEGATIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitFeedbackRequestFeedback? ToEnum(string value)
        {
            return value switch
            {
                "NEGATIVE" => SubmitFeedbackRequestFeedback.Negative,
                "POSITIVE" => SubmitFeedbackRequestFeedback.Positive,
                "VERY_NEGATIVE" => SubmitFeedbackRequestFeedback.VeryNegative,
                _ => null,
            };
        }
    }
}