//HintName: G.Models.GetPresenterByIdResponsePresenterVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresenterByIdResponsePresenterVoiceAmazonVoiceId
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