//HintName: G.Models.SafetyRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SafetyRule
    {
        /// <summary>
        /// 
        /// </summary>
        Extremism,
        /// <summary>
        /// 
        /// </summary>
        ForgetModeration,
        /// <summary>
        /// 
        /// </summary>
        IllegalDistributionMedical,
        /// <summary>
        /// 
        /// </summary>
        Political,
        /// <summary>
        /// 
        /// </summary>
        ScamFraud,
        /// <summary>
        /// 
        /// </summary>
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        SexualAdults,
        /// <summary>
        /// 
        /// </summary>
        SexualMinors,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetyRuleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyRule value)
        {
            return value switch
            {
                SafetyRule.Extremism => "extremism",
                SafetyRule.ForgetModeration => "forget_moderation",
                SafetyRule.IllegalDistributionMedical => "illegal_distribution_medical",
                SafetyRule.Political => "political",
                SafetyRule.ScamFraud => "scam_fraud",
                SafetyRule.SelfHarm => "self_harm",
                SafetyRule.SexualAdults => "sexual_adults",
                SafetyRule.SexualMinors => "sexual_minors",
                SafetyRule.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyRule? ToEnum(string value)
        {
            return value switch
            {
                "extremism" => SafetyRule.Extremism,
                "forget_moderation" => SafetyRule.ForgetModeration,
                "illegal_distribution_medical" => SafetyRule.IllegalDistributionMedical,
                "political" => SafetyRule.Political,
                "scam_fraud" => SafetyRule.ScamFraud,
                "self_harm" => SafetyRule.SelfHarm,
                "sexual_adults" => SafetyRule.SexualAdults,
                "sexual_minors" => SafetyRule.SexualMinors,
                "unknown" => SafetyRule.Unknown,
                _ => null,
            };
        }
    }
}