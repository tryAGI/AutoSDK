//HintName: G.Models.SafetyRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SafetyRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sexual_minors")]
        SexualMinors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forget_moderation")]
        ForgetModeration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extremism")]
        Extremism,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scam_fraud")]
        ScamFraud,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="political")]
        Political,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="self_harm")]
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="illegal_distribution_medical")]
        IllegalDistributionMedical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sexual_adults")]
        SexualAdults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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
                SafetyRule.SexualMinors => "sexual_minors",
                SafetyRule.ForgetModeration => "forget_moderation",
                SafetyRule.Extremism => "extremism",
                SafetyRule.ScamFraud => "scam_fraud",
                SafetyRule.Political => "political",
                SafetyRule.SelfHarm => "self_harm",
                SafetyRule.IllegalDistributionMedical => "illegal_distribution_medical",
                SafetyRule.SexualAdults => "sexual_adults",
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
                "sexual_minors" => SafetyRule.SexualMinors,
                "forget_moderation" => SafetyRule.ForgetModeration,
                "extremism" => SafetyRule.Extremism,
                "scam_fraud" => SafetyRule.ScamFraud,
                "political" => SafetyRule.Political,
                "self_harm" => SafetyRule.SelfHarm,
                "illegal_distribution_medical" => SafetyRule.IllegalDistributionMedical,
                "sexual_adults" => SafetyRule.SexualAdults,
                "unknown" => SafetyRule.Unknown,
                _ => null,
            };
        }
    }
}