//HintName: G.Models.VoiceIdsAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceIdsAmazon
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
    public static class VoiceIdsAmazonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceIdsAmazon value)
        {
            return value switch
            {
                VoiceIdsAmazon.Amy => "Amy",
                VoiceIdsAmazon.Aria => "Aria",
                VoiceIdsAmazon.Ayanda => "Ayanda",
                VoiceIdsAmazon.Bianca => "Bianca",
                VoiceIdsAmazon.Brian => "Brian",
                VoiceIdsAmazon.Camila => "Camila",
                VoiceIdsAmazon.Emma => "Emma",
                VoiceIdsAmazon.Gabrielle => "Gabrielle",
                VoiceIdsAmazon.Ivy => "Ivy",
                VoiceIdsAmazon.Joanna => "Joanna",
                VoiceIdsAmazon.Joey => "Joey",
                VoiceIdsAmazon.Justin => "Justin",
                VoiceIdsAmazon.Kendra => "Kendra",
                VoiceIdsAmazon.Kevin => "Kevin",
                VoiceIdsAmazon.Kimberly => "Kimberly",
                VoiceIdsAmazon.Lucia => "Lucia",
                VoiceIdsAmazon.Lupe => "Lupe",
                VoiceIdsAmazon.L_a => "Léa",
                VoiceIdsAmazon.Matthew => "Matthew",
                VoiceIdsAmazon.Olivia => "Olivia",
                VoiceIdsAmazon.Salli => "Salli",
                VoiceIdsAmazon.Seoyeon => "Seoyeon",
                VoiceIdsAmazon.Takumi => "Takumi",
                VoiceIdsAmazon.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceIdsAmazon? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => VoiceIdsAmazon.Amy,
                "Aria" => VoiceIdsAmazon.Aria,
                "Ayanda" => VoiceIdsAmazon.Ayanda,
                "Bianca" => VoiceIdsAmazon.Bianca,
                "Brian" => VoiceIdsAmazon.Brian,
                "Camila" => VoiceIdsAmazon.Camila,
                "Emma" => VoiceIdsAmazon.Emma,
                "Gabrielle" => VoiceIdsAmazon.Gabrielle,
                "Ivy" => VoiceIdsAmazon.Ivy,
                "Joanna" => VoiceIdsAmazon.Joanna,
                "Joey" => VoiceIdsAmazon.Joey,
                "Justin" => VoiceIdsAmazon.Justin,
                "Kendra" => VoiceIdsAmazon.Kendra,
                "Kevin" => VoiceIdsAmazon.Kevin,
                "Kimberly" => VoiceIdsAmazon.Kimberly,
                "Lucia" => VoiceIdsAmazon.Lucia,
                "Lupe" => VoiceIdsAmazon.Lupe,
                "Léa" => VoiceIdsAmazon.L_a,
                "Matthew" => VoiceIdsAmazon.Matthew,
                "Olivia" => VoiceIdsAmazon.Olivia,
                "Salli" => VoiceIdsAmazon.Salli,
                "Seoyeon" => VoiceIdsAmazon.Seoyeon,
                "Takumi" => VoiceIdsAmazon.Takumi,
                "Vicki" => VoiceIdsAmazon.Vicki,
                _ => null,
            };
        }
    }
}