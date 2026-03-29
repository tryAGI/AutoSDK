//HintName: G.Models.AmazonTtsProviderVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AmazonTtsProviderVoiceId
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
    public static class AmazonTtsProviderVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AmazonTtsProviderVoiceId value)
        {
            return value switch
            {
                AmazonTtsProviderVoiceId.Amy => "Amy",
                AmazonTtsProviderVoiceId.Aria => "Aria",
                AmazonTtsProviderVoiceId.Ayanda => "Ayanda",
                AmazonTtsProviderVoiceId.Bianca => "Bianca",
                AmazonTtsProviderVoiceId.Brian => "Brian",
                AmazonTtsProviderVoiceId.Camila => "Camila",
                AmazonTtsProviderVoiceId.Emma => "Emma",
                AmazonTtsProviderVoiceId.Gabrielle => "Gabrielle",
                AmazonTtsProviderVoiceId.Ivy => "Ivy",
                AmazonTtsProviderVoiceId.Joanna => "Joanna",
                AmazonTtsProviderVoiceId.Joey => "Joey",
                AmazonTtsProviderVoiceId.Justin => "Justin",
                AmazonTtsProviderVoiceId.Kendra => "Kendra",
                AmazonTtsProviderVoiceId.Kevin => "Kevin",
                AmazonTtsProviderVoiceId.Kimberly => "Kimberly",
                AmazonTtsProviderVoiceId.Lucia => "Lucia",
                AmazonTtsProviderVoiceId.Lupe => "Lupe",
                AmazonTtsProviderVoiceId.L_a => "Léa",
                AmazonTtsProviderVoiceId.Matthew => "Matthew",
                AmazonTtsProviderVoiceId.Olivia => "Olivia",
                AmazonTtsProviderVoiceId.Salli => "Salli",
                AmazonTtsProviderVoiceId.Seoyeon => "Seoyeon",
                AmazonTtsProviderVoiceId.Takumi => "Takumi",
                AmazonTtsProviderVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AmazonTtsProviderVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => AmazonTtsProviderVoiceId.Amy,
                "Aria" => AmazonTtsProviderVoiceId.Aria,
                "Ayanda" => AmazonTtsProviderVoiceId.Ayanda,
                "Bianca" => AmazonTtsProviderVoiceId.Bianca,
                "Brian" => AmazonTtsProviderVoiceId.Brian,
                "Camila" => AmazonTtsProviderVoiceId.Camila,
                "Emma" => AmazonTtsProviderVoiceId.Emma,
                "Gabrielle" => AmazonTtsProviderVoiceId.Gabrielle,
                "Ivy" => AmazonTtsProviderVoiceId.Ivy,
                "Joanna" => AmazonTtsProviderVoiceId.Joanna,
                "Joey" => AmazonTtsProviderVoiceId.Joey,
                "Justin" => AmazonTtsProviderVoiceId.Justin,
                "Kendra" => AmazonTtsProviderVoiceId.Kendra,
                "Kevin" => AmazonTtsProviderVoiceId.Kevin,
                "Kimberly" => AmazonTtsProviderVoiceId.Kimberly,
                "Lucia" => AmazonTtsProviderVoiceId.Lucia,
                "Lupe" => AmazonTtsProviderVoiceId.Lupe,
                "Léa" => AmazonTtsProviderVoiceId.L_a,
                "Matthew" => AmazonTtsProviderVoiceId.Matthew,
                "Olivia" => AmazonTtsProviderVoiceId.Olivia,
                "Salli" => AmazonTtsProviderVoiceId.Salli,
                "Seoyeon" => AmazonTtsProviderVoiceId.Seoyeon,
                "Takumi" => AmazonTtsProviderVoiceId.Takumi,
                "Vicki" => AmazonTtsProviderVoiceId.Vicki,
                _ => null,
            };
        }
    }
}