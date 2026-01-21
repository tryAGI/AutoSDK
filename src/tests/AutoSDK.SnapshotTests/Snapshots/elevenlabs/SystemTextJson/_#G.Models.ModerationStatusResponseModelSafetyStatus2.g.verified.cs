//HintName: G.Models.ModerationStatusResponseModelSafetyStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationStatusResponseModelSafetyStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        AppealApproved,
        /// <summary>
        /// 
        /// </summary>
        AppealDenied,
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationStatusResponseModelSafetyStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationStatusResponseModelSafetyStatus2 value)
        {
            return value switch
            {
                ModerationStatusResponseModelSafetyStatus2.AppealApproved => "appeal_approved",
                ModerationStatusResponseModelSafetyStatus2.AppealDenied => "appeal_denied",
                ModerationStatusResponseModelSafetyStatus2.FalsePositive => "false_positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationStatusResponseModelSafetyStatus2? ToEnum(string value)
        {
            return value switch
            {
                "appeal_approved" => ModerationStatusResponseModelSafetyStatus2.AppealApproved,
                "appeal_denied" => ModerationStatusResponseModelSafetyStatus2.AppealDenied,
                "false_positive" => ModerationStatusResponseModelSafetyStatus2.FalsePositive,
                _ => null,
            };
        }
    }
}