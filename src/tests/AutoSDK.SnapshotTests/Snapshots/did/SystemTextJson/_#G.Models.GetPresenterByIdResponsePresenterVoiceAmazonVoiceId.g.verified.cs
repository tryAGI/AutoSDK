//HintName: G.Models.GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum GetPresenterByIdResponsePresenterVoiceAmazonVoiceId
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
    public static class GetPresenterByIdResponsePresenterVoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresenterByIdResponsePresenterVoiceAmazonVoiceId value)
        {
            return value switch
            {
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Amy => "Amy",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Aria => "Aria",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Ayanda => "Ayanda",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Bianca => "Bianca",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Brian => "Brian",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Camila => "Camila",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Emma => "Emma",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Ivy => "Ivy",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Joanna => "Joanna",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Joey => "Joey",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Justin => "Justin",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Kendra => "Kendra",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Kevin => "Kevin",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Kimberly => "Kimberly",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Lucia => "Lucia",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Lupe => "Lupe",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.L_a => "Léa",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Matthew => "Matthew",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Olivia => "Olivia",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Salli => "Salli",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Takumi => "Takumi",
                GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresenterByIdResponsePresenterVoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Amy,
                "Aria" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Aria,
                "Ayanda" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Ayanda,
                "Bianca" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Bianca,
                "Brian" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Brian,
                "Camila" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Camila,
                "Emma" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Emma,
                "Gabrielle" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Gabrielle,
                "Ivy" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Ivy,
                "Joanna" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Joanna,
                "Joey" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Joey,
                "Justin" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Justin,
                "Kendra" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Kendra,
                "Kevin" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Kevin,
                "Kimberly" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Kimberly,
                "Lucia" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Lucia,
                "Lupe" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Lupe,
                "Léa" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.L_a,
                "Matthew" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Matthew,
                "Olivia" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Olivia,
                "Salli" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Salli,
                "Seoyeon" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Seoyeon,
                "Takumi" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Takumi,
                "Vicki" => GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}