//HintName: G.Models.TextScript3ProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextScript3ProviderAmazonVoiceId
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
        Léa,
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
    public static class TextScript3ProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3ProviderAmazonVoiceId value)
        {
            return value switch
            {
                TextScript3ProviderAmazonVoiceId.Amy => "Amy",
                TextScript3ProviderAmazonVoiceId.Aria => "Aria",
                TextScript3ProviderAmazonVoiceId.Ayanda => "Ayanda",
                TextScript3ProviderAmazonVoiceId.Bianca => "Bianca",
                TextScript3ProviderAmazonVoiceId.Brian => "Brian",
                TextScript3ProviderAmazonVoiceId.Camila => "Camila",
                TextScript3ProviderAmazonVoiceId.Emma => "Emma",
                TextScript3ProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                TextScript3ProviderAmazonVoiceId.Ivy => "Ivy",
                TextScript3ProviderAmazonVoiceId.Joanna => "Joanna",
                TextScript3ProviderAmazonVoiceId.Joey => "Joey",
                TextScript3ProviderAmazonVoiceId.Justin => "Justin",
                TextScript3ProviderAmazonVoiceId.Kendra => "Kendra",
                TextScript3ProviderAmazonVoiceId.Kevin => "Kevin",
                TextScript3ProviderAmazonVoiceId.Kimberly => "Kimberly",
                TextScript3ProviderAmazonVoiceId.Lucia => "Lucia",
                TextScript3ProviderAmazonVoiceId.Lupe => "Lupe",
                TextScript3ProviderAmazonVoiceId.Léa => "Léa",
                TextScript3ProviderAmazonVoiceId.Matthew => "Matthew",
                TextScript3ProviderAmazonVoiceId.Olivia => "Olivia",
                TextScript3ProviderAmazonVoiceId.Salli => "Salli",
                TextScript3ProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                TextScript3ProviderAmazonVoiceId.Takumi => "Takumi",
                TextScript3ProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3ProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => TextScript3ProviderAmazonVoiceId.Amy,
                "Aria" => TextScript3ProviderAmazonVoiceId.Aria,
                "Ayanda" => TextScript3ProviderAmazonVoiceId.Ayanda,
                "Bianca" => TextScript3ProviderAmazonVoiceId.Bianca,
                "Brian" => TextScript3ProviderAmazonVoiceId.Brian,
                "Camila" => TextScript3ProviderAmazonVoiceId.Camila,
                "Emma" => TextScript3ProviderAmazonVoiceId.Emma,
                "Gabrielle" => TextScript3ProviderAmazonVoiceId.Gabrielle,
                "Ivy" => TextScript3ProviderAmazonVoiceId.Ivy,
                "Joanna" => TextScript3ProviderAmazonVoiceId.Joanna,
                "Joey" => TextScript3ProviderAmazonVoiceId.Joey,
                "Justin" => TextScript3ProviderAmazonVoiceId.Justin,
                "Kendra" => TextScript3ProviderAmazonVoiceId.Kendra,
                "Kevin" => TextScript3ProviderAmazonVoiceId.Kevin,
                "Kimberly" => TextScript3ProviderAmazonVoiceId.Kimberly,
                "Lucia" => TextScript3ProviderAmazonVoiceId.Lucia,
                "Lupe" => TextScript3ProviderAmazonVoiceId.Lupe,
                "Léa" => TextScript3ProviderAmazonVoiceId.Léa,
                "Matthew" => TextScript3ProviderAmazonVoiceId.Matthew,
                "Olivia" => TextScript3ProviderAmazonVoiceId.Olivia,
                "Salli" => TextScript3ProviderAmazonVoiceId.Salli,
                "Seoyeon" => TextScript3ProviderAmazonVoiceId.Seoyeon,
                "Takumi" => TextScript3ProviderAmazonVoiceId.Takumi,
                "Vicki" => TextScript3ProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}