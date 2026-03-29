//HintName: G.Models.GuardrailConfigOutputTopic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailConfigOutputTopic
    {
        /// <summary>
        /// 
        /// </summary>
        ChildSafetyAndExploitation,
        /// <summary>
        /// 
        /// </summary>
        DefenseAndNationalSecurity,
        /// <summary>
        /// 
        /// </summary>
        Gambling,
        /// <summary>
        /// 
        /// </summary>
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        IllicitAndHarmfulActivity,
        /// <summary>
        /// 
        /// </summary>
        RegulatedProfessionalAdvice,
        /// <summary>
        /// 
        /// </summary>
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        SexualExploitation,
        /// <summary>
        /// 
        /// </summary>
        Violence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailConfigOutputTopicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailConfigOutputTopic value)
        {
            return value switch
            {
                GuardrailConfigOutputTopic.ChildSafetyAndExploitation => "child_safety_and_exploitation",
                GuardrailConfigOutputTopic.DefenseAndNationalSecurity => "defense_and_national_security",
                GuardrailConfigOutputTopic.Gambling => "gambling",
                GuardrailConfigOutputTopic.Harassment => "harassment",
                GuardrailConfigOutputTopic.IllicitAndHarmfulActivity => "illicit_and_harmful_activity",
                GuardrailConfigOutputTopic.RegulatedProfessionalAdvice => "regulated_professional_advice",
                GuardrailConfigOutputTopic.SelfHarm => "self_harm",
                GuardrailConfigOutputTopic.SexualExploitation => "sexual_exploitation",
                GuardrailConfigOutputTopic.Violence => "violence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailConfigOutputTopic? ToEnum(string value)
        {
            return value switch
            {
                "child_safety_and_exploitation" => GuardrailConfigOutputTopic.ChildSafetyAndExploitation,
                "defense_and_national_security" => GuardrailConfigOutputTopic.DefenseAndNationalSecurity,
                "gambling" => GuardrailConfigOutputTopic.Gambling,
                "harassment" => GuardrailConfigOutputTopic.Harassment,
                "illicit_and_harmful_activity" => GuardrailConfigOutputTopic.IllicitAndHarmfulActivity,
                "regulated_professional_advice" => GuardrailConfigOutputTopic.RegulatedProfessionalAdvice,
                "self_harm" => GuardrailConfigOutputTopic.SelfHarm,
                "sexual_exploitation" => GuardrailConfigOutputTopic.SexualExploitation,
                "violence" => GuardrailConfigOutputTopic.Violence,
                _ => null,
            };
        }
    }
}