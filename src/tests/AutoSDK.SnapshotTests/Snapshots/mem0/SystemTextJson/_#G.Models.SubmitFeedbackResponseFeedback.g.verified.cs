//HintName: G.Models.SubmitFeedbackResponseFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of feedback
    /// </summary>
    public enum SubmitFeedbackResponseFeedback
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
    public static class SubmitFeedbackResponseFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitFeedbackResponseFeedback value)
        {
            return value switch
            {
                SubmitFeedbackResponseFeedback.Negative => "NEGATIVE",
                SubmitFeedbackResponseFeedback.Positive => "POSITIVE",
                SubmitFeedbackResponseFeedback.VeryNegative => "VERY_NEGATIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitFeedbackResponseFeedback? ToEnum(string value)
        {
            return value switch
            {
                "NEGATIVE" => SubmitFeedbackResponseFeedback.Negative,
                "POSITIVE" => SubmitFeedbackResponseFeedback.Positive,
                "VERY_NEGATIVE" => SubmitFeedbackResponseFeedback.VeryNegative,
                _ => null,
            };
        }
    }
}