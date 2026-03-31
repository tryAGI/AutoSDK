//HintName: G.Models.UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum UpdatePresenterAttributesVariant1VoiceAmazonVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Amy,
        /// <summary>
        /// 
        /// </summary>
        Aria,
        /// <summary>
        /// 
        /// </summary>
        Ayanda,
        /// <summary>
        /// 
        /// </summary>
        Bianca,
        /// <summary>
        /// 
        /// </summary>
        Brian,
        /// <summary>
        /// 
        /// </summary>
        Camila,
        /// <summary>
        /// 
        /// </summary>
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Gabrielle,
        /// <summary>
        /// 
        /// </summary>
        Ivy,
        /// <summary>
        /// 
        /// </summary>
        Joanna,
        /// <summary>
        /// 
        /// </summary>
        Joey,
        /// <summary>
        /// 
        /// </summary>
        Justin,
        /// <summary>
        /// 
        /// </summary>
        Kendra,
        /// <summary>
        /// 
        /// </summary>
        Kevin,
        /// <summary>
        /// 
        /// </summary>
        Kimberly,
        /// <summary>
        /// 
        /// </summary>
        Lucia,
        /// <summary>
        /// 
        /// </summary>
        Lupe,
        /// <summary>
        /// 
        /// </summary>
        L_a,
        /// <summary>
        /// 
        /// </summary>
        Matthew,
        /// <summary>
        /// 
        /// </summary>
        Olivia,
        /// <summary>
        /// 
        /// </summary>
        Salli,
        /// <summary>
        /// 
        /// </summary>
        Seoyeon,
        /// <summary>
        /// 
        /// </summary>
        Takumi,
        /// <summary>
        /// 
        /// </summary>
        Vicki,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePresenterAttributesVariant1VoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesVariant1VoiceAmazonVoiceId value)
        {
            return value switch
            {
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Amy => "Amy",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Aria => "Aria",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Ayanda => "Ayanda",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Bianca => "Bianca",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Brian => "Brian",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Camila => "Camila",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Emma => "Emma",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Ivy => "Ivy",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Joanna => "Joanna",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Joey => "Joey",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Justin => "Justin",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Kendra => "Kendra",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Kevin => "Kevin",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Kimberly => "Kimberly",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Lucia => "Lucia",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Lupe => "Lupe",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.L_a => "Léa",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Matthew => "Matthew",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Olivia => "Olivia",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Salli => "Salli",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Takumi => "Takumi",
                UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesVariant1VoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Amy,
                "Aria" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Aria,
                "Ayanda" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Ayanda,
                "Bianca" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Bianca,
                "Brian" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Brian,
                "Camila" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Camila,
                "Emma" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Emma,
                "Gabrielle" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Gabrielle,
                "Ivy" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Ivy,
                "Joanna" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Joanna,
                "Joey" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Joey,
                "Justin" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Justin,
                "Kendra" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Kendra,
                "Kevin" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Kevin,
                "Kimberly" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Kimberly,
                "Lucia" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Lucia,
                "Lupe" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Lupe,
                "Léa" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.L_a,
                "Matthew" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Matthew,
                "Olivia" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Olivia,
                "Salli" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Salli,
                "Seoyeon" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Seoyeon,
                "Takumi" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Takumi,
                "Vicki" => UpdatePresenterAttributesVariant1VoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}