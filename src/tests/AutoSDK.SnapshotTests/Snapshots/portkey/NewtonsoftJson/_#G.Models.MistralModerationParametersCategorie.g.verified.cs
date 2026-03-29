//HintName: G.Models.MistralModerationParametersCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MistralModerationParametersCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dangerous_and_criminal_content")]
        DangerousAndCriminalContent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial")]
        Financial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hate_and_discrimination")]
        HateAndDiscrimination,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="health")]
        Health,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="law")]
        Law,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pii")]
        Pii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selfharm")]
        Selfharm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sexual")]
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="violence_and_threats")]
        ViolenceAndThreats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MistralModerationParametersCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MistralModerationParametersCategorie value)
        {
            return value switch
            {
                MistralModerationParametersCategorie.DangerousAndCriminalContent => "dangerous_and_criminal_content",
                MistralModerationParametersCategorie.Financial => "financial",
                MistralModerationParametersCategorie.HateAndDiscrimination => "hate_and_discrimination",
                MistralModerationParametersCategorie.Health => "health",
                MistralModerationParametersCategorie.Law => "law",
                MistralModerationParametersCategorie.Pii => "pii",
                MistralModerationParametersCategorie.Selfharm => "selfharm",
                MistralModerationParametersCategorie.Sexual => "sexual",
                MistralModerationParametersCategorie.ViolenceAndThreats => "violence_and_threats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MistralModerationParametersCategorie? ToEnum(string value)
        {
            return value switch
            {
                "dangerous_and_criminal_content" => MistralModerationParametersCategorie.DangerousAndCriminalContent,
                "financial" => MistralModerationParametersCategorie.Financial,
                "hate_and_discrimination" => MistralModerationParametersCategorie.HateAndDiscrimination,
                "health" => MistralModerationParametersCategorie.Health,
                "law" => MistralModerationParametersCategorie.Law,
                "pii" => MistralModerationParametersCategorie.Pii,
                "selfharm" => MistralModerationParametersCategorie.Selfharm,
                "sexual" => MistralModerationParametersCategorie.Sexual,
                "violence_and_threats" => MistralModerationParametersCategorie.ViolenceAndThreats,
                _ => null,
            };
        }
    }
}