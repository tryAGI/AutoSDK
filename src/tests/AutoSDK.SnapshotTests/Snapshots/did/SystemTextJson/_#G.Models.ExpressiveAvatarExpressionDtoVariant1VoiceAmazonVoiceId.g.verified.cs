//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId
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
    public static class ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Amy => "Amy",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Aria => "Aria",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Ayanda => "Ayanda",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Bianca => "Bianca",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Brian => "Brian",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Camila => "Camila",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Emma => "Emma",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Ivy => "Ivy",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Joanna => "Joanna",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Joey => "Joey",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Justin => "Justin",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Kendra => "Kendra",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Kevin => "Kevin",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Kimberly => "Kimberly",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Lucia => "Lucia",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Lupe => "Lupe",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Léa => "Léa",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Matthew => "Matthew",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Olivia => "Olivia",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Salli => "Salli",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Takumi => "Takumi",
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Amy,
                "Aria" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Aria,
                "Ayanda" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Ayanda,
                "Bianca" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Bianca,
                "Brian" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Brian,
                "Camila" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Camila,
                "Emma" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Emma,
                "Gabrielle" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Gabrielle,
                "Ivy" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Ivy,
                "Joanna" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Joanna,
                "Joey" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Joey,
                "Justin" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Justin,
                "Kendra" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Kendra,
                "Kevin" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Kevin,
                "Kimberly" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Kimberly,
                "Lucia" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Lucia,
                "Lupe" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Lupe,
                "Léa" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Léa,
                "Matthew" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Matthew,
                "Olivia" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Olivia,
                "Salli" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Salli,
                "Seoyeon" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Seoyeon,
                "Takumi" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Takumi,
                "Vicki" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}