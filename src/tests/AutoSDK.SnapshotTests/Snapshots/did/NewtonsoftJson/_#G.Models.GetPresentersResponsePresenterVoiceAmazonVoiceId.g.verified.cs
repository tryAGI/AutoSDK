//HintName: G.Models.GetPresentersResponsePresenterVoiceAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresentersResponsePresenterVoiceAmazonVoiceId
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
                GetPresentersResponsePresenterVoiceAmazonVoiceId.L_a => "Léa",
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
                "Léa" => GetPresentersResponsePresenterVoiceAmazonVoiceId.L_a,
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