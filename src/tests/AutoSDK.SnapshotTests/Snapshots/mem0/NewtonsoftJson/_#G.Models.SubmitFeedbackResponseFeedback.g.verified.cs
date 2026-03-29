//HintName: G.Models.SubmitFeedbackResponseFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of feedback
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubmitFeedbackResponseFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEGATIVE")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSITIVE")]
        Positive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VERY_NEGATIVE")]
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