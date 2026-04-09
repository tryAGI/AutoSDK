//HintName: G.Models.TextScriptProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum TextScriptProviderAmazonVoiceId
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
        Léa,
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
    public static class TextScriptProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScriptProviderAmazonVoiceId value)
        {
            return value switch
            {
                TextScriptProviderAmazonVoiceId.Amy => "Amy",
                TextScriptProviderAmazonVoiceId.Aria => "Aria",
                TextScriptProviderAmazonVoiceId.Ayanda => "Ayanda",
                TextScriptProviderAmazonVoiceId.Bianca => "Bianca",
                TextScriptProviderAmazonVoiceId.Brian => "Brian",
                TextScriptProviderAmazonVoiceId.Camila => "Camila",
                TextScriptProviderAmazonVoiceId.Emma => "Emma",
                TextScriptProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                TextScriptProviderAmazonVoiceId.Ivy => "Ivy",
                TextScriptProviderAmazonVoiceId.Joanna => "Joanna",
                TextScriptProviderAmazonVoiceId.Joey => "Joey",
                TextScriptProviderAmazonVoiceId.Justin => "Justin",
                TextScriptProviderAmazonVoiceId.Kendra => "Kendra",
                TextScriptProviderAmazonVoiceId.Kevin => "Kevin",
                TextScriptProviderAmazonVoiceId.Kimberly => "Kimberly",
                TextScriptProviderAmazonVoiceId.Lucia => "Lucia",
                TextScriptProviderAmazonVoiceId.Lupe => "Lupe",
                TextScriptProviderAmazonVoiceId.Léa => "Léa",
                TextScriptProviderAmazonVoiceId.Matthew => "Matthew",
                TextScriptProviderAmazonVoiceId.Olivia => "Olivia",
                TextScriptProviderAmazonVoiceId.Salli => "Salli",
                TextScriptProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                TextScriptProviderAmazonVoiceId.Takumi => "Takumi",
                TextScriptProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScriptProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => TextScriptProviderAmazonVoiceId.Amy,
                "Aria" => TextScriptProviderAmazonVoiceId.Aria,
                "Ayanda" => TextScriptProviderAmazonVoiceId.Ayanda,
                "Bianca" => TextScriptProviderAmazonVoiceId.Bianca,
                "Brian" => TextScriptProviderAmazonVoiceId.Brian,
                "Camila" => TextScriptProviderAmazonVoiceId.Camila,
                "Emma" => TextScriptProviderAmazonVoiceId.Emma,
                "Gabrielle" => TextScriptProviderAmazonVoiceId.Gabrielle,
                "Ivy" => TextScriptProviderAmazonVoiceId.Ivy,
                "Joanna" => TextScriptProviderAmazonVoiceId.Joanna,
                "Joey" => TextScriptProviderAmazonVoiceId.Joey,
                "Justin" => TextScriptProviderAmazonVoiceId.Justin,
                "Kendra" => TextScriptProviderAmazonVoiceId.Kendra,
                "Kevin" => TextScriptProviderAmazonVoiceId.Kevin,
                "Kimberly" => TextScriptProviderAmazonVoiceId.Kimberly,
                "Lucia" => TextScriptProviderAmazonVoiceId.Lucia,
                "Lupe" => TextScriptProviderAmazonVoiceId.Lupe,
                "Léa" => TextScriptProviderAmazonVoiceId.Léa,
                "Matthew" => TextScriptProviderAmazonVoiceId.Matthew,
                "Olivia" => TextScriptProviderAmazonVoiceId.Olivia,
                "Salli" => TextScriptProviderAmazonVoiceId.Salli,
                "Seoyeon" => TextScriptProviderAmazonVoiceId.Seoyeon,
                "Takumi" => TextScriptProviderAmazonVoiceId.Takumi,
                "Vicki" => TextScriptProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}