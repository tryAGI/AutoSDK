//HintName: G.Models.GetPresentersResponsePresenterVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum GetPresentersResponsePresenterVoiceAmazonVoiceId
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
    public static class GetPresentersResponsePresenterVoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresentersResponsePresenterVoiceAmazonVoiceId value)
        {
            return value switch
            {
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Amy => "Amy",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Aria => "Aria",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Ayanda => "Ayanda",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Bianca => "Bianca",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Brian => "Brian",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Camila => "Camila",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Emma => "Emma",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Ivy => "Ivy",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Joanna => "Joanna",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Joey => "Joey",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Justin => "Justin",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Kendra => "Kendra",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Kevin => "Kevin",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Kimberly => "Kimberly",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Lucia => "Lucia",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Lupe => "Lupe",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Léa => "Léa",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Matthew => "Matthew",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Olivia => "Olivia",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Salli => "Salli",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Takumi => "Takumi",
                GetPresentersResponsePresenterVoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresentersResponsePresenterVoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Amy,
                "Aria" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Aria,
                "Ayanda" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Ayanda,
                "Bianca" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Bianca,
                "Brian" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Brian,
                "Camila" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Camila,
                "Emma" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Emma,
                "Gabrielle" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Gabrielle,
                "Ivy" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Ivy,
                "Joanna" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Joanna,
                "Joey" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Joey,
                "Justin" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Justin,
                "Kendra" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Kendra,
                "Kevin" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Kevin,
                "Kimberly" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Kimberly,
                "Lucia" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Lucia,
                "Lupe" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Lupe,
                "Léa" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Léa,
                "Matthew" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Matthew,
                "Olivia" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Olivia,
                "Salli" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Salli,
                "Seoyeon" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Seoyeon,
                "Takumi" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Takumi,
                "Vicki" => GetPresentersResponsePresenterVoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}