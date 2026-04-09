//HintName: G.Models.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
    /// Example: Joanna
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestScriptVariant1ProviderAmazonVoiceId2
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
    public static class CreateClipRequestScriptVariant1ProviderAmazonVoiceId2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1ProviderAmazonVoiceId2 value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Amy => "Amy",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Aria => "Aria",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Ayanda => "Ayanda",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Bianca => "Bianca",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Brian => "Brian",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Camila => "Camila",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Emma => "Emma",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Gabrielle => "Gabrielle",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Ivy => "Ivy",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Joanna => "Joanna",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Joey => "Joey",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Justin => "Justin",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Kendra => "Kendra",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Kevin => "Kevin",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Kimberly => "Kimberly",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Lucia => "Lucia",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Lupe => "Lupe",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Léa => "Léa",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Matthew => "Matthew",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Olivia => "Olivia",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Salli => "Salli",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Seoyeon => "Seoyeon",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Takumi => "Takumi",
                CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Vicki => "Vicki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1ProviderAmazonVoiceId2? ToEnum(string value)
        {
            return value switch
            {
                "Amy" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Amy,
                "Aria" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Aria,
                "Ayanda" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Ayanda,
                "Bianca" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Bianca,
                "Brian" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Brian,
                "Camila" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Camila,
                "Emma" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Emma,
                "Gabrielle" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Gabrielle,
                "Ivy" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Ivy,
                "Joanna" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Joanna,
                "Joey" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Joey,
                "Justin" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Justin,
                "Kendra" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Kendra,
                "Kevin" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Kevin,
                "Kimberly" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Kimberly,
                "Lucia" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Lucia,
                "Lupe" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Lupe,
                "Léa" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Léa,
                "Matthew" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Matthew,
                "Olivia" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Olivia,
                "Salli" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Salli,
                "Seoyeon" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Seoyeon,
                "Takumi" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Takumi,
                "Vicki" => CreateClipRequestScriptVariant1ProviderAmazonVoiceId2.Vicki,
                _ => null,
            };
        }
    }
}