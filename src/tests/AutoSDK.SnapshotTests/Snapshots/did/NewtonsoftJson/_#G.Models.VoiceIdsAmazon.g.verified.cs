//HintName: G.Models.VoiceIdsAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceIdsAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Amy")]
        Amy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Aria")]
        Aria,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Ayanda")]
        Ayanda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bianca")]
        Bianca,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Brian")]
        Brian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Camila")]
        Camila,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Emma")]
        Emma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Gabrielle")]
        Gabrielle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Ivy")]
        Ivy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Joanna")]
        Joanna,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Joey")]
        Joey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Justin")]
        Justin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kendra")]
        Kendra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kevin")]
        Kevin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kimberly")]
        Kimberly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Lucia")]
        Lucia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Lupe")]
        Lupe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Léa")]
        L_a,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Matthew")]
        Matthew,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Olivia")]
        Olivia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Salli")]
        Salli,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Seoyeon")]
        Seoyeon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Takumi")]
        Takumi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Vicki")]
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