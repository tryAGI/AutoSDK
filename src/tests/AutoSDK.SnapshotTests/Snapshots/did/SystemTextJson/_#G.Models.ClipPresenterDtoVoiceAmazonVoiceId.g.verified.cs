//HintName: G.Models.ClipPresenterDtoVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum ClipPresenterDtoVoiceAmazonVoiceId
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
    public static class ClipPresenterDtoVoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterDtoVoiceAmazonVoiceId value)
        {
            return value switch
            {
                ClipPresenterDtoVoiceAmazonVoiceId.Amy => "Amy",
                ClipPresenterDtoVoiceAmazonVoiceId.Aria => "Aria",
                ClipPresenterDtoVoiceAmazonVoiceId.Ayanda => "Ayanda",
                ClipPresenterDtoVoiceAmazonVoiceId.Bianca => "Bianca",
                ClipPresenterDtoVoiceAmazonVoiceId.Brian => "Brian",
                ClipPresenterDtoVoiceAmazonVoiceId.Camila => "Camila",
                ClipPresenterDtoVoiceAmazonVoiceId.Emma => "Emma",
                ClipPresenterDtoVoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                ClipPresenterDtoVoiceAmazonVoiceId.Ivy => "Ivy",
                ClipPresenterDtoVoiceAmazonVoiceId.Joanna => "Joanna",
                ClipPresenterDtoVoiceAmazonVoiceId.Joey => "Joey",
                ClipPresenterDtoVoiceAmazonVoiceId.Justin => "Justin",
                ClipPresenterDtoVoiceAmazonVoiceId.Kendra => "Kendra",
                ClipPresenterDtoVoiceAmazonVoiceId.Kevin => "Kevin",
                ClipPresenterDtoVoiceAmazonVoiceId.Kimberly => "Kimberly",
                ClipPresenterDtoVoiceAmazonVoiceId.Lucia => "Lucia",
                ClipPresenterDtoVoiceAmazonVoiceId.Lupe => "Lupe",
                ClipPresenterDtoVoiceAmazonVoiceId.L_a => "Léa",
                ClipPresenterDtoVoiceAmazonVoiceId.Matthew => "Matthew",
                ClipPresenterDtoVoiceAmazonVoiceId.Olivia => "Olivia",
                ClipPresenterDtoVoiceAmazonVoiceId.Salli => "Salli",
                ClipPresenterDtoVoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                ClipPresenterDtoVoiceAmazonVoiceId.Takumi => "Takumi",
                ClipPresenterDtoVoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterDtoVoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => ClipPresenterDtoVoiceAmazonVoiceId.Amy,
                "Aria" => ClipPresenterDtoVoiceAmazonVoiceId.Aria,
                "Ayanda" => ClipPresenterDtoVoiceAmazonVoiceId.Ayanda,
                "Bianca" => ClipPresenterDtoVoiceAmazonVoiceId.Bianca,
                "Brian" => ClipPresenterDtoVoiceAmazonVoiceId.Brian,
                "Camila" => ClipPresenterDtoVoiceAmazonVoiceId.Camila,
                "Emma" => ClipPresenterDtoVoiceAmazonVoiceId.Emma,
                "Gabrielle" => ClipPresenterDtoVoiceAmazonVoiceId.Gabrielle,
                "Ivy" => ClipPresenterDtoVoiceAmazonVoiceId.Ivy,
                "Joanna" => ClipPresenterDtoVoiceAmazonVoiceId.Joanna,
                "Joey" => ClipPresenterDtoVoiceAmazonVoiceId.Joey,
                "Justin" => ClipPresenterDtoVoiceAmazonVoiceId.Justin,
                "Kendra" => ClipPresenterDtoVoiceAmazonVoiceId.Kendra,
                "Kevin" => ClipPresenterDtoVoiceAmazonVoiceId.Kevin,
                "Kimberly" => ClipPresenterDtoVoiceAmazonVoiceId.Kimberly,
                "Lucia" => ClipPresenterDtoVoiceAmazonVoiceId.Lucia,
                "Lupe" => ClipPresenterDtoVoiceAmazonVoiceId.Lupe,
                "Léa" => ClipPresenterDtoVoiceAmazonVoiceId.L_a,
                "Matthew" => ClipPresenterDtoVoiceAmazonVoiceId.Matthew,
                "Olivia" => ClipPresenterDtoVoiceAmazonVoiceId.Olivia,
                "Salli" => ClipPresenterDtoVoiceAmazonVoiceId.Salli,
                "Seoyeon" => ClipPresenterDtoVoiceAmazonVoiceId.Seoyeon,
                "Takumi" => ClipPresenterDtoVoiceAmazonVoiceId.Takumi,
                "Vicki" => ClipPresenterDtoVoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}