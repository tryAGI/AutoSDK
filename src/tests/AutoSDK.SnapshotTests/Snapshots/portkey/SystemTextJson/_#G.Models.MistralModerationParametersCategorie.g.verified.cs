//HintName: G.Models.MistralModerationParametersCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MistralModerationParametersCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        DangerousAndCriminalContent,
        /// <summary>
        /// 
        /// </summary>
        Financial,
        /// <summary>
        /// 
        /// </summary>
        HateAndDiscrimination,
        /// <summary>
        /// 
        /// </summary>
        Health,
        /// <summary>
        /// 
        /// </summary>
        Law,
        /// <summary>
        /// 
        /// </summary>
        Pii,
        /// <summary>
        /// 
        /// </summary>
        Selfharm,
        /// <summary>
        /// 
        /// </summary>
        Sexual,
        /// <summary>
        /// 
        /// </summary>
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