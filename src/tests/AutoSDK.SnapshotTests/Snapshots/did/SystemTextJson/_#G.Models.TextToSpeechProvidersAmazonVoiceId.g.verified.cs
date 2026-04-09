//HintName: G.Models.TextToSpeechProvidersAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum TextToSpeechProvidersAmazonVoiceId
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
    public static class TextToSpeechProvidersAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechProvidersAmazonVoiceId value)
        {
            return value switch
            {
                TextToSpeechProvidersAmazonVoiceId.Amy => "Amy",
                TextToSpeechProvidersAmazonVoiceId.Aria => "Aria",
                TextToSpeechProvidersAmazonVoiceId.Ayanda => "Ayanda",
                TextToSpeechProvidersAmazonVoiceId.Bianca => "Bianca",
                TextToSpeechProvidersAmazonVoiceId.Brian => "Brian",
                TextToSpeechProvidersAmazonVoiceId.Camila => "Camila",
                TextToSpeechProvidersAmazonVoiceId.Emma => "Emma",
                TextToSpeechProvidersAmazonVoiceId.Gabrielle => "Gabrielle",
                TextToSpeechProvidersAmazonVoiceId.Ivy => "Ivy",
                TextToSpeechProvidersAmazonVoiceId.Joanna => "Joanna",
                TextToSpeechProvidersAmazonVoiceId.Joey => "Joey",
                TextToSpeechProvidersAmazonVoiceId.Justin => "Justin",
                TextToSpeechProvidersAmazonVoiceId.Kendra => "Kendra",
                TextToSpeechProvidersAmazonVoiceId.Kevin => "Kevin",
                TextToSpeechProvidersAmazonVoiceId.Kimberly => "Kimberly",
                TextToSpeechProvidersAmazonVoiceId.Lucia => "Lucia",
                TextToSpeechProvidersAmazonVoiceId.Lupe => "Lupe",
                TextToSpeechProvidersAmazonVoiceId.Léa => "Léa",
                TextToSpeechProvidersAmazonVoiceId.Matthew => "Matthew",
                TextToSpeechProvidersAmazonVoiceId.Olivia => "Olivia",
                TextToSpeechProvidersAmazonVoiceId.Salli => "Salli",
                TextToSpeechProvidersAmazonVoiceId.Seoyeon => "Seoyeon",
                TextToSpeechProvidersAmazonVoiceId.Takumi => "Takumi",
                TextToSpeechProvidersAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechProvidersAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => TextToSpeechProvidersAmazonVoiceId.Amy,
                "Aria" => TextToSpeechProvidersAmazonVoiceId.Aria,
                "Ayanda" => TextToSpeechProvidersAmazonVoiceId.Ayanda,
                "Bianca" => TextToSpeechProvidersAmazonVoiceId.Bianca,
                "Brian" => TextToSpeechProvidersAmazonVoiceId.Brian,
                "Camila" => TextToSpeechProvidersAmazonVoiceId.Camila,
                "Emma" => TextToSpeechProvidersAmazonVoiceId.Emma,
                "Gabrielle" => TextToSpeechProvidersAmazonVoiceId.Gabrielle,
                "Ivy" => TextToSpeechProvidersAmazonVoiceId.Ivy,
                "Joanna" => TextToSpeechProvidersAmazonVoiceId.Joanna,
                "Joey" => TextToSpeechProvidersAmazonVoiceId.Joey,
                "Justin" => TextToSpeechProvidersAmazonVoiceId.Justin,
                "Kendra" => TextToSpeechProvidersAmazonVoiceId.Kendra,
                "Kevin" => TextToSpeechProvidersAmazonVoiceId.Kevin,
                "Kimberly" => TextToSpeechProvidersAmazonVoiceId.Kimberly,
                "Lucia" => TextToSpeechProvidersAmazonVoiceId.Lucia,
                "Lupe" => TextToSpeechProvidersAmazonVoiceId.Lupe,
                "Léa" => TextToSpeechProvidersAmazonVoiceId.Léa,
                "Matthew" => TextToSpeechProvidersAmazonVoiceId.Matthew,
                "Olivia" => TextToSpeechProvidersAmazonVoiceId.Olivia,
                "Salli" => TextToSpeechProvidersAmazonVoiceId.Salli,
                "Seoyeon" => TextToSpeechProvidersAmazonVoiceId.Seoyeon,
                "Takumi" => TextToSpeechProvidersAmazonVoiceId.Takumi,
                "Vicki" => TextToSpeechProvidersAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}