//HintName: G.Models.PortkeyModerationParametersCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PortkeyModerationParametersCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        HarassmentThreatening,
        /// <summary>
        /// 
        /// </summary>
        Hate,
        /// <summary>
        /// 
        /// </summary>
        HateThreatening,
        /// <summary>
        /// 
        /// </summary>
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        SelfHarmInstructions,
        /// <summary>
        /// 
        /// </summary>
        SelfHarmIntent,
        /// <summary>
        /// 
        /// </summary>
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        SexualMinors,
        /// <summary>
        /// 
        /// </summary>
        Violence,
        /// <summary>
        /// 
        /// </summary>
        ViolenceGraphic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PortkeyModerationParametersCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PortkeyModerationParametersCategorie value)
        {
            return value switch
            {
                PortkeyModerationParametersCategorie.Harassment => "harassment",
                PortkeyModerationParametersCategorie.HarassmentThreatening => "harassment/threatening",
                PortkeyModerationParametersCategorie.Hate => "hate",
                PortkeyModerationParametersCategorie.HateThreatening => "hate/threatening",
                PortkeyModerationParametersCategorie.SelfHarm => "self-harm",
                PortkeyModerationParametersCategorie.SelfHarmInstructions => "self-harm/instructions",
                PortkeyModerationParametersCategorie.SelfHarmIntent => "self-harm/intent",
                PortkeyModerationParametersCategorie.Sexual => "sexual",
                PortkeyModerationParametersCategorie.SexualMinors => "sexual/minors",
                PortkeyModerationParametersCategorie.Violence => "violence",
                PortkeyModerationParametersCategorie.ViolenceGraphic => "violence/graphic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PortkeyModerationParametersCategorie? ToEnum(string value)
        {
            return value switch
            {
                "harassment" => PortkeyModerationParametersCategorie.Harassment,
                "harassment/threatening" => PortkeyModerationParametersCategorie.HarassmentThreatening,
                "hate" => PortkeyModerationParametersCategorie.Hate,
                "hate/threatening" => PortkeyModerationParametersCategorie.HateThreatening,
                "self-harm" => PortkeyModerationParametersCategorie.SelfHarm,
                "self-harm/instructions" => PortkeyModerationParametersCategorie.SelfHarmInstructions,
                "self-harm/intent" => PortkeyModerationParametersCategorie.SelfHarmIntent,
                "sexual" => PortkeyModerationParametersCategorie.Sexual,
                "sexual/minors" => PortkeyModerationParametersCategorie.SexualMinors,
                "violence" => PortkeyModerationParametersCategorie.Violence,
                "violence/graphic" => PortkeyModerationParametersCategorie.ViolenceGraphic,
                _ => null,
            };
        }
    }
}