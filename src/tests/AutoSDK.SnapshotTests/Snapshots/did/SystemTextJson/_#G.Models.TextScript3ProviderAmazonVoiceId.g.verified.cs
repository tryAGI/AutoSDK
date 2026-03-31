//HintName: G.Models.TextScript3ProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum TextScript3ProviderAmazonVoiceId
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
    public static class TextScript3ProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3ProviderAmazonVoiceId value)
        {
            return value switch
            {
                TextScript3ProviderAmazonVoiceId.Amy => "Amy",
                TextScript3ProviderAmazonVoiceId.Aria => "Aria",
                TextScript3ProviderAmazonVoiceId.Ayanda => "Ayanda",
                TextScript3ProviderAmazonVoiceId.Bianca => "Bianca",
                TextScript3ProviderAmazonVoiceId.Brian => "Brian",
                TextScript3ProviderAmazonVoiceId.Camila => "Camila",
                TextScript3ProviderAmazonVoiceId.Emma => "Emma",
                TextScript3ProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                TextScript3ProviderAmazonVoiceId.Ivy => "Ivy",
                TextScript3ProviderAmazonVoiceId.Joanna => "Joanna",
                TextScript3ProviderAmazonVoiceId.Joey => "Joey",
                TextScript3ProviderAmazonVoiceId.Justin => "Justin",
                TextScript3ProviderAmazonVoiceId.Kendra => "Kendra",
                TextScript3ProviderAmazonVoiceId.Kevin => "Kevin",
                TextScript3ProviderAmazonVoiceId.Kimberly => "Kimberly",
                TextScript3ProviderAmazonVoiceId.Lucia => "Lucia",
                TextScript3ProviderAmazonVoiceId.Lupe => "Lupe",
                TextScript3ProviderAmazonVoiceId.L_a => "Léa",
                TextScript3ProviderAmazonVoiceId.Matthew => "Matthew",
                TextScript3ProviderAmazonVoiceId.Olivia => "Olivia",
                TextScript3ProviderAmazonVoiceId.Salli => "Salli",
                TextScript3ProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                TextScript3ProviderAmazonVoiceId.Takumi => "Takumi",
                TextScript3ProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3ProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => TextScript3ProviderAmazonVoiceId.Amy,
                "Aria" => TextScript3ProviderAmazonVoiceId.Aria,
                "Ayanda" => TextScript3ProviderAmazonVoiceId.Ayanda,
                "Bianca" => TextScript3ProviderAmazonVoiceId.Bianca,
                "Brian" => TextScript3ProviderAmazonVoiceId.Brian,
                "Camila" => TextScript3ProviderAmazonVoiceId.Camila,
                "Emma" => TextScript3ProviderAmazonVoiceId.Emma,
                "Gabrielle" => TextScript3ProviderAmazonVoiceId.Gabrielle,
                "Ivy" => TextScript3ProviderAmazonVoiceId.Ivy,
                "Joanna" => TextScript3ProviderAmazonVoiceId.Joanna,
                "Joey" => TextScript3ProviderAmazonVoiceId.Joey,
                "Justin" => TextScript3ProviderAmazonVoiceId.Justin,
                "Kendra" => TextScript3ProviderAmazonVoiceId.Kendra,
                "Kevin" => TextScript3ProviderAmazonVoiceId.Kevin,
                "Kimberly" => TextScript3ProviderAmazonVoiceId.Kimberly,
                "Lucia" => TextScript3ProviderAmazonVoiceId.Lucia,
                "Lupe" => TextScript3ProviderAmazonVoiceId.Lupe,
                "Léa" => TextScript3ProviderAmazonVoiceId.L_a,
                "Matthew" => TextScript3ProviderAmazonVoiceId.Matthew,
                "Olivia" => TextScript3ProviderAmazonVoiceId.Olivia,
                "Salli" => TextScript3ProviderAmazonVoiceId.Salli,
                "Seoyeon" => TextScript3ProviderAmazonVoiceId.Seoyeon,
                "Takumi" => TextScript3ProviderAmazonVoiceId.Takumi,
                "Vicki" => TextScript3ProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}