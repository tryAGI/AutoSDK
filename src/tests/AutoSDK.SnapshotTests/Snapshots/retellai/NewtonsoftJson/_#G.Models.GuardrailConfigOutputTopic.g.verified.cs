//HintName: G.Models.GuardrailConfigOutputTopic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GuardrailConfigOutputTopic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="child_safety_and_exploitation")]
        ChildSafetyAndExploitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="defense_and_national_security")]
        DefenseAndNationalSecurity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gambling")]
        Gambling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="harassment")]
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="illicit_and_harmful_activity")]
        IllicitAndHarmfulActivity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regulated_professional_advice")]
        RegulatedProfessionalAdvice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="self_harm")]
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sexual_exploitation")]
        SexualExploitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="violence")]
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