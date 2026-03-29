//HintName: G.Models.CompliancePlanRecordingConsentPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompliancePlanRecordingConsentPlanDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        StayOnLine,
        /// <summary>
        /// 
        /// </summary>
        Verbal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompliancePlanRecordingConsentPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompliancePlanRecordingConsentPlanDiscriminatorType value)
        {
            return value switch
            {
                CompliancePlanRecordingConsentPlanDiscriminatorType.StayOnLine => "stay-on-line",
                CompliancePlanRecordingConsentPlanDiscriminatorType.Verbal => "verbal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompliancePlanRecordingConsentPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "stay-on-line" => CompliancePlanRecordingConsentPlanDiscriminatorType.StayOnLine,
                "verbal" => CompliancePlanRecordingConsentPlanDiscriminatorType.Verbal,
                _ => null,
            };
        }
    }
}