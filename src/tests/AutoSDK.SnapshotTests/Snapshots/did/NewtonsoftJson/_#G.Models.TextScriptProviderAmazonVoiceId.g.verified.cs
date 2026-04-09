//HintName: G.Models.TextScriptProviderAmazonVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextScriptProviderAmazonVoiceId
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
    public static class TextScriptProviderAmazonVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScriptProviderAmazonVoiceId value)
        {
            return value switch
            {
                TextScriptProviderAmazonVoiceId.Amy => "Amy",
                TextScriptProviderAmazonVoiceId.Aria => "Aria",
                TextScriptProviderAmazonVoiceId.Ayanda => "Ayanda",
                TextScriptProviderAmazonVoiceId.Bianca => "Bianca",
                TextScriptProviderAmazonVoiceId.Brian => "Brian",
                TextScriptProviderAmazonVoiceId.Camila => "Camila",
                TextScriptProviderAmazonVoiceId.Emma => "Emma",
                TextScriptProviderAmazonVoiceId.Gabrielle => "Gabrielle",
                TextScriptProviderAmazonVoiceId.Ivy => "Ivy",
                TextScriptProviderAmazonVoiceId.Joanna => "Joanna",
                TextScriptProviderAmazonVoiceId.Joey => "Joey",
                TextScriptProviderAmazonVoiceId.Justin => "Justin",
                TextScriptProviderAmazonVoiceId.Kendra => "Kendra",
                TextScriptProviderAmazonVoiceId.Kevin => "Kevin",
                TextScriptProviderAmazonVoiceId.Kimberly => "Kimberly",
                TextScriptProviderAmazonVoiceId.Lucia => "Lucia",
                TextScriptProviderAmazonVoiceId.Lupe => "Lupe",
                TextScriptProviderAmazonVoiceId.Léa => "Léa",
                TextScriptProviderAmazonVoiceId.Matthew => "Matthew",
                TextScriptProviderAmazonVoiceId.Olivia => "Olivia",
                TextScriptProviderAmazonVoiceId.Salli => "Salli",
                TextScriptProviderAmazonVoiceId.Seoyeon => "Seoyeon",
                TextScriptProviderAmazonVoiceId.Takumi => "Takumi",
                TextScriptProviderAmazonVoiceId.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScriptProviderAmazonVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => TextScriptProviderAmazonVoiceId.Amy,
                "Aria" => TextScriptProviderAmazonVoiceId.Aria,
                "Ayanda" => TextScriptProviderAmazonVoiceId.Ayanda,
                "Bianca" => TextScriptProviderAmazonVoiceId.Bianca,
                "Brian" => TextScriptProviderAmazonVoiceId.Brian,
                "Camila" => TextScriptProviderAmazonVoiceId.Camila,
                "Emma" => TextScriptProviderAmazonVoiceId.Emma,
                "Gabrielle" => TextScriptProviderAmazonVoiceId.Gabrielle,
                "Ivy" => TextScriptProviderAmazonVoiceId.Ivy,
                "Joanna" => TextScriptProviderAmazonVoiceId.Joanna,
                "Joey" => TextScriptProviderAmazonVoiceId.Joey,
                "Justin" => TextScriptProviderAmazonVoiceId.Justin,
                "Kendra" => TextScriptProviderAmazonVoiceId.Kendra,
                "Kevin" => TextScriptProviderAmazonVoiceId.Kevin,
                "Kimberly" => TextScriptProviderAmazonVoiceId.Kimberly,
                "Lucia" => TextScriptProviderAmazonVoiceId.Lucia,
                "Lupe" => TextScriptProviderAmazonVoiceId.Lupe,
                "Léa" => TextScriptProviderAmazonVoiceId.Léa,
                "Matthew" => TextScriptProviderAmazonVoiceId.Matthew,
                "Olivia" => TextScriptProviderAmazonVoiceId.Olivia,
                "Salli" => TextScriptProviderAmazonVoiceId.Salli,
                "Seoyeon" => TextScriptProviderAmazonVoiceId.Seoyeon,
                "Takumi" => TextScriptProviderAmazonVoiceId.Takumi,
                "Vicki" => TextScriptProviderAmazonVoiceId.Vicki,
                _ => null,
            };
        }
    }
}