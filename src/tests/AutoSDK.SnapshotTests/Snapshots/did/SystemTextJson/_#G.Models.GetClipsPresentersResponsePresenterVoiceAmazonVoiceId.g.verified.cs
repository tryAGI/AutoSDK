//HintName: G.Models.GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    public enum GetClipsPresentersResponsePresenterVoiceAmazonVoiceId
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
    public static class GetClipsPresentersResponsePresenterVoiceAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsPresentersResponsePresenterVoiceAmazonVoiceId value)
        {
            return value switch
            {
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Amy => "Amy",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Aria => "Aria",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Ayanda => "Ayanda",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Bianca => "Bianca",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Brian => "Brian",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Camila => "Camila",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Emma => "Emma",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Gabrielle => "Gabrielle",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Ivy => "Ivy",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Joanna => "Joanna",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Joey => "Joey",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Justin => "Justin",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Kendra => "Kendra",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Kevin => "Kevin",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Kimberly => "Kimberly",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Lucia => "Lucia",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Lupe => "Lupe",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Léa => "Léa",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Matthew => "Matthew",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Olivia => "Olivia",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Salli => "Salli",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Seoyeon => "Seoyeon",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Takumi => "Takumi",
                GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsPresentersResponsePresenterVoiceAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Amy,
                "Aria" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Aria,
                "Ayanda" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Ayanda,
                "Bianca" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Bianca,
                "Brian" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Brian,
                "Camila" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Camila,
                "Emma" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Emma,
                "Gabrielle" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Gabrielle,
                "Ivy" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Ivy,
                "Joanna" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Joanna,
                "Joey" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Joey,
                "Justin" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Justin,
                "Kendra" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Kendra,
                "Kevin" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Kevin,
                "Kimberly" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Kimberly,
                "Lucia" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Lucia,
                "Lupe" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Lupe,
                "Léa" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Léa,
                "Matthew" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Matthew,
                "Olivia" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Olivia,
                "Salli" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Salli,
                "Seoyeon" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Seoyeon,
                "Takumi" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Takumi,
                "Vicki" => GetClipsPresentersResponsePresenterVoiceAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}