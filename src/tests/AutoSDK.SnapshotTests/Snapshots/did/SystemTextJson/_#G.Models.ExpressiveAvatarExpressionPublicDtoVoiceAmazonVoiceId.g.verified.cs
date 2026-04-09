//HintName: G.Models.ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId
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
    public static class ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Amy => "Amy",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Aria => "Aria",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Ayanda => "Ayanda",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Bianca => "Bianca",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Brian => "Brian",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Camila => "Camila",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Emma => "Emma",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Ivy => "Ivy",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Joanna => "Joanna",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Joey => "Joey",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Justin => "Justin",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Kendra => "Kendra",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Kevin => "Kevin",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Kimberly => "Kimberly",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Lucia => "Lucia",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Lupe => "Lupe",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Léa => "Léa",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Matthew => "Matthew",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Olivia => "Olivia",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Salli => "Salli",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Takumi => "Takumi",
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Amy,
                "Aria" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Aria,
                "Ayanda" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Ayanda,
                "Bianca" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Bianca,
                "Brian" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Brian,
                "Camila" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Camila,
                "Emma" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Emma,
                "Gabrielle" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Gabrielle,
                "Ivy" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Ivy,
                "Joanna" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Joanna,
                "Joey" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Joey,
                "Justin" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Justin,
                "Kendra" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Kendra,
                "Kevin" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Kevin,
                "Kimberly" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Kimberly,
                "Lucia" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Lucia,
                "Lupe" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Lupe,
                "Léa" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Léa,
                "Matthew" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Matthew,
                "Olivia" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Olivia,
                "Salli" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Salli,
                "Seoyeon" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Seoyeon,
                "Takumi" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Takumi,
                "Vicki" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}